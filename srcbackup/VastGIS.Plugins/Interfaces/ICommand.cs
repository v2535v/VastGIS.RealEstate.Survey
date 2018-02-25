using System.Drawing;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Plugins.Interfaces
{
    public interface ICommand
    {
        string Description { get; }
        string HeaderName { get; }
        Bitmap Icon { get; }
        string Key { get; }
        PluginIdentity PluginIdentity { get; set; }
        Keys ShortcutKeys { get; set; }
        string Text { get; }
        string ToolStripExName { get; }

        string Message { get;set; }
        string Tooltip { get; set; }

        void OnClick();

        void OnCreate(object hook);

        bool IsEnabled { get; }
        bool IsChecked { get; set; }
    }
}