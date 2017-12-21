using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;

namespace VastGIS.Plugins.Events
{
    public class TileProviderArgs: CancelEventArgs
    {
        public TileProviderArgs(int providerId)
        {
            ProviderId = providerId;
        }

        public int ProviderId { get; set; }

        public bool IsBingProvider
        {
            get
            {
                var bingProviders = new[] { TileProvider.BingHybrid, TileProvider.BingMaps, TileProvider.BingSatellite };
                var list = bingProviders.Select(p => (int)p);
                return list.Contains(ProviderId);
            }
        }
    }
}
