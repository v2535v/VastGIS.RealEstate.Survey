using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Symbology.Views.Abstract
{
    public interface IVectorStyleView : IComplexView<ILegendLayer>
    {
        bool SpatialIndex { get; }

        event Action UpdateSpatialIndex;

        event Action ModifyCharts;

        event Action ModifyLabels;

        void LockView();

        void UnlockView();

        void RefreshCharts();

        void RefreshLabels();
    }
}
