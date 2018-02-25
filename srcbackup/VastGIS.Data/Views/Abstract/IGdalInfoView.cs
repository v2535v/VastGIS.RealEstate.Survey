using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Data.Views.Abstract
{
    public interface IGdalInfoView: IView<GdalInfoModel>
    {
        void SetDescription(string description);
    }
}
