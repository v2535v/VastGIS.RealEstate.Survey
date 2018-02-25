﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Shared
{
    public static class DebugHelper
    {
        public static bool HideAdditionalMapControls = false;
        public static bool SyncfusionMenu = true;
        public static bool ShowDebugMenuElements = false;
        public static bool CleanTileCache = false;
        public static bool LoadToolDocumentation = true;
        public static bool DrawTilesGrid = false;

        static DebugHelper()
        {
#if DEBUG
        DrawTilesGrid = false;
        LoadToolDocumentation = false;
#endif
        }
    }
}
