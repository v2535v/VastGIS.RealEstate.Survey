﻿// -------------------------------------------------------------------------------------------
// <copyright file="LayoutMenuCommands.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Printing.Properties;

namespace VastGIS.Plugins.Printing.Views
{
    public class LayoutMenuCommands : CommandProviderBase
    {
        public LayoutMenuCommands(PluginIdentity identity)
            : base(identity)
        {
        }

        public override IEnumerable<ICommand> GetCommands()
        {
            return new List<MenuCommand>
                       {
                           // file
                           new MenuCommand("New Layout", LayoutMenuKeys.NewLayout,
                               Resources.img_create24),
                           new MenuCommand("Save Layout", LayoutMenuKeys.SaveLayout,
                               Resources.img_save24),
                           new MenuCommand("Save Layout As", LayoutMenuKeys.SaveLayoutAs,
                               Resources.img_save_as24),
                           new MenuCommand("Load Layout", LayoutMenuKeys.LoadLayout,
                               Resources.img_open24),
                           new MenuCommand("Print", LayoutMenuKeys.Print, Resources.img_printer24),
                           new MenuCommand("Choose Printer...", LayoutMenuKeys.PrinterSetup, null),
                           new MenuCommand("Page Setup...", LayoutMenuKeys.PageSetup,
                               Resources.img_page_setup24),
                           new MenuCommand("Export to Bitmap", LayoutMenuKeys.ExportToBitmap,
                               Resources.img_export24),
                               new MenuCommand("Export to PDF", LayoutMenuKeys.ExportToPdf,
                               Resources.img_export_pdf24),
                           new MenuCommand("Close", LayoutMenuKeys.Close, Resources.img_close24),
                           new MenuCommand("Adjust Layout", LayoutMenuKeys.AdjustPages, Resources.img_refresh24),

                           // zooming
                           new MenuCommand("Zoom In", LayoutMenuKeys.ZoomIn, Resources.img_zoom_in24),
                           new MenuCommand("Zoom Out", LayoutMenuKeys.ZoomOut,
                               Resources.img_zoom_out24),
                           new MenuCommand("Zoom to Fit Screen", LayoutMenuKeys.ZoomFitScreen,
                               Resources.img_zoom_region24),
                               new MenuCommand("Zoom to Original Scale", LayoutMenuKeys.ZoomOriginal, Resources.img_zoom_original24),
                           new MenuCommand("Show Page Numbers", LayoutMenuKeys.ShowPageNumbers, Resources.img_page_number24),
                           new MenuCommand("Show Margins", LayoutMenuKeys.ShowMargins, null),
                           new MenuCommand("Show Rulers", LayoutMenuKeys.ShowRulers, null),
                           new MenuCommand("Restore Panels", LayoutMenuKeys.RestorePanels, null),
                           new MenuCommand("Restore Toolbars", LayoutMenuKeys.RestoreToolbars, null),

                           // selection
                           new MenuCommand("Select All", LayoutMenuKeys.SelectAll, null),
                           new MenuCommand("Select None", LayoutMenuKeys.SelectNone, null),
                           new MenuCommand("Invert Selection", LayoutMenuKeys.InvertSelection, null),
                           new MenuCommand("Convert Bitmap", LayoutMenuKeys.ConvertToBitmap, null),
                           new MenuCommand("Move Up", LayoutMenuKeys.MoveUp, null),
                           new MenuCommand("Move Down", LayoutMenuKeys.MoveDown, null),
                           new MenuCommand("Delete Element", LayoutMenuKeys.DeleteElement, null),

                           // map
                           new MenuCommand("Zoom map in", LayoutMenuKeys.MapZoomIn,
                               Resources.img_map_zoom_in24),
                           new MenuCommand("Zoom map to original extents", LayoutMenuKeys.ZoomToOriginalExtents,
                               Resources.img_zoom_layer24),
                           new MenuCommand("Zoom map to maximum extents", LayoutMenuKeys.ZoomToMaximum,
                               Resources.img_map_zoom_max24),
                           new MenuCommand("Zoom map out", LayoutMenuKeys.MapZoomOut,
                               Resources.img_map_zoom_out24),
                           new MenuCommand("Pan map", LayoutMenuKeys.MapPan, Resources.img_pan24),

                           // insert
                           new MenuCommand("Add Map", LayoutMenuKeys.AddMap,
                               Resources.img_insert_map24),
                           new MenuCommand("Add Legend", LayoutMenuKeys.AddLegend,
                               Resources.img_insert_legend24),
                           new MenuCommand("Add Scale Bar", LayoutMenuKeys.AddScaleBar,
                               Resources.img_scalebar24),
                           new MenuCommand("Add North Arrow", LayoutMenuKeys.AddNorthArrow,
                               Resources.img_insert_compass24),
                           new MenuCommand("Add Table", LayoutMenuKeys.AddTable,
                               Resources.img_insert_table24),
                           new MenuCommand("Add Label", LayoutMenuKeys.AddLabel,
                               Resources.img_insert_text24),
                           new MenuCommand("Add Rectangle", LayoutMenuKeys.AddRectangle,
                               Resources.img_rectangle24),
                           new MenuCommand("Add Bitmap", LayoutMenuKeys.AddBitmap,
                               Resources.img_insert_picture24),
                       };
        }
    }
}