using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.ShapeEditor.Context;
using VastGIS.Plugins.ShapeEditor.Helpers;
using VastGIS.Plugins.ShapeEditor.Menu;
using VastGIS.Plugins.ShapeEditor.Services;
using VastGIS.Plugins.ShapeEditor.Views;
using VastGIS.Plugins.ShapeEditor.Views.Abstract;
using VastGIS.Services;

namespace VastGIS.Plugins.ShapeEditor
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<IGeoprocessingService, GeoprocessingService>()
                .RegisterSingleton<ILayerEditingService, LayerEditingService>()
                .RegisterService<ContextMenuView>()
                .RegisterSingleton<ContextMenuPresenter>()
                .RegisterService<IAttributeView, AttributeView>();
        }
    }
}


