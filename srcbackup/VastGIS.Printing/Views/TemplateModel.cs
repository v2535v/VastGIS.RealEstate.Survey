﻿// -------------------------------------------------------------------------------------------
// <copyright file="TemplateModel.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Helpers;
using VastGIS.Plugins.Printing.Enums;
using VastGIS.Plugins.Printing.Helpers;
using VastGIS.Plugins.Printing.Model;
using VastGIS.Shared;

namespace VastGIS.Plugins.Printing.Views
{
    internal class TemplateModel
    {
        private readonly PrinterSettings _printerSettings;

        private TemplateModel(PrinterSettings settings)
        {
            if (settings == null) throw new ArgumentNullException("settings");
            Valid = true;
            Templates = new List<LayoutTemplate>();
            _printerSettings = settings;
        }

        public TemplateModel(PrintArea area, PrinterSettings settings)
            : this(settings)
        {
            PrintArea = area;
            Extents = null;
            
        }

        public TemplateModel(IEnvelope extents, PrinterSettings settings)
            : this(settings)
        {
            if (extents == null) throw new ArgumentNullException("extents");
            Extents = extents;
            PrintArea = PrintArea.Selection;
        }

        public IEnvelope Extents { get; set; }

        public int PageCountX { get; set; }

        public int PageCountY { get; set; }

        public string PaperFormat { get; set; }

        public Orientation PaperOrientation { get; set; }

        public PrintArea PrintArea { get; set; }

        public int Scale { get; set; }

        public string TemplateName { get; set; }

        public bool Valid { get; set; }

        public List<LayoutTemplate> Templates { get; private set;  }

        public bool HasTemplate
        {
            get { return !string.IsNullOrWhiteSpace(TemplateName); }
        }

        public void LoadTemplates(string path)
        {
            Templates.Clear();

            try
            {
                string[] names = Directory.GetFiles(path, "*.xml");

                foreach (var name in names)
                {
                    Templates.Add(new LayoutTemplate(name));
                }
            }
            catch (Exception ex)
            {
                Logger.Current.Warn("Failed to load layout templates: " + path, ex);
            }
        }

        public PrinterSettings PrinterSettings
        {
            get
            {
                var page = _printerSettings.DefaultPageSettings;

                page.Landscape = PaperOrientation == Orientation.Horizontal;

                if (!string.IsNullOrWhiteSpace(PaperFormat))
                {
                    page.PaperSize = PaperSizes.PaperSizeByFormatName(PaperFormat, _printerSettings);
                }

                page.Margins = AppConfig.Instance.PrintingMargins;

                return _printerSettings;
            }
        }
    }
}