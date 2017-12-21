using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Tools.Model.Parameters;

namespace VastGIS.Gdal.Views.Abstract
{
    public interface IGdalDriverOptionsView: IGdalView
    {
        IEnumerable<BaseParameter> DriverParameters { get; }
    }
}
