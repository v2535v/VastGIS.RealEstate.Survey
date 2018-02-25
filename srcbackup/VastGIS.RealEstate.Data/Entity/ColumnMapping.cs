﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.RealEstate.Data.Entity
{
    public class ColumnMapping
    {
        public ColumnMapping(string from, string to)
        {
            From = from;
            To = to;
        }
        public string From { get; set; }
        public string To { get; set; }
    }
}
