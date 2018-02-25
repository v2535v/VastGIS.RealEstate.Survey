﻿using System;
using System.Windows.Forms;
using VastGIS.Api;
using VastGIS.Api.Enums;
using VastGIS.Api.Events;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Map;
using VastGIS.Menu;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;

namespace VastGIS.Listeners
{
    /// <summary>
    /// Allows to handle map events by the core application and broadcast them to plugins after that.
    /// </summary>
    internal class MapListener
    {
        private readonly IBroadcasterService _broadcaster;
        private readonly ILayerService _layerService;
        private readonly ContextMenuPresenter _contextMenuPresenter;
        private readonly IProjectService _projectService;
        private readonly IMap _map;
        private readonly IAppContext _context;
        
        public MapListener(IAppContext context, IBroadcasterService broadcaster, ILayerService layerService,
                ContextMenuPresenter contextMenuPresenter, IProjectService projectService)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (broadcaster == null) throw new ArgumentNullException("broadcaster");
            if (layerService == null) throw new ArgumentNullException("layerService");
            if (contextMenuPresenter == null) throw new ArgumentNullException("contextMenuPresenter");
            if (projectService == null) throw new ArgumentNullException("projectService");

            _context = context;
            _broadcaster = broadcaster;
            _layerService = layerService;
            _contextMenuPresenter = contextMenuPresenter;
            _projectService = projectService;

            _map = _context.Map as IMap;
            if (_map == null)
            {
                throw new ApplicationException("Invalid map state.");
            }

            RegisterEvents();
        }

        private void RegisterEvents()
        {
            _map.AfterShapeEdit += MapAfterShapeEdit;
            _map.BeforeDeleteShape += MapBeforeDeleteShape;
            _map.BeforeShapeEdit += MapBeforeShapeEdit;
            _map.ChooseLayer += MapChooseLayer;
            _map.ExtentsChanged += MapExtentsChanged;
            _map.FileDropped += MapFileDropped;
            _map.HistoryChanged += MapHistoryChanged;
            _map.MapCursorChanged += MapCursorChanged;
            _map.MapLocked += MapLocked;
            _map.MouseUp += MapMouseUp;
            _map.MouseDown += MapMouseDown;
            _map.MouseMove += MapMouseMove;
            _map.MouseDoubleClick += MapMouseDoubleClick;
            _map.SelectionChanged += MapSelectionChanged;
            _map.SelectBoxFinal += MapSelectBoxFinal;
            _map.ShapeIdentified += MapShapeIdentified;
            _map.ShapeValidationFailed += MapShapeValidationFailed;
            _map.ValidateShape += MapValidateShape;
            _map.TmsProviderChanged += MapTmsProviderChanged;

            var mapControl = (_map as MapControl);
            if (mapControl != null)
            {
                mapControl.PreviewKeyDown += MapListener_PreviewKeyDown;
            }
        }

