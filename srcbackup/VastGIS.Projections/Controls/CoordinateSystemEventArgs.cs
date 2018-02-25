using System;
using VastGIS.Projections.BL;

namespace VastGIS.Projections.Controls
{
    public class CoordinateSystemEventArgs: EventArgs
    {
        public CoordinateSystem CoordinateSystem { get; set; }
    }
}
