using System;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Events
{
    public class MenuEventArgs: EventArgs
    {
        public MenuEventArgs(IMenuItem menuItem)
        {
            MenuItem = menuItem;
        }

        public IMenuItem MenuItem { get; private set; }
    }
}