        private void MapTmsProviderChanged(object sender, EventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.TmsProviderChanged_, sender as IMuteMap, e);
        }

        private void MapSelectBoxFinal(object sender, SelectBoxFinalEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.SelectBoxFinal_, sender as IMuteMap, e);
        }
        
        private void MapAfterShapeEdit(object sender, AfterShapeEditEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.AfterShapeEdit_, sender as IMuteMap, e);
        }

        private void MapLocked(object sender, LockedEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.MapLocked_, sender as IMuteMap, e);
        }

        private void MapMouseDoubleClick(object sender, EventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.MouseDoubleClick_, sender as IMuteMap, e);
        }

        private void MapMouseMove(object sender, MouseEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.MouseMove_, sender as IMuteMap, e);
        }

        private void MapMouseDown(object sender, MouseEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.MouseDown_, sender as IMuteMap, e);
        }

        private void MapShapeIdentified(object sender, ShapeIdentifiedEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.ShapeIdentified_, sender as IMuteMap, e);
        }

        private void MapSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.UpdateMap)
            {
                _map.Redraw();
            }
            _context.View.Update();

            _broadcaster.BroadcastEvent(p => p.SelectionChanged_, sender as IMuteMap, e);
        }

        private void MapChooseLayer(object sender, ChooseLayerEventArgs e)
        {
            if (_context.Map.IsCustomSelectionMode)
            {
                // someone wants to override default selection box behavior, let's not interfere
                return;
            }
            
            e.LayerHandle = _context.Map.Layers.Current.Handle;
            _broadcaster.BroadcastEvent(p => p.ChooseLayer_, sender as IMuteMap, e);
            
        }

        private void MapCursorChanged(object sender, EventArgs e)
        {
            _context.View.Update();

            _broadcaster.BroadcastEvent(p => p.MapCursorChanged_, sender as IMuteMap, e);
        }

        private void MapValidateShape(object sender, ValidateShapeEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.ValidateShape_, sender as IMuteMap, e);
        }

        private void MapHistoryChanged(object sender, EventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.HistoryChanged_, sender as IMuteMap, e);
        }

        private void MapShapeValidationFailed(object sender, ShapeValidationFailedEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.ShapeValidationFailed_, sender as IMuteMap, e);
        }

        private void MapMouseUp(object sender, MouseEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.MouseUp_, sender as IMuteMap, e);

            if (e.Button == MouseButtons.Right)     // TODO: don't handle if it was handled by plugins
            {
                ShowContextMenu(e.X, e.Y);
            }
        }

        private void MapBeforeShapeEdit(object sender, BeforeShapeEditEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.BeforeShapeEdit_, sender as IMuteMap, e);
        }

        private void MapBeforeDeleteShape(object sender, BeforeDeleteShapeEventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.BeforeDeleteShape_, sender as IMuteMap, e);
        }

        private void MapFileDropped(object sender, FileDroppedEventArgs e)
        {
            if (TryParseTmsProviderFromDroppedFilename(e.Filename))
            {
                return;
            }

            if (e.Filename.ToLower().EndsWith(".mwproj") ||
                e.Filename.ToLower().EndsWith(".mwprj"))
            {
                _projectService.Open(e.Filename, false);
                return;
            }

            _layerService.AddLayersFromFilename(e.Filename);
            int handle = _layerService.LastLayerHandle;
            _map.ZoomToLayer(handle);
        }

        private bool TryParseTmsProviderFromDroppedFilename(string filename)
        {
            // expected format: "TmsProvider|" + Provider.Id (see RepositoryTreeView)
            if (filename.ToLower().StartsWith("tmsprovider"))
            {
                var parts = filename.Split('|');
                if (parts.Length == 2)
                {
                    int providerId;
                    if (Int32.TryParse(parts[1], out providerId))
                    {
                        _map.SetTileProvider(providerId);
                        _map.Redraw(RedrawType.Minimal, true);
                        _context.View.Update();
                    }
                }

                return true;
            }

            return false;
        }

        private void MapExtentsChanged(object sender, EventArgs e)
        {
            _broadcaster.BroadcastEvent(p => p.ExtentsChanged_, sender as IMuteMap, e);

            _context.View.Update();
        }

        private void MapListener_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    e.IsInputKey = true;
                    return;
            }
        }

        private void ShowContextMenu(int x, int y)
        {
            var parent = _map as Control;
            if (parent == null)
            {
                return;
            }

            ContextMenuStrip menu = null;

            switch (_map.MapCursor)
            {
                case MapCursor.Measure:
                    menu = _contextMenuPresenter.MeasuringMenu;
                    break;
                case MapCursor.ZoomIn:
                case MapCursor.ZoomOut:
                case MapCursor.Pan:
                     menu = _contextMenuPresenter.ZoomingMenu;
                    break;
            }

            if (menu != null)
            {
                menu.Show(parent, x, y);
            }
        }
    }
}
