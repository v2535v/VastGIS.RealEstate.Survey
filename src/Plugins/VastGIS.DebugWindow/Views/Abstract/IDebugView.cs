using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.DebugWindow.Views.Abstract
{
    public interface IDebugView: IMenuProvider
    {
        void Clear();
    }
}
