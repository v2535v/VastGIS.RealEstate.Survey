﻿// -------------------------------------------------------------------------------------------
// <copyright file="StringParameterControl.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Windows.Forms;

namespace VastGIS.Tools.Controls.Parameters
{
    /// <summary>
    /// Represents TextBox control for entering string parameter.
    /// </summary>
    public partial class StringParameterControl : ParameterControlBase
    {
        private const int multiLineHeight = 80;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringParameterControl"/> class.
        /// </summary>
        public StringParameterControl(bool multiline = false)
        {
            InitializeComponent();
            buttonAdv1.Visible = false;

            if (multiline)
            {
                textBoxExt1.Multiline = true;
                int dif = multiLineHeight - textBoxExt1.Height;
                textBoxExt1.Height = multiLineHeight;
                Height += dif;
            }

            // the rate of update can be too high
            // consider triggering it on LostFocus
            textBoxExt1.TextChanged += (s, e) => FireValueChanged();
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
        /// Gets or sets a value indicating whether the control's text is read only.
        /// </summary>
        public bool ReadOnly
        {
            get { return textBoxExt1.ReadOnly; }
            set { textBoxExt1.ReadOnly = value; }
        }

        /// <summary>
        /// Gets control to display tooltip for.
        /// </summary>
        public override Control ToolTipControl
        {
            get { return textBoxExt1; }
        }

        /// <summary>
        /// The get value.
        /// </summary>
        public override object GetValue()
        {
            return textBoxExt1.Text;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        public override void SetValue(object value)
        {
            textBoxExt1.Text = (string)value;
        }
    }
}