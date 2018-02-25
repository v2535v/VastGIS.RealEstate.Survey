﻿using System;
using AxMapWinGIS;
using MapWinGIS;

namespace VastGIS.Api.Events
{
    public class ProjectionMismatchEventArgs: EventArgs
    {
        private readonly _DMapEvents_ProjectionMismatchEvent _args;

        internal ProjectionMismatchEventArgs(_DMapEvents_ProjectionMismatchEvent args)
        {
            _args = args;
            if (args == null)
            {
                throw new NullReferenceException("Internal reference is null.");
            }
        }

        public bool CancelAdding
        {
            get { return _args.cancelAdding == tkMwBoolean.blnTrue; }
            set { _args.cancelAdding = value ? tkMwBoolean.blnTrue : tkMwBoolean.blnFalse; }
        }

        public bool Reproject
        {
            get { return _args.reproject == tkMwBoolean.blnTrue; }
            set { _args.reproject = value ? tkMwBoolean.blnTrue : tkMwBoolean.blnFalse; }
        }

        public int LayerHandle
        {
            get { return _args.layerHandle; }
        }
    }
}
