using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Services
{
    internal class InputLayerEventArgs: EventArgs
    {
        public InputLayerEventArgs(IDatasourceInput input)
        {
            if (input == null) throw new ArgumentNullException("layer");
            Datasource = input;
        }

        public IDatasourceInput Datasource { get; private set; }
    }
}
