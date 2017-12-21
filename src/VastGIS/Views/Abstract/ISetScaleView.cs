using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    internal interface ISetScaleView: IView
    {
        string NewScale { get; }

        bool SnapToZoomLevel { get; }
    }
}
