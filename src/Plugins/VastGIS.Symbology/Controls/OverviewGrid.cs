using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.UI.Controls;

namespace VastGIS.Plugins.Symbology.Controls
{
    public class OverviewGrid: StronglyTypedGrid<OverviewScale>
    {
        public OverviewGrid()
        {
            Adapter.ReadOnly = false;
            Adapter.AllowCurrentCell = false;
            Adapter.HotTracking = true;
        }

        protected override void UpdateColumns()
        {
            // do nothing
        }
    }
}
