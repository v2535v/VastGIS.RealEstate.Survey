﻿// -------------------------------------------------------------------------------------------
// <copyright file="ZoomableLayoutControl.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VastGIS.Plugins.Printing.Enums;
using VastGIS.Plugins.Printing.Helpers;
using VastGIS.Plugins.Printing.Model;
using VastGIS.Plugins.Printing.Model.Elements;

namespace VastGIS.Plugins.Printing.Controls.Layout
{
    [ToolboxItem(false)]
    public partial class ZoomableLayoutControl : LayoutControlBase
    {
        protected readonly List<LayoutElement> _layoutElements = new List<LayoutElement>();
        protected readonly List<LayoutElement> _selectedLayoutElements = new List<LayoutElement>();
        protected bool _showMargins;

        /// <summary>
        /// Creates a new instance of ZoomableLayoutControl
        /// </summary>
        internal ZoomableLayoutControl()
        {
            InitializeComponent();
        }

        public event EventHandler<PageSelectionEventArgs> PageSelectionChanged;

        public event EventHandler ZoomChanged;

        /// <summary>
        /// Gets the list of layoutElements currently loaded in the project
        /// </summary>
        public IEnumerable<LayoutElement> LayoutElements
        {
            get { return _layoutElements; }
        }

        /// <summary>
        /// Gets or sets the zoom of the paper
        /// </summary>
        public float Zoom
        {
            get { return _zoom; }
            set
            {
                _suppressScrollbarUpdate = true;

                var paperCenter = ScreenToPaper(UsableWidth / 2F, UsableHeight / 2F);

                _zoom = value <= 0.1F ? 0.1F : value;

                CenterPaperOnPoint(paperCenter);

                if (UsableWidth > PaperWidthPixels)
                {
                    CenterByWidth(new PointF(_pages.TotalWidth / 2F, _pages.TotalHeight / 2F));
                }

                if (UsableHeight > PaperHeightPixels)
                {
                    CenterByHeight(new PointF(_pages.TotalWidth / 2F, _pages.TotalHeight / 2F));
                }

                _suppressScrollbarUpdate = false;

                UpdateScrollBars();

                FireZoomChanged(null);
            }
        }

        /// <summary>
        /// Zooms the page to fit to the screen and centers it
        /// </summary>
        public void ZoomFitToScreen()
        {
            const int offset = 100;

            float xZoom = (UsableWidth - offset) / (_pages.TotalWidth * ScreenHelper.LogicToScreenDpi);
            float yZoom = (UsableHeight - offset) / (_pages.TotalHeight * ScreenHelper.LogicToScreenDpi);

            _zoom = xZoom < yZoom ? xZoom : yZoom;

            if (_zoom > 1)
            {
                _zoom = 1f;
            }

            var margins = _printerSettings.DefaultPageSettings.Margins;

            float width = _pages.TotalWidth;
            float height = _pages.TotalHeight;

            if (_showMargins)
            {
                width -= margins.Left - margins.Right;
                height -= margins.Top - margins.Bottom;
            }

            CenterPaperOnPoint(new PointF(width / 2f, height / 2F));

            FireZoomChanged(null);

            FirePageSelectionChanged();
        }

        /// <summary>
        /// Zooms into the paper
        /// </summary>
        public void ZoomIn()
        {
            Zoom = Zoom + 0.1F;
        }

        /// <summary>
        /// Zooms the specified map element in by 10%
        /// </summary>
        public void ZoomInMap(LayoutMap lm)
        {
            lm.ZoomInMap();
        }

        /// <summary>
        /// Zooms out of the paper
        /// </summary>
        public void ZoomOut()
        {
            Zoom = Zoom - 0.1F;
        }

        /// <summary>
        /// Zooms the specified map element out by 10%
        /// </summary>
        public void ZoomOutMap(LayoutMap lm)
        {
            lm.ZoomOutMap();
        }

        protected void FirePageSelectionChanged()
        {
            var handler = PageSelectionChanged;
            if (handler != null)
            {
                handler(this, new PageSelectionEventArgs { Count = _pages.Count(), Selected = _pages.SelectedCount });
            }
        }

        /// <summary>
        /// Gets requested element from the layout
        /// </summary>
        protected T GetElement<T>(ElementType role) where T : LayoutElement
        {
            return LayoutElements.FirstOrDefault(item => item is T && item.Type == role) as T;
        }

