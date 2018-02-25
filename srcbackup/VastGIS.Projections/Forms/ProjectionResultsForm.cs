﻿// -------------------------------------------------------------------------------------------
// <copyright file="ProjectionResultsForm.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.UI.Forms;

namespace VastGIS.Projections.Forms
{
    /// <summary>
    /// Displays results of assigning projection
    /// </summary>
    public partial class ProjectionResultsForm : MapWindowForm
    {
        /// <summary>
        /// Creates a new instance of the frmProjectionResults class
        /// </summary>
        public ProjectionResultsForm(IAppContext context)
            : base(context)
        {
            InitializeComponent();

            projectionMap1.LoadStateFromExeName(Application.ExecutablePath);
            projectionMap1.CoordinatesChanged += projectionMap1_CoordinatesChanged;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgv.SelectionChanged += new EventHandler(dgv_SelectionChanged);
        }

        /// <summary>
        /// Assignes selected projection and displays results
        /// </summary>
        public bool Assign(string filename, ISpatialReference proj)
        {
            var projWgs84 = new SpatialReference();
            if (!projWgs84.ImportFromEpsg(4326))
            {
                MessageService.Current.Warn("Failed to initialize WGS84 coordinate system.");
                return false;
            }

            bool sameProj = proj.IsSame(projWgs84);
            int count = 0;

            bool success = false;
            int rowIndex = dgv.Rows.Add();

            _shapefile = new FeatureSet(filename);

            Text = @"Assigning projection: " + Path.GetFileName(filename);
            lblProjection.Text = @"Projection: " + proj.Name;

            // it will be faster to assing new instance of class
            // as ImportFromEPSG() is slow according to GDAL documentation
            _shapefile.Projection.CopyFrom(proj);

            if (!sameProj)
            {
                // we can't show preview on map without reprojection
                if ((_shapefile.StartEditingShapes()))
                {
                    if (_shapefile.ReprojectInPlace(projWgs84, ref count))
                    {
                        success = true;
                    }
                }
            }
            else
            {
                success = true;
            }

            if (success)
            {
                AddShapefile(_shapefile);
                return true;
            }

            // no success in reprojection
            _shapefile.Close();
            return false;
        }

        /// <summary>
        /// Displaying selected layer on the map
        /// </summary>
        private void AddShapefile(IFeatureSet sf)
        {
            if (sf == null)
            {
                return;
            }

            _layerHandle = projectionMap1.Layers.Add(sf, true);

            var style = sf.Style;
            style.Fill.Color = Color.Orange;
            style.Fill.Transparency = 110;
            style.Line.Color = Color.Orange;
            projectionMap1.ZoomToLayer(_layerHandle);
        }

        /// <summary>
        /// Displays map coordinate when a mouse moves
        /// </summary>
        void projectionMap1_CoordinatesChanged(double x, double y, string textX, string textY)
        {
            lblX.Text = "X: " + textX + "deg.";
            lblY.Text = "Y: " + textY + "deg.";
        }

        private void ProjectionResultsForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        // TODO: rather use IDisposable
        /// <summary>
        /// Destructor. Closes all the opened shapefiles
        /// </summary>
        ~ProjectionResultsForm()
        {
            projectionMap1.Layers.Clear();
            if (_shapefile != null)
            {
                _shapefile.Close();
                _shapefile = null;
            }
            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    if (row.Tag != null)
            //    {
            //        MapWinGIS.Shapefile sf = row.Tag as MapWinGIS.Shapefile;
            //        if (sf != null)
            //        {
            //            sf.Close();
            //            sf = null;
            //        }
            //    }
            //}
        }

        #region Declarations

        // data grid view columns
        private const int CMN_FILENAME = 0;
        private const int CMN_COMMENTS = 1;

        // a handle of the reprojected layer on the map
        private int _layerHandle = -1;

        // shapefile that was reprojected
        private IFeatureSet _shapefile;

        #endregion
    }
}