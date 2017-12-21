using System;
using VastGIS.Data.Views;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Shared;

namespace VastGIS.Data.Services
{
    public class GeoDatabaseService: IGeoDatabaseService
    {
        private readonly IAppContext _context;

        public GeoDatabaseService(IAppContext context)
        {
            Logger.Current.Trace("In GeoDatabaseService");
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public void ImportLayer()
        {
            Logger.Current.Trace("In GeoDatabaseService.ImportLayer()");
            _context.Container.Run<ImportLayerPresenter>();
        }

        public DatabaseConnection PromptUserForConnection(GeoDatabaseType? databaseType = null)
        {
            Logger.Current.Trace("In GeoDatabaseService.PromptUserForConnection()");
            var p = _context.Container.GetInstance<AddConnectionPresenter>();

            var model = new AddConnectionModel(databaseType);

            return p.Run(model) ? model.Connection : null;
        }
    }
}
