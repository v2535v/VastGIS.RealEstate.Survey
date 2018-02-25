﻿// -------------------------------------------------------------------------------------------
// <copyright file="LayoutPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Printing.Enums;
using VastGIS.Plugins.Printing.Helpers;
using VastGIS.Plugins.Printing.Model;
using VastGIS.Plugins.Printing.Model.Elements;
using VastGIS.Plugins.Printing.Services;
using VastGIS.Plugins.Printing.Views.Abstract;

namespace VastGIS.Plugins.Printing.Views
{
    internal class LayoutPresenter : ComplexPresenter<ILayoutView, LayoutCommand, TemplateModel>
    {
        private readonly IAppContext _context;
        private readonly TileLoadingService _loadingService;

        public LayoutPresenter(IAppContext context, ILayoutView view, TileLoadingService loadingService)
            : base(view)
        {
            _context = context;
            _loadingService = loadingService;
            if (context == null) throw new ArgumentNullException("context");
            if (loadingService == null) throw new ArgumentNullException("loadingService");

            View.LayoutControl.NewElement += OnNewElement;
            View.LayoutControl.ElementDoubleClicked += OnElementDoubleClicked;

            _loadingService.Start += OnLoadingServiceStart;
            _loadingService.End += OnLoadingServiceEnd;
        }

        private void OnLoadingServiceEnd(object sender, EventArgs e)
        {
            if (View.Visible)
            {
                View.TilesLoadingVisible = false;
            }
        }

