using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Data.Views;
using VastGIS.Helpers;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;
using VastGIS.Tiles.Views;
using VastGIS.UI.Docking;
using VastGIS.Views;

namespace VastGIS.Commands.File
{
    public class CmdShowRepository:BaseCommand
    {
        private IAppContext _context;
        public CmdShowRepository(IAppContext context)
        {
            base._text = "显示目录窗口";
            base._key = MenuKeys.ShowRepository;
            base._icon = Resources.icon_folder;
            _context = context;
        }

        public override void OnClick()
        {
            DockPanelHelper.ShowPanel(_context, DockPanelKeys.Repository);
        }
    }

    public class CmdShowToolbox : BaseCommand
    {
        private IAppContext _context;
        public CmdShowToolbox(IAppContext context)
        {
            base._text = "显示工具箱";
            base._key = MenuKeys.ShowToolbox;
            base._icon = Resources.img_toolbox24;
            _context = context;
        }

        public override void OnClick()
        {
            DockPanelHelper.ShowPanel(_context, DockPanelKeys.Toolbox);
        }
    }

    public class CmdQuit : BaseCommand
    {
        private IAppContext _context;
        public CmdQuit(IAppContext context)
        {
            base._text = "退出系统";
            base._key = Plugins.Menu.MenuKeys.Quit;
            base._icon = Resources.icon_quit;
            _context = context;
        }

        public override void OnClick()
        {
            var appContext = _context as AppContext;
            if (appContext != null)
            {
                appContext.Close();
            }
        }
    }
    public class CmdCreateNewMap : BaseCommand
    {
        private IAppContext _context;
        public CmdCreateNewMap(IAppContext context)
        {
            base._text = "新建地图";
            base._key = MenuKeys.NewMap;
            base._icon = Resources.icon_new_map;
            _context = context;
        }

        public override void OnClick()
        {
            IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            projectService.TryClose();
        }
    }

    public class CmdOpenProject : BaseCommand
    {
        private IAppContext _context;
        public CmdOpenProject(IAppContext context)
        {
            base._text = "打开项目";
            base._key = MenuKeys.OpenProject;
            base._icon = Resources.icon_folder;
            _context = context;
        }

        public override void OnClick()
        {
            IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            projectService.Open();
        }
    }

    public class CmdSaveProject : BaseCommand
    {
        private IAppContext _context;
        public CmdSaveProject(IAppContext context)
        {
            base._text = "保存项目";
            base._key = MenuKeys.SaveProject;
            base._icon = Resources.icon_save;
            _context = context;
        }

        public override void OnClick()
        {
            IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            if (projectService.Save())
            {
                MessageService.Current.Info("项目已经成功保存为: " + projectService.Filename);
            }
        }
    }

    public class CmdSaveProjectAs : BaseCommand
    {
        private IAppContext _context;
        public CmdSaveProjectAs(IAppContext context)
        {
            base._text = "项目另存为";
            base._key = MenuKeys.SaveProjectAs;
            base._icon = Resources.icon_save_as;
            _context = context;
        }

        public override void OnClick()
        {
            IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            if (projectService.SaveAs())
            {
                MessageService.Current.Info("项目已经成功保存为: " + projectService.Filename);
            }
        }
    }

    public class CmdAddLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddLayer(IAppContext context)
        {
            base._text = "添加数据";
            base._key = MenuKeys.AddLayer;
            base._icon = Resources.icon_layer_add;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.AddLayer(DataSourceType.All);
        }
    }

    public class CmdAddVectorLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddVectorLayer(IAppContext context)
        {
            base._text = "添加矢量图层";
            base._key = MenuKeys.AddVectorLayer;
            base._icon = Resources.icon_layer_vector_add;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.AddLayer(DataSourceType.Vector);
        }
    }

    public class CmdAddRasterLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddRasterLayer(IAppContext context)
        {
            base._text = "添加栅格图层";
            base._key = MenuKeys.AddRasterLayer;
            base._icon = Resources.icon_layer_raster_add;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.AddLayer(DataSourceType.Raster);
        }
    }

    public class CmdAddWmsLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddWmsLayer(IAppContext context)
        {
            base._text = "添加WMS图层";
            base._key = MenuKeys.AddWmsLayer;
            base._icon = Resources.img_wms_add24;
            _context = context;
        }

        public override void OnClick()
        {
            var model = new WmsCapabilitiesModel(_context.Repository);
            _context.Container.Run<WmsCapabilitiesPresenter, WmsCapabilitiesModel>(model);
        }
    }

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


    public class CmdSettings : BaseCommand
    {
        private IAppContext _context;
        public CmdSettings(IAppContext context)
        {
            base._text = "设置";
            base._key = MenuKeys.Settings;
            base._icon = Resources.icon_settings;
            _context = context;
        }

        public override void OnClick()
        {
            var model = _context.Container.GetInstance<ConfigViewModel>();
            _context.Container.Run<ConfigPresenter, ConfigViewModel>(model);
        }
    }

    public class CmdRemoveLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdRemoveLayer(IAppContext context)
        {
            base._text = "删除图层";
            base._key = MenuKeys.RemoveLayer;
            base._icon = Resources.icon_layer_remove;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.RemoveSelectedLayer();
        }
    }
}
