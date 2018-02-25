using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;
using VastGIS.Views;

namespace VastGIS.Commands.View
{
    public class CmdSetScale : BaseCommand
    {
        private IAppContext _context;
        public CmdSetScale(IAppContext context)
        {
            base._text = "…Ë÷√±»¿˝";
            base._key = MenuKeys.SetScale;
            base._icon = Resources.img_scale24;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Container.Run<SetScalePresenter>();
        }
    }
}