using System;
using VastGIS.Api.Enums;
using VastGIS.Shared;

namespace VastGIS.Plugins.Identifier.Enums
{
    internal class IdentifierModeConverter : IEnumConverter<IdentifierMode>
    {
        public string GetString(IdentifierMode value)
        {
            switch (value)
            {
                case IdentifierMode.CurrentLayer:
                    return "Current layer";
                case IdentifierMode.AllLayers:
                    return "All layers";
                case IdentifierMode.AllLayersStopOnFirst:
                    return "Top down stop on first";
            }
            throw new ApplicationException("Invalid IdentifierMode mode");
        }
    }
}
