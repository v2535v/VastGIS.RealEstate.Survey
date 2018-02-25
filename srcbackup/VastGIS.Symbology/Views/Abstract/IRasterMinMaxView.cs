using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Symbology.Views.Abstract
{
    public interface IRasterMinMaxView : IView<RasterMinMaxModel>
    {
        void UiToModel();
    }
}
