// -------------------------------------------------------------------------------------------
// <copyright file="IAppContext.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces.Projections;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Interfaces
{
    public interface IAppContext
    {
        AppConfig Config { get; }

        IApplicationContainer Container { get; }

        IDockPanelCollection DockPanels { get; }

        ILayerCollection<ILayer> Layers { get; }

        IMuteLegend Legend { get; }

        ILocator Locator { get; }

        IMuteMap Map { get; }

        IMenu Menu { get; }

        IProject Project { get; }

        IProjectionDatabase Projections { get; }

        IRepository Repository { get; }

        IStatusBar StatusBar { get; }

        SynchronizationContext SynchronizationContext { get; }

        ITaskCollection Tasks { get; }

        IToolbarCollection Toolbars { get; }

        IToolbox Toolbox { get; }

        IAppView View { get; }

        bool Initialized { get; }

        void SetMapProjection(ISpatialReference projection);

        MainViewType ViewType { get; }

        IRibbonMenu RibbonMenu { get; }

        IMapTool CurrentTool { get; set; }

        bool SetCurrentTool(IMapTool tool);

        List<ICommand> Commands { get; set; }
    }
    
}