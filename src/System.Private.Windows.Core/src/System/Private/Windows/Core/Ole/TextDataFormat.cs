﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Private.Windows.Core.Ole;

internal enum TextDataFormat
{
    /// <summary>
    ///  Specifies the standard ANSI text format.
    /// </summary>
    Text,

    /// <summary>
    ///  Specifies the standard Windows Unicode text format.
    /// </summary>
    UnicodeText,

    /// <summary>
    ///  Specifies text consisting of Rich Text Format (RTF) data.
    /// </summary>
    Rtf,

    /// <summary>
    ///  Specifies text consisting of HTML data.
    /// </summary>
    Html,

    /// <summary>
    ///  Specifies a comma-separated value (CSV) format, which is a
    ///  common interchange format used by spreadsheets.
    /// </summary>
    CommaSeparatedValue,

    /// <summary>
    ///  Specifies a data format as Xaml.
    /// </summary>
    Xaml
}