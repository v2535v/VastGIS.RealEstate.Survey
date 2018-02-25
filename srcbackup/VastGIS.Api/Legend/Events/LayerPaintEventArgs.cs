﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Api.Legend.Events
{
    public class LayerPaintEventArgs: LayerEventArgs
    {
        public Rectangle Bounds { get; internal set; }
        public Graphics Graphics { get; set; }

        public LayerPaintEventArgs(int layerHandle, Rectangle bounds, Graphics g) : base(layerHandle)
        {
            Graphics = g;
            Bounds = bounds;
        }
    }
}
