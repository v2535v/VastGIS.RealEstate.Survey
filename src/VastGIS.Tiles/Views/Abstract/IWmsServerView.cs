using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Tiles.Views.Abstract
{
    internal interface IWmsServerView: IView<WmsServer>
    {
        string ServerName { get; }

        string Url { get; }
    }
}
