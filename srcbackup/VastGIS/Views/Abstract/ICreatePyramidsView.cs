using System;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    public interface ICreatePyramidsView: IView<IRasterSource>
    {
        event Action ButtonClicked;
        TiffCompression Compression { get; }
        RasterOverviewSampling Sampling { get; }
        bool DontShowAgain { get; }
    }
}
