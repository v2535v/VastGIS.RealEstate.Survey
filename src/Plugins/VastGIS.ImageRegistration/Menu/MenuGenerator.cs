using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.ImageRegistration.Properties;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Menu;

namespace VastGIS.Plugins.ImageRegistration.Menu
{
    internal class MenuGenerator
    {
        private readonly IAppContext _context;
        private readonly ImageRegistrationPlugin _plugin;

        public MenuGenerator(IAppContext context, ImageRegistrationPlugin plugin)
        {
            _context = context;
            _plugin = plugin;
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");

            InitMenu(context);
        }

        private void InitMenu(IAppContext context)
        {
            var items = context.Menu.ToolsMenu.SubItems;

            items.AddButton("Register Image", MenuKeys.RegisterImage, Resources.img_georectify24,  _plugin.Identity).BeginGroup = true;

            context.Menu.ToolsMenu.Update();
        }
    }
}
