using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdSaveProjectAs : BaseCommand
    {
        private IAppContext _context;
        public CmdSaveProjectAs(IAppContext context)
        {
            base._text = "��Ŀ���Ϊ";
            base._key = MenuKeys.SaveProjectAs;
            base._icon = Resources.icon_save_as;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExFile";
            _context = context;
        }

        public override void OnClick()
        {
            IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            if (projectService.SaveAs())
            {
                MessageService.Current.Info("��Ŀ�Ѿ��ɹ�����Ϊ: " + projectService.Filename);
            }
        }
    }
}