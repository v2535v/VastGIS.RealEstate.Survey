using System;
using System.Collections.Generic;
using VastGIS.Api.Enums;
using VastGIS.Shared.Log;

namespace VastGIS.Api.Interfaces
{
    // at least to prevent adding types that are not suppported
    public interface IDatasource: IComWrapper, IDisposable
    {
        string Name { get;}

        string Filename { get; }

        void Close();

        string OpenDialogFilter { get; }

        LayerType LayerType { get; }

        string ToolTipText { get; }

        bool IsVector { get; }

        bool IsRaster { get; }

        IGlobalListener Callback { get; set; }
    }
}
