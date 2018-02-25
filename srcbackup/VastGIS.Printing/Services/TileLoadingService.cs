﻿// -------------------------------------------------------------------------------------------
// <copyright file="TileLoadingService.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using VastGIS.Api.Enums;
using VastGIS.Api.Events;
using VastGIS.Api.Map;
using VastGIS.Plugins.Printing.Controls.Layout;
using VastGIS.Plugins.Printing.Model;
using VastGIS.Plugins.Printing.Model.Elements;
using VastGIS.Shared;

namespace VastGIS.Plugins.Printing.Services
{
    public class TileLoadingService: IDisposable
    {
        private const int TimeOut = 30000;
        private readonly object _lock = new object();
        private readonly Queue<TileLoadingTask> _queue = new Queue<TileLoadingTask>();
        private readonly Timer _timer;
        private bool _busy;
        private LayoutControl _layoutControl;
        private IPrintableMap _map;

        public TileLoadingService()
        {
            _timer = new Timer { Interval = TimeOut };
            _timer.Elapsed += OnTimerElapsed;
        }

        public event EventHandler End;

        public event EventHandler Start;

        public object Lock
        {
            get { return _lock; }
        }

        public void EnqueTask(TileLoadingTask task)
        {
            _queue.Enqueue(task);
            RunQueue();
        }

        public void Initialize(IPrintableMap map, LayoutControl layoutControl)
        {
            if (map == null) throw new ArgumentNullException("map");
            if (layoutControl == null) throw new ArgumentNullException("layoutControl");

            _map = map;
            _layoutControl = layoutControl;

            _map.TilesLoaded += TilesLoaded;
        }

        private void MarkBusy()
        {
            _timer.Stop();
            _busy = true;
            _timer.Start();
        }

        private void MarkReady()
        {
            _timer.Stop();
            _busy = false;
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            _busy = false;
            Logger.Current.Warn("Failed to load tiles in the layout when timeout is reached.");
            RunQueue();
        }

        private void RunQueue()
        {
            if (_busy) return;

            lock (_lock)
            {
                if (_queue.Any())
                {
                    MarkBusy();

                    var task = _queue.Dequeue();

                    var tiles = _map.Tiles;
                    var oldProvider = tiles.ProviderId;
                    var oldVisible = tiles.Visible;

                    _map.SetTileProvider(task.TileProvider);
                    tiles.Visible = task.TileProvider != (int)TileProvider.None;

                    // if true is returned, then the tiles are already in cache
                    // no need to do anything else, otherwise a loading process has started
                    // and we need to wait for IMap.TilesLoaded event.
                    if (!_map.LoadTilesForSnapshot(task.Extents, task.Width, task.Guid))
                    {
                        DelegateHelper.FireEvent(_layoutControl, Start);
                    }
                    else
                    {
                        MarkReady();
                    }

                    tiles.Visible = oldVisible;
                    _map.SetTileProvider(oldProvider);
                }
            }
        }

        private void TilesLoaded(object sender, TilesLoadedEventArgs e)
        {
            // all loading requests have GUIDs as keys
            if (string.IsNullOrWhiteSpace(e.Key) || e.FromCache)
            {
                return; // no need to update map
            }

            MarkReady();

            var map =
                _layoutControl.LayoutElements.OfType<LayoutMap>().FirstOrDefault(item => item.Guid.ToString() == e.Key);

            if (map != null)
            {
                map.TilesLoaded = true;
                map.RefreshElement();
                RunQueue();
            }

            DelegateHelper.FireEvent(_layoutControl, End);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            _timer.Stop();
            _timer.Elapsed -= OnTimerElapsed;
            _map.TilesLoaded -= TilesLoaded;
        }
    }
}