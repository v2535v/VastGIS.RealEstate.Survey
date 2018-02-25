using System;

namespace VastGIS.Plugins.RealEstate.Viewer
{
    public class ImageViewerRotationEventArgs : EventArgs
    {
        private int rotation;
        public int Rotation
        {
            get { return rotation; }
        }

        public ImageViewerRotationEventArgs(int rotation)
        {
            this.rotation = rotation;
        }
    }
}