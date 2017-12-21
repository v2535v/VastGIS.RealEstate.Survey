using System;
using System.Collections.Generic;
using VastGIS.Enums;
using VastGIS.Plugins.Mvp;
using VastGIS.Services.Config;

namespace VastGIS.Views.Abstract
{
    public interface IConfigView: IView<ConfigViewModel>, IMenuProvider
    {
        event Action PageShown;
    }
}
