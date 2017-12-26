// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleDockWindow.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The sample dock window.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace VastGIS.Plugins.TemplatePlugin
{
    #region

    using System;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    /// The sample dock window.
    /// </summary>
    public partial class SampleDockWindow : UserControl
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleDockWindow"/> class.
        /// </summary>
        public SampleDockWindow()
        {
            InitializeComponent();
        }

        #endregion

        public void Write(string prefix, string message)
        {
            if (Visible)
            {
                DebugTextbox.AppendText(string.Format("[{0}]: {1}{2}", prefix, message, Environment.NewLine));
            }
        }
    }
}