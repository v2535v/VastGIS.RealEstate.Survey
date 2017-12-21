using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.ImageRegistration.Views;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Menu;

namespace VastGIS.Plugins.ImageRegistration.Menu
{
    internal class MenuListener : MenuServiceBase
    {
        private readonly ImageRegistrationPlugin _plugin;

        public MenuListener(IAppContext context, ImageRegistrationPlugin plugin) :
            base(context, plugin.Identity)
        {
            if (plugin == null) throw new ArgumentNullException("plugin");
            _plugin = plugin;

            plugin.ItemClicked += OnItemClicked;
            plugin.ViewUpdating += ViewUpdating;
        }

        private void ViewUpdating(object sender, EventArgs e)
        {
            var item = _context.Toolbars.FindItem(MenuKeys.RegisterImage, _plugin.Identity);
            if (item != null)
            {
                item.Checked = !_context.Map.IsEmpty;
            }
        }

        private void OnItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.ItemKey)
            {
                case MenuKeys.RegisterImage:
                    var model = new ImageRegistrationModel();
                    _context.Container.Run<ImageRegistrationPresenter, ImageRegistrationModel>(model);
                    break;
            }
        }
    }
}
