﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MapWinGIS;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Events;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Api.Map;

namespace VastGIS.Api.Interfaces
{
    public interface IMuteMap: IComWrapper, IPrintableMap
    {
        // TODO: revisit
        //ISpatialReference Projection { get; set; }
        //IEnvelope Extents { get; }
        //bool ScalebarVisible { get; set; }
        //void Lock();
        //bool Unlock();
        //bool SnapShotToDC2(IntPtr hDC, IEnvelope extents, int width, float offsetX, float offsetY, float clipX, float clipY, float clipWidth, float clipHeight);
        //LengthUnits MapUnits { get; set; }
        //ILayerCollection<ILayer> Layers { get; }

        IShapesList IdentifiedShapes { get; }
        IFeatureSet SelectedFeatureSet { get; }
        IImageSource SelectedImage { get; }
        IVectorLayer SelectedVectorLayer { get; }
        IMuteLegend Legend { get; set; }
        MapProjection MapProjection { get; set; }
        ZoomBarSettings ZoomBar { get;  }
        ScalebarUnits ScalebarUnits { get; set; }
        double CurrentScale { get; set; }
        int CurrentZoom { get; set; }
        KnownExtents KnownExtents { get; set; }
        float Latitude { get; set; }
        float Longitude { get; set; }
        SystemCursor SystemCursor { get; set; }
        MapCursor MapCursor { get; set; }
        TileProvider TileProvider { get; set; }
        ILayer GetLayer(int layerHandle);
        IFeatureSet GetFeatureSet(int layerHandle);
        IImageSource GetImage(int layerHandle);
        AngleFormat ShowCoordinatesFormat { get; set; }
        IEnvelope GeographicExtents { get; }
        bool SetGeographicExtents(IEnvelope pVal);
        bool SetGeographicExtents2(double xLongitude, double yLatitude, double widthKilometers);

        void ZoomIn();
        void ZoomOut();
        void ZoomIn(double percent);
        void ZoomOut(double percent);
        void ZoomToLayer(int layerHandle);
        void ZoomToExtents(IEnvelope extents);
        void ZoomToMaxExtents();
        void ZoomToMaxVisibleExtents();
        int ZoomToPrev();
        int ZoomToNext();
        bool ZoomToSelected(int layerHandle);
        void ZoomToShape(int layerHandle, int shape);
        bool ZoomToTileLevel(int zoom);
        bool ZoomToWorld();

        bool PixelToDegrees(double pixelX, double pixelY, out double degreesLngX, out double degreesLatY);
        void PixelToProj(double pixelX, double pixelY, out double projX, out double projY);
        bool ProjToDegrees(double projX, double projY, out double degreesLngX, out double degreesLatY);
        void ProjToPixel(double projX, double projY, out double pixelX, out double pixelY);
        bool DegreesToPixel(double degreesLngX, double degreesLatY, out double pixelX, out double pixelY);
        bool DegreesToProj(double degreesLngX, double degreesLatY, out double projX, out double projY);

        IGeometryEditor GeometryEditor { get; }
        //TileManager Tiles { get; }
        IdentifierSettings Identifier { get; }
        MeasuringTool Measuring { get; }
        HistoryList History { get; }
        DrawingLayers Drawing { get; }

        AutoToggle AnimationOnZooming { get; set; }
        int ExtentHistory { get; set; }
        double ExtentPad { get; set; }
        bool GrabProjectionFromData { get; set; }
        AutoToggle InertiaOnPanning { get; set; }
        bool IsLocked { get; }
        ResizeBehavior ResizeBehavior { get; set; }
        IEnvelope MaxExtents { get; }
        double MouseWheelSpeed { get; set; }
        bool ReuseTileBuffer { get; set; }
        ZoomBehavior ZoomBehavior { get; set; }
        void SetDefaultExtents();

        double ZoomPercent { get; set; }
        CoordinatesDisplay ShowCoordinates { get; set; }
        bool ShowRedrawTime { get; set; }
        bool ShowVersionNumber { get; set; }
        int UdCursorHandle { get; set; }
        bool UseSeamlessPan { get; set; }
        string VersionNumber { get; }
        IEnvelope GetKnownExtents(KnownExtents extents);

     
        void Redraw(RedrawType redrawType = RedrawType.All);
        void Redraw(RedrawType redrawType, bool reloadTiles);
        void Clear();
        void Undo();
        bool FindSnapPoint(double tolerance, double xScreen, double yScreen, ref double xFound, ref double yFound);

        double GeodesicArea(IGeometry polygon);
        double GeodesicDistance(double projX1, double projY1, double projX2, double projY2);
        double GeodesicLength(IGeometry polyline);

        IImageSource SnapShot(IEnvelope boundBox);
        IImageSource SnapShot(int clippingLayerHandle, double zoom, int width);
        IImageSource SnapShot(IEnvelope boundBox, int width);

        IntPtr Handle { get; }

        int Width { get; }
        int Height { get;  }

        CustomCursor CustomCursor { get; set; }

        DecorationRectangle FocusRectangle { get; }

        bool LoadMapState(string filename);

        ZoomBoxStyle ZoomBoxStyle { get; set; }

        Color BackgroundColor { get; set; }

        int ExtentHistoryUndoCount { get; }

        int ExtentHistoryRedoCount { get; }

        void ClearExtentHistory();

        void StartCustomSelectionMode(Guid clientId);

        void StopCustomSelectionMode();

        bool IsCustomSelectionMode { get; }

        bool GetIsCustomSelectionMode(Guid clientId);

        //void SetTileProvider(int providerId);

        bool IsEmpty { get; }

        #region Not implemented

        //event _DMapEvents_SelectBoxDragEventHandler SelectBoxDrag;
        //event _DMapEvents_AfterDrawingEventHandler AfterDrawing;
        //event _DMapEvents_BeforeDrawingEventHandler BeforeDrawing;
        //event _DMapEvents_MapStateEventHandler MapState;
        //event _DMapEvents_OnDrawBackBufferEventHandler OnDrawBackBuffer;

        //bool SendMouseDown { get; set; }
        //bool SendMouseMove { get; set; }
        //bool SendMouseUp { get; set; }
        //bool SendOnDrawBackBuffer { get; set; }
        //bool SendSelectBoxDrag { get; set; }
        //bool SendSelectBoxFinal { get; set; }

        // bool SetImageLayerColorScheme(int layerHandle, object colorScheme);
        // void DrawBackBuffer(IntPtr hDC, int imageWidth, int imageHeight);
        // double PixelsPerDegree { get; }
        //bool DisableWaitCursor { get; set; }
        // object GetColorScheme(int layerHandle);
        // int HWnd();
        // void Resize(int width, int height);
        // bool SaveMapState(string filename, bool relativePaths, bool overwrite);
        // string SerializeMapState(bool relativePaths, string basePath);
        // void ShowToolTip(string text, int milliseconds);
        //  FileManager FileManager { get; }
        // bool DeserializeMapState(string state, bool loadLayers, string basePath);
        //bool TrapRMouseDown { get; set; }
        // bool SnapShotToDC(IntPtr hDC, Extents extents, int width);
        //tkZoomBoxStyle ZoomBoxStyle { get; set; }

        #endregion
    }
}