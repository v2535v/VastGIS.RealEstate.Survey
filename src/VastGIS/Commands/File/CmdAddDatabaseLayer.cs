using VastGIS.Api.Concrete;
using VastGIS.Data.Views;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdAddDatabaseLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddDatabaseLayer(IAppContext context)
        {
            base._text = "添加数据库图层";
            base._key = MenuKeys.AddDatabaseLayer;
            base._icon = Resources.icon_layer_database_add;
            _context = context;
        }

        public override void OnClick()
        {
            IGeoDatabaseService _databaseService = _context.Container.GetInstance<IGeoDatabaseService>();
            var connection = _databaseService.PromptUserForConnection();
            if (connection != null)
            {
                using (var ds = new VectorDatasource())
                {
                    var model = new DatabaseLayersModel(ds, connection);
                    _context.Container.Run<DatabaseLayersPresenter, DatabaseLayersModel>(model);
                }
            }
            return ;
        }
    }
}