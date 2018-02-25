﻿using MapWinGIS;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;

namespace VastGIS.Api.Static
{
    /// <summary>
    /// A wrapper class for MapWinGIS GlobalSettings object.
    /// </summary>
    public static class MapConfig
    {
        private static readonly GlobalSettings _settings = new GlobalSettings();

        static MapConfig()
        {
            _settings.ApplicationCallback = new GlobalNativeCallback();

            // default mode, don't expose it to API
            _settings.ShapefileFastMode = true;    
        }

        internal static void Init()
        {
            // intentionally blank; just need to call any member to execute static constructor
        }

        public static bool ShapefileFastMode
        {
            get { return _settings.ShapefileFastMode;  }
        }

        public static bool OverrideLocalCallback
        {
            get { return _settings.OverrideLocalCallback; }
            set { _settings.OverrideLocalCallback = value; }
        }

        public static void ResetGdalError()
        {
            _settings.ResetGdalError();
        }

        public static bool TestBingApiKey(string key)
        {
            return _settings.TestBingApiKey(key);
        }

        public static void SetHereMapsApiKey(string appId, string appCode)
        {
            _settings.SetHereMapsApiKey(appId, appCode);
        }

        public static GdalError GdalLastErrorNo
        {
            get { return (GdalError)_settings.GdalLastErrorNo; }
        }

        public static GdalErrorType GdalLastErrorType
        {
            get { return (GdalErrorType)_settings.GdalLastErrorType; }
        }

        public static string GdalLastErrorMsg
        {
            get { return _settings.GdalLastErrorMsg; }
        }

        public static string GdalReprojectionErrorMsg
        {
            get { return _settings.GdalReprojectionErrorMsg; }
        }

        public static string get_LocalizedString(LocalizedStrings s)
        {
            return _settings.LocalizedString[(tkLocalizedStrings)s];
        }

        public static void set_LocalizedString(LocalizedStrings s, string value)
        {
            _settings.LocalizedString[(tkLocalizedStrings)s] = value;
        }

        public static bool ZoomToFirstLayer
        {
            get { return _settings.ZoomToFirstLayer; }
            set { _settings.ZoomToFirstLayer = value; }
        }

        public static CollisionMode LabelsCollisionMode
        {
            get { return (CollisionMode)_settings.LabelsCollisionMode; }
            set { _settings.LabelsCollisionMode = (tkCollisionMode) value; }
        }

        public static GridProxyFormat GridProxyFormat
        {
            get { return (GridProxyFormat)_settings.GridProxyFormat; }
            set { _settings.GridProxyFormat = (tkGridProxyFormat)value; }
        }

        public static double MaxGridSizeMb
        {
            get { return _settings.MaxDirectGridSizeMb; }
            set { _settings.MaxDirectGridSizeMb = value; }
        }

        public static GridProxyMode GridProxyMode
        {
            get { return (GridProxyMode)_settings.GridProxyMode; }
            set { _settings.GridProxyMode = (tkGridProxyMode)value; }
        }

        public static int MaxUniqueValuesCountForGridScheme
        {
            get { return _settings.MaxUniqueValuesCountForGridScheme; }
            set { _settings.MaxUniqueValuesCountForGridScheme = value; }
        }

        public static bool RandomColorSchemeForGrids
        {
            get { return _settings.RandomColorSchemeForGrids; }
            set { _settings.RandomColorSchemeForGrids = value; }
        }

        public static PredefinedColors DefaultColorSchemeForGrids
        {
            get { return (PredefinedColors)_settings.DefaultColorSchemeForGrids; }
            set { _settings.DefaultColorSchemeForGrids = (PredefinedColorScheme)value; }
        }

        public static ValidationMode OutputValidationMode
        {
            get { return (ValidationMode)_settings.ShapeOutputValidationMode; }
            set { _settings.ShapeOutputValidationMode = (tkShapeValidationMode)value; }
        }

        public static ValidationMode InputValidationMode
        {
            get { return (ValidationMode)_settings.ShapeInputValidationMode; }
            set { _settings.ShapeInputValidationMode = (tkShapeValidationMode)value; }
        }

        public static bool SaveGridColorSchemeToFile
        {
            get { return _settings.SaveGridColorSchemeToFile; }
            set { _settings.SaveGridColorSchemeToFile = value; }
        }

        public static int MinOverviewWidth
        {
            get { return _settings.MinOverviewWidth; }
            set { _settings.MinOverviewWidth = value; }
        }

        public static RasterOverviewCreation RasterOverviewCreation
        {
            get { return (RasterOverviewCreation)_settings.RasterOverviewCreation; }
            set { _settings.RasterOverviewCreation = (tkRasterOverviewCreation)value; }
        }

        public static TiffCompression TiffCompression
        {
            get { return (TiffCompression)_settings.TiffCompression; }
            set { _settings.TiffCompression = (tkTiffCompression)value; }
        }

        public static GdalResamplingMethod RasterOverviewResampling
        {
            get { return (GdalResamplingMethod)_settings.RasterOverviewResampling; }
            set { _settings.RasterOverviewResampling = (tkGDALResamplingMethod)value; }
        }

        public static int TilesThreadPoolSize
        {
            get { return _settings.TilesThreadPoolSize; }
            set { _settings.TilesThreadPoolSize = value; }
        }

        public static bool LoadSymbologyOnAddLayer
        {
            get { return _settings.LoadSymbologyOnAddLayer; }
            set { _settings.LoadSymbologyOnAddLayer = value; }
        }

