using VastGIS.Api.Interfaces;
using VastGIS.Projections.Enums;
using VastGIS.Projections.Forms;

namespace VastGIS.Projections.Services.Abstract
{
    public interface IReprojectingService
    {
        TestingResult Reproject(ILayerSource layer, out ILayerSource newLayer, ISpatialReference projection,
            TesterReportForm report);
    }
}
