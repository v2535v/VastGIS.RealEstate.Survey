using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class Jzx
    {
        public bool Selected { get; set; }
        public int Zdnxsh { get; set; }
        public double CenterX { get; set; }
        public double  CenterY { get; set; }

        public double StartX { get; set; }
        public double StartY { get; set; }

        public double EndX { get; set; }
        public double EndY { get; set; }

    }

}