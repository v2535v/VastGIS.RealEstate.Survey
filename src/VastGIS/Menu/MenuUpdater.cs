using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Menu;

namespace VastGIS.Menu
{
    internal class MenuUpdater: MenuServiceBase
    {
        private readonly IMuteMap _map;
        private readonly IMuteLegend _legend;
      

        public MenuUpdater(IAppContext context, PluginIdentity identity) 
            : base(context, identity)
        {
            
            _map = context.Map;
            if (_context.ViewType == MainViewType.Normal)
            {
                _legend = context.Legend;
            }

        }

        public void Update(bool rendered)
        {
            if (_context.ViewType == MainViewType.Normal)
            {
                UpdateToolbars(rendered);
                UpdateMenu();
            }
            else
            {
               // UpdateMenu();
            }

            
        }

        private void UpdateMenu()
        {

            if (_context.ViewType == MainViewType.Normal)
            {
                var layer=_legend.Layers.Current;
                FindMenuItem(MenuKeys.RemoveLayer).Enabled = layer != null;
                FindMenuItem(MenuKeys.LayerClearSelection).Enabled = layer != null && layer.IsVector;
                FindMenuItem(MenuKeys.ClearLayers).Enabled = _map.Layers.Any();
                FindMenuItem(MenuKeys.ClearSelection).Enabled = _map.Layers.Any();
                FindMenuItem(MenuKeys.ZoomToLayer).Enabled = _map.Layers.Any();
                FindMenuItem(MenuKeys.ZoomToBaseLayer).Enabled = !_map.Projection.IsEmpty && _map.Tiles.Visible;
                var config = AppConfig.Instance;
                FindMenuItem(MenuKeys.ShowCoordinates).Checked = config.ShowCoordinates;
                FindMenuItem(MenuKeys.ShowScalebar).Checked = config.ShowScalebar;
                FindMenuItem(MenuKeys.ShowZoombar).Checked = config.ShowZoombar;
                FindMenuItem(MenuKeys.ShowRedrawTime).Checked = config.ShowRedrawTime;
                FindMenuItem(MenuKeys.ZoomNext).Enabled = _map.ExtentHistoryUndoCount > 0;
                FindMenuItem(MenuKeys.ZoomPrev).Enabled = _map.ExtentHistoryRedoCount > 0;
            }
            else
            {
                ToolStripItem oneItem;
                //oneItem=FindToolStripItem(MenuKeys.RemoveLayer);
                //if(oneItem != null) oneItem.Enabled = false;
                //oneItem = FindToolStripItem(MenuKeys.LayerClearSelection);
                //if (oneItem != null) oneItem.Enabled = true;
                //oneItem = FindToolStripItem(MenuKeys.ClearLayers);
                //if (oneItem != null) oneItem.Enabled = _map.Layers.Any();
                //oneItem = FindToolStripItem(MenuKeys.ClearSelection);
                //if (oneItem != null) oneItem.Enabled = _map.Layers.Any();
                //oneItem = FindToolStripItem(MenuKeys.ZoomToLayer);
                //if (oneItem != null) oneItem.Enabled = _map.Layers.Any();
                //oneItem = FindToolStripItem(MenuKeys.ZoomToBaseLayer);
                //if (oneItem != null) oneItem.Enabled = !_map.Projection.IsEmpty && _map.Tiles.Visible;

                //var config = AppConfig.Instance;
                //oneItem = FindToolStripItem(MenuKeys.ShowCoordinates);
                //if (oneItem != null) ((ToolStripButton)oneItem).Checked = config.ShowCoordinates;
                //oneItem = FindToolStripItem(MenuKeys.ShowScalebar);
                //if (oneItem != null) ((ToolStripButton)oneItem).Checked = config.ShowScalebar;
                //oneItem = FindToolStripItem(MenuKeys.ShowZoombar);
                //if (oneItem != null) ((ToolStripButton)oneItem).Checked = config.ShowZoombar;
                //oneItem = FindToolStripItem(MenuKeys.ShowRedrawTime);
                //if (oneItem != null) ((ToolStripButton)oneItem).Checked = config.ShowRedrawTime;
                //oneItem = FindToolStripItem(MenuKeys.ZoomNext);
                //if (oneItem != null) oneItem.Enabled = _map.ExtentHistoryUndoCount > 0;
                //oneItem = FindToolStripItem(MenuKeys.ZoomPrev);
                //if (oneItem != null) oneItem.Enabled = _map.ExtentHistoryRedoCount > 0;
            }
           
        }

        private void UpdateToolbars(bool rendered)
        {
            // mapControl plays the role of the model here
            FindToolbarItem(MenuKeys.ZoomIn).Checked = _map.MapCursor == MapCursor.ZoomIn;
            FindToolbarItem(MenuKeys.ZoomOut).Checked = _map.MapCursor == MapCursor.ZoomOut;
            FindToolbarItem(MenuKeys.Pan).Checked = _map.MapCursor == MapCursor.Pan;

            FindToolbarItem(MenuKeys.ZoomPrev).Enabled = _map.ExtentHistoryUndoCount > 0;
            FindToolbarItem(MenuKeys.ZoomNext).Enabled = _map.ExtentHistoryRedoCount > 0;

            bool selection = _map.MapCursor == MapCursor.Selection && !_map.IsCustomSelectionMode;
            FindToolbarItem(MenuKeys.SelectByRectangle).Checked = selection;
            FindToolbarItem(MenuKeys.SelectByPolygon).Checked = _map.MapCursor == MapCursor.SelectByPolygon;

            bool selectionCursor = selection || _map.MapCursor == MapCursor.SelectByPolygon;
            FindToolbarItem(MenuKeys.SelectDropDown).Checked = selectionCursor;

            bool distance = _map.Measuring.Type == MeasuringType.Distance;
            FindToolbarItem(MenuKeys.MeasureArea).Checked = _map.MapCursor == MapCursor.Measure && !distance;
            FindToolbarItem(MenuKeys.MeasureDistance).Checked = _map.MapCursor == MapCursor.Measure && distance;

            FindToolbarItem(MenuKeys.FindLocation).Enabled = !_map.Projection.IsEmpty;

            bool hasFeatureSet = false;

            bool hasLayer = _context.Legend.SelectedLayerHandle != -1;
            if (hasLayer)
            {
                var fs = _context.Map.GetFeatureSet(_context.Legend.SelectedLayerHandle);
                if (fs != null)
                {
                    FindToolbarItem(MenuKeys.ClearSelection).Enabled = fs.NumSelected > 0;
                    FindToolbarItem(MenuKeys.ZoomToSelected).Enabled = fs.NumSelected > 0;
                    hasFeatureSet = true;
                }
            }

            if (!hasFeatureSet)
            {
                FindToolbarItem(MenuKeys.ClearSelection).Enabled = false;
                FindToolbarItem(MenuKeys.ZoomToSelected).Enabled = false;
            }

            FindToolbarItem(MenuKeys.RemoveLayer).Enabled = hasLayer;

            //toolSearch.Enabled = true;
            //toolSearch.Text = "Find location";
            //if (App.Map.Count > 0 && !App.Map.Measuring.IsUsingEllipsoid)
            //{
            //    toolSearch.Enabled = false;
            //    toolSearch.Text = "Unsupported projection. Search isn't allowed.";
            //}
        }
    }
}
