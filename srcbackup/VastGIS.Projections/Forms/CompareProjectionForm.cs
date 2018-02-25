﻿// -------------------------------------------------------------------------------------------
// <copyright file="CompareProjectionForm.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Interfaces.Projections;
using VastGIS.Projections.Helpers;
using VastGIS.UI.Forms;

namespace VastGIS.Projections.Forms
{
    public partial class CompareProjectionForm : MapWindowForm
    {
        /// <summary>
        /// Creates a new instance of the frmProjectionCompare class
        /// </summary>
        public CompareProjectionForm(IAppContext context, ISpatialReference projectProj, ISpatialReference layerProj)
            : base(context)
        {
            if (context == null) throw new ArgumentNullException("context");
            InitializeComponent();

            var layerProj1 = layerProj;

            lblProject.Text = @"Project: " + projectProj.Name;
            lblLayer.Text = @"Layer: " + layerProj.Name;

            txtProject.Text = projectProj.ExportToProj4();
            txtLayer.Text = layerProj.ExportToProj4();

            btnLayer.Click += (s, e) => ShowProjectionProperties(layerProj1);
            btnProject.Click += (s, e) => ShowProjectionProperties(layerProj1);
        }

        private void CompareProjectionForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        /// <summary>
        /// Shows properties for the selected projection
        /// </summary>
        private void ShowProjectionProperties(ISpatialReference proj)
        {
            if (proj == null || proj.IsEmpty)
            {
                return;
            }

            ICoordinateSystem cs = null;
            if (_context.Projections != null)
            {
                cs = _context.Projections.GetCoordinateSystem(proj, ProjectionSearchType.Enhanced);
            }

            if (cs != null)
            {
                _context.ShowProjectionProperties(cs, this);
            }
            else
            {
                _context.ShowProjectionProperties(proj, this);
            }
        }
    }
}