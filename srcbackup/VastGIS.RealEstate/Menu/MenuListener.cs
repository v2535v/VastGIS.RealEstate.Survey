// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuListener.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015-2017
// </copyright>
// <summary>
//   The menu listener.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Services;
using VastGIS.Plugins.Services;
using VastGIS.UI.Menu;

namespace VastGIS.Plugins.RealEstate.Menu
{

    /// <summary>
    ///     The menu listener.
    /// </summary>
    public class MenuListener:MenuServiceBase
    {
        #region Constants

        #endregion

        #region Fields
        private readonly RealEstateEditor _plugin;
    
        #endregion

        #region Constructors and Destructors

       
        public MenuListener(IAppContext context, RealEstateEditor plugin) : base(context, plugin.Identity)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }
            
            _plugin = plugin;

            // Create event handlers:
            plugin.ItemClicked += OnItemClicked;
        }

        #endregion

        #region Methods
      
        private void OnItemClicked(object sender, MenuItemEventArgs e)
        {
            foreach (ICommand command in _plugin.Commands)
            {
                if (command.Key == e.ItemKey)
                {
                    command.OnClick();
                    return;
                }
            }
    
        }

        #endregion
    }
}