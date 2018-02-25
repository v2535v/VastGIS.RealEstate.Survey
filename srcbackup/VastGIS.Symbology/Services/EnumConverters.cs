﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Shared;
using VastGIS.UI.Helpers;

namespace VastGIS.Plugins.Symbology.Services
{
    internal class SymbologyTypeCoverter : IEnumConverter<SymbologyType>
    {
        public string GetString(SymbologyType value)
        {
            switch (value)
            {
                case SymbologyType.Default:
                    return "Default options stored in the .mwsymb or .mwsr files";
                case SymbologyType.Random:
                    return "Options set randomly by MapWinGIS ActiveX control";
                case SymbologyType.Custom:
                default:
                    return "Custom symbology";
            }
        }
    }

    internal class RasterRenderingConverter : IEnumConverter<RasterRendering>
    {
        public string GetString(RasterRendering value)
        {
            switch (value)
            {
                case RasterRendering.SingleBand:
                    return "Single band greyscale";
                case RasterRendering.Rgb:
                    return "RGB";
                case RasterRendering.ColorScheme:
                    return "Color scheme";
                case RasterRendering.BuiltInColorTable:
                    return "Built-in color table";
            }

            return string.Empty;
        }
    }

    internal class RasterClassificationConverter : IEnumConverter<RasterClassification>
    {
        public string GetString(RasterClassification value)
        {
            switch (value)
            {
                case RasterClassification.EqualIntervals:
                    return "Equal intervals";
                case RasterClassification.UniqueValues:
                    return "Unique values";
                case RasterClassification.EqualCount:
                    return "Equal count";
            }

            return string.Empty;
        }
    }

    internal class CollisionModeConverter : IEnumConverter<CollisionMode>
    {
        public string GetString(CollisionMode value)
        {
            switch (value)
            {
                case CollisionMode.AllowCollisions:
                    return "Allow overlaps";
                case CollisionMode.LocalList:
                    return "Avoid point vs point overlaps";
                case CollisionMode.GlobalList:
                    return "Avoid point vs label overlaps";
            }

            return string.Empty;
        }
    }
}
