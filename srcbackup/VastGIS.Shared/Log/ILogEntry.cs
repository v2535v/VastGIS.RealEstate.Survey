﻿// -------------------------------------------------------------------------------------------
// <copyright file="ILogEntry.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Drawing;

namespace VastGIS.Shared.Log
{
    public interface ILogEntry
    {
        [DisplayName("Message")]
        string DetailedMessage { get; }

        [Browsable(false)]
        bool Displayed { get; set; }

        [Browsable(false)]
        Exception Exception { get; }

        [DisplayName(" ")]
        Bitmap Image { get; set; }

        [DisplayName(" ")]
        int Index { get; set; }

        LogLevel Level { get; }

        [Browsable(false)]
        string Message { get; }

        [DisplayName("Time")]
        DateTime TimeStamp { get; }

        string ToLine();

        string GetCompleteDescription(bool innerExceptions);
    }
}