// ****************************************************************************
// 
// HdBrStreamExtractor - A GUI front-end for eac3to
// Copyright (C) 2010-2012 Matthew Griffore
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, see <http://www.gnu.org/licenses/>.
// 
// ****************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using eac3to;

namespace eac3toGUI
{
    public partial class HdBrStreamExtractor : Form
    {
        List<Feature> features;
        BackgroundWorker backgroundWorker;
        string eac3toPath;

        public HdBrStreamExtractor()
        {
            InitializeComponent();

            eac3toPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "eac3to.exe");

            /*TODO: Use undocumented argument '-neroaacenc="[path to neroaacenc.exe]"'
             * Need to check if file exists prior, if not, state an update is reqiuired.
            */
        }

        struct eac3toArgs
        {
            public string eac3toPath { get; set; }
            public string inputPath { get; set; }
            public string workingFolder { get; set; }
            public string featureNumber { get; set; }
            public string args { get; set; }
            public ResultState resultState { get; set; }

            public eac3toArgs(string eac3toPath, string inputPath, string args) : this()
            {
                this.eac3toPath = eac3toPath;
                this.inputPath = inputPath;
                this.args = args;
            }
        }

        public enum ResultState
        {
            [StringValue("Feature Retrieval Completed")]
            FeatureCompleted,
            [StringValue("Stream Retrieval Completed")]
            StreamCompleted,
            [StringValue("Stream Extraction Completed")]
            ExtractCompleted
        }

        #region backgroundWorker
        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            eac3toArgs args = (eac3toArgs)e.Argument;

            using (Process process = new Process())
            {
                process.StartInfo.FileName = args.eac3toPath;
                //process.StartInfo.FileName = @"C:\Users\mgriffor\Documents\Visual Studio 2012\Projects\HdBrStreamExtractor\trunk\Tester\bin\Debug\Tester.exe";

                switch (args.resultState)
                {
                    case ResultState.FeatureCompleted:
                        process.StartInfo.Arguments = string.Format("\"{0}\"", args.inputPath);
                        //process.StartInfo.Arguments = string.Concat("\"", System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "feature.txt"), "\"");
                        break;
                    case ResultState.StreamCompleted:
                        process.StartInfo.Arguments = string.Format("\"{0}\" {1}) {2}", args.inputPath, args.args, "-progressnumbers");
                        //process.StartInfo.Arguments = string.Concat("\"", System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "stream.txt"), "\"");
                        break;
                    case ResultState.ExtractCompleted:
                        if (InputSourceTextBox.Tag.ToString() == "File")
                            process.StartInfo.Arguments = string.Format("\"{0}\" {1}", args.inputPath, args.args + " -progressnumbers");
                        else
                            process.StartInfo.Arguments = string.Format("\"{0}\" {1}) {2}", args.inputPath, args.featureNumber, args.args + " -progressnumbers");

                        string value = process.StartInfo.Arguments;

                        if (Control.ModifierKeys == Keys.Control)
                            if (InputBox("Arguments", "Review or modify arguments:", ref value) == DialogResult.OK)
                                process.StartInfo.Arguments = value;
                        break;
                }

                WriteToLog(string.Format("Arguments: {0}", process.StartInfo.Arguments));

                process.StartInfo.WorkingDirectory = args.workingFolder;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.ErrorDialog = false;
                process.EnableRaisingEvents = true;
                process.EnableRaisingEvents = true;
                process.Exited += new EventHandler(backgroundWorker_Exited);
                process.ErrorDataReceived += new DataReceivedEventHandler(backgroundWorker_ErrorDataReceived);
                process.OutputDataReceived += new DataReceivedEventHandler(backgroundWorker_OutputDataReceived);

                try
                {
                    process.Start();
                    process.PriorityBoostEnabled = true;
                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();

                    while (!process.HasExited)
                    {
                        if (backgroundWorker.CancellationPending)
                            process.Kill();

                        // Do not monopolize resource, relinquish some time
                        Thread.Sleep(250);
                    }

                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    //e.Cancel = true;
                    //e.Result = ex.Message;
                    WriteToLog(ex.Message);
                }
                finally
                {
                    process.ErrorDataReceived -= new DataReceivedEventHandler(backgroundWorker_ErrorDataReceived);
                    process.OutputDataReceived -= new DataReceivedEventHandler(backgroundWorker_OutputDataReceived);
                }
            }

