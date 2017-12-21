using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Legend.Abstract;

namespace VastGIS.Api.Legend
{
    public delegate void LegendEventHandler<TArgs>(IMuteLegend legend, TArgs e)
        where TArgs : EventArgs;
}
