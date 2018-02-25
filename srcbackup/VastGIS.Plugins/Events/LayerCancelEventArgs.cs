using System;
using System.ComponentModel;

namespace VastGIS.Plugins.Events
{
    public class LayerCancelEventArgs: CancelEventArgs
    {
        public LayerCancelEventArgs(int layerHandle)
        {
            LayerHandle = layerHandle;
            if (layerHandle == -1)
            {
                throw new ApplicationException("Invalid layer handle.");
            }
        }

        public int LayerHandle { get; private set; }
    }
}
