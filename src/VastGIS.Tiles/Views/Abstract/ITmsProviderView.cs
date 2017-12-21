using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Model;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Tiles.Views.Abstract
{
    public interface ITmsProviderView: IView<TmsProvider>
    {
        int Id { get; }
        string Url { get; }
        string ProviderName { get; }
        TileProjection Projection { get; }
        int MinZoom { get; }
        int MaxZoom { get; }
        bool UseBounds { get; }
        double MinLat { get; }
        double MaxLat { get; }
        double MinLng { get; }
        double MaxLng { get; }
        string Description { get; }
        event Action ChooseProjection;
    }
}
