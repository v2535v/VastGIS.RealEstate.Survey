// -------------------------------------------------------------------------------------------
// <copyright file="PageSetupPresenter.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Printing.Helpers;
using VastGIS.Plugins.Printing.Views.Abstract;

namespace VastGIS.Plugins.Printing.Views
{
    internal class PageSetupPresenter : BasePresenter<IPageSetupView, PrinterSettings>
    {
        public PageSetupPresenter(IPageSetupView view)
            : base(view)
        {
        }

        /// <summary>
        /// A handler for the IView.OkButton.Click event. 
        /// If the method returns true, View will be closed and presenter.ReturnValue set to true.
        /// If the method return false, no actions are taken, so View.Close, presenter.ReturnValue
        /// should be called / set manually.
        /// </summary>
        public override bool ViewOkClicked()
        {
            var page = Model.DefaultPageSettings;

            page.PaperSize = View.PaperSize;
            page.Landscape = View.Orientation == Orientation.Horizontal;

            ConfigHelper.SaveMargins(page, View.LeftMargin, View.RightMargin, View.TopMargin, View.BottomMargin);

            AppConfig.Instance.PrintingMargins = page.Margins;

            return true;
        }
    }
}