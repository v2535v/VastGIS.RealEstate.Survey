namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmLayerManagement
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageLayers = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dgvLayers = new System.Windows.Forms.DataGridView();
            this.ColCanDisplay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCanIdentify = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCanEditing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCanSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCanSanpping = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageLayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(648, 255);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageLayers);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(648, 255);
            this.tabControlAdv1.TabIndex = 0;
            // 
            // tabPageLayers
            // 
            this.tabPageLayers.Controls.Add(this.dgvLayers);
            this.tabPageLayers.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.LayerManagement;
            this.tabPageLayers.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageLayers.Location = new System.Drawing.Point(1, 28);
            this.tabPageLayers.Name = "tabPageLayers";
            this.tabPageLayers.ShowCloseButton = true;
            this.tabPageLayers.Size = new System.Drawing.Size(645, 225);
            this.tabPageLayers.TabIndex = 1;
            this.tabPageLayers.Text = "层";
            this.tabPageLayers.ThemesEnabled = false;
            // 
            // dgvLayers
            // 
            this.dgvLayers.AllowUserToAddRows = false;
            this.dgvLayers.AllowUserToDeleteRows = false;
            this.dgvLayers.AllowUserToResizeColumns = false;
            this.dgvLayers.AllowUserToResizeRows = false;
            this.dgvLayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCanDisplay,
            this.ColCaption,
            this.ColCanIdentify,
            this.ColCanEditing,
            this.ColCanSelect,
            this.ColCanSanpping,
            this.ColName});
            this.dgvLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLayers.Location = new System.Drawing.Point(0, 0);
            this.dgvLayers.MultiSelect = false;
            this.dgvLayers.Name = "dgvLayers";
            this.dgvLayers.RowHeadersVisible = false;
            this.dgvLayers.RowTemplate.Height = 23;
            this.dgvLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLayers.Size = new System.Drawing.Size(645, 225);
            this.dgvLayers.TabIndex = 1;
            // 
            // ColCanDisplay
            // 
            this.ColCanDisplay.DataPropertyName = "Visible";
            this.ColCanDisplay.HeaderText = "显示";
            this.ColCanDisplay.Name = "ColCanDisplay";
            // 
            // ColCaption
            // 
            this.ColCaption.DataPropertyName = "Zwmc";
            this.ColCaption.HeaderText = "层名";
            this.ColCaption.Name = "ColCaption";
            this.ColCaption.ReadOnly = true;
            // 
            // ColCanIdentify
            // 
            this.ColCanIdentify.DataPropertyName = "Identify";
            this.ColCanIdentify.HeaderText = "查看定义";
            this.ColCanIdentify.Name = "ColCanIdentify";
            this.ColCanIdentify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCanIdentify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColCanEditing
            // 
            this.ColCanEditing.DataPropertyName = "Editable";
            this.ColCanEditing.HeaderText = "可编辑";
            this.ColCanEditing.Name = "ColCanEditing";
            // 
            // ColCanSelect
            // 
            this.ColCanSelect.DataPropertyName = "Queryable";
            this.ColCanSelect.HeaderText = "可查询";
            this.ColCanSelect.Name = "ColCanSelect";
            // 
            // ColCanSanpping
            // 
            this.ColCanSanpping.DataPropertyName = "Snapable";
            this.ColCanSanpping.HeaderText = "可捕捉";
            this.ColCanSanpping.Name = "ColCanSanpping";
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Mc";
            this.ColName.HeaderText = "表名";
            this.ColName.Name = "ColName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 36);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(567, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 36);
            this.panel3.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnOK.IsBackStageButton = false;
            this.btnOK.Location = new System.Drawing.Point(3, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmLayerManagement
            // 
            this.AcceptButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(648, 291);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.panel1);
            this.Name = "frmLayerManagement";
            this.Text = "图层管理";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageLayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageLayers;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private System.Windows.Forms.DataGridView dgvLayers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCanDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCaption;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCanIdentify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCanEditing;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCanSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCanSanpping;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
    }
}
