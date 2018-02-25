﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Api.Legend.Events
{
    public class LayerMeasureEventArgs: LayerEventArgs
    {
        public int CurrentWidth { get; internal set; }
        public int HeightToDraw { get; set; }

        public LayerMeasureEventArgs(int layerHandle, int currentWidth, int heightToDraw) : base(layerHandle)
        {
            CurrentWidth = currentWidth;
            HeightToDraw = heightToDraw;
        }
    }
}
