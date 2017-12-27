using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdOpenProject : BaseCommand
    {
        private IAppContext _context;
        public CmdOpenProject(IAppContext context)
        {
            base._text = "打开项目";
            base._key = MenuKeys.OpenProject;
            base._icon = Resources.icon_folder;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExFile";
            _context = context;
        }

        public override void OnClick()
        {
            IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            projectService.Open();
        }
    }
}