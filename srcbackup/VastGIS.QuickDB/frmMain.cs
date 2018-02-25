#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VastGIS.QuickDB
{
    public partial class frmMain : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewDatabase_Click(object sender, EventArgs e)
        {
            frmCreateDB frm=new frmCreateDB();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
