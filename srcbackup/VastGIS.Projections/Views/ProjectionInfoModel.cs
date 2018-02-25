﻿// -------------------------------------------------------------------------------------------
// <copyright file="ProjectionInfoModel.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces.Projections;
using VastGIS.Projections.BL;

namespace VastGIS.Projections.Views
{
    public class ProjectionInfoModel
    {
        private BindingList<ProjectionDialect> _dialects;

        public ProjectionInfoModel(ISpatialReference sr)
        {
            if (sr == null) throw new ArgumentNullException("sr");
            SpatialReference = sr;
        }

        public ProjectionInfoModel(ICoordinateSystem cs)
        {
            if (cs == null) throw new ArgumentNullException("cs");
            CoordinateSystem = cs;
        }

        public ICoordinateSystem CoordinateSystem { get; private set; }

        public IList<ProjectionDialect> Dialects
        {
            get { return _dialects; }
        }

        public ISpatialReference SpatialReference { get; private set; }

        public bool LoadDialects(IProjectionDatabase db)
        {
            if (db == null) return false;

            if (CoordinateSystem != null)
            {
                db.ReadDialects(CoordinateSystem);
                var list = CoordinateSystem.Dialects.Select(d => new ProjectionDialect(d)).ToList();
                _dialects = new BindingList<ProjectionDialect>(list);
                return true;
            }

            return false;
        }
    }
}