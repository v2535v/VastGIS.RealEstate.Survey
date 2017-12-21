using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Data.Model;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Data.Views.Abstract
{
    public interface IDatabaseLayersView : IView<DatabaseLayersModel>
    {
        IEnumerable<VectorLayerGridAdapter> Layers { get; }
    }
}
