namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucFeatureListSingle
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstFeatureList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFeatureList
            // 
            this.lstFeatureList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFeatureList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstFeatureList.FormattingEnabled = true;
            this.lstFeatureList.ItemHeight = 16;
            this.lstFeatureList.Location = new System.Drawing.Point(0, 0);
            this.lstFeatureList.Name = "lstFeatureList";
            this.lstFeatureList.Size = new System.Drawing.Size(384, 379);
            this.lstFeatureList.TabIndex = 0;
            this.lstFeatureList.SelectedIndexChanged += new System.EventHandler(this.lstFeatureList_SelectedIndexChanged);
            // 
            // ucFeatureListSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstFeatureList);
            this.Name = "ucFeatureListSingle";
            this.Size = new System.Drawing.Size(384, 379);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFeatureList;
    }
}
