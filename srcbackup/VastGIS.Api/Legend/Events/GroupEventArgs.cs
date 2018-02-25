﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Api.Legend.Events
{
    public class GroupEventArgs : EventArgs
    {
        public GroupEventArgs(int groupHandle)
        {
            GroupHandle = groupHandle;
        }
        
        public int GroupHandle { get; internal set; }
    }
}
