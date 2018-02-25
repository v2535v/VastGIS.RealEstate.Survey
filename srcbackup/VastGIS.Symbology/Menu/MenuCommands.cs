using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Symbology.Properties;

namespace VastGIS.Plugins.Symbology.Menu
{
    public class MenuCommands : CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity) : base(identity)
        {
        }

        protected override void AssignShortcutKeys()
        {
            Commands[MenuKeys.QueryBuilder].ShortcutKeys = Keys.Control | Keys.Q;
        }

        public override IEnumerable<ICommand> GetCommands()
        {
            return new List<MenuCommand>()
            {
                new MenuCommand("Query Builder", MenuKeys.QueryBuilder, Resources.img_database_search32),
                new MenuCommand("Categories", MenuKeys.Categories, Resources.img_categories32),
                new MenuCommand("Label Mover", MenuKeys.LabelMover, Resources.label_mover),
                new MenuCommand("Labels", MenuKeys.Labels, Resources.img_label24),
                new MenuCommand("Charts", MenuKeys.Charts, Resources.img_chart24),
                new MenuCommand("Layer Properties", MenuKeys.LayerProperties, Resources.img_properties24),
            };
        }
    }
}
