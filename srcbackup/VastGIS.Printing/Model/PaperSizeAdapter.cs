﻿// -------------------------------------------------------------------------------------------
// <copyright file="PaperSizeAdapter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing.Printing;

namespace VastGIS.Plugins.Printing.Model
{
    internal class PaperSizeAdapter
    {
        private readonly PaperSize _size;

        public PaperSizeAdapter(PaperSize paperSize)
        {
            if (paperSize == null) throw new ArgumentNullException("paperSize");
            _size = paperSize;
        }

        public PaperSize Item
        {
            get { return _size; }
        }

        public string PaperName
        {
            get { return _size.PaperName; }
        }

        public override string ToString()
        {
            return string.Format("{0} [{1}×{2}]", _size.PaperName, _size.Width, _size.Height);
        }
    }
}