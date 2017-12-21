using VastGIS.Attributes.Model;
using VastGIS.UI.Controls;

namespace VastGIS.Attributes.Controls
{
    public class FieldsGrid: StronglyTypedGrid<FieldWrapper>
    {
        public FieldsGrid()
        {
            Adapter.HotTracking = true;
            Adapter.ReadOnly = false;
            Adapter.AllowCurrentCell = false;
        }

        protected override void UpdateColumns()
        {
            Adapter.HideColumns();

            Adapter.ShowColumn(f => f.Selected);
            Adapter.ShowColumn(f => f.Name);

            UI.Helpers.GroupingGridHelper.AdjustColumnWidths(this);
        }
    }
}
