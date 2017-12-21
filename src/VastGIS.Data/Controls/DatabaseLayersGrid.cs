using System.Windows.Forms;
using VastGIS.Data.Model;
using VastGIS.UI.Controls;

namespace VastGIS.Data.Controls
{
    public class DatabaseLayersGrid: StronglyTypedGrid<VectorLayerGridAdapter>
    {
        public DatabaseLayersGrid()
        {
            KeyDown += DatabaseLayersGrid_KeyDown;

            Adapter.AllowCurrentCell = false;
        }

        void DatabaseLayersGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Adapter.ToggleProperty(info => info.Selected);
            }
        }

        protected override void UpdateColumns()
        {
            // do nothing
        }
    }
}
