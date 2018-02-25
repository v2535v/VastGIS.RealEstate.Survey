using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;

namespace VastGIS.Tools.Model.Layers
{
    public interface IRasterInput: IDatasourceInput
    {
        /// <summary>
        /// Gets or sets the datasource serving as input for GIS task.
        /// </summary>
        new IRasterSource Datasource { get; set; }
    }
}
