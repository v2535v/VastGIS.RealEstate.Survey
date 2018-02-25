using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Services.Views;

namespace VastGIS.Services.Concrete
{
    internal class SelectLayerService: ISelectLayerService
    {
        private readonly IAppContext _context;

        public SelectLayerService(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public IEnumerable<ILayer> Select(DataSourceType layerType)
        {
            var model = new SelectLayerModel(_context.Layers.Select(l => new SelectLayerGridAdapter(l)), layerType);

            if (_context.Container.Run<SelectLayerPresenter, SelectLayerModel>(model))
            {
                return model.Layers.Where(l => l.Selected).Select(l => l.Layer);
            }

            return new List<ILayer>();
        }
    }
}
