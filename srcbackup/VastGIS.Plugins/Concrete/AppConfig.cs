// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppConfig.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   Defines the AppConfig type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Static;
using VastGIS.Plugins.Enums;
using VastGIS.Shared;

namespace VastGIS.Plugins.Concrete
{
    [DataContract(Name = "Settings")]
    public class AppConfig
    {
        private List<Guid> _applicationPlugins;
        private CoordinatesDisplay _coordinatesDisplay;
        private List<int> _favoriteProjections;
        private List<string> _recentProjects;

        public AppConfig()
        {
            SetDefaults();
        }

        public static AppConfig Instance { get; internal set; }

        [DataMember]
        public AutoToggle AnimationOnZooming { get; set; }

        [DataMember]
        public List<Guid> ApplicationPlugins
        {
            get { return _applicationPlugins ?? (_applicationPlugins = DefaultApplicationPlugins); }
            set { _applicationPlugins = value; }
        }

        [DataMember]
        public string BingApiKey { get; set; }

        [DataMember]
        public bool CacheDbfRecords
        {
            get { return MapConfig.CacheDbfRecords; }
            set { MapConfig.CacheDbfRecords = value; }
        }

        [DataMember]
        public bool CacheRenderingData
        {
            get { return MapConfig.CacheRenderingData; }
            set { MapConfig.CacheRenderingData = value; }
        }

        [DataMember]
        public AngleFormat CoordinateAngleFormat { get; set; }

        [DataMember]
        public int CoordinatePrecision { get; set; }

        [DataMember]
        public CoordinatesDisplay CoordinatesDisplay
        {
            get { return _coordinatesDisplay == CoordinatesDisplay.None ? CoordinatesDisplay.Auto : _coordinatesDisplay; }
            set { _coordinatesDisplay = value == CoordinatesDisplay.None ? CoordinatesDisplay.Auto : value; }
        }

        [DataMember]
        public bool CreatePyramidsOnOpening { get; set; }

        [DataMember]
        public bool CreateSpatialIndexOnOpening { get; set; }
        
