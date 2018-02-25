using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;

namespace VastGIS.Plugins.Services
{
    public interface ISelectLayerService
    {
        IEnumerable<ILayer> Select(DataSourceType layerType);
    }
}
