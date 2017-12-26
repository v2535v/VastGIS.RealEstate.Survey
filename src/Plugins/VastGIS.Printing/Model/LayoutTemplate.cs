// -------------------------------------------------------------------------------------------
// <copyright file="LayoutTemplate.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Windows.Forms;
using VastGIS.Plugins.Printing.Services;
using VastGIS.Shared;

namespace VastGIS.Plugins.Printing.Model
{
    public class LayoutTemplate
    {
        public LayoutTemplate(string filename)
        {
            Filename = filename;

            LoadTemplate();
        }

        public string Filename { get; private set; }

        public string Name
        {
            get { return Path.GetFileNameWithoutExtension(Filename); }
        }

        public Orientation Orientation { get; private set; }

        public string Pages { get; private set; }

        public string PaperFormat { get; set; }

        private void LoadTemplate()
        {
            try
            {
                string xml = File.ReadAllText(Filename);

                var layout = LayoutSerializer.DeserializeLite(xml);

                if (layout != null)
                {
                    PaperFormat = layout.Paper.PaperName;
                    Orientation = layout.Paper.Landscape ? Orientation.Horizontal : Orientation.Vertical;
                    Pages = string.Format("{0} × {1}", layout.Paper.PageCountX, layout.Paper.PageCountY);
                }
                else
                {
                    Orientation = Orientation.Vertical;
                    PaperFormat = "n/d";
                    Pages = "n/d";
                }
            }
            catch (Exception ex)
            {
                Logger.Current.Warn("Failed to read layout template: " + Filename, ex);
            }
        }
    }
}