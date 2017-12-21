using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BruTile.Wms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Tiles.Views.Abstract
{
    internal interface IWmsCapabilitiesView : IComplexView<WmsCapabilitiesModel>
    {
        WmsServer Server { get; set; }

        void ShowHourglass();

        void HideHourglass();

        IEnumerable<Layer> SelectedLayers { get; }

        event Action LayerDoubleClicked;

        event Action SelectedServerChanged;

        void UpdateCapabilities();

        void UpdateServer(WmsServer server = null);
    }
}
