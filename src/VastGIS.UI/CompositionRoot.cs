using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Helpers;
using VastGIS.Plugins;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.UI.Style;

namespace VastGIS.UI
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterService<IStyleService, SyncfusionStyleService>()
                .RegisterSingleton<ControlStyleSettings>();
        }
    }
}