        public static InterpolationType ImageUpsamplingMode
        {
            get { return (InterpolationType)_settings.ImageUpsamplingMode; }
            set { _settings.ImageUpsamplingMode = (tkInterpolationMode)value; }
        }

        public static InterpolationType ImageDownsamplingMode
        {
            get { return (InterpolationType)_settings.ImageDownsamplingMode; }
            set { _settings.ImageDownsamplingMode = (tkInterpolationMode)value; }
        }

        public static OgrEncoding OgrEncoding
        {
            get { return (OgrEncoding)_settings.OgrStringEncoding; }
            set { _settings.OgrStringEncoding = (tkOgrEncoding)value; }
        }

        public static bool ReprojectLayersOnAdding
        {
            get { return _settings.ReprojectLayersOnAdding; }
            set { _settings.ReprojectLayersOnAdding = value; }
        }

        public static int HotTrackingMaxCount
        {
            get { return _settings.HotTrackingMaxShapeCount; }
            set { _settings.HotTrackingMaxShapeCount = value; }
        }

        public static bool AllowLayersWithoutProjections
        {
            get { return _settings.AllowLayersWithoutProjections; }
            set { _settings.AllowLayersWithoutProjections = value; }
        }

        public static bool AllowProjectionMismatch
        {
            get { return _settings.AllowProjectionMismatch; }
            set { _settings.AllowProjectionMismatch = value; }
        }

        public static double MouseTolerance
        {
            get { return _settings.MouseTolerance; }
            set { _settings.MouseTolerance = value; }
        }

        public static int MaxReprojectionCount
        {
            get { return _settings.MaxReprojectionShapeCount; }
            set { _settings.MaxReprojectionShapeCount = value; }
        }

        public static PixelOffsetMode PixelOffsetMode
        {
            get { return (PixelOffsetMode)_settings.PixelOffsetMode; }
            set { _settings.PixelOffsetMode = (tkPixelOffsetMode)value; }
        }

        public static bool AutoChooseRenderingHintForLabels
        {
            get { return _settings.AutoChooseRenderingHintForLabels; }
            set { _settings.AutoChooseRenderingHintForLabels = value; }
        }

        public static string GdalVersion
        {
            get { return _settings.GdalVersion; }
        }

        public static bool OgrLayerForceUpdateMode
        {
            get { return _settings.OgrLayerForceUpdateMode; }
            set { _settings.OgrLayerForceUpdateMode = value; }
        }

        public static bool ForceHideLabels
        {
            get { return _settings.ForceHideLabels; }
            set { _settings.ForceHideLabels = value; }
        }

        public static string GdalPluginPath
        {
            get { return _settings.GdalPluginPath; }
            set { _settings.GdalPluginPath = value; }
        }

        public static string GdalDataPath
        {
            get { return _settings.GdalDataPath; }
            set { _settings.GdalDataPath = value; }
        }

        public static string BingApiKey
        {
            get { return _settings.BingApiKey; }
            set { _settings.BingApiKey = value; }
        }

        public static string get_ComUsageReport(bool unreleasedOnly)
        {
            return new Utils().ComUsageReport[unreleasedOnly];
        }

        public static TiffCompression CompressOverviews
        {
            get { return (TiffCompression)_settings.CompressOverviews; }
            set { _settings.CompressOverviews = (tkTiffCompression)value; }
        }

        public static bool GridFavorGreyscale
        {
            get { return _settings.GridFavorGreyscale;  }
            set { _settings.GridFavorGreyscale = value; }
        }

        public static bool GridUseHistogram
        {
            get { return _settings.GridUseHistogram; }
            set { _settings.GridUseHistogram = value; }
        }

        public static bool CacheDbfRecords
        {
            get { return _settings.CacheDbfRecords;  }
            set { _settings.CacheDbfRecords = value; }
        }

        public static bool CacheRenderingData
        {
            get { return _settings.CacheShapeRenderingData; }
            set { _settings.CacheShapeRenderingData = value; }
        }

        public static bool WmsDiskCaching
        {
            get { return _settings.WmsDiskCaching; }
            set { _settings.WmsDiskCaching = value; }
        }

        public static CallbackVerbosity CallbackVerbosity
        {
            get { return (CallbackVerbosity)_settings.CallbackVerbosity; }
            set { _settings.CallbackVerbosity = (tkCallbackVerbosity)value; }
        }

        public static int OgrLayerMaxFeatureCount
        {
            get { return _settings.OgrLayerMaxFeatureCount; }
            set { _settings.OgrLayerMaxFeatureCount = value; }
        }

        public static bool OgrShareDatasources
        {
            get { return _settings.OgrShareConnection; }
            set { _settings.OgrShareConnection = value; }
        }

        #region Not implemented
        /*
        public static double MinPolygonArea
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public static double MinAreaToPerimeterRatio
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public static double ClipperGcsMultiplicationFactor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public static bool ShapefileFastMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public static bool ShapefileFastUnion
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        
        public static tkSmoothingMode LabelsSmoothingMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public static tkCompositingQuality LabelsCompositingQuality
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        
        public static int TilesMinZoomOnProjectionMismatch
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
         
        public static tkGeometryEngine GeometryEngine
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        
        
         
        public static bool AutoChooseOgrLoadingMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
         * 
         * */
        #endregion
    }
}
