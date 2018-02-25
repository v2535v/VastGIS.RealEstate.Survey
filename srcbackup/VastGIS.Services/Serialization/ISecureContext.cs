using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;

namespace VastGIS.Services.Serialization
{
    public interface ISecureContext: IAppContext
    {
        IPluginManager PluginManager { get; }
        Control GetDockPanelObject(DefaultDockPanel panel);
        XmlProject VastProject { get; set; }
    }
}
