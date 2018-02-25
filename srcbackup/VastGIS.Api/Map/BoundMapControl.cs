using System;
using System.ComponentModel;
using MapWinGIS;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Shared;

namespace VastGIS.Api.Map
{
    public class BoundMapControl : MapControl, IMap
    {
        private ILayerCollection<ILayer> _layers;
        private CustomCursor _customCursor;

        public BoundMapControl()
        {
           // Logger.Current.Trace("In BoundMapControl");
            MapCursorChanged += BoundMapControl_MapCursorChanged;
        }

        void BoundMapControl_MapCursorChanged(object sender, EventArgs e)
        {
            if (MapCursor != MapCursor.None)
            {
                _customCursor = null;
                _map.MapCursor = tkCursor.crsrMapDefault;
            }
        }

        [Browsable(false)]
        public IMuteLegend Legend { get; set; }

        [Browsable(false)]
        public new ILayerCollection<ILayer> Layers
        {
            get
            {
                if (Legend == null)
                {
                    throw new NullReferenceException(
                        "MapControl.Legend property should be set before acceccing layers collection.");
                }

                return _layers ?? (_layers = new LayerCollection<ILayer>(this, Legend));
            }
        }

        public ILayer GetLayer(int layerHandle)
        {
            return Layers.ItemByHandle(layerHandle);
        }

        public IFeatureSet GetFeatureSet(int layerHandle)
        {
            var layer = GetLayer(layerHandle);
            if (layer != null)
            {
                return layer.FeatureSet;
            }
            return null;
        }

        public IImageSource GetImage(int layerHandle)
        {
            var layer = GetLayer(layerHandle);
            if (layer != null)
            {
                return layer.ImageSource;
            }
            return null;
        }

        public CustomCursor CustomCursor
        {
            get
            {
                return _customCursor;
            }
            set
            {
                _customCursor = value;

                if (value != null && value.Guid != default(Guid))
                {
                    if (_customCursor.Cursor == null)
                    {
                        _map.MapCursor = tkCursor.crsrArrow;
                    }
                    else
                    {
                        _map.UDCursorHandle = (int)_customCursor.Cursor.Handle;
                        _map.MapCursor = tkCursor.crsrUserDefined;
                    }

                    MapCursor = MapCursor.None;
                }
            }
        }

        public bool SnapShotToDC2(
            IntPtr hDC,
            IEnvelope extents,
            int width,
            float offsetX,
            float offsetY,
            float clipX,
            float clipY,
            float clipWidth,
            float clipHeight)
        {
            return _map.SnapShotToDC2(hDC, extents.GetInternal(), width, offsetX, offsetY, clipX, clipY, clipWidth, clipHeight);
        }

        [Browsable(false)]
        public IFeatureSet SelectedFeatureSet
        {
            get
            {
                var layer = Layers.Current;
                if (layer != null)
                {
                    return layer.FeatureSet;
                }
                return null;
            }
        }

        [Browsable(false)]
        public IImageSource SelectedImage
        {
            get
            {
                var layer = Layers.Current;
                if (layer != null)
                {
                    return layer.ImageSource;
                }
                return null;
            }
        }

        [Browsable(false)]
        public IVectorLayer SelectedVectorLayer
        {
            get
            {
                var layer = Layers.Current;
                if (layer != null)
                {
                    return layer.VectorSource;
                }
                return null;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoundMapControl));
            VastGIS.Api.Concrete.Envelope envelope1 = new VastGIS.Api.Concrete.Envelope();
            VastGIS.Api.Concrete.SpatialReference spatialReference1 = new VastGIS.Api.Concrete.SpatialReference();
            ((System.ComponentModel.ISupportInitialize)(this._map)).BeginInit();
            this.SuspendLayout();
            // 
            // _map
            // 
            this._map.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("_map.OcxState")));
            this._map.Size = new System.Drawing.Size(308, 174);
            // 
            // BoundMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.CurrentScale = 21.721422731034483D;
            envelope1.Tag = "";
            this.Extents = envelope1;
            this.Name = "BoundMapControl";
            spatialReference1.Tag = "";
            this.Projection = spatialReference1;
            ((System.ComponentModel.ISupportInitialize)(this._map)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
