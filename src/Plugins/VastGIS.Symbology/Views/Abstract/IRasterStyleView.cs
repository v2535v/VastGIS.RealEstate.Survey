using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Symbology.Controls;

namespace VastGIS.Plugins.Symbology.Views.Abstract
{
    public interface IRasterStyleView: IComplexView<ILegendLayer>
    {
        void UiToModel();
        RasterRenderingPresenter RenderingPresenter { get; }
        void ClearColorAdjustments();
        RasterStyleTab InitialTab { get; set; }
    }
}
