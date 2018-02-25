﻿// -------------------------------------------------------------------------------------------
// <copyright file="QueryBuilderModel.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Api.Interfaces;

namespace VastGIS.Attributes.Views
{
    public class QueryBuilderModel
    {
        public QueryBuilderModel(ILayer layer, string expression, bool query = true)
        {
            if (layer == null) throw new ArgumentNullException("layer");

            Layer = layer;
            Expression = expression;
            IsQuery = query;
        }

        public bool IsQuery { get; private set; }

        public string Expression { get; set; }

        public ILayer Layer { get; private set; }
    }
}