﻿using System;
using System.Linq;
using AxMapWinGIS;
using MapWinGIS;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Api.Legend.Events;
using VastGIS.Api.Map;

namespace VastGIS.Api.Legend
{
    public class LayerCollection<T> : BaseLayerCollection<T>, ILayerCollection<T>
         where T : class, ILayer
    {
        private readonly LegendControl _legend;

        internal LayerCollection(MapControl mapControl, IMuteLegend legend)
            : base(mapControl)
        {
            _legend = legend as LegendControl;
            if (_legend == null)
            {
                throw new NullReferenceException("Invalid legend reference.");
            }
        }

        public override T this[int position]
        {
            get
            {
                if (position < 0 && position >= Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid layer position");
                }

                var layerHandle = _axMap.get_LayerHandle(position);
                if (layerHandle != -1)
                {
                    return _legend.Groups.LayerByHandle(layerHandle) as T;
                }
                return null;
            }
        }

        public override T ItemByHandle(int layerHandle)
        {
            return _legend.Groups.LayerByHandle(layerHandle) as T;
        }

        /// <summary>
        /// Gets the position (index) of the specified layer within the group
        /// </summary>
        /// <param name="layerHandle">Handle of the layer</param>
        /// <returns>0-Based Index into list of layers within group, -1 on failure</returns>
        public int PositionInGroup(int layerHandle)
        {
            int layerIndex, groupIndex;

            var lyr = _legend.FindLayerByHandle(layerHandle, out groupIndex, out layerIndex);

            if (lyr != null)
            {
                return layerIndex;
            }

            return -1;
        }

        /// <summary>
        /// Gets the handle of the group containing the specified layer
        /// </summary>
        /// <param name="layerHandle">Handle of the layer</param>
        /// <returns>Group Handle of the group that contains the layer, -1 on failure</returns>
        public int GroupOf(int layerHandle)
        {
            int layerIndex, groupIndex;

            var lyr = _legend.FindLayerByHandle(layerHandle, out groupIndex, out layerIndex);

            if (lyr != null)
            {
                var grp = _legend.Groups[groupIndex];
                return grp.Handle;
            }

            return -1;
        }

        /// <summary>
        /// Move a layer to a specified location within a specified group
        /// </summary>
        /// <param name="layerHandle">Handle to the layer to move</param>
        /// <param name="targetGroupHandle">Handle of the group into which to move the layer</param>
        /// <param name="positionInGroup">0-Based index into the list of layers within the Target Group</param>
        /// <returns>True on success, False otherwise</returns>
        public bool MoveLayer(int layerHandle, int targetGroupHandle, int positionInGroup = -1)
        {
            return _legend.MoveLayer(targetGroupHandle, layerHandle, positionInGroup);
        }

        /// <summary>
        /// Adds a layer to the topmost Group
        /// </summary>
        /// <param name="layerSource"> object to be added as new layer </param>
        /// <param name="visible"> Should this layer to be visible in the map? </param>
        /// <param name="legendVisible"> Should this layer be visible in the legend? </param>
        /// <param name="targetGroupHandle"> layerHandle of the group into which this layer should be added </param>
        /// <param name="positionInGroup"> Position in group new layer should be inserted at </param>
        /// <returns> layerHandle to the Layer on success, -1 on failure </returns>
        public int Add(ILayerSource layerSource, bool visible, bool legendVisible, int targetGroupHandle = -1, int positionInGroup = -1)
        {
            var newLayer = layerSource.InternalObject;

            var mapLayerHandle = _axMap.AddLayer(newLayer, visible);
            if (mapLayerHandle < 0)
            {
                return mapLayerHandle;
            }

            _axMap.LockWindow(tkLockMode.lmLock);

            var legendGroups = _legend.Groups as LegendGroups;
            if (legendGroups != null)
            {
                var grp = legendGroups.FindOrCreateGroup(targetGroupHandle) as LegendGroup;

                if (grp != null)
                {
                    var lyr = _legend.CreateLayer(mapLayerHandle, newLayer);
                    lyr.HideFromLegend = !legendVisible;
                    lyr.Expanded = _mapControl.ExpandLayersOnAdding;

                    if (positionInGroup == -1)
                    {
                        grp.AddLayer(lyr);
                    }
                    else
                    {
                        grp.InsertLayer(positionInGroup, lyr);
                    }
                }
            }

            if (legendVisible)
            {
                _legend.SelectedLayerHandle = mapLayerHandle;
            }

            _axMap.LockWindow(tkLockMode.lmUnlock);

            _legend.Redraw();
            _legend.FireLayerAdded(mapLayerHandle);

            return mapLayerHandle;
        }

        /// <summary>
        /// Adds a layer to the topmost Group
        /// </summary>
        /// <param name="newLayer"> object to be added as new layer </param>
        /// <param name="visible"> Should this layer to be visible? </param>
        /// <param name="targetGroupHandle"> layerHandle of the group into which this layer should be added </param>
        /// <returns> layerHandle to the Layer on success, -1 on failure </returns>
        public int Add(ILayerSource newLayer, bool visible, int targetGroupHandle)
        {
            return Add(newLayer, visible, true, targetGroupHandle);
        }

        /// <summary>
        /// Adds a layer to the topmost Group
        /// </summary>
        /// <param name="newLayer"> object to be added as new layer </param>
        /// <param name="visible"> Should this layer to be visible? </param>
        /// <returns> layerHandle to the Layer on success, -1 on failure </returns>
        public override int Add(ILayerSource newLayer, bool visible = true)
        {
            return Add(newLayer, visible, true, -1);
        }

        public override bool Remove(int layerHandle)
        {
            return _legend.RemoveLayer(layerHandle, false);
        }

        public override void Clear()
        {
            _legend.ClearLayers();
        }

        public T Current
        {
            get
            {
                 if (_legend.SelectedLayerHandle != -1)
                 {
                     return ItemByHandle(_legend.SelectedLayerHandle);
                 }
                 return null;
            }
        }
    }
}