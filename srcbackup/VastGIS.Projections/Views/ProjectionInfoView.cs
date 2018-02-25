﻿// -------------------------------------------------------------------------------------------
// <copyright file="ProjectionInfoView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Projections.BL;
using VastGIS.Projections.Controls;
using VastGIS.Projections.Views.Abstract;
using VastGIS.Shared;
using VastGIS.UI.Forms;
using VastGIS.UI.Helpers;
using Syncfusion.Windows.Forms.Grid;

namespace VastGIS.Projections.Views
{
    public partial class ProjectionInfoView : ProjectionInfoViewBase, IProjectionInfoView
    {
        private static int _lastTabIndex;
        private readonly IAppContext _context;

        public ProjectionInfoView(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;

            InitializeComponent();

            tabControl1.SelectedIndex = _lastTabIndex;

            FormClosed += (s, e) => _lastTabIndex = tabControl1.SelectedIndex;

            
        }

        public event Action EditDialect;

        public override void UpdateView()
        {
            btnRemoveDialect.Enabled = dialectGrid1.Adapter.SelectedItem != null;
            btnEditDialect.Enabled = dialectGrid1.Adapter.SelectedItem != null;
            btnClearDialects.Enabled = dialectGrid1.Adapter.Items.Any();

            dialectGrid1.AdjustRowHeights();
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            if (Model.CoordinateSystem != null)
            {
                LoadMapPreviewSettings();

                ShowCoordinateSystem();

                InitDialectsGrid();

                LoadDialects();
            }
            else
            {
                ShowProjection();

                _projectionMap1.Visible = false;
                linkLabel1.Visible = false;
                tabControl1.SelectedIndex = _lastTabIndex;

                // those aren't avaialable for unidentified projection
                tabControl1.TabPages.Remove(tabMap);
                tabControl1.TabPages.Remove(tabDialects);
                tabControl1.TabPages.Remove(tabEsriWkt);
            }
        }

        public override ViewStyle Style
        {
            get { return new ViewStyle(true); }
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get { yield break; }
        }

        public IEnumerable<Control> Buttons
        {
            get
            {
                yield return btnAddDialect;
                yield return btnRemoveDialect;
                yield return btnClearDialects;
                yield return btnEditDialect;
            }
        }

        public ProjectionDialect SelectedDialect
        {
            get { return dialectGrid1.Adapter.SelectedItem; }
            set
            {
                dialectGrid1.Adapter.SelectedItem = value;
                dialectGrid1.Adapter.ScrollToSelectedRow();
            }
        }

        private void InitDialectsGrid()
        {
            dialectGrid1.Adapter.SelectionChanged += (s, e) => UpdateView();

            dialectGrid1.TableControlCellDoubleClick += (s, e) => Invoke(EditDialect);

            dialectGrid1.Adapter.AutoAdjustRowHeights = true;
        }

        /// <summary>
        /// Loads and displays dialects for projection.
        /// </summary>
        private void LoadDialects()
        {
            if (Model.LoadDialects(_context.Projections))
            {
                dialectGrid1.DataSource = Model.Dialects;
                dialectGrid1.Adapter.SelectFirstRecord();

                var cmn = dialectGrid1.Adapter.GetColumn(d => d.Definition);
                if (cmn != null)
                {
                    cmn.Width -= 55;
                    dialectGrid1.AdjustRowHeights();
                }
            }
        }

        /// <summary>
        /// Initializes map control with projection bounds.
        /// </summary>
        private void LoadMapPreviewSettings()
        {
            _projectionMap1.LoadStateFromExeName(Application.ExecutablePath);
            _projectionMap1.ZoomBar.Visible = false;
            _projectionMap1.ScalebarVisible = false;
            _projectionMap1.ShowCoordinates = CoordinatesDisplay.None;
            _projectionMap1.ShowVersionNumber = false;
            _projectionMap1.TileProvider = TileProvider.None;
            _projectionMap1.ZoomBehavior = ZoomBehavior.Default;
        }

        private void OnCopyClipboardClick(object sender, EventArgs e)
        {
            CopyToClipboard(projectionTextBox1);
        }

        private void btnCopyClipboardEsri_Click(object sender, EventArgs e)
        {
            CopyToClipboard(projectionTextBoxEsri);
        }

        private void CopyToClipboard(ProjectionTextBox box)
        {
            box.SelectAll();
            box.Copy();
            box.SelectionLength = 0;
        }

        private void OnEpsgLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://spatialreference.org/ref/epsg/" + txtCode.Text + "/";
            PathHelper.OpenUrl(url);
        }

        /// <summary>
        /// Shows information about selected projection
        /// </summary>
        private void ShowCoordinateSystem()
        {
            var cs = Model.CoordinateSystem;

            txtName.Text = cs.Name;
            txtCode.Text = cs.Code.ToString(CultureInfo.InvariantCulture);

            var sr = new SpatialReference();
            if (!sr.ImportFromEpsg(cs.Code))
            {
                // unsupported projection
            }
            else
            {
                projectionTextBox1.ShowProjection(sr.ExportToWkt());
                projectionTextBoxEsri.ShowProjection(sr.ExportToEsri());

                _projectionMap1.DrawCoordinateSystem(cs);
                _projectionMap1.ZoomToCoordinateSystem(cs);

                txtProj4.Text = sr.ExportToProj4();

                txtAreaName.Text = cs.AreaName;
                txtRemarks.Text = cs.Remarks;
                txtScope.Text = cs.Scope;
            }
        }

        /// <summary>
        /// Shows information about unrecognized projection
        /// </summary>
        private void ShowProjection()
        {
            var projection = Model.SpatialReference;

            txtName.Text = projection.Name == "" ? "None" : projection.Name;
            txtCode.Text = "None";

            if (!projection.IsEmpty)
            {
                projectionTextBox1.ShowProjection(projection.ExportToWkt());
                txtProj4.Text = projection.ExportToProj4();

                txtAreaName.Text = "Not defined";
                txtScope.Text = "Not defined";
                txtRemarks.Text = "Unrecognized projection";
            }
        }
    }

    public class ProjectionInfoViewBase : MapWindowView<ProjectionInfoModel>
    {
    }
}