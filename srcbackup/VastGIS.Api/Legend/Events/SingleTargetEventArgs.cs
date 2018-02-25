using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Api.Legend.Events
{
    public class SingleTargetEventArgs: EventArgs
    {
        public bool Handled { get; set; }
    }
}
