// -------------------------------------------------------------------------------------------
// <copyright file="MenuCommands.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Printing.Properties;

namespace VastGIS.Plugins.Printing.Menu
{
    public class MenuCommands : CommandProviderBase
    {
        public MenuCommands(PluginIdentity identity)
            : base(identity)
        {
        }

        public override IEnumerable<ICommand> GetCommands()
        {
            return new List<MenuCommand>
                       {
                           new MenuCommand("Print", MenuKeys.Print, Resources.img_printer24),
                           new MenuCommand("Select Print Area", MenuKeys.SelectPrintArea, Resources.img_select_print_area24)
                       };
        }
    }
}