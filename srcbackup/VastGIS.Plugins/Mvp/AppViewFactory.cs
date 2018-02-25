using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Mvp
{
    public static class AppViewFactory
    {
        public static IAppView Instance { get;  internal set; }
    }
}
