﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Api.Legend.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Repository.Views;

namespace VastGIS.Plugins.Repository
{
    public class LegendListener
    {
        private readonly IAppContext _context;
        private readonly RepositoryPlugin _plugin;
        private readonly RepositoryPresenter _presenter;

        public LegendListener(IAppContext context, RepositoryPlugin plugin, RepositoryPresenter presenter)
        {
            if (plugin == null) throw new ArgumentNullException("plugin");
            if (presenter == null) throw new ArgumentNullException("presenter");

            _context = context;
            _plugin = plugin;
            _presenter = presenter;
            if (context.ViewType == MainViewType.Normal)
            {
                plugin.LayerAdded += OnLayerAdded;
                plugin.LayerRemoved += (s, e) => UpdateRepositoryTree();
                plugin.ProjectClosed += (s, e) => UpdateRepositoryTree();
                plugin.MapLocked += (s, e) => UpdateRepositoryTree();
            }
        }

        private void OnLayerAdded(IMuteLegend legend, LayerEventArgs e)
        {
            var layer = _context.Layers.ItemByHandle(e.LayerHandle);
            UpdateRepositoryTree(layer != null ? layer.Handle : -1);
        }

        private void UpdateRepositoryTree(int newLayerHandle = -1)
        {
            if (!_context.Map.IsLocked)
            {
                var list = new List<LayerIdentity>();
                foreach (var layer in _context.Layers)
                {
                    var identity = layer.Identity;

                    if (newLayerHandle == layer.Handle)
                    {
                        identity.ForceRefresh = true;
                    }

                    list.Add(identity);
                }

                var hash = new HashSet<LayerIdentity>(list.Distinct());
                _presenter.View.Tree.UpdateState(hash);
            }
        }
    }
}
