﻿// ****************************************************************************
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
using eac3toGUI;

namespace eac3to
{
    /// <summary>An enumeration of Subtitle Stream types</summary>
    [Flags]
    public enum SubtitleStreamType
    {
        [StringValue("Advanced SubStation Alpha")]
        ASS,
        [StringValue("SubStation Alpha")]
        SSA,
        [StringValue("SubRip")]
        SRT,
        [StringValue("DirectVobSub")]
        SUB,
        [StringValue("Subpicture")]
        SUP
    }
}