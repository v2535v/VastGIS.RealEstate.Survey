﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Api.Legend.Events
{
    public class LayerEventArgs : SingleTargetEventArgs
    {
        public LayerEventArgs(int layerHandle)
        {
            LayerHandle = layerHandle;
        }

        public int LayerHandle { get; internal set; }
    }
}
