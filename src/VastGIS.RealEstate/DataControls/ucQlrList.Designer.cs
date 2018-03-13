namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucQlrList
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
            this.lblList = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteQlr = new System.Windows.Forms.Button();
            this.btnEditQlr = new System.Windows.Forms.Button();
            this.btnNewQlr = new System.Windows.Forms.Button();
            this.gridQlrs = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQlrs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblList, 8);
            this.lblList.Location = new System.Drawing.Point(15, 10);
            this.lblList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(65, 12);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "权利人列表";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteQlr, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEditQlr, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewQlr, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridQlrs, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblList, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 279);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btnDeleteQlr
            // 
            this.btnDeleteQlr.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_delete;
            this.btnDeleteQlr.Location = new System.Drawing.Point(159, 232);
            this.btnDeleteQlr.Name = "btnDeleteQlr";
            this.btnDeleteQlr.Size = new System.Drawing.Size(28, 34);
            this.btnDeleteQlr.TabIndex = 22;
            this.btnDeleteQlr.UseVisualStyleBackColor = true;
            this.btnDeleteQlr.Click += new System.EventHandler(this.btnDeleteQlr_Click);
            // 
            // btnEditQlr
            // 
            this.btnEditQlr.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_createall;
            this.btnEditQlr.Location = new System.Drawing.Point(87, 232);
            this.btnEditQlr.Name = "btnEditQlr";
            this.btnEditQlr.Size = new System.Drawing.Size(28, 34);
            this.btnEditQlr.TabIndex = 21;
            this.btnEditQlr.UseVisualStyleBackColor = true;
            this.btnEditQlr.Click += new System.EventHandler(this.btnEditQlr_Click);
            // 
            // btnNewQlr
            // 
            this.btnNewQlr.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_add;
            this.btnNewQlr.Location = new System.Drawing.Point(15, 232);
            this.btnNewQlr.Name = "btnNewQlr";
            this.btnNewQlr.Size = new System.Drawing.Size(28, 34);
            this.btnNewQlr.TabIndex = 20;
            this.btnNewQlr.UseVisualStyleBackColor = true;
            this.btnNewQlr.Click += new System.EventHandler(this.btnNewQlr_Click);
            // 
            // gridQlrs
            // 
            this.gridQlrs.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridQlrs.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.gridQlrs, 8);
            this.gridQlrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQlrs.EnableTouchMode = true;
            this.gridQlrs.Location = new System.Drawing.Point(15, 33);
            this.gridQlrs.Name = "gridQlrs";
            this.gridQlrs.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridQlrs.Size = new System.Drawing.Size(570, 193);
            this.gridQlrs.TabIndex = 19;
            this.gridQlrs.TableDescriptor.TableOptions.CaptionRowHeight = 29;
            this.gridQlrs.TableOptions.AllowDragColumns = false;
            this.gridQlrs.TableOptions.AllowDropDownCell = false;
            this.gridQlrs.TableOptions.AllowMultiColumnSort = false;
            this.gridQlrs.TableOptions.AllowSortColumns = false;
            this.gridQlrs.UseRightToLeftCompatibleTextBox = true;
            this.gridQlrs.VersionInfo = "15.1460.0.33";
            this.gridQlrs.SelectedRecordsChanged += new Syncfusion.Grouping.SelectedRecordsChangedEventHandler(this.gridAttachments_SelectedRecordsChanged);
            // 
            // ucQlrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucQlrList";
            this.Size = new System.Drawing.Size(604, 279);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQlrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDeleteQlr;
        private System.Windows.Forms.Button btnEditQlr;
        private System.Windows.Forms.Button btnNewQlr;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridQlrs;
    }
}
