using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Helpers;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Projections.Helpers;
using VastGIS.Properties;
using VastGIS.Shared;
using VastGIS.Views;

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


    public class CmdZoomPrev : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomPrev(IAppContext context)
        {
            base._text = "上一视图";
            base._key = MenuKeys.ZoomPrev;
            base._icon = Resources.img_zoom_prev24;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.ZoomToPrev();
        }
    }

    public class CmdZoomNext : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomNext(IAppContext context)
        {
            base._text = "下一视图";
            base._key = MenuKeys.ZoomNext;
            base._icon = Resources.img_zoom_next24;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.ZoomToNext();
        }
    }

    public class CmdZoomMax : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomMax(IAppContext context)
        {
            base._text = "全图";
            base._key = MenuKeys.ZoomMax;
            base._icon = Resources.icon_zoom_max_extents;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.ZoomToMaxExtents();
        }
    }


    public class CmdZoomToLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomToLayer(IAppContext context)
        {
            base._text = "全图";
            base._key = MenuKeys.ZoomToLayer;
            base._icon = Resources.icon_zoom_to_layer;
            _context = context;
        }

        public override void OnClick()
        {
            if(_context.Legend!=null)
            _context.Map.ZoomToLayer(_context.Legend.SelectedLayerHandle);
        }
    }

    public class CmdPan : BaseCommand
    {
        private IAppContext _context;
        public CmdPan(IAppContext context)
        {
            base._text = "平移";
            base._key = MenuKeys.Pan;
            base._icon = Resources.icon_pan;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.Pan;
        }
    }

    public class CmdZoomIn : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomIn(IAppContext context)
        {
            base._text = "放大";
            base._key = MenuKeys.ZoomIn;
            base._icon = Resources.icon_zoom_in;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.ZoomIn;
        }
    }

    public class CmdZoomOut : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomOut(IAppContext context)
        {
            base._text = "缩小";
            base._key = MenuKeys.ZoomOut;
            base._icon = Resources.icon_zoom_out;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.ZoomOut;
        }
    }

    public class CmdShowZoombar : BaseCommand
    {
        private IAppContext _context;
        public CmdShowZoombar(IAppContext context)
        {
            base._text = "显示放大工具条";
            base._key = MenuKeys.ShowZoombar;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            var config = AppConfig.Instance;
            config.ShowZoombar = !AppConfig.Instance.ShowZoombar;
            _context.Map.ApplyConfig(config);
            _context.Map.Redraw(RedrawType.SkipAllLayers);
        }
    }

    public class CmdShowScalebar : BaseCommand
    {
        private IAppContext _context;
        public CmdShowScalebar(IAppContext context)
        {
            base._text = "显示比例尺";
            base._key = MenuKeys.ShowScalebar;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            var config = AppConfig.Instance;
            AppConfig.Instance.ShowScalebar = !AppConfig.Instance.ShowScalebar;
            _context.Map.ApplyConfig(config);
            _context.Map.Redraw(RedrawType.SkipAllLayers);
        }
    }


    public class CmdShowCoordinates : BaseCommand
    {
        private IAppContext _context;
        public CmdShowCoordinates(IAppContext context)
        {
            base._text = "显示坐标";
            base._key = MenuKeys.ShowCoordinates;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            var config = AppConfig.Instance;
            AppConfig.Instance.ShowCoordinates = !AppConfig.Instance.ShowCoordinates;
            _context.Map.ApplyConfig(config);
            _context.Map.Redraw(RedrawType.SkipAllLayers);
        }
    }

    public class CmdShowRedrawTime : BaseCommand
    {
        private IAppContext _context;
        public CmdShowRedrawTime(IAppContext context)
        {
            base._text = "显示绘制时间";
            base._key = MenuKeys.ShowRedrawTime;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            var config = AppConfig.Instance;
            AppConfig.Instance.ShowRedrawTime = !AppConfig.Instance.ShowRedrawTime;
            _context.Map.ApplyConfig(config);
            _context.Map.Redraw(RedrawType.SkipAllLayers);
        }
    }

    public class CmdSetScale : BaseCommand
    {
        private IAppContext _context;
        public CmdSetScale(IAppContext context)
        {
            base._text = "设置比例";
            base._key = MenuKeys.SetScale;
            base._icon = Resources.img_scale24;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Container.Run<SetScalePresenter>();
        }
    }

    public class CmdSetProjection : BaseCommand
    {
        private IAppContext _context;
        public CmdSetProjection(IAppContext context)
        {
            base._text = "底图投影";
            base._key = MenuKeys.SetProjection;
            base._icon = Resources.icon_crs_change;
            _context = context;
        }

        public override void OnClick()
        {
            if (_context.Map.Projection.IsEmpty)
            {
                _context.ChangeProjection();
            }
            else
            {
                _context.ShowMapProjectionProperties();
            }
        }
    }

    public class CmdFindLocation : BaseCommand
    {
        private IAppContext _context;
        public CmdFindLocation(IAppContext context)
        {
            base._text = "查找";
            base._key = MenuKeys.FindLocation;
            base._icon = Resources.icon_search;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Container.Run<GeoLocationPresenter>();
        }
    }


    public class CmdMeasureDistance : BaseCommand
    {
        private IAppContext _context;
        public CmdMeasureDistance(IAppContext context)
        {
            base._text = "距离量测";
            base._key = MenuKeys.MeasureDistance;
            base._icon = Resources.icon_measure_distance;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.Measuring.Type = MeasuringType.Distance;
            _context.Map.MapCursor = MapCursor.Measure;
        }
    }

    public class CmdMeasureArea : BaseCommand
    {
        private IAppContext _context;
        public CmdMeasureArea(IAppContext context)
        {
            base._text = "面积量测";
            base._key = MenuKeys.MeasureArea;
            base._icon = Resources.icon_measure_area;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.Measuring.Type = MeasuringType.Area;
            _context.Map.MapCursor = MapCursor.Measure;
        }
    }

    public class CmdSelectByRectangle : BaseCommand
    {
        private IAppContext _context;
        public CmdSelectByRectangle(IAppContext context)
        {
            base._text = "矩形选择";
            base._key = MenuKeys.SelectByRectangle;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.Selection;
        }
    }

    public class CmdSelectByPolygon : BaseCommand
    {
        private IAppContext _context;
        public CmdSelectByPolygon(IAppContext context)
        {
            base._text = "多边形选择";
            base._key = MenuKeys.SelectByPolygon;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.SelectByPolygon;
        }
    }

    public class CmdAttributesTool : BaseCommand
    {
        private IAppContext _context;
        public CmdAttributesTool(IAppContext context)
        {
            base._text = "属性";
            base._key = MenuKeys.AttributesTool;
            base._icon = Resources.icon_identify;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.Identify;
        }
    }

    public class CmdZoomToSelected : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomToSelected(IAppContext context)
        {
            base._text = "放大到选择集";
            base._key = MenuKeys.ZoomToSelected;
            base._icon = Resources.icon_zoom_to_selection;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.ZoomToSelected();
        }
    }

    public class CmdClearSelection : BaseCommand
    {
        private IAppContext _context;
        public CmdClearSelection(IAppContext context)
        {
            base._text = "清除选择集";
            base._key = MenuKeys.ClearSelection;
            base._icon = Resources.icon_clear_selection;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.ClearSelection();
        }
    }

    public class CmdLayerClearSelection : BaseCommand
    {
        private IAppContext _context;
        public CmdLayerClearSelection(IAppContext context)
        {
            base._text = "清除图层选择集";
            base._key = MenuKeys.LayerClearSelection;
            base._icon = Resources.icon_clear_selection;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.ClearSelection();
        }
    }

    public class CmdClearLayers : BaseCommand
    {
        private IAppContext _context;
        public CmdClearLayers(IAppContext context)
        {
            base._text = "删除所有图层";
            base._key = MenuKeys.ClearLayers;
            base._icon = Resources.icon_layer_clear;
            _context = context;
        }

        public override void OnClick()
        {
            if (MessageService.Current.Ask("你确认移除所有图层吗?"))
            {
                _context.Legend.Layers.Clear();
            }
        }
    }
}