            e.Result = args.resultState;
        }

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SetProgress(e.ProgressPercentage);

            if (e.UserState != null)
                ToolStripStatusLabel.Text = e.UserState.ToString();
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CancelButton.Enabled = false;

            if (e.Cancelled)
                WriteToLog("Work was cancelled");

            if (e.Error != null)
            {
                WriteToLog(e.Error.Message);
                WriteToLog(e.Error.TargetSite.Name);
                WriteToLog(e.Error.Source);
                WriteToLog(e.Error.StackTrace);
            }

            SetProgress(0);
            ToolStripStatusLabel.Text = Extensions.GetStringValue(((ResultState)e.Result));

            // update the features
            features.Sort((first, second) => first.Name.CompareTo(second.Name));

            if (e.Result != null)
            {
                WriteToLog(Extensions.GetStringValue(((ResultState)e.Result)));

                switch ((ResultState)e.Result)
                {
                    case ResultState.FeatureCompleted:
                        FeatureDataGridView.DataSource = features;
                        FeatureLinkLabel.Enabled = true;
                        FeatureDataGridView.SelectionChanged += new System.EventHandler(FeatureDataGridView_SelectionChanged);
                        StreamDataGridView.DataSourceChanged += new System.EventHandler(StreamDataGridView_DataSourceChanged);
                        if (features.Count == 1) FeatureDataGridView.Rows[0].Selected = true;
                        break;
                    case ResultState.StreamCompleted:
                        FeatureDataGridView.SelectionChanged += new System.EventHandler(this.FeatureDataGridView_SelectionChanged);
                        StreamDataGridView.DataSource = ((Feature)FeatureDataGridView.SelectedRows[0].DataBoundItem).Streams;
                        break;
                    case ResultState.ExtractCompleted:
                        ExtractButton.Enabled = FileInputSourceButton.Enabled = FolderInputSourceButton.Enabled = FolderOutputSourceButton.Enabled
                            = FeatureLinkLabel.Enabled = FeatureDataGridView.Enabled = StreamDataGridView.Enabled = true;
                        break;
                }
            }
        }

        void backgroundWorker_Exited(object sender, EventArgs e)
        {
            ResetCursor(Cursors.Default);
        }

        void backgroundWorker_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string data;

            if (!String.IsNullOrEmpty(e.Data))
            {
                data = e.Data.TrimStart('\b').Trim();

                if (!string.IsNullOrEmpty(data))
                    WriteToLog("Error: " + e.Data);
            }
        }

        void backgroundWorker_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string data;

            if (!string.IsNullOrEmpty(e.Data))
            {
                data = e.Data.Substring(e.Data.LastIndexOf('\b') + 1).Trim();

                if (!string.IsNullOrEmpty(data))
                    ProcessLine(data);
            }
        }

        void ProcessLine(string data)
        {
            // Analyzing|Processing|Progress
            // analyze: 100%
            if (Regex.IsMatch(data, @"^\b(analyze|process|progress)\b: [0-9]{1,3}%$", RegexOptions.Compiled))
            {
                if (backgroundWorker.IsBusy)
                    backgroundWorker.ReportProgress(int.Parse(Regex.Match(data, "[0-9]{1,3}").Value),
                        string.Format("{0} ({1}%)", data.Substring(0, data.IndexOf(":")), int.Parse(Regex.Match(data, "[0-9]{1,3}").Value)));

                return;
            }

            // Feature line
            // 2) 00216.mpls, 0:50:19
            else if (Regex.IsMatch(data, @"^[0-99]+\).+$", RegexOptions.Compiled))
            {
                try
                {
                    features.Add(Feature.Parse(data));
                }
                catch (Exception ex)
                {
                    WriteToLog(string.Format("{0}, {{1}}", ex.Message, data));
                }

                return;
            }

            // File input, Feature line
            // MKV, 1 video track, 1 audio track, 1 subtitle track, 1:47:18, 24p /1.001
            else if (Regex.IsMatch(data, @"^[A-Za-z0-9]{3,}, .*$", RegexOptions.Compiled))
            {
                if (InputSourceTextBox.Tag.ToString() == "File")
                {
                    try
                    {
                        Feature f = new Feature();
                        f.Name = System.IO.Path.GetFileNameWithoutExtension(InputSourceTextBox.Text);
                        f.Number = features.Count + 1;
                        f.Description = data;
                        f.Files.Add(new File(System.IO.Path.GetFileName(InputSourceTextBox.Text), 1));

                        if (data.Contains(":"))
                            f.Duration = TimeSpan.Parse(data.Substring(data.IndexOf(":") - 2, (data.LastIndexOf(":") + 3) - (data.IndexOf(":") - 2)).Trim());

                        features.Add(f);
                    }
                    catch (Exception ex)
                    {
                        WriteToLog(string.Format("{0}, {{1}}", ex.Message, data));
                    }
                }

                return;
            }

            // Feature name
            // "Feature Name"
            else if (Regex.IsMatch(data, "^\".+\"$", RegexOptions.Compiled))
            {
                if (InputSourceTextBox.Tag.ToString() == "File")
                {
                    features[features.Count - 1].Streams[features[features.Count - 1].Streams.Count - 1].Name = Extensions.CapitalizeAll(data.Trim("\" .".ToCharArray()));
                }
                else
                {
                    features[features.Count - 1].Name = Extensions.CapitalizeAll(data.Trim("\" .".ToCharArray()));
                }

                return;
            }

            // Stream line on feature listing
            // - h264/AVC, 1080p24 /1.001 (16:9)
            else if (Regex.IsMatch(data, @"^-.+$", RegexOptions.Compiled))
            {
                features[features.Count - 1].ToolTip.Add(data.Trim());
                return;
            }

            // Core information for audio stream
            // (core: DTS, 5.1 channels, 16 bits, 1509kbps, 48khz)
            else if (Regex.IsMatch(data, @"^\(core: .*\)$", RegexOptions.Compiled))
            {
                //TODO: Add core info to stream
                //features[features.Count - 1].Streams[features[features.Count - 1].Streams.Count - 1].ToolTip.Add(data);
                return;
            }

            // Stream embedded audio
            // (embedded: AC3, 5.1 channels, 640kbps, 48khz, dialnorm: -27dB)
            else if (Regex.IsMatch(data, @"^\(embedded: .+\)$", RegexOptions.Compiled))
            {
                //TODO: Add embedded info to stream
                //((Feature)FeatureDataGridView.SelectedRows[0].DataBoundItem).Streams.Count[Streams.Count - 1].ToolTip.Add(data);
                return;
            }

            // Playlist file listing
            // [99+100+101+102+103+104+105+106+114].m2ts (blueray playlist *.mpls)
            else if (Regex.IsMatch(data, @"^\[.+\].m2ts$", RegexOptions.Compiled))
            {
                foreach (string file in Regex.Match(data, @"\[.+\]").Value.Trim("[]".ToCharArray()).Split("+".ToCharArray()))
                    features[features.Count - 1].Files.Add(new File(file + ".m2ts", features[features.Count - 1].Files.Count + 1));

                return;
            }

            // Stream listing feature header
            // M2TS, 1 video track, 6 audio tracks, 9 subtitle tracks, 1:53:06
            // EVO, 2 video tracks, 4 audio tracks, 8 subtitle tracks, 2:20:02
            else if (Regex.IsMatch(data, @"^\b(M2TS|EVO|TS|VOB|MKV|MKA)\b, .+$", RegexOptions.Compiled))
            {
                WriteToLog(data);
                return;
            }

            // Stream line
            // 8: AC3, English, 2.0 channels, 192kbps, 48khz, dialnorm: -27dB
            else if (Regex.IsMatch(data, @"^[0-99]+:.+$", RegexOptions.Compiled))
            {
                if (InputSourceTextBox.Tag.ToString() == "File")
                {
                    try
                    {
                        features[features.Count - 1].Streams.Add(eac3to.Stream.Parse(data));
                    }
                    catch (Exception ex)
                    {
                        WriteToLog(ex.Message);
                        WriteToLog(ex.Source);
                        WriteToLog(ex.StackTrace);
                    }
                }
                else ((Feature)FeatureDataGridView.SelectedRows[0].DataBoundItem).Streams.Add(Stream.Parse(data));


                return;
            }

            // Information line
            // [a03] Creating file "audio.ac3"...
            else if (Regex.IsMatch(data, @"^\[.+\] .+\.{3}$", RegexOptions.Compiled))
            {
                WriteToLog(data);
                return;
            }

            // Creating file
            // Creating file "C:\1_1_chapter.txt"...
            else if (Regex.IsMatch(data, "^Creating file \".+\"\\.{3}$", RegexOptions.Compiled))
            {
                WriteToLog(data);
                return;
            }

            // Done
            // Done.
            else if (data.Equals("Done."))
            {
                WriteToLog(data);
                return;
            }

            #region Errors
            // Source file not found
            // Source file "x:\" not found.
            else if (Regex.IsMatch(data, "^Source file \".*\" not found.$", RegexOptions.Compiled))
            {
                //MessageBox.Show(data, "Source", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                WriteToLog(data);
                return;
            }

            // Format of Source file not detected
            // The format of the source file could not be detected.
            else if (data.Equals("The format of the source file could not be detected."))
            {
                //MessageBox.Show(data, "Source File Format", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                WriteToLog(data);
                return;
            }

            // Audio conversion not supported
            // This audio conversion is not supported.
            else if (data.Equals("This audio conversion is not supported."))
            {
                //MessageBox.Show(data, "Audio Conversion", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                WriteToLog(data);
                return;
            }
            #endregion

            // Unknown line
            else
            {
                WriteToLog(string.Format("{0}", data));
            }
        }
        #endregion

        #region GUI
        delegate void SetProgressCallback(int value);
        void SetProgress(int value)
        {
            lock (this)
            {
                if (this.InvokeRequired)
                    this.BeginInvoke(new SetProgressCallback(SetProgress), value);
                else
                    this.ToolStripProgressBar.Value = value;
            }
        }

        delegate void ResetCursorCallback(System.Windows.Forms.Cursor cursor);
        void ResetCursor(System.Windows.Forms.Cursor cursor)
        {
            lock (this)
            {
                if (this.InvokeRequired)
                    this.BeginInvoke(new ResetCursorCallback(ResetCursor), cursor);
                else
                    this.Cursor = cursor;
            }
        }

        delegate void WriteToLogCallback(string text);
        void WriteToLog(string text)
        {
            if (LogTextBox.InvokeRequired)
                LogTextBox.BeginInvoke(new WriteToLogCallback(WriteToLog), text);
            else
            {
                lock (this)
                {
                    LogTextBox.AppendText(string.Format("[{0}] {1}{2}", DateTime.Now.ToString("HH:mm:ss"), text, Environment.NewLine));

                    using (System.IO.StreamWriter SW = new System.IO.StreamWriter(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "HdBrStreamExtractor.txt"), true))
                    {
                        SW.WriteLine(string.Format("[{0}] {1}{2}", DateTime.Now.ToString("HH:mm:ss"), text, Environment.NewLine));
                        SW.Close();
                    }
                }
            }
        }

        void FileInputSourceButton_Click(object sender, EventArgs e)
        {
            InputSourceTextBox.Tag = "File";

            openFileDialog1.FileName = string.Empty;
            //openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                foreach (string s in openFileDialog1.FileNames)
                    sb.AppendFormat("{0}+", s);

                sb.Remove(sb.Length - 1, 1);

                InputSourceTextBox.Text = sb.ToString();

                if (IsLocalDisk(InputSourceTextBox.Text))
                    FolderOutputTextBox.Text = System.IO.Path.GetDirectoryName(InputSourceTextBox.Text);
            }
        }

        void FolderInputSourceButton_Click(object sender, EventArgs e)
        {
            InputSourceTextBox.Tag = "Folder";

            folderBrowserDialog1.Description = "Choose an input directory";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.SelectedPath = InputSourceTextBox.Text;
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                InputSourceTextBox.Text = folderBrowserDialog1.SelectedPath;

                if (IsLocalDisk(InputSourceTextBox.Text))
                    FolderOutputTextBox.Text = InputSourceTextBox.Text;
            }
        }

        bool IsLocalDisk(string path)
        {
            bool retVal = false;

            foreach (System.IO.DriveInfo d in System.IO.DriveInfo.GetDrives())
                if (d.DriveType == System.IO.DriveType.Fixed || d.DriveType == System.IO.DriveType.Network || d.DriveType == System.IO.DriveType.Removable)
                    if (System.IO.Path.GetPathRoot(InputSourceTextBox.Text) == System.IO.Path.GetPathRoot(d.RootDirectory.FullName))
                        return true;

            return retVal;
        }

        void FolderOutputSourceButton_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.SelectedPath = string.Empty;
            folderBrowserDialog1.Description = "Choose an output directory";
            folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.OK)
                FolderOutputTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        void StreamDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in StreamDataGridView.Rows)
            {
                Stream s = row.DataBoundItem as Stream;
                DataGridViewComboBoxCell comboBox = row.Cells["StreamExtractAsComboBox"] as DataGridViewComboBoxCell;
                comboBox.Items.Clear();
                comboBox.Items.AddRange(s.ExtractTypes);
                if (comboBox.Items.Count == 1)
                    comboBox.Value = comboBox.Items[0];
            }
        }

        void InitBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
        }

        void ExtractButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FolderOutputTextBox.Text))
            {
                MessageBox.Show("Configure output target folder.", "Extract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (FeatureDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Retrieve features prior to extracting.", "Extract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (StreamDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Retrieve streams prior to extracting.", "Extract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (!IsStreamCheckedForExtract())
            {
                MessageBox.Show("Select stream(s) to extract.", "Extract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            eac3toArgs args = new eac3toArgs();

            args.eac3toPath = eac3toPath;
            args.inputPath = InputSourceTextBox.Text;
            args.featureNumber = ((Feature)FeatureDataGridView.SelectedRows[0].DataBoundItem).Number.ToString();
            args.workingFolder = string.IsNullOrEmpty(FolderOutputTextBox.Text) ? FolderOutputTextBox.Text : System.IO.Path.GetDirectoryName(args.eac3toPath);
            args.resultState = ResultState.ExtractCompleted;

            try
            {
                args.args = GenerateArguments();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Stream Extract", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            InitBackgroundWorker();
            backgroundWorker.ReportProgress(0, "Extracting streams");
            WriteToLog("Extracting streams");
            ExtractButton.Enabled = FileInputSourceButton.Enabled = FolderInputSourceButton.Enabled = FolderOutputSourceButton.Enabled
                = FeatureLinkLabel.Enabled = FeatureDataGridView.Enabled = StreamDataGridView.Enabled = false;
            CancelButton.Enabled = true;
            Cursor = Cursors.WaitCursor;

            backgroundWorker.RunWorkerAsync(args);
        }

        string GenerateArguments()
        {
            StringBuilder sb = new StringBuilder();

            // get the name
            Feature feature = ((Feature)FeatureDataGridView.SelectedRows[0].DataBoundItem);
            int number;
            if (!int.TryParse(System.IO.Path.GetFileNameWithoutExtension(feature.Name), out number))
            {
                number = feature.Number;
            }

            foreach (DataGridViewRow row in StreamDataGridView.Rows)
            {
                Stream stream = row.DataBoundItem as Stream;
                DataGridViewCheckBoxCell extractStream = row.Cells["StreamExtractCheckBox"] as DataGridViewCheckBoxCell;

                if (extractStream.Value != null && int.Parse(extractStream.Value.ToString()) == 1)
                {
                    if (row.Cells["StreamExtractAsComboBox"].Value == null)
                        throw new ApplicationException(string.Format("Specify an extraction type for stream:\r\n\n\t{0}: {1}", stream.Number, stream.Name));

                    sb.Append(string.Format("{0}:\"{1}\" {2} ", stream.Number,
                        System.IO.Path.Combine(FolderOutputTextBox.Text, string.Format("{0}_{1}_{2}.{3}", number, stream.Number, Extensions.GetStringValue(stream.Type), row.Cells["StreamExtractAsComboBox"].Value).ToLower()),
                        row.Cells["StreamAddOptionsTextBox"].Value).Trim());

                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker != null)
            {
                if (backgroundWorker.IsBusy)
                    if (MessageBox.Show("A process is still running. Do you want to cancel it?", "Cancel process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        backgroundWorker.CancelAsync();

                if (backgroundWorker.CancellationPending)
                    backgroundWorker.Dispose();
            }
        }

        void HdBrStreamExtractor_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (backgroundWorker != null)
            {
                if (backgroundWorker.IsBusy)
                    if (MessageBox.Show("A process is still running. Do you want to cancel it?", "Cancel process?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        backgroundWorker.CancelAsync();

                if (backgroundWorker.CancellationPending)
                    backgroundWorker.Dispose();
            }
        }

        bool IsStreamCheckedForExtract()
        {
            bool enableExtract = false;

            foreach (DataGridViewRow row in StreamDataGridView.Rows)
                if (row.Cells["StreamExtractCheckBox"].Value != null && int.Parse(row.Cells["StreamExtractCheckBox"].Value.ToString()) == 1)
                    enableExtract = true;

            return enableExtract;
        }

        void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.doom9.org/showthread.php?t=141829");
        }

        void Eac3toLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.doom9.org/showthread.php?t=125966");
        }

        void FeatureDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // only fire after the Databind has completed on grid and a row is selected
            if (FeatureDataGridView.Rows.Count == features.Count && FeatureDataGridView.SelectedRows.Count == 1)
            {
                if (backgroundWorker.IsBusy) // disallow selection change
                {
                    //TODO: Disable selection change on processing
                    //this.FeatureDataGridView.SelectionChanged -= new System.EventHandler(this.FeatureDataGridView_SelectionChanged);

                    //FeatureDataGridView.CurrentRow.Selected = false;
                    //FeatureDataGridView.Rows[int.Parse(FeatureDataGridView.Tag.ToString())].Selected = true;

                    //this.FeatureDataGridView.SelectionChanged += new System.EventHandler(this.FeatureDataGridView_SelectionChanged);
                }
                else // backgroundworker is not busy, allow selection change
                {
                    Feature feature = FeatureDataGridView.SelectedRows[0].DataBoundItem as Feature;

                    // Check for Streams
                    if (feature.Streams == null || feature.Streams.Count == 0)
                    {
                        InitBackgroundWorker();
                        eac3toArgs args = new eac3toArgs();

                        args.eac3toPath = eac3toPath;
                        args.inputPath = InputSourceTextBox.Text;
                        args.workingFolder = string.IsNullOrEmpty(FolderOutputTextBox.Text) ? FolderOutputTextBox.Text : System.IO.Path.GetDirectoryName(args.eac3toPath);
                        args.resultState = ResultState.StreamCompleted;
                        args.args = ((Feature)FeatureDataGridView.SelectedRows[0].DataBoundItem).Number.ToString();

                        backgroundWorker.ReportProgress(0, "Retrieving streams");
                        WriteToLog("Retrieving streams");
                        Cursor = Cursors.WaitCursor;

                        backgroundWorker.RunWorkerAsync(args);
                    }
                    else // use already collected streams
                    {
                        StreamDataGridView.DataSource = feature.Streams;
                    }
                }
            }
        }

        void FeatureDataGridView_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            FeatureDataGridView.ClearSelection();
        }

        void FeatureDataGridView_RowLeave(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            FeatureDataGridView.Tag = e.RowIndex;
        }

        void FeatureDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in FeatureDataGridView.Rows)
            {
                Feature feature = row.DataBoundItem as Feature;
                DataGridViewComboBoxCell comboBox = row.Cells["FeatureFileDataGridViewComboBoxColumn"] as DataGridViewComboBoxCell;

                if (feature != null)
                {
                    if (feature.Files != null || feature.Files.Count > 0)
                    {
                        foreach (File file in feature.Files)
                        {
                            comboBox.Items.Add(file.FullName);

                            if (file.Index == 1)
                                comboBox.Value = file.FullName;
                        }
                    }
                }
            }
        }

        void FeatureDataGridView_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex != -1 && FeatureDataGridView.DataSource != null && FeatureDataGridView.Rows.Count > 0)
            {
                StringBuilder toolTip = new StringBuilder();

                foreach (string s in features[e.RowIndex].ToolTip)
                    toolTip.AppendFormat("{0}\r\n", s);

                e.ToolTipText = toolTip.ToString();
            }
        }

        void StreamDataGridView_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex != -1 && StreamDataGridView.DataSource != null && StreamDataGridView.Rows.Count > 0)
            {
                StringBuilder toolTip = new StringBuilder();

                foreach (string s in ((Feature)FeatureDataGridView.SelectedRows[0].DataBoundItem).Streams[e.RowIndex].ToolTip)
                    toolTip.AppendFormat("{0}\r\n", s);

                e.ToolTipText = toolTip.ToString();
            }
        }

        void FeatureLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(InputSourceTextBox.Text))
            {
                MessageBox.Show("Configure input source prior to retrieving features.", "Feature Retrieval", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                InitBackgroundWorker();
                eac3toArgs args = new eac3toArgs();
                features = new List<Feature>();
                FeatureDataGridView.DataSource = null;
                StreamDataGridView.DataSource = null;

                args.eac3toPath = eac3toPath;
                args.inputPath = InputSourceTextBox.Text;
                args.workingFolder = string.IsNullOrEmpty(FolderOutputTextBox.Text) ? FolderOutputTextBox.Text : System.IO.Path.GetDirectoryName(args.eac3toPath);
                args.resultState = ResultState.FeatureCompleted;
                args.args = string.Empty;

                backgroundWorker.ReportProgress(0, "Retrieving features");
                WriteToLog("Retrieving features");
                FeatureLinkLabel.Enabled = false;
                Cursor = Cursors.WaitCursor;

                backgroundWorker.RunWorkerAsync(args);
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        #endregion

        void HdBrStreamExtractor_Load(object sender, EventArgs e)
        {
            Version ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += string.Format("v{0}.{1}.{2}", ver.Major, ver.Minor, ver.Build);
            StreamDataGridView.DataSource = StreamsBindingSource;
        }
    }
}
