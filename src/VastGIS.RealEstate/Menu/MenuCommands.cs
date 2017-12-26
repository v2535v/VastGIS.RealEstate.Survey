// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuCommands.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The menu commands.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Commands;

namespace VastGIS.Plugins.RealEstate.Menu
{
    #region

    #endregion

    /// <summary>
    /// The menu commands.
    /// </summary>
    public class MenuCommands : CommandProviderBase
    {
       
        private PluginIdentity _identity;
        private RealEstateEditor _plugin;
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuCommands"/> class.
        /// </summary>
        /// <param name="identity">
        /// The identity.
        /// </param>
        public MenuCommands(IAppContext context, RealEstateEditor plugin)
            : base(context,plugin.Identity)
        {
           
            _identity = plugin.Identity;
            _plugin = plugin;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The commands of the toolbar buttons.
        /// </summary>
        /// <returns>
        /// The <see cref="MenuCommand"/> as an IEnumerable
        /// </returns>
        public override IEnumerable<ICommand> GetCommands()
        {
            // Create a list of MenuCommands for every toolbar button created in MenuGenerator:
            List<ICommand> commands=new List<ICommand>();
            ICommand command = new CmdOpenRealEstateDatabase(_context);
            command.PluginIdentity = _identity;
            commands.Add(command);
            command=new CmdNewJZD(_context,_plugin);
            command.PluginIdentity = _identity;
            commands.Add(command);
            return commands;

        }

        #endregion
    }
}