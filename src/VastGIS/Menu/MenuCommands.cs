using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Commands.File;
using VastGIS.Commands.View;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Menu
{
    /// <summary>
    /// Holds list of commands for the core app. 
    /// </summary>
    internal class MenuCommands : CommandProviderBase
    {
        private List<ICommand> _commands;
       
        private PluginIdentity _identity;
        public MenuCommands(IAppContext context,PluginIdentity identity)
            : base(context,identity)
        {
            _context = context;
            _identity = identity;
        }

        protected override void AssignShortcutKeys()
        {
            Commands[MenuKeys.FindLocation].ShortcutKeys = Keys.Control | Keys.F;

            Commands[MenuKeys.NewMap].ShortcutKeys = Keys.Control | Keys.N;

            Commands[MenuKeys.SaveProject].ShortcutKeys = Keys.Control | Keys.S;

            Commands[MenuKeys.OpenProject].ShortcutKeys = Keys.Control | Keys.O;

            Commands[MenuKeys.AddLayer].ShortcutKeys = Keys.Control | Keys.L;

            Commands[MenuKeys.Settings].ShortcutKeys = Keys.Shift | Keys.Alt | Keys.S;

            Commands[MenuKeys.SetScale].ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;

            Commands[MenuKeys.ShowRepository].ShortcutKeys = Keys.Control | Keys.R;

            Commands[MenuKeys.ShowToolbox].ShortcutKeys = Keys.Control | Keys.T;
        }

        public override IEnumerable<ICommand> GetCommands()
        {
            if (_commands == null)
            {
                _commands=new List<ICommand>();
                ICommand command=new CmdCreateNewMap(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                //command = new CmdCreateNewProject(_context);
                //command.PluginIdentity = _identity;
                //_commands.Add(command);

                //command = new CmdImportDXF(_context);
                //command.PluginIdentity = _identity;
                //_commands.Add(command);

                command = new CmdAddLayer(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdAddVectorLayer(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdAddRasterLayer(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdAddWmsLayer(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdAddDatabaseLayer(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdOpenProject(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdSaveProject(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdSaveProjectAs(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdQuit(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdRemoveLayer(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdSettings(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomToBaseLayer(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomIn(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomOut(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomPrev(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomNext(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomMax(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomToLayer(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdPan(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdShowZoombar(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdShowScalebar(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdShowCoordinates(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdShowRedrawTime(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdSetScale(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdSetProjection(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdFindLocation(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                //command = new CmdMeasureDistance(_context);
                //command.PluginIdentity = _identity;
                //_commands.Add(command);

                //command = new CmdMeasureArea(_context);
                //command.PluginIdentity = _identity;
                //_commands.Add(command);

                command = new CmdSelectByRectangle(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdSelectByPolygon(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdAttributesTool(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomToSelected(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdClearSelection(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdLayerClearSelection(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdClearLayers(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdShowRepository(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdShowToolbox(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdShowLegend(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomInBox(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);

                command = new CmdZoomCenter(_context);
                command.PluginIdentity = _identity;
                _commands.Add(command);
            }
            return _commands;
        }
    }
}
