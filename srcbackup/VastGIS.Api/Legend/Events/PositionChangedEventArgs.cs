﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Api.Legend.Events
{
    public class PositionChangedEventArgs: EventArgs
    {
        public PositionChangedEventArgs(int handle, int oldPosition, int newPosition)
        {
            Handle = handle;
            OldPosition = oldPosition;
            NewPostion = newPosition;
        }
        
        public int Handle { get; internal set; }
        public int OldPosition { get; internal set; }
        public int NewPostion { get; internal set; }
    }
}
