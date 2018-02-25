// -------------------------------------------------------------------------------------------
// <copyright file="PageSelectionEventArgs.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;

namespace VastGIS.Plugins.Printing.Model
{
    public class PageSelectionEventArgs : EventArgs
    {
        public int Count;
        public int Selected;
    }
}