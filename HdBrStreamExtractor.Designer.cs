namespace eac3toGUI
{
    partial class HdBrStreamExtractor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HdBrStreamExtractor));
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Eac3toLinkLabel = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FileInputSourceButton = new System.Windows.Forms.Button();
            this.FolderInputSourceButton = new System.Windows.Forms.Button();
            this.FolderOutputSourceButton = new System.Windows.Forms.Button();
            this.FeatureLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.InputSourceTextBox = new System.Windows.Forms.TextBox();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.FolderOutputTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.FeatureGroupBox = new System.Windows.Forms.GroupBox();
            this.FeatureDataGridView = new eac3toGUI.CustomDataGridView();
            this.FeatureNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureFileDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FeatureDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StreamGroupBox = new System.Windows.Forms.GroupBox();
            this.StreamDataGridView = new eac3toGUI.CustomDataGridView();
            this.StreamExtractCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StreamNumberTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamTypeTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamDescriptionTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamExtractAsComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StreamAddOptionsTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.InputGroupBox.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.FeatureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeatureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeatureBindingSource)).BeginInit();
            this.StreamGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StreamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(12, 357);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(560, 51);
            this.LogTextBox.TabIndex = 7;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel,
            this.ToolStripProgressBar});
            this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip.Location = new System.Drawing.Point(0, 440);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.ShowItemToolTips = true;
            this.StatusStrip.Size = new System.Drawing.Size(584, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 11;
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.AutoSize = false;
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(358, 17);
            this.ToolStripStatusLabel.Text = "Ready";
            this.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripStatusLabel.ToolTipText = "Status";
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(200, 16);
            this.ToolStripProgressBar.ToolTipText = "Progress";
            // 
            // ExtractButton
            // 
            this.ExtractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtractButton.Location = new System.Drawing.Point(416, 414);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractButton.TabIndex = 9;
            this.ExtractButton.Text = "Extract";
            this.toolTip1.SetToolTip(this.ExtractButton, "Click to extract selected streams");
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(497, 414);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.CancelButton, "Click to cancel");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Eac3toLinkLabel
            // 
            this.Eac3toLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Eac3toLinkLabel.AutoSize = true;
            this.Eac3toLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eac3toLinkLabel.Location = new System.Drawing.Point(51, 417);
            this.Eac3toLinkLabel.Name = "Eac3toLinkLabel";
            this.Eac3toLinkLabel.Size = new System.Drawing.Size(44, 15);
            this.Eac3toLinkLabel.TabIndex = 13;
            this.Eac3toLinkLabel.TabStop = true;
            this.Eac3toLinkLabel.Text = "eac3to";
            this.toolTip1.SetToolTip(this.Eac3toLinkLabel, "Click to visit eac3to thread on Doom9 forum");
            this.Eac3toLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Eac3toLinkLabel_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files|*.*|EVO files|*.evo|VOB files|*.vob|(M2)TS files|*.mts;*.m2ts;*.ts|MPLS" +
    " Playlist|*.mpls|Matroska Video file|*.mkv";
            this.openFileDialog1.FilterIndex = 0;
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.Title = "Choose the input file(s)";
            // 
            // FileInputSourceButton
            // 
            this.FileInputSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileInputSourceButton.AutoSize = true;
            this.FileInputSourceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FileInputSourceButton.BackgroundImage = global::HdBrStreamExtractor.Properties.Resources.copy_24;
            this.FileInputSourceButton.Location = new System.Drawing.Point(219, 14);
            this.FileInputSourceButton.Name = "FileInputSourceButton";
            this.FileInputSourceButton.Size = new System.Drawing.Size(26, 23);
            this.FileInputSourceButton.TabIndex = 13;
            this.FileInputSourceButton.Text = "   ";
            this.toolTip1.SetToolTip(this.FileInputSourceButton, "Select Input File(s)");
            this.FileInputSourceButton.UseVisualStyleBackColor = false;
            this.FileInputSourceButton.Click += new System.EventHandler(this.FileInputSourceButton_Click);
            // 
            // FolderInputSourceButton
            // 
            this.FolderInputSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderInputSourceButton.AutoSize = true;
            this.FolderInputSourceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderInputSourceButton.BackgroundImage = global::HdBrStreamExtractor.Properties.Resources.folder_24;
            this.FolderInputSourceButton.Location = new System.Drawing.Point(251, 14);
            this.FolderInputSourceButton.Name = "FolderInputSourceButton";
            this.FolderInputSourceButton.Size = new System.Drawing.Size(26, 23);
            this.FolderInputSourceButton.TabIndex = 12;
            this.FolderInputSourceButton.Text = "   ";
            this.toolTip1.SetToolTip(this.FolderInputSourceButton, "Select Input Folder");
            this.FolderInputSourceButton.UseVisualStyleBackColor = true;
            this.FolderInputSourceButton.Click += new System.EventHandler(this.FolderInputSourceButton_Click);
            // 
            // FolderOutputSourceButton
            // 
            this.FolderOutputSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderOutputSourceButton.AutoSize = true;
            this.FolderOutputSourceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FolderOutputSourceButton.BackgroundImage = global::HdBrStreamExtractor.Properties.Resources.folder_24;
            this.FolderOutputSourceButton.Location = new System.Drawing.Point(250, 14);
            this.FolderOutputSourceButton.Name = "FolderOutputSourceButton";
            this.FolderOutputSourceButton.Size = new System.Drawing.Size(26, 23);
            this.FolderOutputSourceButton.TabIndex = 13;
            this.FolderOutputSourceButton.Text = "   ";
            this.toolTip1.SetToolTip(this.FolderOutputSourceButton, "Select Output Folder");
            this.FolderOutputSourceButton.UseVisualStyleBackColor = true;
            this.FolderOutputSourceButton.Click += new System.EventHandler(this.FolderOutputSourceButton_Click);
            // 
            // FeatureLinkLabel
            // 
            this.FeatureLinkLabel.AutoSize = true;
            this.FeatureLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeatureLinkLabel.Location = new System.Drawing.Point(6, -2);
            this.FeatureLinkLabel.Name = "FeatureLinkLabel";
            this.FeatureLinkLabel.Size = new System.Drawing.Size(63, 15);
            this.FeatureLinkLabel.TabIndex = 16;
            this.FeatureLinkLabel.TabStop = true;
            this.FeatureLinkLabel.Text = "Feature(s)";
            this.toolTip1.SetToolTip(this.FeatureLinkLabel, "Click to retrieve Feature(s)");
            this.FeatureLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FeatureLinkLabel_LinkClicked);
            // 
            // HelpLinkLabel
            // 
            this.HelpLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HelpLinkLabel.AutoSize = true;
            this.HelpLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpLinkLabel.Location = new System.Drawing.Point(12, 417);
            this.HelpLinkLabel.Name = "HelpLinkLabel";
            this.HelpLinkLabel.Size = new System.Drawing.Size(33, 15);
            this.HelpLinkLabel.TabIndex = 13;
            this.HelpLinkLabel.TabStop = true;
            this.HelpLinkLabel.Text = "Help";
            this.toolTip1.SetToolTip(this.HelpLinkLabel, "Click to visit HdBrStreamExtractor thread on Doom9 forum");
            this.HelpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLinkLabel_LinkClicked);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Number";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(9, 9);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.InputGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OutputGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(566, 49);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 16;
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.FileInputSourceButton);
            this.InputGroupBox.Controls.Add(this.FolderInputSourceButton);
            this.InputGroupBox.Controls.Add(this.InputSourceTextBox);
            this.InputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputGroupBox.Location = new System.Drawing.Point(0, 0);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(283, 49);
            this.InputGroupBox.TabIndex = 18;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Input";
            // 
            // InputSourceTextBox
            // 
            this.InputSourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputSourceTextBox.Location = new System.Drawing.Point(6, 16);
            this.InputSourceTextBox.Name = "InputSourceTextBox";
            this.InputSourceTextBox.Size = new System.Drawing.Size(207, 20);
            this.InputSourceTextBox.TabIndex = 0;
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Controls.Add(this.FolderOutputSourceButton);
            this.OutputGroupBox.Controls.Add(this.FolderOutputTextBox);
            this.OutputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputGroupBox.Location = new System.Drawing.Point(0, 0);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(282, 49);
            this.OutputGroupBox.TabIndex = 19;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output";
            // 
            // FolderOutputTextBox
            // 
            this.FolderOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderOutputTextBox.Location = new System.Drawing.Point(6, 16);
            this.FolderOutputTextBox.Name = "FolderOutputTextBox";
            this.FolderOutputTextBox.Size = new System.Drawing.Size(238, 20);
            this.FolderOutputTextBox.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(9, 58);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.FeatureGroupBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.StreamGroupBox);
            this.splitContainer2.Size = new System.Drawing.Size(566, 296);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 17;
            // 
            // FeatureGroupBox
            // 
            this.FeatureGroupBox.Controls.Add(this.FeatureLinkLabel);
            this.FeatureGroupBox.Controls.Add(this.FeatureDataGridView);
            this.FeatureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeatureGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FeatureGroupBox.Name = "FeatureGroupBox";
            this.FeatureGroupBox.Size = new System.Drawing.Size(566, 110);
            this.FeatureGroupBox.TabIndex = 15;
            this.FeatureGroupBox.TabStop = false;
            // 
            // FeatureDataGridView
            // 
            this.FeatureDataGridView.AllowUserToAddRows = false;
            this.FeatureDataGridView.AllowUserToDeleteRows = false;
            this.FeatureDataGridView.AllowUserToResizeColumns = false;
            this.FeatureDataGridView.AllowUserToResizeRows = false;
            this.FeatureDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeatureDataGridView.AutoGenerateColumns = false;
            this.FeatureDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FeatureDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.FeatureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeatureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeatureNumberDataGridViewTextBoxColumn1,
            this.FeatureNameDataGridViewTextBoxColumn,
            this.FeatureDescriptionDataGridViewTextBoxColumn,
            this.FeatureFileDataGridViewComboBoxColumn,
            this.FeatureDurationDataGridViewTextBoxColumn});
            this.FeatureDataGridView.DataSource = this.FeatureBindingSource;
            this.FeatureDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.FeatureDataGridView.Location = new System.Drawing.Point(6, 16);
            this.FeatureDataGridView.MultiSelect = false;
            this.FeatureDataGridView.Name = "FeatureDataGridView";
            this.FeatureDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FeatureDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FeatureDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FeatureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeatureDataGridView.ShowEditingIcon = false;
            this.FeatureDataGridView.Size = new System.Drawing.Size(554, 88);
            this.FeatureDataGridView.TabIndex = 13;
            this.FeatureDataGridView.Tag = "0";
            this.FeatureDataGridView.DataSourceChanged += new System.EventHandler(this.FeatureDataGridView_DataSourceChanged);
            this.FeatureDataGridView.SelectionChanged += new System.EventHandler(this.FeatureDataGridView_SelectionChanged);
            // 
            // FeatureNumberDataGridViewTextBoxColumn1
            // 
            this.FeatureNumberDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeatureNumberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.FeatureNumberDataGridViewTextBoxColumn1.FillWeight = 5F;
            this.FeatureNumberDataGridViewTextBoxColumn1.HeaderText = "#";
            this.FeatureNumberDataGridViewTextBoxColumn1.MinimumWidth = 26;
            this.FeatureNumberDataGridViewTextBoxColumn1.Name = "FeatureNumberDataGridViewTextBoxColumn1";
            this.FeatureNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.FeatureNumberDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FeatureNumberDataGridViewTextBoxColumn1.ToolTipText = "Feature number";
            // 
            // FeatureNameDataGridViewTextBoxColumn
            // 
            this.FeatureNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeatureNameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.FeatureNameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.FeatureNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.FeatureNameDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.FeatureNameDataGridViewTextBoxColumn.Name = "FeatureNameDataGridViewTextBoxColumn";
            this.FeatureNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.FeatureNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FeatureNameDataGridViewTextBoxColumn.ToolTipText = "Feature name";
            // 
            // FeatureDescriptionDataGridViewTextBoxColumn
            // 
            this.FeatureDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeatureDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.FeatureDescriptionDataGridViewTextBoxColumn.FillWeight = 50F;
            this.FeatureDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.FeatureDescriptionDataGridViewTextBoxColumn.MinimumWidth = 244;
            this.FeatureDescriptionDataGridViewTextBoxColumn.Name = "FeatureDescriptionDataGridViewTextBoxColumn";
            this.FeatureDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.FeatureDescriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FeatureDescriptionDataGridViewTextBoxColumn.ToolTipText = "Feature description";
            // 
            // FeatureFileDataGridViewComboBoxColumn
            // 
            this.FeatureFileDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeatureFileDataGridViewComboBoxColumn.FillWeight = 15F;
            this.FeatureFileDataGridViewComboBoxColumn.HeaderText = "File(s)";
            this.FeatureFileDataGridViewComboBoxColumn.MinimumWidth = 90;
            this.FeatureFileDataGridViewComboBoxColumn.Name = "FeatureFileDataGridViewComboBoxColumn";
            this.FeatureFileDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FeatureFileDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FeatureFileDataGridViewComboBoxColumn.ToolTipText = "Feature File(s)";
            // 
            // FeatureDurationDataGridViewTextBoxColumn
            // 
            this.FeatureDurationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeatureDurationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.FeatureDurationDataGridViewTextBoxColumn.FillWeight = 10F;
            this.FeatureDurationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.FeatureDurationDataGridViewTextBoxColumn.MinimumWidth = 52;
            this.FeatureDurationDataGridViewTextBoxColumn.Name = "FeatureDurationDataGridViewTextBoxColumn";
            this.FeatureDurationDataGridViewTextBoxColumn.ReadOnly = true;
            this.FeatureDurationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FeatureBindingSource
            // 
            this.FeatureBindingSource.AllowNew = false;
            this.FeatureBindingSource.DataSource = typeof(eac3to.Feature);
            // 
            // StreamGroupBox
            // 
            this.StreamGroupBox.Controls.Add(this.StreamDataGridView);
            this.StreamGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreamGroupBox.Location = new System.Drawing.Point(0, 0);
            this.StreamGroupBox.Name = "StreamGroupBox";
            this.StreamGroupBox.Size = new System.Drawing.Size(566, 185);
            this.StreamGroupBox.TabIndex = 16;
            this.StreamGroupBox.TabStop = false;
            this.StreamGroupBox.Text = "Stream(s)";
            // 
            // StreamDataGridView
            // 
            this.StreamDataGridView.AllowUserToAddRows = false;
            this.StreamDataGridView.AllowUserToDeleteRows = false;
            this.StreamDataGridView.AllowUserToResizeColumns = false;
            this.StreamDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            this.StreamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.StreamDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreamDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StreamDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.StreamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StreamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StreamExtractCheckBox,
            this.StreamNumberTextBox,
            this.StreamTypeTextBox,
            this.StreamDescriptionTextBox,
            this.StreamExtractAsComboBox,
            this.StreamAddOptionsTextBox});
            this.StreamDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.StreamDataGridView.Location = new System.Drawing.Point(6, 18);
            this.StreamDataGridView.MultiSelect = false;
            this.StreamDataGridView.Name = "StreamDataGridView";
            this.StreamDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.StreamDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.StreamDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StreamDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StreamDataGridView.ShowEditingIcon = false;
            this.StreamDataGridView.Size = new System.Drawing.Size(554, 160);
            this.StreamDataGridView.TabIndex = 7;
            this.StreamDataGridView.DataSourceChanged += new System.EventHandler(this.StreamDataGridView_DataSourceChanged);
            // 
            // StreamExtractCheckBox
            // 
            this.StreamExtractCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamExtractCheckBox.FalseValue = "0";
            this.StreamExtractCheckBox.FillWeight = 10F;
            this.StreamExtractCheckBox.HeaderText = "Extract?";
            this.StreamExtractCheckBox.IndeterminateValue = "-1";
            this.StreamExtractCheckBox.MinimumWidth = 55;
            this.StreamExtractCheckBox.Name = "StreamExtractCheckBox";
            this.StreamExtractCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StreamExtractCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.StreamExtractCheckBox.ToolTipText = "Extract stream?";
            this.StreamExtractCheckBox.TrueValue = "1";
            // 
            // StreamNumberTextBox
            // 
            this.StreamNumberTextBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamNumberTextBox.DataPropertyName = "Number";
            this.StreamNumberTextBox.FillWeight = 5F;
            this.StreamNumberTextBox.HeaderText = "#";
            this.StreamNumberTextBox.MinimumWidth = 28;
            this.StreamNumberTextBox.Name = "StreamNumberTextBox";
            this.StreamNumberTextBox.ReadOnly = true;
            this.StreamNumberTextBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StreamNumberTextBox.ToolTipText = "Stream Number";
            // 
            // StreamTypeTextBox
            // 
            this.StreamTypeTextBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamTypeTextBox.DataPropertyName = "Type";
            this.StreamTypeTextBox.FillWeight = 10F;
            this.StreamTypeTextBox.HeaderText = "Type";
            this.StreamTypeTextBox.MinimumWidth = 55;
            this.StreamTypeTextBox.Name = "StreamTypeTextBox";
            this.StreamTypeTextBox.ReadOnly = true;
            this.StreamTypeTextBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StreamTypeTextBox.ToolTipText = "Stream type";
            // 
            // StreamDescriptionTextBox
            // 
            this.StreamDescriptionTextBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamDescriptionTextBox.DataPropertyName = "Description";
            this.StreamDescriptionTextBox.FillWeight = 45F;
            this.StreamDescriptionTextBox.HeaderText = "Description";
            this.StreamDescriptionTextBox.MinimumWidth = 250;
            this.StreamDescriptionTextBox.Name = "StreamDescriptionTextBox";
            this.StreamDescriptionTextBox.ReadOnly = true;
            this.StreamDescriptionTextBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StreamDescriptionTextBox.ToolTipText = "Stream description";
            // 
            // StreamExtractAsComboBox
            // 
            this.StreamExtractAsComboBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamExtractAsComboBox.FillWeight = 12F;
            this.StreamExtractAsComboBox.HeaderText = "Extract As";
            this.StreamExtractAsComboBox.MinimumWidth = 72;
            this.StreamExtractAsComboBox.Name = "StreamExtractAsComboBox";
            this.StreamExtractAsComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StreamExtractAsComboBox.ToolTipText = "Stream extract type";
            // 
            // StreamAddOptionsTextBox
            // 
            this.StreamAddOptionsTextBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamAddOptionsTextBox.FillWeight = 13F;
            this.StreamAddOptionsTextBox.HeaderText = "+ Options";
            this.StreamAddOptionsTextBox.MinimumWidth = 65;
            this.StreamAddOptionsTextBox.Name = "StreamAddOptionsTextBox";
            this.StreamAddOptionsTextBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StreamAddOptionsTextBox.ToolTipText = "Stream extract additional options";
            // 
            // StreamsBindingSource
            // 
            this.StreamsBindingSource.AllowNew = false;
            this.StreamsBindingSource.DataSource = typeof(eac3to.Stream);
            // 
            // HdBrStreamExtractor
            // 
            this.AcceptButton = this.ExtractButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.HelpLinkLabel);
            this.Controls.Add(this.Eac3toLinkLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.LogTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "HdBrStreamExtractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HD-DVD/Blu-ray Stream Extractor ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HdBrStreamExtractor_FormClosing);
            this.Load += new System.EventHandler(this.HdBrStreamExtractor_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.FeatureGroupBox.ResumeLayout(false);
            this.FeatureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeatureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeatureBindingSource)).EndInit();
            this.StreamGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StreamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource FeatureBindingSource;
        private System.Windows.Forms.BindingSource StreamsBindingSource;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.LinkLabel Eac3toLinkLabel;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.LinkLabel HelpLinkLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Button FileInputSourceButton;
        private System.Windows.Forms.Button FolderInputSourceButton;
        private System.Windows.Forms.TextBox InputSourceTextBox;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Button FolderOutputSourceButton;
        private System.Windows.Forms.TextBox FolderOutputTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox FeatureGroupBox;
        private System.Windows.Forms.LinkLabel FeatureLinkLabel;
        private CustomDataGridView FeatureDataGridView;
        private System.Windows.Forms.GroupBox StreamGroupBox;
        private CustomDataGridView StreamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn FeatureFileDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StreamExtractCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamNumberTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamTypeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamDescriptionTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn StreamExtractAsComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamAddOptionsTextBox;
    }
}