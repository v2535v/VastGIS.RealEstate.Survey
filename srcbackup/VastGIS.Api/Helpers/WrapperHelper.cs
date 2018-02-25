﻿using AxMapWinGIS;
using MapWinGIS;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Map;
using VastGIS.Api.Static;

namespace VastGIS.Api.Helpers
{
    public static class WrapperHelper
    {
        internal static ShapefileCategory GetInternal(this IFeatureCategory category)
        {
            return category.InternalObject as ShapefileCategory;
        }

        public static ColorScheme GetInternal(this ColorRamp ramp)
        {
            return ramp.InternalObject as ColorScheme;
        }

        public static Shape GetInternal(this IGeometry geometry)
        {
            return geometry.InternalObject as Shape;
        }

        public static Point GetInternal(this ICoordinate point)
        {
            return point.InternalObject as Point;
        }

        public static GeoProjection GetInternal(this ISpatialReference spatialReference)
        {
            return spatialReference.InternalObject as GeoProjection;
        }

        public static Extents GetInternal(this IEnvelope envelope)
        {
            return envelope.InternalObject as Extents;
        }

        public static Image GetInternal(this IImageSource image)
        {
            return image.InternalObject as Image;
        }

        public static Field GetInternal(this IAttributeField field)
        {
            return field.InternalObject as Field;
        }

        public static LabelCategory GetInternal(this ILabelStyle style)
        {
            return style.InternalObject as LabelCategory;
        }

        public static ShapeDrawingOptions GetInternal(this IGeometryStyle style)
        {
            return style.InternalObject as ShapeDrawingOptions;
        }

        public static Shapefile GetInternal(this IFeatureSet featureSet)
        {
            return featureSet.InternalObject as Shapefile;
        }

        public static GridHeader GetInternal(this GridSourceHeader header)
        {
            return header.InternalObject as GridHeader;
        }

        public static GridColorScheme GetInternal(this RasterColorScheme colorScheme)
        {
            return colorScheme.InternalObject as GridColorScheme;
        }

        public static GridColorBreak GetInternal(this RasterInterval interval)
        {
            return interval.InternalObject as GridColorBreak;
        }

        public static Vector GetInternal(this Vector3D interval)
        {
            return interval.InternalObject as Vector;
        }
        
        public static ChartField GetInternal(this DiagramField interval)
        {
            return interval.InternalObject as ChartField;
        }

        public static LineSegment GetInternal(this SimpleLine interval)
        {
            return interval.InternalObject as LineSegment;
        }

        public static LinePattern GetInternal(this CompositeLine interval)
        {
            return interval.InternalObject as LinePattern;
        }

        public static FieldStatOperations GetInternal(this FieldOperationList operations)
        {
            return operations.InternalObject as FieldStatOperations;
        }

        public static Grid GetInternal(this IGridSource grid)
        {
            return grid.InternalObject as Grid;
        }

        public static Table GetInternal(this IAttributeTable table)
        {
            return table.InternalObject as Table;
        }

        public static AxMap GetInternal(this MapControl mapControl)
        {
            return mapControl.InternalObject as AxMap;
        }

        public static WmsLayer GetInternal(this WmsSource provider)
        {
            return provider.InternalObject as WmsLayer;
        }

        public static Utils GetInternal(this GisUtils utils)
        {
            return utils.InternalObject as Utils;
        }
    }
}
