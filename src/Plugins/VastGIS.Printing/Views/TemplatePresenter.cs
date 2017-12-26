// -------------------------------------------------------------------------------------------
// <copyright file="TemplatePresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Helpers;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Helpers;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Printing.Enums;
using VastGIS.Plugins.Printing.Helpers;
using VastGIS.Plugins.Printing.Model;
using VastGIS.Plugins.Printing.Views.Abstract;
using VastGIS.Plugins.Services;
using VastGIS.Shared;

namespace VastGIS.Plugins.Printing.Views
{
    internal class TemplatePresenter : BasePresenter<ITemplateView, TemplateModel>
    {
        private readonly IAppContext _context;

        public TemplatePresenter(ITemplateView view, IAppContext context)
            : base(view)
        {
            _context = context;

            View.LayoutSizeChanged += OnLayoutSizeChanged;

            View.FitToPage += FitToPage;
            View.ViewShown += FitToPage;
        }

        private void OnLayoutSizeChanged()
        {
            Validate();

            View.UpdateView();
        }

        /// <summary>
        /// Called when fit to page is clicked.
        /// </summary>
        private void FitToPage()
        {
            GeoSize geoSize;
            if (_context.Map.GetGeodesicSize(View.MapExtents, out geoSize))
            {
                var size = GetUsablePaperSize();
                if (size == default(SizeF))
                {
                    return;
                }

                size.Width -= PrintingConstants.DefaultMapOffset * 2;
                size.Height -= PrintingConstants.DefaultMapOffset * 2;

                // let's adjust the size according to XY ratio, 
                // since geodesic scale may differ along the axis
                double ratio = size.Width / size.Height;
                double ratio2 = View.MapExtents.Width / View.MapExtents.Height;
                if (ratio > ratio2)
                {
                    size.Width /= (float)(ratio / ratio2);
                }
                else if (ratio < ratio2)
                {
                    size.Height /= (float)(ratio2 / ratio);
                }

                double val = LayoutScaleHelper.CalcMapScale(geoSize, size, Enums.ScaleType.Average);

                int scale = Convert.ToInt32(val);
                if (scale == 0)
                {
                    // it's probably an empty map, but let's display something all the same
                    scale = 1;
                }

                View.PopulateScales(scale);
            }
        }

        /// <summary>
        /// A handler for the IView.OkButton.Click event. 
        /// If the method returns true, View will be closed and presenter.ReturnValue set to true.
        /// If the method return false, no actions are taken, so View.Close, presenter.ReturnValue
        /// should be called / set manually.
        /// </summary>
        public override bool ViewOkClicked()
        {
            if (View.MapScale == 0)
            {
                MessageService.Current.Info("Map scale is not defined.");
                return false;
            }

            if (!Validate())
            {
                string msg = View.IsNewLayout ? "Invalid layout size." : "No template is selected.";
                MessageService.Current.Info(msg);
                return false;
            }

            Model.PaperFormat = View.PaperFormat;
            Model.PaperOrientation = View.Orientation;
            Model.TemplateName = TemplateFilename;
            Model.Extents = View.MapExtents;
            Model.Scale = View.MapScale;

            SaveConfig();

            InitPaperSize();

            return true;
        }

        private void InitPaperSize()
        {
            var ps = Model.PrinterSettings;

            // TODO: improve conversion from PaperFormat to PaperSize
            var paperSizes = PaperSizes.GetPaperSizes(ps);
            var paperSize = paperSizes.FirstOrDefault(p => p.PaperName == PaperFormat.A4.ToString());

            ps.DefaultPageSettings.PaperSize = paperSize;
        }

        private string TemplateFilename
        {
            get
            {
                if (View.IsNewLayout)
                {
                    return string.Empty;
                }

                var template = View.Template;
                return template != null ? template.Filename : string.Empty;
            }
        }

        /// <summary>
        /// Calculates canvas size in pixels.
        /// </summary>
        private bool CalculateCanvasSize(out SizeF size)
        {
            size = default(SizeF);

            var extents = View.MapExtents;

            GeoSize geoSize;
            if (!_context.Map.GetGeodesicSize(extents, out geoSize))
            {
                return false;
            }

            if (!NumericHelper.Equal(View.MapScale, 0.0))
            {
                size = LayoutScaleHelper.CalcMapSize(View.MapScale, geoSize, extents.Width / extents.Height);
            }

            return true;
        }

        private SizeF GetUsablePaperSize()
        {
            if (string.IsNullOrWhiteSpace(View.PaperFormat))
            {
                return default(SizeF);
            }

            var paperSize = PaperSizes.PaperSizeByFormatName(View.PaperFormat, Model.PrinterSettings);
            if (paperSize != null)
            {
                var margins = AppConfig.Instance.PrintingMargins;
                float width = paperSize.Width - margins.Left - margins.Right;
                float height = paperSize.Height - margins.Top - margins.Bottom;

                bool swap = View.Orientation != Orientation.Vertical;

                return new SizeF(swap ? height : width, swap ? width : height);
            }

            Logger.Current.Warn("Failed to find specified paper format: " + View.PaperFormat);
            return default(SizeF);
        }

        /// <summary>
        /// Calculates the number of pages
        /// </summary>
        private void CalculatePageCount(SizeF size)
        {
            var usableSize = GetUsablePaperSize();
            if (usableSize == default(SizeF))
            {
                Model.PageCountX = -1;
                Model.PageCountY = -1;
                return;
            }

            Model.PageCountX = (int)Math.Ceiling(size.Width / usableSize.Width);
            Model.PageCountY = (int)Math.Ceiling(size.Height / usableSize.Height);
        }

        private void SaveConfig()
        {
            var config = AppConfig.Instance;

            config.PrintingOrientation = View.Orientation;
            config.PrintingPaperFormat = View.PaperFormat;
            config.PrintingTemplate = TemplateFilename;
        }

        /// <summary>
        /// Calculates canvas size and returns true if it's within limits.
        /// </summary>
        private bool Validate()
        {
            if (View.IsNewLayout)
            {
                SizeF size;
                if (!CalculateCanvasSize(out size))
                {
                    return false;
                }

                Model.Valid = size.Width * size.Height / 10000 <= Math.Pow(PrintingConstants.MaxSizeInches, 2.0);

                CalculatePageCount(size);

                return Model.Valid;
            }

            return View.Template != null;
        }
    }
}