        private void OnLoadingServiceStart(object sender, EventArgs e)
        {
            if (View.Visible)
            {
                View.TilesLoadingVisible = true;
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
            return true;
        }

        protected override void Initialize()
        {
            View.LayoutControl.Lock();

            if (Model.HasTemplate)
            {
                var serializer = new LayoutSerializer();
                serializer.LoadLayout(_context, View.LayoutControl, Model.TemplateName, Model.Extents, Model.PrinterSettings);
            }

            View.LayoutControl.PrinterSettings = Model.PrinterSettings;

            View.LayoutControl.Initialize(_context.Map, _loadingService);

            if (!Model.HasTemplate)
            {
                AddMapElement(Model.Scale, Model.Extents);
            }


            View.LayoutControl.Unlock();

            View.UpdateView();
        }

        /// <summary>
        /// Adds map element to the new layout.
        /// </summary>
        /// <param name="mapScale">The map scale.</param>
        /// <param name="extents">The extents.</param>
        private void AddMapElement(int mapScale, IEnvelope extents)
        {
            var map = _context.Map;

            var mapElement = new LayoutMap();
            mapElement.Initialize(map, View.LayoutControl);
            mapElement.IsMain = true;
            mapElement.TileProvider = _context.Map.TileProvider;

            mapElement.LocationF = new PointF(PrintingConstants.DefaultMapOffset, PrintingConstants.DefaultMapOffset); 
            mapElement.DrawTiles = map.Tiles.Visible;

            // calc the necessary size in paper coordinates
            GeoSize size;
            if (map.GetGeodesicSize(extents, out size))
            {
                mapElement.SizeF = LayoutScaleHelper.CalcMapSize(mapScale, size, extents.Width / extents.Height);

                mapElement.Envelope = extents.Clone();
                mapElement.Initialized = true;

                View.LayoutControl.AddToLayout(mapElement);

                View.LayoutControl.UpdateLayout();

                View.LayoutControl.ZoomFitToScreen();
            }
        }

        /// <summary>
        /// Edits the table.
        /// </summary>
        private bool EditTable(LayoutTable table, bool newTable)
        {
            var model2 = new TableViewModel(table, newTable);
            if (_context.Container.Run<TablePresenter, TableViewModel>(model2))
            {
                table.UpdateWidth(GdiPlusHelper.TempGraphics, false);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Opens element specific editing dialog for the element
        /// </summary>
        private void OnElementDoubleClicked(object sender, LayoutElementEventArgs e)
        {
            switch (e.Element.Type)
            {
                case ElementType.Table:
                    {
                        if (EditTable(e.Element as LayoutTable, false))
                        {
                            return;
                        }
                        break;
                    }
            }

            e.Cancel = true;
        }

        /// <summary>
        /// Initializes element added by user manually.
        /// </summary>
        private void OnNewElement(object sender, LayoutElementEventArgs e)
        {
            switch (e.Element.Type)
            {
                case ElementType.Table:
                    {
                        if (!OpenTableDialog(e.Element as LayoutTable))
                        {
                            e.Cancel = true;
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Initializes a table added by user.
        /// </summary>
        private bool OpenTableDialog(LayoutTable table)
        {
            var model = new CreateTableModel();
            if (_context.Container.Run<CreateTablePresenter, CreateTableModel>(model))
            {
                table.Data.Initialize(model.RowCount, model.ColumnCount);

                return EditTable(table, true);
            }

            return false;
        }

        public override void RunCommand(LayoutCommand command)
        {
            var width = View.LayoutControl.Pages.TotalWidth;
            var height = View.LayoutControl.Pages.TotalHeight;
            var list = View.LayoutControl.SelectedLayoutElements.ToList();

            switch (command)
            {
                case LayoutCommand.MoveUp:
                    View.LayoutControl.MoveSelectionUp();
                    break;
                case LayoutCommand.MoveDown:
                    View.LayoutControl.MoveSelectionDown();
                    break;
                case LayoutCommand.Delete:
                    View.LayoutControl.DeleteSelected();
                    break;
                case LayoutCommand.AlignLeft:
                    list.Align(Alignment.Left);
                    break;
                case LayoutCommand.AlignRight:
                    list.Align(Alignment.Right);
                    break;
                case LayoutCommand.AlignTop:
                    list.Align(Alignment.Top);
                    break;
                case LayoutCommand.AlignBottom:
                    list.Align(Alignment.Bottom);
                    break;
                case LayoutCommand.AlignHorizontal:
                    list.Align(Alignment.Horizontal);
                    break;
                case LayoutCommand.AlignVertical:
                    list.Align(Alignment.Vertical);
                    break;
                case LayoutCommand.PageAlignLeft:
                    list.AlignByPageSide(Alignment.Left, width, height);
                    break;
                case LayoutCommand.PageAlignRight:
                    list.AlignByPageSide(Alignment.Right, width, height);
                    break;
                case LayoutCommand.PageAlignTop:
                    list.AlignByPageSide(Alignment.Top, width, height);
                    break;
                case LayoutCommand.PageAlignBottom:
                    list.AlignByPageSide(Alignment.Bottom, width, height);
                    break;
                case LayoutCommand.PageAlignHorizontal:
                    list.AlignByPageSide(Alignment.Horizontal, width, height);
                    break;
                case LayoutCommand.PageAlignVertical:
                    list.AlignByPageSide(Alignment.Vertical, width, height);
                    break;
                case LayoutCommand.FitWidth:
                    {
                        int pageWidth = View.LayoutControl.Pages.PageWidth;
                        int pageHeight = View.LayoutControl.Pages.PageHeight;
                        list.FitToPage(Fit.Width, new Size(pageWidth, pageHeight));
                        list.AlignByPageSide(Alignment.Horizontal, pageWidth, pageHeight);
                    }
                    break;
                case LayoutCommand.FitHeight:
                    {
                        int pageWidth = View.LayoutControl.Pages.PageWidth;
                        int pageHeight = View.LayoutControl.Pages.PageHeight;
                        list.FitToPage(Fit.Height, new Size(pageWidth, pageHeight));
                        list.AlignByPageSide(Alignment.Vertical, pageWidth, pageHeight);
                    }
                    break;
                case LayoutCommand.FitBoth:
                    {
                        int pageWidth = View.LayoutControl.Pages.PageWidth;
                        int pageHeight = View.LayoutControl.Pages.PageHeight;
                        var size = new Size(pageWidth, pageHeight);
                        list.FitToPage(Fit.Width, size);
                        list.FitToPage(Fit.Height, size);
                        list.AlignByPageSide(Alignment.Vertical, width, height);
                        list.AlignByPageSide(Alignment.Horizontal, width, height);
                    }
                    break;
                case LayoutCommand.SameWidth:
                    list.MakeSameSize(Fit.Width);
                    break;
                case LayoutCommand.SameHeight:
                    list.MakeSameSize(Fit.Height);
                    break;
                case LayoutCommand.SameBoth:
                    list.MakeSameSize(Fit.Width);
                    list.MakeSameSize(Fit.Height);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("command");
            }
        }
    }
}