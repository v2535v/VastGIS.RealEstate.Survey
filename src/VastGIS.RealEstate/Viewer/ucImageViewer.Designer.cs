namespace VastGIS.Plugins.RealEstate.Viewer
{
    partial class ucImageViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnFitToScreen = new System.Windows.Forms.Button();
            this.btnRotate270 = new System.Windows.Forms.Button();
            this.btnRotate90 = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrevStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.cbZoom = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.pbFull = new VastGIS.Plugins.RealEstate.Viewer.PanelDoubleBuffered();
            this.sbPanel = new System.Windows.Forms.Panel();
            this.sbVert = new System.Windows.Forms.VScrollBar();
            this.sbHoriz = new System.Windows.Forms.HScrollBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbZoom)).BeginInit();
            this.pbFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnZoomIn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnZoomOut, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFitToScreen, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRotate270, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRotate90, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMode, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrevStep, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNextStep, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbZoom, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbFull, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 497);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_zoomin;
            this.btnZoomIn.Location = new System.Drawing.Point(52, 453);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(35, 35);
            this.btnZoomIn.TabIndex = 0;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_zoomout;
            this.btnZoomOut.Location = new System.Drawing.Point(102, 453);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(35, 35);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnFitToScreen
            // 
            this.btnFitToScreen.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_scaleview;
            this.btnFitToScreen.Location = new System.Drawing.Point(152, 453);
            this.btnFitToScreen.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnFitToScreen.Name = "btnFitToScreen";
            this.btnFitToScreen.Size = new System.Drawing.Size(35, 35);
            this.btnFitToScreen.TabIndex = 2;
            this.btnFitToScreen.UseVisualStyleBackColor = true;
            this.btnFitToScreen.Click += new System.EventHandler(this.btnFitToScreen_Click);
            // 
            // btnRotate270
            // 
            this.btnRotate270.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.rotate270;
            this.btnRotate270.Location = new System.Drawing.Point(202, 453);
            this.btnRotate270.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnRotate270.Name = "btnRotate270";
            this.btnRotate270.Size = new System.Drawing.Size(35, 35);
            this.btnRotate270.TabIndex = 3;
            this.btnRotate270.UseVisualStyleBackColor = true;
            this.btnRotate270.Click += new System.EventHandler(this.btnRotate270_Click);
            // 
            // btnRotate90
            // 
            this.btnRotate90.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.rotate90;
            this.btnRotate90.Location = new System.Drawing.Point(252, 453);
            this.btnRotate90.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnRotate90.Name = "btnRotate90";
            this.btnRotate90.Size = new System.Drawing.Size(35, 35);
            this.btnRotate90.TabIndex = 4;
            this.btnRotate90.UseVisualStyleBackColor = true;
            this.btnRotate90.Click += new System.EventHandler(this.btnRotate90_Click);
            // 
            // btnMode
            // 
            this.btnMode.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.rectangle;
            this.btnMode.Location = new System.Drawing.Point(302, 453);
            this.btnMode.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(35, 35);
            this.btnMode.TabIndex = 5;
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.print;
            this.btnPrint.Location = new System.Drawing.Point(352, 453);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(35, 35);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnPrevStep
            // 
            this.btnPrevStep.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_preview;
            this.btnPrevStep.Location = new System.Drawing.Point(402, 453);
            this.btnPrevStep.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnPrevStep.Name = "btnPrevStep";
            this.btnPrevStep.Size = new System.Drawing.Size(35, 35);
            this.btnPrevStep.TabIndex = 7;
            this.btnPrevStep.UseVisualStyleBackColor = true;
            this.btnPrevStep.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_nextview;
            this.btnNextStep.Location = new System.Drawing.Point(452, 453);
            this.btnNextStep.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(35, 35);
            this.btnNextStep.TabIndex = 8;
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbZoom
            // 
            this.cbZoom.BeforeTouchSize = new System.Drawing.Size(74, 20);
            this.cbZoom.EnableTouchMode = true;
            this.cbZoom.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbZoom.Location = new System.Drawing.Point(497, 455);
            this.cbZoom.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(74, 26);
            this.cbZoom.TabIndex = 9;
            this.cbZoom.SelectedIndexChanged += new System.EventHandler(this.cbZoom_SelectedIndexChanged);
            this.cbZoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbZoom_KeyPress);
            // 
            // pbFull
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbFull, 12);
            this.pbFull.Controls.Add(this.sbPanel);
            this.pbFull.Controls.Add(this.sbVert);
            this.pbFull.Controls.Add(this.sbHoriz);
            this.pbFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFull.Location = new System.Drawing.Point(3, 3);
            this.pbFull.Name = "pbFull";
            this.pbFull.Size = new System.Drawing.Size(613, 441);
            this.pbFull.TabIndex = 10;
            this.pbFull.Click += new System.EventHandler(this.pbFull_Click);
            this.pbFull.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbFull_DragDrop);
            this.pbFull.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbFull_DragEnter);
            this.pbFull.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFull_Paint);
            this.pbFull.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbFull_MouseDoubleClick);
            this.pbFull.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFull_MouseDown);
            this.pbFull.MouseEnter += new System.EventHandler(this.pbFull_MouseEnter);
            this.pbFull.MouseLeave += new System.EventHandler(this.pbFull_MouseLeave);
            this.pbFull.MouseHover += new System.EventHandler(this.pbFull_MouseHover);
            this.pbFull.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFull_MouseMove);
            this.pbFull.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbFull_MouseUp);
            // 
            // sbPanel
            // 
            this.sbPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sbPanel.Location = new System.Drawing.Point(595, 423);
            this.sbPanel.Name = "sbPanel";
            this.sbPanel.Size = new System.Drawing.Size(15, 17);
            this.sbPanel.TabIndex = 2;
            // 
            // sbVert
            // 
            this.sbVert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbVert.Location = new System.Drawing.Point(595, 1);
            this.sbVert.Name = "sbVert";
            this.sbVert.Size = new System.Drawing.Size(17, 419);
            this.sbVert.TabIndex = 1;
            this.sbVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVert_Scroll);
            // 
            // sbHoriz
            // 
            this.sbHoriz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbHoriz.Location = new System.Drawing.Point(1, 422);
            this.sbHoriz.Name = "sbHoriz";
            this.sbHoriz.Size = new System.Drawing.Size(596, 17);
            this.sbHoriz.TabIndex = 0;
            this.sbHoriz.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbHoriz_Scroll);
            // 
            // ucImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucImageViewer";
            this.Size = new System.Drawing.Size(619, 497);
            this.Load += new System.EventHandler(this.ucImageViewer_Load);
            this.Click += new System.EventHandler(this.ucImageViewer_Click);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ucImageViewer_MouseWheel);
            this.Resize += new System.EventHandler(this.ucImageViewer_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbZoom)).EndInit();
            this.pbFull.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnFitToScreen;
        private System.Windows.Forms.Button btnRotate270;
        private System.Windows.Forms.Button btnRotate90;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrevStep;
        private System.Windows.Forms.Button btnNextStep;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbZoom;
        private PanelDoubleBuffered pbFull;
        private System.Windows.Forms.Panel sbPanel;
        private System.Windows.Forms.VScrollBar sbVert;
        private System.Windows.Forms.HScrollBar sbHoriz;
    }
}
