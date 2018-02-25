namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucEdgeList
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
            this.chkSelFeature = new System.Windows.Forms.CheckBox();
            this.txtFeature = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblPart = new System.Windows.Forms.Label();
            this.cmbParts = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.gridEdges = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEdges)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSelFeature
            // 
            this.chkSelFeature.AutoSize = true;
            this.chkSelFeature.Location = new System.Drawing.Point(3, 13);
            this.chkSelFeature.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.chkSelFeature.Name = "chkSelFeature";
            this.chkSelFeature.Size = new System.Drawing.Size(72, 16);
            this.chkSelFeature.TabIndex = 0;
            this.chkSelFeature.Text = "选取要素";
            this.chkSelFeature.UseVisualStyleBackColor = true;
            // 
            // txtFeature
            // 
            this.txtFeature.BeforeTouchSize = new System.Drawing.Size(221, 21);
            this.txtFeature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFeature.EnableTouchMode = true;
            this.txtFeature.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFeature.Location = new System.Drawing.Point(83, 3);
            this.txtFeature.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.Size = new System.Drawing.Size(137, 28);
            this.txtFeature.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFeature.TabIndex = 1;
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(3, 48);
            this.lblPart.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(65, 12);
            this.lblPart.TabIndex = 2;
            this.lblPart.Text = "子段序号：";
            // 
            // cmbParts
            // 
            this.cmbParts.BeforeTouchSize = new System.Drawing.Size(221, 20);
            this.cmbParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParts.EnableTouchMode = true;
            this.cmbParts.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbParts.Location = new System.Drawing.Point(83, 38);
            this.cmbParts.Name = "cmbParts";
            this.cmbParts.Size = new System.Drawing.Size(137, 26);
            this.cmbParts.TabIndex = 3;
            this.cmbParts.SelectedIndexChanged += new System.EventHandler(this.cmbParts_SelectedIndexChanged);
            this.cmbParts.Click += new System.EventHandler(this.cmbParts_Click);
            // 
            // gridEdges
            // 
            this.gridEdges.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridEdges.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.gridEdges, 2);
            this.gridEdges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEdges.EnableTouchMode = true;
            this.gridEdges.Location = new System.Drawing.Point(3, 73);
            this.gridEdges.Name = "gridEdges";
            this.gridEdges.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridEdges.Size = new System.Drawing.Size(217, 167);
            this.gridEdges.TabIndex = 17;
            this.gridEdges.TableDescriptor.TableOptions.CaptionRowHeight = 29;
            this.gridEdges.TableOptions.AllowDragColumns = false;
            this.gridEdges.TableOptions.AllowDropDownCell = false;
            this.gridEdges.TableOptions.AllowMultiColumnSort = false;
            this.gridEdges.TableOptions.AllowSortColumns = false;
            this.gridEdges.UseRightToLeftCompatibleTextBox = true;
            this.gridEdges.VersionInfo = "15.1460.0.33";
            this.gridEdges.SelectedRecordsChanged += new Syncfusion.Grouping.SelectedRecordsChangedEventHandler(this.gridEdges_SelectedRecordsChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chkSelFeature, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridEdges, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFeature, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbParts, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPart, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 243);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // ucEdgeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucEdgeList";
            this.Size = new System.Drawing.Size(223, 243);
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEdges)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSelFeature;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFeature;
        private System.Windows.Forms.Label lblPart;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbParts;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridEdges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
