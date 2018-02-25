﻿// -------------------------------------------------------------------------------------------
// <copyright file="LayoutHelper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Plugins.Printing.Controls.Layout;
using VastGIS.Plugins.Printing.Enums;
using VastGIS.Plugins.Printing.Model.Elements;
using VastGIS.Plugins.Printing.Properties;
using VastGIS.Plugins.Printing.Services;
using VastGIS.Plugins.Services;
using VastGIS.Shared;

namespace VastGIS.Plugins.Printing.Helpers
{
    internal static class LayoutHelper
    {
        public static void SetUniqueElementName(IEnumerable<LayoutElement> elements, LayoutElement le)
        {
            var list = elements.ToList();

            string leName = le.Name + " 1";
            int i = 2;

            while (list.Any(o => o.Name == leName))
            {
                leName = le.Name + " " + i;
                i++;
            }

            le.Name = leName;
        }

        public static LayoutBitmap ConvertElementToBitmap(LayoutElement le, string filename)
        {
            if (le is LayoutBitmap) return null;
            int padding = le is LayoutLegend ? 10 : 0;

            int width = Convert.ToInt32(le.SizeF.Width * 3 + 0.5) + padding;
            int height = Convert.ToInt32(le.SizeF.Height *  3 + 0.5);

            if (le is LayoutMap)
            {
                width = Convert.ToInt32(width * ScreenHelper.LogicToScreenDpi);
                height = Convert.ToInt32(height * ScreenHelper.LogicToScreenDpi);
            }
            
            using (var temp = new Bitmap(width, height, PixelFormat.Format32bppArgb))
            { 
                temp.SetResolution(96, 96);
                temp.MakeTransparent();

                using (var g = Graphics.FromImage(temp))
                {
                    g.PageUnit = GraphicsUnit.Pixel;
                    g.ScaleTransform(300F / 100F, 300F / 100F);

                    if (!(le is LayoutMap))
                    {
                        g.TranslateTransform(-le.LocationF.X, -le.LocationF.Y);
                    }

                    le.DrawElement(g, false, false);
                }

                temp.SetResolution(300, 300);
                temp.Save(filename);
            }
            
            var bmp = new LayoutBitmap
                          {
                              Rectangle = le.Rectangle,
                              Name = le.Name,
                              Filename = filename,
                              Initialized = true
                          };

            return bmp;
        }

        /// <summary>
        /// Calculates which edge of a rectangle the point intersects with, within a certain limit
        /// </summary>
        public static Edge IntersectElementEdge(RectangleF screen, PointF pt, float limit)
        {
            var ptRect = new RectangleF(pt.X - limit, pt.Y - limit, 2F * limit, 2F * limit);
            if ((pt.X >= screen.X - limit && pt.X <= screen.X + limit) &&
                (pt.Y >= screen.Y - limit && pt.Y <= screen.Y + limit)) return Edge.TopLeft;
            if ((pt.X >= screen.X + screen.Width - limit && pt.X <= screen.X + screen.Width + limit) &&
                (pt.Y >= screen.Y - limit && pt.Y <= screen.Y + limit)) return Edge.TopRight;
            if ((pt.X >= screen.X + screen.Width - limit && pt.X <= screen.X + screen.Width + limit) &&
                (pt.Y >= screen.Y + screen.Height - limit && pt.Y <= screen.Y + screen.Height + limit)) return Edge.BottomRight;
            if ((pt.X >= screen.X - limit && pt.X <= screen.X + limit) &&
                (pt.Y >= screen.Y + screen.Height - limit && pt.Y <= screen.Y + screen.Height + limit)) return Edge.BottomLeft;
            if (ptRect.IntersectsWith(new RectangleF(screen.X, screen.Y, screen.Width, 1F))) return Edge.Top;
            if (ptRect.IntersectsWith(new RectangleF(screen.X, screen.Y, 1F, screen.Height))) return Edge.Left;
            if (ptRect.IntersectsWith(new RectangleF(screen.X, screen.Y + screen.Height, screen.Width, 1F))) return Edge.Bottom;
            if (ptRect.IntersectsWith(new RectangleF(screen.X + screen.Width, screen.Y, 1F, screen.Height))) return Edge.Right;
            return Edge.None;
        }
    }
}