using System;

namespace VastGIS.Plugins.RealEstate.Viewer
{
    public class ImageViewerZoomEventArgs : EventArgs
    {
        private int zoom;
        public int Zoom
        {
            get { return zoom; }
        }

        private KpZoom inOut;
        public KpZoom InOut
        {
            get { return inOut; }
        }

        public ImageViewerZoomEventArgs(double zoom, KpZoom inOut)
        {
            this.zoom = Convert.ToInt32(Math.Round((zoom * 100), 0));
            this.inOut = inOut;
        }
    }
}