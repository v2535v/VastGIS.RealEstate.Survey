using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdSaveProject : BaseCommand
    {
        private IAppContext _context;
        public CmdSaveProject(IAppContext context)
        {
            base._text = "保存项目";
            base._key = MenuKeys.SaveProject;
            base._icon = Resources.icon_save;
            _context = context;
        }

        public override void OnClick()
        {
            IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            if (projectService.Save())
            {
                MessageService.Current.Info("项目已经成功保存为: " + projectService.Filename);
            }
        }
    }
}