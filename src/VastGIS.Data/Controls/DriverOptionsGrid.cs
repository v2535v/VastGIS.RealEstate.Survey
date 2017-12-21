using VastGIS.Api.Concrete;
using VastGIS.UI.Controls;

namespace VastGIS.Data.Controls
{
    public class DriverOptionsGrid: StronglyTypedGrid<DriverOption>
    {
        public DriverOptionsGrid()
        {
            Adapter.ReadOnly = true;
            Adapter.HotTracking = true;
            WrapWithPanel = false;

            TableControlResizingColumns += DriverMetadataGrid_TableControlResizingColumns;
        }

        void DriverMetadataGrid_TableControlResizingColumns(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlResizingColumnsEventArgs e)
        {
            UI.Helpers.GroupingGridHelper.AdjustRowHeights(this);
        }

        protected override void UpdateColumns()
        {
            // do nothing
        }
    }
}
