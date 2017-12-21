using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;

namespace VastGIS.Plugins.Mvp
{
    public abstract class CommandDispatcher<TView, TCommand>: CommandDispatcher<TCommand>
        where TCommand : struct, IConvertible
        where TView : IMenuProvider
    {
        public TView View { get; private set; }

        protected CommandDispatcher(TView view)
        {
            View = view;
            WireUpMenus(view as Control);
        }
    }
}
