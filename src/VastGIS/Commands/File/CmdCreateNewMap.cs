using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdCreateNewMap : BaseCommand
    {
        private IAppContext _context;
        public CmdCreateNewMap(IAppContext context)
        {
            base._text = "新建地图";
            base._key = MenuKeys.NewMap;
            base._icon = Resources.icon_new_map;
            _context = context;
        }

        public override void OnClick()
        {
            IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            projectService.TryClose();
        }
    }
}