﻿// -------------------------------------------------------------------------------------------
// <copyright file="IPageSetupView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Drawing.Printing;
using System.Windows.Forms;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Printing.Views.Abstract
{
    internal interface IPageSetupView : IView<PrinterSettings>
    {
        double BottomMargin { get; }

        double LeftMargin { get; }

        Orientation Orientation { get; }

        PaperSize PaperSize { get; }

        double RightMargin { get; }

        double TopMargin { get; }
    }
}