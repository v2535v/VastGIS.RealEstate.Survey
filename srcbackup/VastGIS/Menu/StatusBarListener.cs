using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Helpers;
using VastGIS.Plugins;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Projections.Helpers;
using VastGIS.Properties;
using VastGIS.Shared;
using VastGIS.UI.Helpers;
using VastGIS.Views;

namespace VastGIS.Menu
{
    public class StatusBarListener
    {
        private readonly IAppContext _context;

        public StatusBarListener(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            
            _context = context;

            InitStatusBar();

            var appContext = context as AppContext;
            if (appContext != null)
            {
                appContext.Broadcaster.StatusItemClicked += PluginManager_MenuItemClicked;
            }

            AddMapEventHandlers();
        }

        private void AddMapEventHandlers()
        {
            var map = _context.Map as IMap;
            if (map == null)
            {
                throw new InvalidCastException("Map must implement IMap interface");
            }

            map.ProjectionChanged += MapProjectionChanged;

            map.ExtentsChanged += map_ExtentsChanged;
        }
        
        private void InitStatusBar()
        {
            var bar = _context.StatusBar;

            var dropDown = bar.Items.AddSplitButton("Not defined", StatusBarKeys.ProjectionDropDown, Identity);
            dropDown.Icon = new MenuIcon(Resources.icon_crs_change);

            var items = dropDown.SubItems;
            items.AddButton("选择投影基准", StatusBarKeys.ChooseProjection, Identity);
            items.AddButton("投影参数", StatusBarKeys.ProjectionProperties, Identity);
            items.AddButton("设置", StatusBarKeys.ProjectionConfig, Identity).BeginGroup = true; ;

            dropDown.Update();

            bar.Items.AddLabel("地图单位: ", StatusBarKeys.MapUnits, Identity).BeginGroup = true;
            bar.Items.AddLabel("选择: ", StatusBarKeys.SelectedCount, Identity).BeginGroup = true;
            bar.Items.AddLabel("修改: ", StatusBarKeys.ModifiedCount, Identity).BeginGroup = true;

            bar.AlignNewItemsRight = true;

            bar.Items.AddLabel("", StatusBarKeys.MapScale, Identity);
            bar.Items.AddLabel("底图数据", StatusBarKeys.TileProvider, Identity).BeginGroup = true;
            
            var progressMsg = bar.Items.AddLabel("进度", StatusBarKeys.ProgressMsg, Identity);
            progressMsg.BeginGroup = true;
            progressMsg.Visible = false;

            bar.Items.AddProgressBar(StatusBarKeys.ProgressBar, Identity).Visible = false;

            bar.Update();
        }

        private void PluginManager_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
            var menuItem = sender as IMenuItem;
            if (menuItem == null)
            {
                throw new InvalidCastException("Invalid type of menu item. IMenuItem interface is expected");
            }

            switch (e.ItemKey)
            {
                case StatusBarKeys.MapScale:
                    _context.Container.Run<SetScalePresenter>();
                    break;
                case StatusBarKeys.ProjectionDropDown:
                    if (_context.Map.Projection.IsEmpty)
                    {
                        _context.ChangeProjection();
                    }
                    else
                    {
                        _context.ShowMapProjectionProperties();
                    }
                    break;
                case StatusBarKeys.ProjectionProperties:
                    _context.ShowMapProjectionProperties();
                    break;
                case StatusBarKeys.ChooseProjection:
                    _context.ChangeProjection();
                    break;
                case StatusBarKeys.ProjectionConfig:
                    var model = _context.Container.GetInstance<ConfigViewModel>();
                    model.UseSelectedPage = true;
                    model.SelectedPage = ConfigPageType.Projections;
                    _context.Container.Run<ConfigPresenter, ConfigViewModel>(model);
                    break;
                default:
                    // do nothing
                    break;
            }
        }

        private PluginIdentity Identity
        {
            get { return PluginIdentity.Default; }
        }

        protected IMenuItem FindItem(string itemKey)
        {
            return _context.StatusBar.FindItem(itemKey, Identity);
        }

        public void Update()
        {
            var bar = _context.StatusBar;

            UpdateSelectionMessage();

            var statusUnits = bar.FindItem(StatusBarKeys.MapUnits, Identity);
            statusUnits.Text = "单位: " + _context.Map.MapUnits.EnumToString().ToLower();

            UpdateTmsProvider();

            UpdateModifiedCount();
        }

        private void UpdateTmsProvider()
        {
            string msg = "基础底图: ";

            if (_context.Map.TileProvider == Api.Enums.TileProvider.ProviderCustom)
            {
                var tiles = _context.Map.Tiles;
                var provider = tiles.Providers.FirstOrDefault(p => p.Id == tiles.ProviderId);
                msg += provider != null ? provider.Name : "未定义";
            }
            else
            {
                msg += _context.Map.TileProvider.EnumToString();
            }

            var statusProvider = _context.StatusBar.FindItem(StatusBarKeys.TileProvider, Identity);
            statusProvider.Text = msg;
        }

        private void UpdateModifiedCount()
        {
            var status = _context.StatusBar.FindItem(StatusBarKeys.ModifiedCount, Identity);

            var layer = _context.Map.Layers.Current;
            if (layer != null && layer.IsVector && layer.FeatureSet.InteractiveEditing)
            {
                int featureCount = layer.FeatureSet.Features.Count(f => f.Modified);
                status.Text = string.Format("修改: {0} 要素", featureCount);
                status.Visible = true;
                return;
            }
            
            status.Visible = false;
        }

        private void UpdateSelectionMessage()
        {
            var statusSelected = _context.StatusBar.FindItem(StatusBarKeys.SelectedCount, Identity);

            if (_context.Map.Layers.Current == null)
            {
                statusSelected.Text = "没有选择图层";
            }
            else
            {
                var fs = _context.Map.SelectedFeatureSet;
                if (fs != null)
                {
                    statusSelected.Text = string.Format("选择: {0} / {1}", fs.NumSelected, fs.Features.Count);

                }
                else
                {
                    var img = _context.Map.SelectedImage;
                    if (img != null)
                    {
                        statusSelected.Text = "选择图层为栅格数据";
                    }
                }
            }
        }

        private void MapProjectionChanged(object sender, EventArgs e)
        {
            var item = _context.StatusBar.FindItem(StatusBarKeys.ProjectionDropDown, Identity);
            var p = _context.Map.Projection;
            item.Text = !p.IsEmpty ? p.Name : "未定义";
        }

        private void map_ExtentsChanged(object sender, EventArgs e)
        {
            var item = _context.StatusBar.FindItem(StatusBarKeys.MapScale, Identity);
            double scale = _context.Map.CurrentScale;
            string format = scale <= Int32.MaxValue ? "f0" : "e4";
            item.Text = string.Format("1:{0}", scale.ToString(format));
        }
    }
}
