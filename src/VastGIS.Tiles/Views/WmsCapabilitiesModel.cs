using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BruTile.Wms;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Tiles.Views
{
    internal class WmsCapabilitiesModel
    {
        public WmsCapabilitiesModel(IRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");

            Repository = repository;
        }

        public IRepository Repository { get; private set; }

        public WmsCapabilities Capabilities { get; set; }
    }
}
