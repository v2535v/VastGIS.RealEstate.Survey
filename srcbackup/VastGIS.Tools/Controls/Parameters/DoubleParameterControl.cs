﻿// -------------------------------------------------------------------------------------------
// <copyright file="DoubleParameterControl.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace VastGIS.Tools.Controls.Parameters
{
    /// <summary>
    /// Represents control for entering value of double parameter. Doesn't allow empty values.
    /// </summary>
    public partial class DoubleParameterControl : ParameterControlBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringParameterControl"/> class.
        /// </summary>
        public DoubleParameterControl()
        {
            InitializeComponent();
            buttonAdv1.Visible = false;
        }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        public override string Caption
        {
            get { return label1.Text; }

            set { label1.Text = value; }
        }

        /// <summary>
        /// Gets control to display tooltip for.
        /// </summary>
        public override Control ToolTipControl
        {
            get { return doubleTextBox1; }
        }

        /// <summary>
        /// The get value.
        /// </summary>
        public override object GetValue()
        {
            return doubleTextBox1.DoubleValue;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        public override void SetValue(object value)
        {
            doubleTextBox1.DoubleValue = Convert.ToDouble(value);
        }
    }
}