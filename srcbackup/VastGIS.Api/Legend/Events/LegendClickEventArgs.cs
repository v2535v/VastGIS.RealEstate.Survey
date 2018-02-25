﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VastGIS.Api.Legend.Events
{
    public class LegendClickEventArgs: EventArgs
    {
        public LegendClickEventArgs(MouseButtons buttons, Point location)
        {
            Button = buttons;
            Location = location;
        }

         public MouseButtons Button { get; internal set; }
         public Point Location { get; internal set; }
    }
}
