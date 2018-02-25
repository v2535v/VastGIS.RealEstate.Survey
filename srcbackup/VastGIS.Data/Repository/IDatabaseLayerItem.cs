using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.Data.Repository
{
    public interface IDatabaseLayerItem: ILayerItem
    {
        string Connection { get; }
        string Name { get; }
        GeometryType GeometryType { get; }
        int NumFeatures { get; }
        ISpatialReference Projection { get; }
        void ShowLoadingIndicator();
        void HideLoadingIndicator();
        bool Loading { get; }
    }
}
