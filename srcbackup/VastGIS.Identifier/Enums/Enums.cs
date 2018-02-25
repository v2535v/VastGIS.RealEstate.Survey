﻿namespace VastGIS.Plugins.Identifier.Enums
{
    public enum IdentifierCommand
    {
        Clear = 0,
    }

    public enum IdentifierIcon
    {
        None= -1,
        Point = 0,
        Line = 1,
        Polygon = 2,
        Calculated = 3,
        Raster = 4,
        Field = 5,
    }

    public enum IdentifierNodeType
    {
        Layer = 0,
        Geometry = 1,
        Attribute = 2,
        Pixel = 3,
    }
}
