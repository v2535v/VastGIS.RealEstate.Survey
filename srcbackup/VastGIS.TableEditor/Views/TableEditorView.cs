﻿// -------------------------------------------------------------------------------------------
// <copyright file="TableEditorView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015-2017
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.TableEditor.Editor;
using VastGIS.Plugins.TableEditor.Model;
using VastGIS.Plugins.TableEditor.Properties;
using VastGIS.Plugins.TableEditor.Views.Abstract;
using VastGIS.Shared;
using VastGIS.UI.Controls;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.TableEditor.Views
{
    /// <summary>
    /// Table editor view representing menu and docking manager to host attribute tables for particular layers.
    /// </summary>
    [LayoutWithRegions]
    internal partial class TableEditorView : DockPanelControlBase, ITableEditorView
    {
        private readonly TablePanelCollection _panels;
        private IAppContext _context;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TableEditorView" /> class.
        /// </summary>
        public TableEditorView()
        {
            InitializeComponent();

            ActiveColumnIndex = -1;

            _panels = new TablePanelCollection(dockingManager1, this);

            InitMenu();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the index of the active column, i.e. the one for which context menu was displayed.
        /// </summary>
        public int ActiveColumnIndex { get; private set; }

        /// <summary>
        /// Gets currently active featureset.
        /// </summary>
        public IFeatureSet ActiveFeatureSet
        {
            get
            {
                var panel = Panels.ActivePanel;

                if (panel == null || panel.LayerHandle == -1)
                {
                    return null;
                }

                return _context.Legend.Layers.GetFeatureSet(panel.LayerHandle);
            }
        }

        /// <summary>
        /// Gets currently active grid.
        /// </summary>
        public TableEditorGrid ActiveGrid
        {
            get
            {
                var panel = Panels.ActivePanel;
                if (panel == null || panel.LayerHandle == -1)
                {
                    return null;
                }

                return panel.Control as TableEditorGrid;
            }
        }

        /// <summary>
        /// Gets the handle of the active layer.
        /// </summary>
        public int ActiveLayerHandle
        {
            get
            {
                var panel = Panels.ActivePanel;
                return panel != null ? panel.LayerHandle : -1;
            }
        }

        /// <summary>
        /// Gets buttons to wire up menu commands for.
        /// </summary>
        public IEnumerable<Control> Buttons
        {
            get { yield break; }
        }

        /// <summary>
        /// Gets the ok button.
        /// </summary>
        public ButtonBase OkButton
        {
            get { return null; }
        }

        /// <summary>
        /// Gets list of docking panels.
        /// </summary>
        public TablePanelCollection Panels
        {
            get { return _panels; }
        }

        /// <summary>
        /// Gets toolstrips to wire up menu commands for.
        /// </summary>
        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get
            {
                yield return toolStripEx1.Items;
                yield return contextMenuStripEx1.Items;
            }
        }

        /// <summary>
        /// Gets the size client area for docking panels.
        /// </summary>
        private Size DockingClientSize
        {
            get { return new Size(ClientSize.Width, ClientSize.Height - toolStripEx1.Height); }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Clears the current cell.
        /// </summary>
        public void ClearCurrentCell()
        {
            var grid = ActiveGrid;
            if (grid != null)
            {
                grid.CurrentCell = null;
            }
        }

        /// <summary>
        /// Creates new table panel for the layer.
        /// </summary>
        public TablePanelInfo CreateTablePanel(ILegendLayer layer)
        {
            var grid = CreateGrid();

            grid.SetTableSource(layer.FeatureSet, layer.Handle, layer.LayerType == Api.Enums.LayerType.VectorLayer);
            
            grid.ColumnContextNeeded += (s, e) => ShowContextMenu(s, e.ColumnIndex);
            grid.CellContextMenuStripNeeded += (s, e) => ShowContextMenu(s, e.ColumnIndex);

            var first = Panels.FirstOrDefault();

            var panel = Panels.Add(grid, layer.Handle);
            panel.Caption = layer.Name;

            int size;
            DockPanelState state;
            GetLayoutSpecs(AppConfig.Instance.TableEditorLayout, out size, out state);

            if (first != null)
            {
                panel.DockTo(first, state, size);
                panel.TabPosition = 0;
            }

            return new TablePanelInfo(grid, layer, panel);
        }

        private void ShowContextMenu(object sender, int columnIndex)
        {
            var grid = sender as TableEditorGrid;
            if (grid != null)
            {
                if (columnIndex >= 0 && columnIndex < grid.Columns.Count)
                {
                    grid.SetSelectionMode(DataGridViewSelectionMode.FullColumnSelect);
                    grid.Columns[columnIndex].Selected = true;
                    grid.Refresh();
                }
            }

            ActiveColumnIndex = columnIndex;
            contextMenuStripEx1.Show(Cursor.Position);
        }

        /// <summary>
        /// Gets the size and docking state for a new docking panel.
        /// </summary>
        public void GetLayoutSpecs(TableEditorLayout layout, out int size, out DockPanelState state)
        {
            size = 0;
            state = DockPanelState.None;

            switch (layout)
            {
                case TableEditorLayout.Tabbed:
                    state = DockPanelState.Tabbed;
                    break;
                case TableEditorLayout.Horizontal:
                    state = DockPanelState.Right;
                    size = DockingClientSize.Width / _panels.Count();
                    break;
                case TableEditorLayout.Vertical:
                    state = DockPanelState.Bottom;
                    size = DockingClientSize.Height / _panels.Count();
                    break;
            }
        }

        /// <summary>
        /// Initializes the view.
        /// </summary>
        public void Initialize(IAppContext context)
        {
            _context = context;

            UpdateView();
        }

        /// <summary>
        /// Performs necessary updates after a differnt dock panel was activated.
        /// </summary>
        public void OnActivateDockingPanel()
        {
            UpdateEditingIcon();

            UpdateView();
        }

        /// <summary>
        /// Reloads featureset for certain layer. 
        /// Useful for OGR layer when another instance of shapefile has been created under the hood.
        /// </summary>
        public void ReloadDatasource(IFeatureSet fs, int layerHandle, bool ogr)
        {
            foreach (var panel in _panels)
            {
                var grid = panel.Control as TableEditorGrid;
                if (grid != null && grid.LayerHandle == layerHandle)
                {
                    UpdateDatasourceCore(grid, fs);

                    break;
                }
            }
        }

        private void UpdateDatasourceCore(TableEditorGrid grid, IFeatureSet fs)
        {
            var manager = grid.RowManager;

            int cmnIndex = manager.SortColumnIndex;
            bool ascending = manager.SortAscending;

            grid.SetTableSource(fs, grid.LayerHandle, grid.IsOgr);

            if (cmnIndex != -1)
            {
                grid.SortByColumn(cmnIndex, ascending);
            }
        }

        /// <summary>
        /// Completely reloads the datasource applying all pending changes.
        /// </summary>
        public void UpdateDatasource()
        {
            var grid = ActiveGrid;
            if (grid != null)
            {
                UpdateDatasourceCore(grid, grid.TableSource);
            }

            UpdateView();
        }

        /// <summary>
        /// Updates a caption text of the specified panel.
        /// </summary>
        public void UpdatePanelCaption(int layerHandle)
        {
            var layer = _context.Legend.Layers.ItemByHandle(layerHandle);
            if (layer == null)
            {
                return;
            }

            var msg = layer.Name;

            var fs = layer.FeatureSet;
            if (fs != null)
            {
                if (fs.CanEditTable())
                {
                    msg += "*";
                }

                if (fs.NumSelected > 0)
                {
                    msg += string.Format(" - selected: {0} / {1}", fs.NumSelected, fs.NumFeatures);
                }

                if (fs.CanEditTable())
                {
                    int modified = fs.Features.Count(ft => ft.RowModified);
                    msg += string.Format(" - modified: {0} / {1}", modified, fs.NumFeatures);
                }
            }

            var panel = Panels.FirstOrDefault(p => p.LayerHandle == layerHandle);
            if (panel != null)
            {
                panel.Caption = msg;
            }
        }

        /// <summary>
        /// Updates the menus and invalidates the currently active grid.
        /// </summary>
        public void UpdateView()
        {
            var hasPanels = Panels.Any();

            lblNoLayers.Visible = !hasPanels;

            toolStripEx1.Enabled = hasPanels;

            var fs = ActiveFeatureSet;
            toolRemoveSelected.Enabled = fs != null && fs.InteractiveEditing;

            UpdateMenus();

            UpdateEditingIcon();

            UpdatePanelCaption(ActiveLayerHandle);

            var grid = ActiveGrid;
            if (grid != null)
            {
                grid.Invalidate();
            }
        }

        public void OnSelectionChanged()
        {
            var fs = ActiveFeatureSet;
            if (fs != null)
            {
                mnuZoomToSelected.Enabled = fs.NumSelected > 0;
            }
        }

        #endregion

        #region Methods

        private TableEditorGrid CreateGrid()
        {
            var grid = new TableEditorGrid { RowManager = new RowManager() };
            grid.DoubleBuffered(true);
            grid.CurrentCellBorderColor = Color.LightGreen;
            Controls.Add(grid);
            return grid;
        }

        private void InitMenu()
        {
            // handlers aren't attached to the items with not null tag
            toolEdit.Tag = 0;
            toolSelection.Tag = 0;
            toolFields.Tag = 0;
            toolTools.Tag = 0;
            toolLayout.Tag = 0;

            toolEdit.DropDownOpening += (s, e) => UpdateMenus();
            toolSelection.DropDownOpening += (s, e) => UpdateMenus();
            toolLayout.DropDownOpening += (s, e) => UpdateMenus();
            toolFields.DropDownOpening += (s, e) => UpdateMenus();
            toolTools.DropDownOpening += (s, e) => UpdateMenus();
        }

        private void UpdateEditingIcon()
        {
            var fs = ActiveFeatureSet;
            if (fs == null)
            {
                return;
            }

            var editing = fs.CanEditTable();

            var img = editing ? Resources.icon_save1 : Resources.icon_layer_edit;

            toolStripEx1.SuspendLayout();
            toolEdit.Image = img;

            toolStripEx1.ResumeLayout();
        }

        private void UpdateMenus()
        {
            var fs = ActiveFeatureSet;
            if (fs == null)
            {
                return;
            }

            var editing = fs.CanEditTable();
            mnuStartEdit.Enabled = !editing;
            mnuSaveChanges.Enabled = editing;
            mnuDiscardChanges.Enabled = editing;

            toolStopJoins.Enabled = fs.Table.Joins.Any();
            mnuShowAliases.Checked = AppConfig.Instance.TableEditorShowAliases;
            
            var hasSelection = fs.NumSelected > 0;
            mnuClearSelection.Enabled = hasSelection;
            mnuZoomToSelected.Enabled = hasSelection;
            mnuShowSelected.Enabled = hasSelection;

            var grid = ActiveGrid;
            if (grid != null)
            {
                if (grid.RowManager.Filtered)
                {
                    mnuShowSelected.Enabled = true;
                    mnuShowSelected.Text = @"Show All Shapes";
                }
                else
                {
                    mnuShowSelected.Text = @"Show Selected Shapes";
                }
            }

            var layout = AppConfig.Instance.TableEditorLayout;
            mnuLayoutHorizontal.Checked = layout == TableEditorLayout.Horizontal;
            mnuLayoutVertical.Checked = layout == TableEditorLayout.Vertical;
            mnuLayoutTabbed.Checked = layout == TableEditorLayout.Tabbed;
        }

        #endregion

        private void OnContextMenuClosed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            var grid = ActiveGrid;
            if (grid != null)
            {
                grid.SetSelectionMode(DataGridViewSelectionMode.CellSelect);
            }
        }

        private void OnLayoutDropDownOpening(object sender, System.EventArgs e)
        {
            mnuFormatValues.Checked = AppConfig.Instance.TableEditorFormatValues;
        }

        private void OnContextOpening(object sender, CancelEventArgs e)
        {
            if (ActiveGrid == null) return;

            bool keyField = ActiveGrid.IsOgr && ActiveColumnIndex == 0;

            mnuCalculateField.Enabled = !keyField;
            mnuRemoveField.Enabled = !keyField;
            mnuFieldProperties.Enabled = !keyField;
        }
    }

    public class TableEditorViewBase : MapWindowView<ILayer>
    {
    }
}