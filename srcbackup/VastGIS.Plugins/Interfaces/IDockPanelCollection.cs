using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Plugins.Interfaces
{
    public interface IDockPanelCollection: IEnumerable<IDockPanel>
    {
        void Lock();
        void Unlock();
        bool Locked { get; }
        IDockPanel Add(Control control, string key, PluginIdentity identity);
        void Remove(IDockPanel panel, PluginIdentity identity);
        void RemoveItemsForPlugin(PluginIdentity identity);
        IDockPanel Find(string key);
        IDockPanel Legend { get; }
        IDockPanel Preview { get; }
        IDockPanel Toolbox { get; }
    }
}
