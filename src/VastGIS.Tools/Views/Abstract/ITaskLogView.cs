using System;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Tools.Views.Abstract
{
    internal interface ITaskLogView: IView<IGisTask>
    {
        event Action Cancel;

        event Action Pause;
    }
}
