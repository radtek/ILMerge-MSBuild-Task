﻿#region MIT License
/*
    MIT License

    Copyright (c) 2016 Emerson Brito

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ILMerge.MsBuild.Task
{

    [DataContract]
    public class AdvancedSettings
    {

        #region Property Wrappers

        [DataMember]
        public bool AllowMultipleAssemblyLevelAttributes { get; set; } = false;

        [DataMember]
        public bool AllowWildCards { get; set; } = false;

        [DataMember]
        public bool AllowZeroPeKind { get; set; } = false;

        [DataMember]
        public string AttributeFile { get; set; } = null;

        [DataMember]
        public bool Closed { get; set; } = false;

        [DataMember]
        public bool CopyAttributes { get; set; } = true;

        [DataMember]
        public bool DebugInfo { get; set; } = true;

        [DataMember]
        public bool DelaySign { get; set; } = false;

        [DataMember]
        public string ExcludeFile { get; set; } = "";

        [DataMember]
        public int FileAlignment { get; set; } = 512;

        [DataMember]
        public bool Internalize { get; set; } = false;

        [DataMember]
        public bool Log { get; set; } = false;

        [DataMember]
        public string LogFile { get; set; } = null;

        [DataMember]
        public bool PublicKeyTokens { get; set; } = true;

        [DataMember]
        public string TargetKind { get; set; } = null;

        [DataMember]
        public bool UnionMerge { get; set; } = false;

        [DataMember]
        public string Version { get; set; } = null;

        [DataMember]
        public bool XmlDocumentation { get; set; } = false;

        #endregion

        #region Method Wrappers

        /// <summary>
        /// Default is none. This option allows the user to either allow all public types to be renamed when they are duplicates, or to specify it for arbitrary type names.
        /// </summary>
        [DataMember]
        public string AllowDuplicateType { get; set; } = null;

        /// <summary>
        /// internal use
        /// </summary>
        [DataMember]
        public List<string> SearchDirectories { get; set; }

        #endregion

        #region Constructors

        public AdvancedSettings()
        {
            SearchDirectories = new List<string>();
        }

        #endregion

    }
}
