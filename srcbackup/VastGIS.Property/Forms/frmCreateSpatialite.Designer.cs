namespace VastGIS.Property.Forms
{
    partial class frmCreateSpatialite
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCoordSys = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtCoordSys = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库保存位置:";
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(339, 44);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(75, 23);
            this.btnDB.TabIndex = 2;
            this.btnDB.Text = "选择...";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "坐标系:";
            // 
            // btnCoordSys
            // 
            this.btnCoordSys.Location = new System.Drawing.Point(339, 100);
            this.btnCoordSys.Name = "btnCoordSys";
            this.btnCoordSys.Size = new System.Drawing.Size(75, 23);
            this.btnCoordSys.TabIndex = 4;
            this.btnCoordSys.Text = "选择...";
            this.btnCoordSys.UseVisualStyleBackColor = true;
            this.btnCoordSys.Click += new System.EventHandler(this.btnCoordSys_Click);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(14, 44);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(319, 21);
            this.txtDB.TabIndex = 5;
            // 
            // txtCoordSys
            // 
            this.txtCoordSys.Location = new System.Drawing.Point(14, 102);
            this.txtCoordSys.Name = "txtCoordSys";
            this.txtCoordSys.Size = new System.Drawing.Size(319, 21);
            this.txtCoordSys.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "创建";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateSpatialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 195);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCoordSys);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.btnCoordSys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateSpatialite";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.Text = "新建不动产数据库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCoordSys;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtCoordSys;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancel;
    }
}