﻿// -------------------------------------------------------------------------------------------
// <copyright file="ProjectionMismatchModel.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;

namespace VastGIS.Projections.Views
{
    public class ProjectionMismatchModel
    {
        public ProjectionMismatchModel(ILayerSource layerSource, bool isMismatch, ISpatialReference projectProj)
        {
            if (layerSource == null) throw new ArgumentNullException("layerSource");

            IsMismatch = isMismatch;
            ProjectProjection = projectProj;
            LayerSource = layerSource;
        }

        public ProjectionAbsence AbsenceBehavior { get; set; }

        public bool DontShow { get; set; }

        public bool IsMismatch { get; private set; }

        public ILayerSource LayerSource { get; private set; }

        public ProjectionMismatch MismatchBehavior { get; set; }

        public ISpatialReference ProjectProjection { get; private set; }

        public bool UseAnswerLater { get; set; }
    }
}