using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Projections.BL;
using VastGIS.UI.Controls;
using VastGIS.UI.Helpers;

namespace VastGIS.Projections.Controls
{
    internal class DialectGrid: StronglyTypedGrid<ProjectionDialect>
    {
        public DialectGrid()
        {
            Adapter.ReadOnly = true;
            Adapter.HotTracking = false;
            Adapter.AutoAdjustRowHeights = true;
        }

        protected override void UpdateColumns()
        {
            Adapter.HideColumns();

            Adapter.ShowColumn(d => d.Format);

            Adapter.ShowColumn(d => d.Definition);
        }
    }
}
