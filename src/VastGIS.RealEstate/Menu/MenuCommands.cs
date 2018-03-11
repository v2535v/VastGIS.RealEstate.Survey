// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuCommands.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The menu commands.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace VastGIS.Plugins.RealEstate.Menu
{
    using System.Collections.Generic;
    using VastGIS.Commands.File;
    using VastGIS.Plugins.Concrete;
    using VastGIS.Plugins.Interfaces;
    using VastGIS.Plugins.RealEstate.Commands;

    /// <summary>
    /// The menu commands.
    /// </summary>
    public class MenuCommands : CommandProviderBase
    {
        #region 变量

        /// <summary>
        /// Defines the _commands
        /// </summary>
        private List<ICommand> _commands;

        /// <summary>
        /// Defines the _identity
        /// </summary>
        private PluginIdentity _identity;

        /// <summary>
        /// Defines the _plugin
        /// </summary>
        private RealEstateEditor _plugin;

        #endregion

        #region 创建

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuCommands"/> class.
        /// </summary>
        /// <param name="identity">
        /// The identity.
        /// </param>
        public MenuCommands(IAppContext context, RealEstateEditor plugin)
            : base(context, plugin.Identity)
        {

            _identity = plugin.Identity;
            _plugin = plugin;
        }

        #endregion

        #region 方法

        /// <summary>
        /// The commands of the toolbar buttons.
        /// </summary>
        /// <returns>
        /// The <see cref="MenuCommand"/> as an IEnumerable
        /// </returns>
        public override IEnumerable<ICommand> GetCommands()
        {

            _commands = new List<ICommand>();
            ICommand command = new CmdTestOgrChinese(_context);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new CmdCreateREProject(_context);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new CmdImportDXF(_context,_plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new CmdOpenTable(_context,_plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            //command = new CmdSplitCAD(_context);
            //command.PluginIdentity = _identity;
            //_commands.Add(command);

            //command = new CmdAssignCADText(_context);
            //command.PluginIdentity = _identity;
            //_commands.Add(command);



            command = new ToolNewFeature(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolEditGeometry(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolCopyFeature(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolDeleteFeature(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolEditFeature(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolUnionFeature(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolSplitPolygon(_context,_plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolWYGZFeature(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolDistanceToDistanceConstructor(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolSelectFeatureByPoint(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolCreateJZDByPolygon(_context);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolCreateJZDByZD(_context,_plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolAssignZRZH(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new ToolAssignPhoto(_context, _plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new CmdResetLayers(_context);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new CmdLayerManagement(_context);
            command.PluginIdentity = _identity;
            _commands.Add(command);

            command = new CmdZoomToDbMax(_context,_plugin);
            command.PluginIdentity = _identity;
            _commands.Add(command);



            return _commands;
        }

        #endregion
    }
}
