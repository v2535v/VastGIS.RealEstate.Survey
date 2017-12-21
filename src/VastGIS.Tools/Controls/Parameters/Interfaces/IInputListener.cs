using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Controls.Parameters.Interfaces
{
    /// <summary>
    /// Represents a control that can react to the changes of the input datasource.
    /// </summary>
    internal interface IInputListener
    {
        void OnLayerChanged(IDatasourceInput input);
    }
}
