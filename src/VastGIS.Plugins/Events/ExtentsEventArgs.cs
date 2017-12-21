using System;
using VastGIS.Api.Interfaces;

namespace VastGIS.Plugins.Events
{
    public class ExtentsEventArgs: EventArgs
    {
        private readonly IEnvelope _extents;

        public ExtentsEventArgs(IEnvelope extents)
        {
            _extents = extents;
        }

        public IEnvelope Extents
        {
            get { return _extents; }
        }
    }
}
