﻿// ********************************************************************************************************
// <copyright file="MWLite.Symbology.cs" company="MapWindow.org">
// Copyright (c) MapWindow.org. All rights reserved.
// </copyright>
// The contents of this file are subject to the Mozilla Public License Version 1.1 (the "License"); 
// you may not use this file except in compliance with the License. You may obtain a copy of the License at 
// http:// Www.mozilla.org/MPL/ 
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
// ANY KIND, either express or implied. See the License for the specificlanguage governing rights and 
// limitations under the License. 
// 
// The Initial Developer of this version of the Original Code is Sergei Leschinski
// 
// Contributor(s): (Open source contributors should list themselves and their modifications here). 
// Change Log: 
// Date            Changed By      Notes
// ********************************************************************************************************

using System;
using System.Drawing;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.Symbology.Forms
{
    public partial class AddChartsForm : MapWindowForm
    {
        private readonly IFeatureSet _shapefile;

        /// <summary>
        /// Creates a new instance of the AddChartsForm class
        /// </summary>
        public AddChartsForm(IFeatureSet sf)
        {
            InitializeComponent();

            _shapefile = sf;

            if (_shapefile.GeometryType == GeometryType.Polygon)
            {
                optPosition1.Text = "中心";
                optPosition2.Text = "重心";
                optPosition3.Text = "内部点";
                optPosition4.Visible = false;

                optPosition1.Tag = LabelPosition.Center;
                optPosition2.Tag = LabelPosition.Centroid;
                optPosition3.Tag = LabelPosition.InteriorPoint;

                groupBox5.Height -= 30;
                Height -= 30;

                optPosition2.Checked = true;
            }
            else if (_shapefile.GeometryType == GeometryType.Polyline)
            {
                optPosition1.Text = "第一部分";
                optPosition2.Text = "结束部分";
                optPosition3.Text = "中间部分";
                optPosition4.Text = "最长部分";

                optPosition1.Tag = LabelPosition.FirstSegment;
                optPosition2.Tag = LabelPosition.LastSegment;
                optPosition3.Tag = LabelPosition.MiddleSegment;
                optPosition4.Tag = LabelPosition.LongestSegement;

                optPosition4.Checked = true;
            }
        }

        /// <summary>
        /// Calculates chart positions
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                var positioning = LabelPosition.Centroid;
                if (optPosition4.Checked)
                    positioning = (LabelPosition)optPosition4.Tag;
                if (optPosition3.Checked)
                    positioning = (LabelPosition)optPosition3.Tag;
                if (optPosition2.Checked)
                    positioning = (LabelPosition)optPosition2.Tag;
                if (optPosition1.Checked)
                    positioning = (LabelPosition)optPosition1.Tag;

                _shapefile.Diagrams.Generate(positioning);
                _shapefile.Diagrams.SavingMode = PersistenceType.XmlOverwrite;
            }
            finally
            {
                Enabled = true;
                Cursor = Cursors.Default;
            }

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void AddChartsForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}
