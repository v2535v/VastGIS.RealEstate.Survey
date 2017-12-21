using System;
using AxMapWinGIS;
using VastGIS.Api.Enums;

namespace VastGIS.Api.Events
{
    public class AfterShapeEditEventArgs: EventArgs
    {
        private readonly _DMapEvents_AfterShapeEditEvent _args;

        internal AfterShapeEditEventArgs(_DMapEvents_AfterShapeEditEvent args)
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

        public UndoOperation Operation
        {
            get { return (UndoOperation)_args.operation; }
        }

        public int ShapeIndex
        {
            get { return _args.shapeIndex; }
        }
    }
}
