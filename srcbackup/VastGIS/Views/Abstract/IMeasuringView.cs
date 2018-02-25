using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    public interface IMeasuringView: IView<IMeasuringSettings>
    {
        void UiToModel();
    }
}
