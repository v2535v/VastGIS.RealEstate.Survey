﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapWinGIS;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Static;

namespace VastGIS.Api.Helpers
{
    public static class MapHelper
    {
        public static void SetGoogleMercatorProjection(this IMuteMap map)
        {
            var sr = new SpatialReference();
            sr.SetGoogleMercator();
            map.Projection = sr;
        }

        /// <summary>
        /// Creates temporary shapefile, adds it to map and returns layer handle
        /// </summary>
        public static int DisplaySelection(this IMuteMap map, IEnvelope ext)
        {
            var sf = new FeatureSet(Enums.GeometryType.Polygon);

            var g = ext.ToGeometry();
            sf.Features.EditAdd(g);
            
            // will be displayed above labels of other layers
            sf.Volatile = true;

            bool oldZoomToFirstLayer = MapConfig.ZoomToFirstLayer;
            MapConfig.ZoomToFirstLayer = false;

            int handle = map.Layers.Add(sf, true, false);

            MapConfig.ZoomToFirstLayer = oldZoomToFirstLayer;

            var fill = sf.Style.Fill;
            fill.Color = Color.LightBlue;
            fill.Transparency = 100;

            var line = sf.Style.Line;
            line.Width = 2;
            line.Color = Color.Blue;
            line.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            
            map.Redraw();

            return handle;
        }
    }
}
