using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.UI.Docking;
using Syncfusion.Windows.Forms.Tools;

namespace VastGIS.Plugins.TableEditor.Model
{
    internal class TablePanel: DockPanel, ITablePanel
    {
        internal TablePanel(DockingManager dockingManager, Control control, Control parent) : base(dockingManager, control, parent)
        {
        }


        public int LayerHandle
        {
            get
            {
                string name = Control.Name;

                int layerHandle;
                return Int32.TryParse(name, out layerHandle) ? layerHandle : -1;
            }
        }
    }
}
