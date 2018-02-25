using System;
using System.Collections;
using System.Collections.Generic;
using AxMapWinGIS;
using MapWinGIS;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Api.Map;

namespace VastGIS.Api.Concrete
{
    public class SimpleLayerCollection : BaseLayerCollection<ILayer>
    {
        public SimpleLayerCollection(MapControl mapControl)
            : base(mapControl)
        {
        }

        public override ILayer ItemByHandle(int layerHandle)
        {
            return new Layer(_mapControl, layerHandle);
        }

        public override ILayer this[int position]
        {
            get
            {
                if (position >= 0 && position < Count)
                {
                    var layerHandle = _axMap.get_LayerHandle(position);
                    if (layerHandle != -1)
                    {
                        return new Layer(_mapControl, layerHandle);
                    }
                }
                return null;
            }
        }
    }
}