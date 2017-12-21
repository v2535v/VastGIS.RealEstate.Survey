using System;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Events;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Events;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;

namespace VastGIS.Plugins.RealEstate
{
    public class MapListener
    {
        private readonly IAppContext _context;
        //private readonly ContextMenuPresenter _contextMenuPresenter;
        private readonly IBroadcasterService _broadcaster;

        public MapListener(IAppContext context, RealEstateEditor plugin,
                           IBroadcasterService broadcaster)
        {
            if (context == null) throw new ArgumentNullException("context");
           
            if (broadcaster == null) throw new ArgumentNullException("broadcaster");

            _context = context;
         
            _broadcaster = broadcaster;

            plugin.ChooseLayer += OnChooseLayer;
            plugin.MouseUp += OnMapMouseUp;
            plugin.MouseDown += OnMouseDown;
            plugin.BeforeDeleteShape += OnBeforeDeleteShape;
            plugin.AfterShapeEdit += OnAfterShapeEdit;
            plugin.ShapeValidationFailed += OnShapeValidationFailed;
        }

        private void OnMouseDown(IMuteMap map, MouseEventArgs e)
        {
          // _broadcaster.BroadcastEvent(p=>p.MouseDown_,map,e);
        }

        private void OnBeforeDeleteShape(IMuteMap map, BeforeDeleteShapeEventArgs e)
        {
            if (e.Target == DeleteTarget.Vertex && Control.ModifierKeys.HasFlag(Keys.Control))
            {
                // don't bother user with prompt
                return;
            }

            string s = string.Empty;
            switch (e.Target)
            {
                case DeleteTarget.Shape: s = "shape";
                    break;
                case DeleteTarget.Part: s = "part";
                    break;
                case DeleteTarget.Vertex: s = "vertex";
                    break;
            }

            s = string.Format("Do you want to delete {0}?", s);
            e.Cancel = !MessageService.Current.Ask(s);
        }

        private void OnMapMouseUp(IMuteMap map, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            var parent = map as Control;
            if (parent == null)
            {
                return;
            }

            switch (_context.Map.MapCursor)
            {
                case MapCursor.RotateShapes:
                case MapCursor.MoveShapes:
                case MapCursor.Selection:
                {
                    //var menu = _contextMenuPresenter.SelectionMenu;
                    //menu.Show(parent, e.X, e.Y);
                    break;
                }
                case MapCursor.EditShape:
                case MapCursor.AddShape:
                case MapCursor.ClipByPolygon:
                case MapCursor.EraseByPolygon:
                case MapCursor.SplitByPolygon:
                case MapCursor.SplitByPolyline:
                case MapCursor.SelectByPolygon:
                {
                    //var menu = _contextMenuPresenter.VertexMenu;
                    //menu.Show(parent, e.X, e.Y);
                    break;
                }
            }
        }

        private void OnChooseLayer(IMuteMap map, ChooseLayerEventArgs e)
        {
            var layer = map.Layers.Current;
            if (layer != null)
            {
                e.LayerHandle = layer.Handle;
            }
        }

        private void OnAfterShapeEdit(IMuteMap map, AfterShapeEditEventArgs e)
        {
            if (e.Operation == UndoOperation.AddShape && AppConfig.Instance.ShapeEditorShowAttributeDialog)
            {
                var fs = _context.Map.GetFeatureSet(e.LayerHandle);
                if (fs != null)
                {
                    var layer = _context.Layers.ItemByHandle(e.LayerHandle);
                    //var model = new AttributeViewModel(layer, e.ShapeIndex);

                    //if (_context.Container.Run<AttributePresenter, AttributeViewModel>(model))
                    //{
                        
                    //}
                }
            }

            if (e.Operation == UndoOperation.AddShape)
            {
                var fs = _context.Map.GetFeatureSet(e.LayerHandle);
                _broadcaster.BroadcastEvent(p => p.LayerFeatureCountChanged_, fs, new LayerEventArgs(e.LayerHandle));
            }

            // to show the number of modified features
            _context.View.Update();
        }

        private void OnShapeValidationFailed(IMuteMap map, ShapeValidationFailedEventArgs e)
        {
            MessageService.Current.Warn("Validation failed: " + e.ErrorMessage);
        }
    }
}
