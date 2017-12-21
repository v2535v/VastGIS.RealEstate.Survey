using VastGIS.Api.Interfaces;
using VastGIS.Projections.Enums;

namespace VastGIS.Projections.Services.Abstract
{
    public interface IProjectionMismatchService
    {
        TestingResult TestLayer(ILayerSource layer, out ILayerSource newLayer);

        void SetReprojectOnMismatch(bool autoReproject);
    }
}
