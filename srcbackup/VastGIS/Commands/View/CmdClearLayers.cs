using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdClearLayers : BaseCommand
    {
        private IAppContext _context;
        public CmdClearLayers(IAppContext context)
        {
            base._text = "ɾ������ͼ��";
            base._key = MenuKeys.ClearLayers;
            base._icon = Resources.icon_layer_clear;
            _context = context;
        }

        public override void OnClick()
        {
            if (MessageService.Current.Ask("��ȷ���Ƴ�����ͼ����?"))
            {
                _context.Legend.Layers.Clear();
            }
        }
    }
}