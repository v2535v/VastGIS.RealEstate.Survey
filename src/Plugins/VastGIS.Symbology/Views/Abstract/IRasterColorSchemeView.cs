using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Symbology.Views.Abstract
{
    public interface IRasterColorSchemeView: IView<RasterColorScheme>, IMenuProvider
    {
        BindingList<RasterInterval> Intervals { get; }
        RasterInterval SelectedInterval { get; }
    }
}
