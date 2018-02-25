using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Symbology.Views.Abstract
{
    internal interface IWmsStyleView: IComplexView<ILegendLayer>
    {
        bool ValidateInput();

        void ApplyChanges();

        void ClearColorAdjustments();
    }
}
