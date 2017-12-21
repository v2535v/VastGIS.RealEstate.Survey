using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Model;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Tiles.Views.Abstract
{
    internal interface IProvidersView: IComplexView<TmsProviderList>
    {
        TmsProvider SelectedProvider { get; }
    }
}
