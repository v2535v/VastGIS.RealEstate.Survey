using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    public interface ISpatialIndexView: IView
    {
        event Action ButtonClicked;
        bool DontShowAgain { get; }
    }
}
