// -------------------------------------------------------------------------------------------
// <copyright file="ITemplateView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Printing.Model;

namespace VastGIS.Plugins.Printing.Views.Abstract
{
    internal interface ITemplateView : IView<TemplateModel>
    {
        event Action LayoutSizeChanged;

        event Action FitToPage;

        event Action ViewShown;

        IEnvelope MapExtents { get; }

        int MapScale { get; }

        Orientation Orientation { get; }

        string PaperFormat { get; }

        LayoutTemplate Template { get; }

        bool IsNewLayout { get; }

        void PopulateScales(int customScale = 0);

        bool IsFitToPage { get; }
    }
}