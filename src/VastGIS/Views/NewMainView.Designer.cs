namespace VastGIS.Views
{
    partial class NewMainView
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
            Syncfusion.Windows.Forms.Tools.Office2013ColorTable office2013ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2013ColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainView));
            VastGIS.Api.Concrete.Envelope envelope1 = new VastGIS.Api.Concrete.Envelope();
            VastGIS.Api.Concrete.SpatialReference spatialReference1 = new VastGIS.Api.Concrete.SpatialReference();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.statusStripLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMapUnits = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this._dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this._mapControl1 = new VastGIS.Api.Map.BoundMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.statusStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dockingManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 0);
            this.ribbonControlAdv1.MenuButtonAutoSize = true;
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            office2013ColorTable1.BackStageCaptionColor = System.Drawing.Color.White;
            office2013ColorTable1.ButtonBackgroundPressed = System.Drawing.Color.Empty;
            office2013ColorTable1.ButtonBackgroundSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.CaptionBackColor = System.Drawing.Color.White;
            office2013ColorTable1.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            office2013ColorTable1.CheckedTabColor = System.Drawing.Color.White;
            office2013ColorTable1.CheckedTabForeColor = System.Drawing.Color.Empty;
            office2013ColorTable1.CloseButtonColor = System.Drawing.Color.Empty;
            office2013ColorTable1.ContextMenuBackColor = System.Drawing.Color.Empty;
            office2013ColorTable1.ContextMenuItemSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.HeaderColor = System.Drawing.Color.White;
            office2013ColorTable1.HoverTabForeColor = System.Drawing.Color.Empty;
            office2013ColorTable1.LauncherBackColorSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.LauncherColorNormal = System.Drawing.Color.Empty;
            office2013ColorTable1.LauncherColorSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.MaximizeButtonColor = System.Drawing.Color.Empty;
            office2013ColorTable1.MinimizeButtonColor = System.Drawing.Color.Empty;
            office2013ColorTable1.PanelBackColor = System.Drawing.Color.White;
            office2013ColorTable1.RestoreButtonColor = System.Drawing.Color.Empty;
            office2013ColorTable1.RibbonPanelBorderColor = System.Drawing.Color.Empty;
            office2013ColorTable1.SelectedTabBorderColor = System.Drawing.Color.White;
            office2013ColorTable1.SelectedTabColor = System.Drawing.Color.White;
            office2013ColorTable1.SplitButtonBackgroundPressed = System.Drawing.Color.Empty;
            office2013ColorTable1.SplitButtonBackgroundSelected = System.Drawing.Color.Empty;
            office2013ColorTable1.SystemButtonBackground = System.Drawing.Color.Empty;
            office2013ColorTable1.TabBackColor = System.Drawing.Color.White;
            office2013ColorTable1.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            office2013ColorTable1.TitleColor = System.Drawing.Color.Empty;
            office2013ColorTable1.ToolStripBackColor = System.Drawing.Color.White;
            office2013ColorTable1.ToolStripBorderColor = System.Drawing.Color.White;
            office2013ColorTable1.ToolStripItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            office2013ColorTable1.ToolStripSpliterColor = System.Drawing.Color.LightGray;
            office2013ColorTable1.UpDownButtonBackColor = System.Drawing.Color.Empty;
            this.ribbonControlAdv1.Office2013ColorTable = office2013ColorTable1;
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.TouchStyle;
            this.ribbonControlAdv1.SelectedTab = null;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(937, 167);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.Black;
            // 
            // statusStripEx1
            // 
            this.statusStripEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.statusStripEx1.BeforeTouchSize = new System.Drawing.Size(937, 23);
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom;
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel5,
            this.statusMapUnits,
            this.toolStripStatusLabel3,
            this.statusProgress,
            this.toolStripMenuItem6});
            this.statusStripEx1.Location = new System.Drawing.Point(1, 479);
            this.statusStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.Size = new System.Drawing.Size(937, 23);
            this.statusStripEx1.TabIndex = 1;
            this.statusStripEx1.Text = "statusStripEx1";
            this.statusStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.StatusStripExStyle.Metro;
            // 
            // statusStripLabel5
            // 
            this.statusStripLabel5.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusStripLabel5.Name = "statusStripLabel5";
            this.SetShortcut(this.statusStripLabel5, System.Windows.Forms.Keys.None);
            this.statusStripLabel5.Size = new System.Drawing.Size(11, 17);
            this.statusStripLabel5.Text = "|";
            // 
            // statusMapUnits
            // 
            this.statusMapUnits.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusMapUnits.Name = "statusMapUnits";
            this.SetShortcut(this.statusMapUnits, System.Windows.Forms.Keys.None);
            this.statusMapUnits.Size = new System.Drawing.Size(68, 17);
            this.statusMapUnits.Text = "Map Units";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.SetShortcut(this.toolStripStatusLabel3, System.Windows.Forms.Keys.None);
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel3.Text = "Progress";
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.SetShortcut(this.statusProgress, System.Windows.Forms.Keys.None);
            this.statusProgress.Size = new System.Drawing.Size(100, 15);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.SetShortcut(this.toolStripMenuItem6, System.Windows.Forms.Keys.None);
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 21);
            this.toolStripMenuItem6.Text = "Properties";
            // 
            // superToolTip1
            // 
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            // 
            // _dockingManager1
            // 
            this._dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.AutoHideTabFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.AutoHideTabForeColor = System.Drawing.Color.Empty;
            this._dockingManager1.DockedCaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("_dockingManager1.DockLayoutStream")));
            this._dockingManager1.DockTabAlignment = Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Left;
            this._dockingManager1.DockTabFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.DockTabForeColor = System.Drawing.Color.Empty;
            this._dockingManager1.DockTabHeight = 26;
            this._dockingManager1.HostControl = this;
            this._dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212))))));
            this._dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this._dockingManager1.MetroButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._dockingManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this._dockingManager1.MetroSplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(159)))), ((int)(((byte)(183)))));
            this._dockingManager1.ReduceFlickeringInRtl = false;
            this._dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2010;
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this._dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            // 
            // _mapControl1
            // 
            this._mapControl1.AllowDrop = true;
            this._mapControl1.AnimationOnZooming = VastGIS.Api.Enums.AutoToggle.Auto;
            this._mapControl1.BackColor = System.Drawing.Color.White;
            this._mapControl1.BackgroundColor = System.Drawing.Color.White;
            this._mapControl1.CurrentScale = 16.511978539029787D;
            this._mapControl1.CurrentZoom = -1;
            this._mapControl1.CustomCursor = null;
            this._mapControl1.ExpandLayersOnAdding = true;
            this._mapControl1.ExtentHistory = 20;
            this._mapControl1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this._mapControl1.Extents = envelope1;
            this._mapControl1.GrabProjectionFromData = true;
            this._mapControl1.InertiaOnPanning = VastGIS.Api.Enums.AutoToggle.Auto;
            this._mapControl1.KnownExtents = VastGIS.Api.Enums.KnownExtents.None;
            this._mapControl1.Latitude = 0F;
            this._mapControl1.Legend = null;
            this._mapControl1.Location = new System.Drawing.Point(252, 174);
            this._mapControl1.Longitude = 0F;
            this._mapControl1.MapCursor = VastGIS.Api.Enums.MapCursor.ZoomIn;
            this._mapControl1.MapProjection = VastGIS.Api.Enums.MapProjection.None;
            this._mapControl1.MapUnits = VastGIS.Api.Enums.LengthUnits.Meters;
            this._mapControl1.MouseWheelSpeed = 0.5D;
            this._mapControl1.Name = "_mapControl1";
            spatialReference1.Tag = "";
            this._mapControl1.Projection = spatialReference1;
            this._mapControl1.ResizeBehavior = VastGIS.Api.Enums.ResizeBehavior.Classic;
            this._mapControl1.ReuseTileBuffer = true;
            this._mapControl1.ScalebarUnits = VastGIS.Api.Enums.ScalebarUnits.GoogleStyle;
            this._mapControl1.ScalebarVisible = true;
            this._mapControl1.ShowCoordinates = VastGIS.Api.Enums.CoordinatesDisplay.Auto;
            this._mapControl1.ShowCoordinatesFormat = VastGIS.Api.Enums.AngleFormat.Degrees;
            this._mapControl1.ShowRedrawTime = false;
            this._mapControl1.ShowVersionNumber = false;
            this._mapControl1.Size = new System.Drawing.Size(375, 231);
            this._mapControl1.SystemCursor = VastGIS.Api.Enums.SystemCursor.MapDefault;
            this._mapControl1.TabIndex = 2;
            this._mapControl1.Tag = "";
            this._mapControl1.TileProvider = VastGIS.Api.Enums.TileProvider.OpenStreetMap;
            this._mapControl1.UdCursorHandle = 0;
            this._mapControl1.UseSeamlessPan = false;
            this._mapControl1.ZoomBehavior = VastGIS.Api.Enums.ZoomBehavior.UseTileLevels;
            this._mapControl1.ZoomBoxStyle = VastGIS.Api.Enums.ZoomBoxStyle.Blue;
            this._mapControl1.ZoomPercent = 0.3D;
            // 
            // NewMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 503);
            this.Controls.Add(this._mapControl1);
            this.Controls.Add(this.statusStripEx1);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Name = "NewMainView";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ShowIcon = false;
            this.Text = "未见移动地理信息平台";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.statusStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dockingManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel5;
        private System.Windows.Forms.ToolStripStatusLabel statusMapUnits;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
        private Syncfusion.Windows.Forms.Tools.DockingManager _dockingManager1;
        private Api.Map.BoundMapControl _mapControl1;
    
    }
}