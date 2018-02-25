using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Printing.Views.Abstract
{
    internal interface IChooseDpiView: IView<ChooseDpiModel>
    {
        void SaveLastDpi();
    }
}
