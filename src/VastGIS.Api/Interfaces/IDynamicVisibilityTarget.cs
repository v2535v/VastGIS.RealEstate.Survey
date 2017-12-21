using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Api.Interfaces
{
    public interface IDynamicVisibilityTarget
    {
        bool DynamicVisibility { get; set; }
        int MinVisibleZoom { get; set; }
        int MaxVisibleZoom { get; set; }
        double MinVisibleScale { get; set; }
        double MaxVisibleScale { get; set; }
    }
}
