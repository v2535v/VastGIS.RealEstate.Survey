using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;
using VastGIS.Shared;

namespace VastGIS.Commands.View
{
    public class CmdZoomToBaseLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomToBaseLayer(IAppContext context)
        {
            base._text = "放大到底图图层";
            base._key = MenuKeys.ZoomToBaseLayer;
            base._icon = Resources.icon_zoom_to_layer;
            _context = context;
        }

        public override void OnClick()
        {
            if (_context.Map.Projection.IsEmpty)
            {
                MessageService.Current.Info("地图投影未设置，无法操作.");
            }
            else
            {
                var tiles = _context.Map.Tiles;
                var provider = _context.Map.Tiles.Providers.FirstOrDefault(p => p.Id == tiles.ProviderId);

                if (!tiles.Visible || provider == null)
                {
                    MessageService.Current.Info("获取底图范围失败.");
                }
                else
                {
                    if (!_context.Map.SetGeographicExtents(provider.GeographicBounds))
                    {
                        Logger.Current.Warn("设置底图范围失败.");
                    }
                }
            }
        }
    }
}
