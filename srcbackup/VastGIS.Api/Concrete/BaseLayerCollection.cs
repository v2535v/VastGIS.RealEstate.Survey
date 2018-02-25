﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxMapWinGIS;
using MapWinGIS;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Map;

namespace VastGIS.Api.Concrete
{
    public abstract class BaseLayerCollection<T>: IEnumerable<T> where T: ILayer
    {
        protected readonly AxMap _axMap;
        protected readonly MapControl _mapControl;

        internal BaseLayerCollection(MapControl mapControl)
        {
            if (mapControl == null)
            {
                throw new NullReferenceException("Map reference is null.");
            }
            _mapControl = mapControl;
            _axMap = mapControl.GetInternal();
        }
        
        public int Count
        {
            get { return _axMap.NumLayers; }
        }

        public IFeatureSet GetFeatureSet(int layerHandle)
        {
            var sf = _axMap.get_Shapefile(layerHandle);
            if (sf != null)
            {
                return new FeatureSet(sf);
            }
            return null;
        }

        public WmsSource GetWmsLayer(int layerHandle)
        {
            var wms = _axMap.get_WmsLayer(layerHandle);
            if (wms != null)
            {
                return new WmsSource(wms);
            }

            return null;
        }

        public IVectorLayer GetVectorLayer(int layerHandle)
        {
            var ogr = _axMap.get_OgrLayer(layerHandle);
            if (ogr != null)
            {
                return new VectorLayer(ogr);
            }
            return null;
        }

        public virtual int Add(ILayerSource layerSource, bool visible = true)
        {
            return _axMap.AddLayer(layerSource.InternalObject, visible);
        }

        public bool Move(int initialPosition, int targetPosition)
        {
            return _axMap.MoveLayer(initialPosition, targetPosition);
        }

        public bool MoveBottom(int initialPosition)
        {
            return _axMap.MoveLayerBottom(initialPosition);
        }

        public bool MoveDown(int initialPosition)
        {
            return _axMap.MoveLayerDown(initialPosition);
        }

        public bool MoveTop(int initialPosition)
        {
            return _axMap.MoveLayerTop(initialPosition);
        }

        public bool MoveUp(int initialPosition)
        {
            return _axMap.MoveLayerUp(initialPosition);
        }

        public int AddFromDatabase(string connectionString, string layerNameOrQuery, bool visible = true)
        {
            return _axMap.AddLayerFromDatabase(connectionString, layerNameOrQuery, visible);
        }

        public int AddFromFilename(string filename, FileOpenStrategy openStrategy = FileOpenStrategy.AutoDetect, bool visible = true)
        {
            return _axMap.AddLayerFromFilename(filename, (tkFileOpenStrategy)openStrategy, visible);
        }

        public virtual void Clear()
        {
            _axMap.RemoveAllLayers();
        }

        public void ClearWithoutClosing()
        {
            int count = Count - 1;

            _mapControl.Lock();

            for (int i = Count - 1; i >= 0; i--)
            {
                int handle = _axMap.get_LayerHandle(i);
                if (handle != -1)
                {
                    _axMap.RemoveLayerWithoutClosing(handle);
                }
            }

            _mapControl.Unlock();
        }

        public virtual bool Remove(int layerHandle)
        {
            _axMap.RemoveLayer(layerHandle);
            return _axMap.get_LayerPosition(layerHandle) != -1;
        }

        public void RemoveWithoutClosing(int layerHandle)
        {
            _axMap.RemoveLayerWithoutClosing(layerHandle);
        }

        public bool IsValidHandle(int layerHandle)
        {
            return _axMap.get_LayerPosition(layerHandle) != -1;
        }

        public abstract T ItemByHandle(int layerHandle);

        public abstract T this[int position] { get; }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