        /// <summary>
        /// Determines whether the element with specified index is selected.
        /// </summary>
        protected bool IsSelected(int elementIndex)
        {
            return _selectedLayoutElements.Contains(_layoutElements[elementIndex]);
        }

        /// <summary>
        /// Finds page located at specific screen ccordinates
        /// </summary>
        protected LayoutPage PageByClick(int xScreen, int yScreen)
        {
            var pnt = ScreenToPaper(xScreen, yScreen);

            return _pages.PageByClick(pnt);
        }

        /// <summary>
        /// Pans the map the specified amount
        /// </summary>
        /// <param name="lm">the layout map to pan</param>
        /// <param name="x">The distance to pan the map on x-axis in screen coord</param>
        /// <param name="y">The distance to pan the map on y-axis in screen coord</param>
        protected void PanMap(LayoutMap lm, float x, float y)
        {
            var mapOnScreen = PaperToScreen(lm.Rectangle);
            lm.PanMap((lm.Envelope.Width / mapOnScreen.Width) * x, (lm.Envelope.Height / mapOnScreen.Height) * -y);
        }

        /// <summary>
        /// Converts a point in screen coordinats to paper coordinats in 1/100 of an inch
        /// </summary>
        /// <returns></returns>
        internal PointF ScreenToPaper(PointF screen)
        {
            return ScreenToPaper(screen.X, screen.Y);
        }

        /// <summary>
        /// Converts a point in screen coordinats to paper coordinats in 1/100 of an inch
        /// </summary>
        /// <returns></returns>
        internal PointF ScreenToPaper(float screenX, float screenY)
        {
            float paperX = (screenX - _paperLocation.X) / _zoom * ScreenHelper.ScreenToLogicDpi;
            float paperY = (screenY - _paperLocation.Y) / _zoom * ScreenHelper.ScreenToLogicDpi;
            return new PointF(paperX, paperY);
        }

        /// <summary>
        /// Converts a rectangle in screen coordinats to paper coordiants in 1/100 of an inch
        /// </summary>
        /// <returns></returns>
        internal RectangleF ScreenToPaper(RectangleF screen)
        {
            return ScreenToPaper(screen.X, screen.Y, screen.Width, screen.Height);
        }

        /// <summary>
        /// Converts a rectangle in screen coordinats to paper coordiants in 1/100 of an inch
        /// </summary>
        /// <returns></returns>
        internal RectangleF ScreenToPaper(float screenX, float screenY, float screenW, float screenH)
        {
            var paperTL = ScreenToPaper(screenX, screenY);
            var paperBR = ScreenToPaper(screenX + screenW, screenY + screenH);
            return new RectangleF(paperTL.X, paperTL.Y, paperBR.X - paperTL.X, paperBR.Y - paperTL.Y);
        }

        /// <summary>
        /// Centers a paper on the screen by height
        /// </summary>
        private void CenterByHeight(PointF centerPoint)
        {
            var paperCenterOnScreen = PaperToScreen(centerPoint);
            float diffY = paperCenterOnScreen.Y - UsableHeight / 2F;
            _paperLocation.Y = _paperLocation.Y - diffY;
            UpdateScrollBars();
            DoInvalidate();
        }

        /// <summary>
        /// Centers a paper on the screen by width
        /// </summary>
        private void CenterByWidth(PointF centerPoint)
        {
            var paperCenterOnScreen = PaperToScreen(centerPoint);
            float diffX = paperCenterOnScreen.X - UsableWidth / 2F;
            _paperLocation.X = _paperLocation.X - diffX;
            UpdateScrollBars();
            DoInvalidate();
        }

        /// <summary>
        /// Centers the layout on a given point
        /// </summary>
        /// <param name="centerPoint">A Point on the paper to center on</param>
        private void CenterPaperOnPoint(PointF centerPoint)
        {
            var paperCenterOnScreen = PaperToScreen(centerPoint);

            float diffX = paperCenterOnScreen.X - UsableWidth / 2F;
            float diffY = paperCenterOnScreen.Y - UsableHeight / 2F;

            _paperLocation.X = _paperLocation.X - diffX;
            _paperLocation.Y = _paperLocation.Y - diffY;

            UpdateScrollBars();
            DoInvalidate();
        }

        /// <summary>
        /// Calls this to indicate the zoom has been changed
        /// </summary>
        private void FireZoomChanged(EventArgs e)
        {
            var handler = ZoomChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}