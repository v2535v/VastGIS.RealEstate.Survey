using System.Drawing;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Plugins.Interfaces
{
    public interface IStatusItemCollection: IMenuItemCollection
    {
        IMenuItem AddProgressBar(string key, PluginIdentity identity);
        IDropDownMenuItem AddSplitButton(string text, string key, PluginIdentity identity);
    }
}
