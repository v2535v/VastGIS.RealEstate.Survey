using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Configuration.Plugins;
using VastGIS.UI.Controls;
using Syncfusion.Grouping;

namespace VastGIS.Configuration
{
    internal class PluginGrid: StronglyTypedGrid<PluginInfo>
    {
        public PluginGrid()
        {
            Adapter.HotTracking = false;
            Adapter.ShowSuperTooltips = true;
            Adapter.ReadOnly = false;
            Adapter.AllowCurrentCell = false;
            WrapWithPanel = false;
        }

        protected override void UpdateColumns()
        {
            // do nothing
        }
    }
}
