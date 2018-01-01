// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuCommands.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The menu commands.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using VastGIS.Commands.File;
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
        private List<ICommand> _commands;

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
            if (_commands == null)
            {
                _commands = new List<ICommand>();
                ICommand command = new CmdTestOgrChinese(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdCreateREProject(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdImportDXF(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdSplitCAD(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdAssignCADText(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

            }
            return _commands;
        }

        #endregion
    }
}