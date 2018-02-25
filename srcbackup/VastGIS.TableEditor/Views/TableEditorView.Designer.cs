﻿using System.Windows.Forms;
using VastGIS.Plugins.TableEditor.Editor;
using Syncfusion.Windows.Forms;

namespace VastGIS.Plugins.TableEditor.Views
{
    partial class TableEditorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableEditorView));
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.toolStripEx1 = new System.Windows.Forms.ToolStrip();
            this.toolEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuStartEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiscardChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuZoomToSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSelection = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuZoomToCurrentCell = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAttributeExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvertSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRemoveSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFields = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuAddField = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuShowAliases = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowAllFields = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUpdateMeasurements = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRecalculateFields = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRemoveFields = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolJoin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStopJoins = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImportFieldDefinitions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLayout = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuLayoutVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLayoutHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLayoutTabbed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFormatValues = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuReloadTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearSorting = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNoLayers = new System.Windows.Forms.Label();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.mnuFieldSortAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFieldSortDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFieldHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCalculateField = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRemoveField = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFieldStats = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFieldProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            this.contextMenuStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.AutoHideTabFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.DockTabFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.EnableAutoAdjustCaption = true;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dockingManager1.MetroCaptionColor = System.Drawing.Color.White;
            this.dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this.dockingManager1.ReduceFlickeringInRtl = false;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEdit,
            this.toolStripSeparator15,
            this.mnuZoomToSelected,
            this.toolStripSeparator1,
            this.toolSelection,
            this.toolFields,
            this.toolTools,
            this.toolStripSeparator6,
            this.toolLayout});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.ShowItemToolTips = false;
            this.toolStripEx1.Size = new System.Drawing.Size(712, 33);
            this.toolStripEx1.TabIndex = 18;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // toolEdit
            // 
            this.toolEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStartEdit,
            this.toolStripSeparator3,
            this.mnuSaveChanges,
            this.mnuDiscardChanges});
            this.toolEdit.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.icon_layer_edit;
            this.toolEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Padding = new System.Windows.Forms.Padding(4, 0, 4, 2);
            this.toolEdit.Size = new System.Drawing.Size(45, 30);
            this.toolEdit.Text = "Editing";
            // 
            // mnuStartEdit
            // 
            this.mnuStartEdit.Name = "mnuStartEdit";
            this.mnuStartEdit.Size = new System.Drawing.Size(162, 22);
            this.mnuStartEdit.Text = "Start Editing";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            // 
            // mnuSaveChanges
            // 
            this.mnuSaveChanges.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.icon_save1;
            this.mnuSaveChanges.Name = "mnuSaveChanges";
            this.mnuSaveChanges.Size = new System.Drawing.Size(162, 22);
            this.mnuSaveChanges.Text = "Save Changes";
            // 
            // mnuDiscardChanges
            // 
            this.mnuDiscardChanges.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_remove16;
            this.mnuDiscardChanges.Name = "mnuDiscardChanges";
            this.mnuDiscardChanges.Size = new System.Drawing.Size(162, 22);
            this.mnuDiscardChanges.Text = "Discard Changes";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 33);
            // 
            // mnuZoomToSelected
            // 
            this.mnuZoomToSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuZoomToSelected.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_zoom_selection24;
            this.mnuZoomToSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuZoomToSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuZoomToSelected.Name = "mnuZoomToSelected";
            this.mnuZoomToSelected.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mnuZoomToSelected.Size = new System.Drawing.Size(36, 30);
            this.mnuZoomToSelected.ToolTipText = "Zoom to Selected Shapes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolSelection
            // 
            this.toolSelection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuZoomToCurrentCell,
            this.mnuShowSelected,
            this.toolStripSeparator5,
            this.mnuQuery,
            this.toolStripSeparator17,
            this.mnuAttributeExplorer,
            this.toolStripSeparator2,
            this.mnuSelectAll,
            this.mnuClearSelection,
            this.mnuInvertSelection,
            this.toolStripMenuItem3,
            this.mnuExportSelected,
            this.toolStripSeparator19,
            this.toolRemoveSelected});
            this.toolSelection.ForeColor = System.Drawing.Color.Black;
            this.toolSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelection.Name = "toolSelection";
            this.toolSelection.Size = new System.Drawing.Size(68, 30);
            this.toolSelection.Text = "Selection";
            // 
            // mnuZoomToCurrentCell
            // 
            this.mnuZoomToCurrentCell.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_zoom_to_cursor16;
            this.mnuZoomToCurrentCell.Name = "mnuZoomToCurrentCell";
            this.mnuZoomToCurrentCell.Size = new System.Drawing.Size(224, 22);
            this.mnuZoomToCurrentCell.Text = "Zoom to Shape Being Edited";
            // 
            // mnuShowSelected
            // 
            this.mnuShowSelected.Name = "mnuShowSelected";
            this.mnuShowSelected.Size = new System.Drawing.Size(224, 22);
            this.mnuShowSelected.Text = "Show Only Selected Shapes";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuQuery
            // 
            this.mnuQuery.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_wand16;
            this.mnuQuery.Name = "mnuQuery";
            this.mnuQuery.Size = new System.Drawing.Size(224, 22);
            this.mnuQuery.Text = "Build Query...";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuAttributeExplorer
            // 
            this.mnuAttributeExplorer.Name = "mnuAttributeExplorer";
            this.mnuAttributeExplorer.Size = new System.Drawing.Size(224, 22);
            this.mnuAttributeExplorer.Text = "Attribute Explorer...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_select_yellow_16;
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.Size = new System.Drawing.Size(224, 22);
            this.mnuSelectAll.Text = "Select All";
            // 
            // mnuClearSelection
            // 
            this.mnuClearSelection.Name = "mnuClearSelection";
            this.mnuClearSelection.Size = new System.Drawing.Size(224, 22);
            this.mnuClearSelection.Text = "Select None";
            // 
            // mnuInvertSelection
            // 
            this.mnuInvertSelection.Name = "mnuInvertSelection";
            this.mnuInvertSelection.Size = new System.Drawing.Size(224, 22);
            this.mnuInvertSelection.Text = "Invert Selection";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuExportSelected
            // 
            this.mnuExportSelected.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_download3;
            this.mnuExportSelected.Name = "mnuExportSelected";
            this.mnuExportSelected.Size = new System.Drawing.Size(224, 22);
            this.mnuExportSelected.Text = "Export Selection...";
            // 
            // toolRemoveSelected
            // 
            this.toolRemoveSelected.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_remove16;
            this.toolRemoveSelected.Name = "toolRemoveSelected";
            this.toolRemoveSelected.Size = new System.Drawing.Size(224, 22);
            this.toolRemoveSelected.Text = "Remove Selected";
            // 
            // toolFields
            // 
            this.toolFields.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddField,
            this.toolStripSeparator4,
            this.mnuShowAliases,
            this.mnuShowAllFields,
            this.toolStripSeparator12,
            this.mnuUpdateMeasurements,
            this.toolStripSeparator13,
            this.mnuRecalculateFields,
            this.toolStripMenuItem1,
            this.mnuRemoveFields});
            this.toolFields.ForeColor = System.Drawing.Color.Black;
            this.toolFields.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolFields.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFields.Name = "toolFields";
            this.toolFields.Size = new System.Drawing.Size(50, 30);
            this.toolFields.Text = "Fields";
            // 
            // mnuAddField
            // 
            this.mnuAddField.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_field_add16;
            this.mnuAddField.Name = "mnuAddField";
            this.mnuAddField.Size = new System.Drawing.Size(202, 22);
            this.mnuAddField.Text = "Add Field...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuShowAliases
            // 
            this.mnuShowAliases.Name = "mnuShowAliases";
            this.mnuShowAliases.Size = new System.Drawing.Size(202, 22);
            this.mnuShowAliases.Text = "Show Aliases";
            // 
            // mnuShowAllFields
            // 
            this.mnuShowAllFields.Name = "mnuShowAllFields";
            this.mnuShowAllFields.Size = new System.Drawing.Size(202, 22);
            this.mnuShowAllFields.Text = "Show All Fields";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuUpdateMeasurements
            // 
            this.mnuUpdateMeasurements.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_measure16;
            this.mnuUpdateMeasurements.Name = "mnuUpdateMeasurements";
            this.mnuUpdateMeasurements.Size = new System.Drawing.Size(202, 22);
            this.mnuUpdateMeasurements.Text = "Update Measurements...";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuRecalculateFields
            // 
            this.mnuRecalculateFields.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_calculate16;
            this.mnuRecalculateFields.Name = "mnuRecalculateFields";
            this.mnuRecalculateFields.Size = new System.Drawing.Size(202, 22);
            this.mnuRecalculateFields.Text = "Recalculate Fields...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuRemoveFields
            // 
            this.mnuRemoveFields.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_remove16;
            this.mnuRemoveFields.Name = "mnuRemoveFields";
            this.mnuRemoveFields.Size = new System.Drawing.Size(202, 22);
            this.mnuRemoveFields.Text = "Remove Fields...";
            // 
            // toolTools
            // 
            this.toolTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFind,
            this.mnuReplace,
            this.toolStripSeparator7,
            this.toolJoin,
            this.toolStopJoins,
            this.toolStripSeparator14,
            this.mnuImportFieldDefinitions});
            this.toolTools.ForeColor = System.Drawing.Color.Black;
            this.toolTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTools.Name = "toolTools";
            this.toolTools.Size = new System.Drawing.Size(49, 30);
            this.toolTools.Text = "Tools";
            // 
            // mnuFind
            // 
            this.mnuFind.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_search16;
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(207, 22);
            this.mnuFind.Text = "Find...";
            // 
            // mnuReplace
            // 
            this.mnuReplace.Name = "mnuReplace";
            this.mnuReplace.Size = new System.Drawing.Size(207, 22);
            this.mnuReplace.Text = "Replace...";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(204, 6);
            // 
            // toolJoin
            // 
            this.toolJoin.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_join16;
            this.toolJoin.Name = "toolJoin";
            this.toolJoin.Size = new System.Drawing.Size(207, 22);
            this.toolJoin.Text = "Join Datasource...";
            // 
            // toolStopJoins
            // 
            this.toolStopJoins.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_remove16;
            this.toolStopJoins.Name = "toolStopJoins";
            this.toolStopJoins.Size = new System.Drawing.Size(207, 22);
            this.toolStopJoins.Text = "Stop Joins";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(204, 6);
            // 
            // mnuImportFieldDefinitions
            // 
            this.mnuImportFieldDefinitions.Name = "mnuImportFieldDefinitions";
            this.mnuImportFieldDefinitions.Size = new System.Drawing.Size(207, 22);
            this.mnuImportFieldDefinitions.Text = "Import Field Definitions...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // toolLayout
            // 
            this.toolLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLayoutVertical,
            this.mnuLayoutHorizontal,
            this.mnuLayoutTabbed,
            this.toolStripSeparator16,
            this.mnuFormatValues,
            this.toolStripSeparator18,
            this.mnuReloadTable,
            this.mnuClearSorting});
            this.toolLayout.ForeColor = System.Drawing.Color.Black;
            this.toolLayout.Image = ((System.Drawing.Image)(resources.GetObject("toolLayout.Image")));
            this.toolLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLayout.Name = "toolLayout";
            this.toolLayout.Size = new System.Drawing.Size(56, 30);
            this.toolLayout.Text = "Layout";
            this.toolLayout.DropDownOpening += new System.EventHandler(this.OnLayoutDropDownOpening);
            // 
            // mnuLayoutVertical
            // 
            this.mnuLayoutVertical.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_vertical16;
            this.mnuLayoutVertical.Name = "mnuLayoutVertical";
            this.mnuLayoutVertical.Size = new System.Drawing.Size(149, 22);
            this.mnuLayoutVertical.Text = "Vertical";
            // 
            // mnuLayoutHorizontal
            // 
            this.mnuLayoutHorizontal.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_horizontal_16;
            this.mnuLayoutHorizontal.Name = "mnuLayoutHorizontal";
            this.mnuLayoutHorizontal.Size = new System.Drawing.Size(149, 22);
            this.mnuLayoutHorizontal.Text = "Horizontal";
            // 
            // mnuLayoutTabbed
            // 
            this.mnuLayoutTabbed.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_tabbed16;
            this.mnuLayoutTabbed.Name = "mnuLayoutTabbed";
            this.mnuLayoutTabbed.Size = new System.Drawing.Size(149, 22);
            this.mnuLayoutTabbed.Text = "Tabbed";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(146, 6);
            // 
            // mnuFormatValues
            // 
            this.mnuFormatValues.Name = "mnuFormatValues";
            this.mnuFormatValues.Size = new System.Drawing.Size(149, 22);
            this.mnuFormatValues.Text = "Format Values";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(146, 6);
            // 
            // mnuReloadTable
            // 
            this.mnuReloadTable.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_refresh16;
            this.mnuReloadTable.Name = "mnuReloadTable";
            this.mnuReloadTable.Size = new System.Drawing.Size(149, 22);
            this.mnuReloadTable.Text = "Reload Table";
            // 
            // mnuClearSorting
            // 
            this.mnuClearSorting.Name = "mnuClearSorting";
            this.mnuClearSorting.Size = new System.Drawing.Size(149, 22);
            this.mnuClearSorting.Text = "Clear Sorting";
            // 
            // lblNoLayers
            // 
            this.lblNoLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoLayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNoLayers.Location = new System.Drawing.Point(0, 33);
            this.lblNoLayers.Name = "lblNoLayers";
            this.lblNoLayers.Size = new System.Drawing.Size(712, 271);
            this.lblNoLayers.TabIndex = 19;
            this.lblNoLayers.Text = "No layers are opened in the table editor.";
            this.lblNoLayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFieldSortAsc,
            this.mnuFieldSortDesc,
            this.toolStripSeparator8,
            this.mnuFieldHide,
            this.toolStripSeparator10,
            this.mnuCalculateField,
            this.toolStripSeparator11,
            this.mnuRemoveField,
            this.toolStripSeparator9,
            this.mnuFieldStats,
            this.mnuFieldProperties});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(161, 182);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            this.contextMenuStripEx1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.OnContextMenuClosed);
            this.contextMenuStripEx1.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextOpening);
            // 
            // mnuFieldSortAsc
            // 
            this.mnuFieldSortAsc.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_sort_asc16;
            this.mnuFieldSortAsc.Name = "mnuFieldSortAsc";
            this.mnuFieldSortAsc.Size = new System.Drawing.Size(160, 22);
            this.mnuFieldSortAsc.Text = "Sort Ascending";
            // 
            // mnuFieldSortDesc
            // 
            this.mnuFieldSortDesc.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_sort_desc16;
            this.mnuFieldSortDesc.Name = "mnuFieldSortDesc";
            this.mnuFieldSortDesc.Size = new System.Drawing.Size(160, 22);
            this.mnuFieldSortDesc.Text = "Sort Descending";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuFieldHide
            // 
            this.mnuFieldHide.Name = "mnuFieldHide";
            this.mnuFieldHide.Size = new System.Drawing.Size(160, 22);
            this.mnuFieldHide.Text = "Hide Field";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuCalculateField
            // 
            this.mnuCalculateField.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_calculate16;
            this.mnuCalculateField.Name = "mnuCalculateField";
            this.mnuCalculateField.Size = new System.Drawing.Size(160, 22);
            this.mnuCalculateField.Text = "Calculate Field";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuRemoveField
            // 
            this.mnuRemoveField.Image = global::VastGIS.Plugins.TableEditor.Properties.Resources.img_remove16;
            this.mnuRemoveField.Name = "mnuRemoveField";
            this.mnuRemoveField.Size = new System.Drawing.Size(160, 22);
            this.mnuRemoveField.Text = "Remove Field";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuFieldStats
            // 
            this.mnuFieldStats.Name = "mnuFieldStats";
            this.mnuFieldStats.Size = new System.Drawing.Size(160, 22);
            this.mnuFieldStats.Text = "Statistics";
            // 
            // mnuFieldProperties
            // 
            this.mnuFieldProperties.Name = "mnuFieldProperties";
            this.mnuFieldProperties.Size = new System.Drawing.Size(160, 22);
            this.mnuFieldProperties.Text = "Properties";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(221, 6);
            // 
            // TableEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoLayers);
            this.Controls.Add(this.toolStripEx1);
            this.Name = "TableEditorView";
            this.Size = new System.Drawing.Size(712, 304);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.contextMenuStripEx1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private ToolStrip toolStripEx1;
        private System.Windows.Forms.ToolStripDropDownButton toolFields;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuAddField;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuRemoveFields;
        private ToolStripDropDownButton toolSelection;
        private ToolStripMenuItem mnuQuery;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuSelectAll;
        private ToolStripMenuItem mnuClearSelection;
        private ToolStripMenuItem mnuExportSelected;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuInvertSelection;
        private ToolStripDropDownButton toolTools;
        private ToolStripMenuItem mnuFind;
        private ToolStripMenuItem mnuReplace;
        private ToolStripMenuItem mnuImportFieldDefinitions;
        private ToolStripDropDownButton toolEdit;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuShowSelected;
        private ToolStripMenuItem mnuZoomToCurrentCell;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripDropDownButton toolLayout;
        private ToolStripMenuItem mnuLayoutVertical;
        private ToolStripMenuItem mnuLayoutHorizontal;
        private ToolStripMenuItem mnuLayoutTabbed;
        private Label lblNoLayers;
        private ToolStripMenuItem mnuStartEdit;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuSaveChanges;
        private ToolStripMenuItem mnuUpdateMeasurements;
        private ToolStripSeparator toolStripSeparator7;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private ToolStripMenuItem mnuFieldSortAsc;
        private ToolStripMenuItem mnuFieldSortDesc;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem mnuFieldHide;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem mnuCalculateField;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem mnuRemoveField;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem mnuFieldStats;
        private ToolStripMenuItem mnuFieldProperties;
        private ToolStripMenuItem mnuShowAliases;
        private ToolStripMenuItem mnuShowAllFields;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem toolStopJoins;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem toolJoin;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripButton mnuZoomToSelected;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripMenuItem mnuAttributeExplorer;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripMenuItem mnuClearSorting;
        private ToolStripMenuItem mnuReloadTable;
        private ToolStripMenuItem mnuDiscardChanges;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem mnuRecalculateFields;
        private ToolTip toolTip1;
        private ToolStripMenuItem mnuFormatValues;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripMenuItem toolRemoveSelected;
        private ToolStripSeparator toolStripSeparator19;

    }
}