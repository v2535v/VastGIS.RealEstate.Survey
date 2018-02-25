using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Mvp
{
    public interface IComplexView : IView, IMenuProvider
    {
    }

    public interface IComplexView<TModel> : IView<TModel>, IMenuProvider
    {
    }
}
