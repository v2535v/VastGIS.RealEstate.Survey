using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    public interface ILegendGroupView: IView<ILegendGroup>
    {
        string GroupName { get;  }
    }
}
