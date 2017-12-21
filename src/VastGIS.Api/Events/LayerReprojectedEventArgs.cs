using System;
using AxMapWinGIS;

namespace VastGIS.Api.Events
{
    public class LayerReprojectedEventArgs: EventArgs
    {
        private readonly _DMapEvents_LayerReprojectedEvent _args;

        internal LayerReprojectedEventArgs(_DMapEvents_LayerReprojectedEvent args)
        {
            _args = args;
            if (args == null)
            {
                throw new NullReferenceException("Internal reference is null.");
            }
        }

        public int LayerHandle
        {
            get { return _args.layerHandle; }
        }

        public bool Succes
        {
            get { return _args.success; }
        }
    }
}