        public List<Guid> DefaultApplicationPlugins
        {
            [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1500:CurlyBracketsForMultiLineStatementsMustNotShareLine", Justification = "Reviewed. Suppression is OK here.")]
            get
            {
                //return new List<Guid> { };
                return new List<Guid> { new Guid("F05CCFAF-26BB-4656-BBE2-0F5E3C7AD0FB"), // Symbology
                                        //new Guid("D241C820-4B27-4954-8BA1-5A0B1DC25F7B"), // Repository
                                        new Guid("6AC34207-254E-48DF-A0A1-01C2C9D9B936"), // Identifier
                                        //new Guid("F9C021D3-2BD7-4591-9BFB-235DEC812222"), // Table editor
                                        //new Guid("22729F63-6D97-48DB-9F51-1B46BB8AFEF1"), // Shape editor
                                        //new Guid("B714AD79-8AFC-41D2-BB96-0C83BA242B7D"), // Debug window
                                        //new Guid("241E5643-8935-4A79-9DD2-745954AD74FA"), // GIS Toolbox
                                        //new Guid("C82AE4FD-4BB2-48EF-A58D-B7E5449B1A27")  // Print lay-out
                                      };
            }
        }

        [DataMember]
        public bool DisplayDynamicVisibilityWarnings { get; set; }

        /// <summary>
        /// List of EPSG codes for favorite projections
        /// </summary>
        [DataMember]
        public List<int> FavoriteProjections
        {
            get { return _favoriteProjections ?? (_favoriteProjections = new List<int>()); }
            set { _favoriteProjections = value; }
        }

        [DataMember]
        public bool FirstRun { get; set; }

        [DataMember]
        public PredefinedColors GridDefaultColorScheme { get; set; }

        [DataMember]
        public bool GridFavorGreyscale { get; set; }

        [DataMember]
        public bool GridRandomColorScheme { get; set; }

        [DataMember]
        public bool GridUseHistogram { get; set; }

        [DataMember]
        public IdentifierMode IdentifierMode { get; set; }

        [DataMember]
        public AutoToggle InnertiaOnPanning { get; set; }

        [DataMember]
        public string LastConfigPage { get; set; }

        [DataMember]
        public string LastProjectPath { get; set; }

        [DataMember]
        public bool LegendExpandLayersOnAdding { get; set; }

        [DataMember]
        public bool LoadLastProject { get; set; }

        [DataMember]
        public bool LoadSymbology { get; set; }

        [DataMember]
        public bool LocalDocumentation { get; set; }

        [DataMember]
        public Color MapBackgroundColor { get; set; }

        [DataMember]
        public string MeasurementsAreaFieldName { get; set; }

        [DataMember]
        public int MeasurementsAreaPrecision { get; set; }

        [DataMember]
        public AreaUnits MeasurementsAreaUnits { get; set; }

        [DataMember]
        public int MeasurementsAreaWidth { get; set; }

        [DataMember]
        public string MeasurementsLengthFieldName { get; set; }

        [DataMember]
        public int MeasurementsLengthPrecision { get; set; }

        [DataMember]
        public LengthUnits MeasurementsLengthUnits { get; set; }

        [DataMember]
        public int MeasurementsLengthWidth { get; set; }

        [DataMember]
        public string MeasurementsPerimeterFieldName { get; set; }

        [DataMember]
        public AngleFormat MeasuringAngleFormat { get; set; }

        [DataMember]
        public int MeasuringAnglePrecision { get; set; }

        [DataMember]
        public int MeasuringAreaPrecision { get; set; }

        [DataMember]
        public AreaDisplay MeasuringAreaUnits { get; set; }

        [DataMember]
        public BearingType MeasuringBearingType { get; set; }

        [DataMember]
        public Color MeasuringFillColor { get; set; }

        [DataMember]
        public byte MeasuringFillTransparency { get; set; }

        [DataMember]
        public int MeasuringLengthPrecision { get; set; }

        [DataMember]
        public LengthDisplay MeasuringLengthUnits { get; set; }

        [DataMember]
        public Color MeasuringLineColor { get; set; }

        [DataMember]
        public DashStyle MeasuringLineStyle { get; set; }

        [DataMember]
        public int MeasuringLineWidth { get; set; }

        [DataMember]
        public bool MeasuringPointLabelsVisible { get; set; }

        [DataMember]
        public bool MeasuringPointsVisible { get; set; }

        [DataMember]
        public bool MeasuringShowBearing { get; set; }

        [DataMember]
        public bool MeasuringShowLength { get; set; }

        [DataMember]
        public bool MeasuringShowTotalLength { get; set; }

        [DataMember]
        public MouseWheelDirection MouseWheelDirection { get; set; }

        [DataMember]
        public int MouseTolerance { get; set; }

        [DataMember]
        public string MsSqlServer { get; set; }

        [DataMember]
        public string MsSqlDatabase { get; set; }

        [DataMember]
        public string MsSqlUser { get; set; }

        [DataMember]
        public bool MsSqlUseNativeAuthentication { get; set; }

        [DataMember]
        public int OgrMaxFeatureCount { get; set; }

        [DataMember]
        public bool OgrShareConnection { get; set; }

        [DataMember]
        public bool OverviewBackgroundVisible { get; set; }

        [DataMember]
        public int PrintingUnits { get; set; }

        [DataMember]
        public Margins PrintingMargins { get; set; }

        [DataMember]
        public Orientation PrintingOrientation { get; set; }

        [DataMember]
        public string PrintingPaperFormat { get; set; }

        [DataMember]
        public string PrintingTemplate { get; set; }

        [DataMember]
        public ProjectionAbsence ProjectionAbsence { get; set; }

        [DataMember]
        public ProjectionMismatch ProjectionMismatch { get; set; }

        [DataMember]
        public bool ProjectionShowLoadingReport { get; set; }

        [DataMember]
        public TiffCompression PyramidCompression { get; set; }

        [DataMember]
        public RasterOverviewSampling PyramidSampling { get; set; }

        [DataMember]
        public bool QueryBuilderShowValue { get; set; }

        [DataMember]
        public SelectionOperation QueryBuilderSelectionOperation { get; set; }

        [DataMember]
        public InterpolationType RasterDownsamplingMode { get; set; }

        [DataMember]
        public InterpolationType RasterUpsamplingMode { get; set; }

        [DataMember]
        public List<string> RecentProjects
        {
            get { return _recentProjects ?? (_recentProjects = new List<string>()); }
            set { _recentProjects = value; }
        }

        [DataMember]
        public ResizeBehavior ResizeBehavior { get; set; }

        [DataMember]
        public bool ReuseTileBuffer { get; set; }

        [DataMember]
        public ScalebarUnits ScalebarUnits { get; set; }

        [DataMember]
        public bool ShapeEditorShowLabels { get; set; }

        [DataMember]
        public bool ShapeEditorShowAttributeDialog { get; set; }

        [DataMember]
        public bool ShapeEditorShowBearing { get; set; }
        
        [DataMember]
        public BearingType ShapeEditorBearingType { get; set; }

        [DataMember]
        public int ShapeEditorBearingPrecision {get; set; }

        [DataMember]
        public AngleFormat ShapeEditorAngleFormat { get; set; }

        [DataMember]
        public bool ShapeEditorShowLength { get; set; }

        [DataMember]
        public bool ShapeEditorShowArea { get; set; }

        [DataMember]
        public LengthDisplay ShapeEditorUnits { get; set; }

        [DataMember]
        public int ShapeEditorUnitPrecision { get; set; }

        [DataMember]
        public bool ShowCoordinates { get; set; }

        [DataMember]
        public bool ShowMenuToolTips { get; set; }

        [DataMember]
        public bool ShowPluginInToolTip { get; set; }

        [DataMember]
        public bool ShowProjectionAbsenceDialog { get; set; }

        [DataMember]
        public bool ShowProjectionMismatchDialog { get; set; }

        [DataMember]
        public bool ShowPyramidDialog { get; set; }

        [DataMember]
        public bool ShowRedrawTime { get; set; }

        [DataMember]
        public bool ShowScalebar { get; set; }

        [DataMember]
        public bool ShowSpatialIndexDialog { get; set; }

        [DataMember]
        public bool ShowValuesOnMouseMove { get; set; }

        [DataMember]
        public bool ShowWelcomeDialog { get; set; }

        [DataMember]
        public bool ShowZoombar { get; set; }

        [DataMember]
        public int SpatialIndexFeatureCount { get; set; }

        [DataMember]
        public SymbologyStorage SymbolobyStorage { get; set; }

        [DataMember]
        public TableEditorLayout TableEditorLayout { get; set; }

        [DataMember]
        public bool TableEditorFormatValues { get; set; }

        [DataMember]
        public bool TableEditorShowAliases { get; set; }

        [DataMember]
        public bool TaskRunInBackground { get; set; }

        [DataMember]
        public bool TilesAutoDetectProxy { get; set; }

        [DataMember]
        public string TilesDatabase { get; set; }

        [DataMember]
        public TilesMaxAge TilesMaxDiskAge { get; set; }

        [DataMember]
        public double TilesMaxDiskSize { get; set; }

        [DataMember]
        public double TilesMaxRamSize { get; set; }

        [DataMember]
        public string TilesProxyAddress { get; set; }

        [DataMember]
        public string TilesProxyPassword { get; set; }

        [DataMember]
        public string TilesProxyUserName { get; set; }

        [DataMember]
        public bool TilesUseDiskCache { get; set; }

        [DataMember]
        public bool TilesUseProxy { get; set; }

        [DataMember]
        public bool TilesUseRamCache { get; set; }

        [DataMember]
        public bool ToolOutputAddToMap { get; set; }

        [DataMember]
        public bool ToolOutputInMemory { get; set; }

        [DataMember]
        public bool ToolOutputOverwrite { get; set; }

        [DataMember]
        public bool ToolShowGdalOptionsDialog { get; set; }

        [DataMember]
        public DateTime UpdaterLastChecked { get; set; }

        [DataMember]
        public bool UpdaterIsDownloading { get; set; }

        [DataMember]
        public bool UpdaterHasNewInstaller { get; set; }

        [DataMember]
        public string UpdaterInstallername { get; set; }

        [DataMember]
        public bool WmsDiskCaching { get; set; }

        [DataMember]
        public string WmsLastServer { get; set; }

        [DataMember]
        public bool UpdaterCheckNewVersion { get; set; }

        [DataMember]
        public ZoomBarVerbosity ZoomBarVerbosity { get; set; }

        [DataMember]
        public ZoomBehavior ZoomBehavior { get; set; }

        [DataMember]
        public ZoomBoxStyle ZoomBoxStyle { get; set; }

        [DataMember]
        public string DefaultProjectPath { get; set; }

        [DataMember]
        public double RealEstateTolerance { get; set; }

        [DataMember]
        public Color RealEstateSelectedColor { get; set; }

        [DataMember]
        public Color RealEstateActivedColor { get; set; }

        public void AddRecentProject(string path)
        {
            path = path.ToLower();

            if (RecentProjects.Contains(path))
            {
                RecentProjects.Remove(path);
            }

            RecentProjects.Add(path);

            if (RecentProjects.Count > 3)
            {
                RecentProjects.RemoveAt(0);
            }
        }

        public void SetDefaults()
        {
            Logger.Current.Trace("Start AppConfig.SetDefaults()");
            AnimationOnZooming = AutoToggle.Auto;
            BingApiKey = string.Empty;
            CacheRenderingData = false;
            CacheDbfRecords = false;
            CoordinateAngleFormat = AngleFormat.Seconds;
            CoordinatesDisplay = CoordinatesDisplay.Auto;
            CoordinatePrecision = 3;
            CreatePyramidsOnOpening = true;
            CreateSpatialIndexOnOpening = true;
            DisplayDynamicVisibilityWarnings = true;
            FirstRun = true;
            GridFavorGreyscale = true;
            GridDefaultColorScheme = PredefinedColors.SummerMountains;
            GridRandomColorScheme = true;
            GridUseHistogram = true;
            IdentifierMode = IdentifierMode.AllLayersStopOnFirst;
            InnertiaOnPanning = AutoToggle.Auto;
            LastProjectPath = "";
            LegendExpandLayersOnAdding = true;
            LoadLastProject = true;
            LoadSymbology = true;
            LocalDocumentation = false;
            MapBackgroundColor = Color.White;
            MeasurementsAreaFieldName = "Area";
            MeasurementsAreaPrecision = 3;
            MeasurementsAreaUnits = AreaUnits.SquareMeters;
            MeasurementsAreaWidth = 14;
            MeasurementsLengthFieldName = "Length";
            MeasurementsLengthPrecision = 3;
            MeasurementsLengthUnits = LengthUnits.Meters;
            MeasurementsLengthWidth = 14;
            MeasurementsPerimeterFieldName = "Perimeter";
            MeasuringAngleFormat = AngleFormat.Degrees;
            MeasuringAnglePrecision = 1;
            MeasuringAreaPrecision = 1;
            MeasuringAreaUnits = AreaDisplay.Metric;
            MeasuringBearingType = BearingType.Absolute;
            MeasuringFillColor = Color.Orange;
            MeasuringFillTransparency = 100;
            MeasuringLengthPrecision = 1;
            MeasuringLengthUnits = LengthDisplay.Metric;
            MeasuringLineColor = Color.Orange;
            MeasuringLineStyle = DashStyle.Solid;
            MeasuringLineWidth = 2;
            MeasuringPointLabelsVisible = true;
            MeasuringPointsVisible = true;
            MeasuringShowBearing = true;
            MeasuringShowLength = true;
            MeasuringShowTotalLength = true;
            MouseTolerance = 10;
            MouseWheelDirection = MouseWheelDirection.Forward;
            OgrMaxFeatureCount = 50000;
            OgrShareConnection = false;
            OverviewBackgroundVisible = true;
            PrintingUnits = 0;
            PrintingMargins = new Margins(25, 25, 50, 50);
            PrintingOrientation = Orientation.Vertical;
            PrintingPaperFormat = "A4";
            PrintingTemplate = "";
            ProjectionAbsence = ProjectionAbsence.IgnoreAbsence;
            ProjectionMismatch = ProjectionMismatch.Reproject;
            ProjectionShowLoadingReport = true;
            PyramidCompression = TiffCompression.Auto;
            PyramidSampling = RasterOverviewSampling.Nearest;
            QueryBuilderShowValue = true;
            QueryBuilderSelectionOperation = SelectionOperation.New;
            RasterDownsamplingMode = InterpolationType.Bilinear;
            RasterUpsamplingMode = InterpolationType.None;
            ResizeBehavior = ResizeBehavior.KeepScale;
            ReuseTileBuffer = true;
            ScalebarUnits = ScalebarUnits.GoogleStyle;
            ShapeEditorShowLabels = true;
            ShapeEditorShowAttributeDialog = true;
            ShapeEditorShowBearing = false;
            ShapeEditorBearingType = BearingType.Absolute;
            ShapeEditorBearingPrecision = 1;
            ShapeEditorAngleFormat = AngleFormat.Degrees;
            ShapeEditorShowLength = true;
            ShapeEditorShowArea = true;
            ShapeEditorUnits = LengthDisplay.Metric;
            ShapeEditorUnitPrecision = 1;
            ShowCoordinates = true;
            ShowMenuToolTips = false;
            ShowPluginInToolTip = false; // perhaps some kind of debug mode will be enough
            ShowProjectionAbsenceDialog = true;
            ShowProjectionMismatchDialog = true;
            ShowPyramidDialog = true;
            ShowRedrawTime = false;
            ShowScalebar = true;
            ShowSpatialIndexDialog = false;
            ShowValuesOnMouseMove = true;
            ShowWelcomeDialog = true;
            ShowZoombar = true;
            SpatialIndexFeatureCount = 10000;
            SymbolobyStorage = SymbologyStorage.Project;
            TableEditorFormatValues = true;
            TableEditorLayout = TableEditorLayout.Tabbed;
            TableEditorShowAliases = true;
            TaskRunInBackground = false;
            TilesAutoDetectProxy = true;
            TilesUseRamCache = true;
            TilesMaxRamSize = 100.0;
            TilesUseDiskCache = true;
            TilesDatabase = string.Empty;
            TilesMaxDiskSize = 300.0;
            TilesMaxDiskAge = TilesMaxAge.Month3;
            TilesProxyAddress = string.Empty;
            TilesProxyPassword = string.Empty;
            TilesProxyUserName = string.Empty;
            TilesUseProxy = true;
            ToolOutputAddToMap = true;
            ToolOutputInMemory = true;
            ToolOutputOverwrite = false;
            ToolShowGdalOptionsDialog = true;
            UpdaterCheckNewVersion = true;
            UpdaterHasNewInstaller = false;
            UpdaterIsDownloading = false;
            UpdaterLastChecked = new DateTime(2015, 1, 1);
            WmsDiskCaching = true;
            WmsLastServer = string.Empty;
            ZoomBarVerbosity = ZoomBarVerbosity.Full;
            ZoomBehavior = ZoomBehavior.UseTileLevels;
            ZoomBoxStyle = ZoomBoxStyle.Blue;
            DefaultProjectPath   = @".\Projects";
            RealEstateTolerance = 1.0;
            RealEstateSelectedColor = Color.IndianRed;
            RealEstateActivedColor = Color.DodgerBlue;
            Logger.Current.Trace("End AppConfig.SetDefaults()");
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            SetDefaults();
        }
    }
}