﻿// -------------------------------------------------------------------------------------------
// <copyright file="FieldAdapter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Api.Interfaces;

namespace VastGIS.Plugins.Symbology.Model
{
    /// <summary>
    /// A wrapper for field selection in label style dialog.
    /// </summary>
    internal class FieldAdapter
    {
        private readonly string _message = string.Empty;

        public FieldAdapter(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg)) throw new ArgumentNullException("msg");
            _message = msg;
        }

        public FieldAdapter(IAttributeField fld)
        {
            if (fld == null) throw new ArgumentNullException("fld");
            Field = fld;
        }

        public bool Empty
        {
            get { return Field == null; }
        }

        public IAttributeField Field { get; private set; }

        public override string ToString()
        {
            return Empty ? _message : Field.Name;
        }
    }
}