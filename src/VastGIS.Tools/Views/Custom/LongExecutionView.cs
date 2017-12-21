using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Model;
using VastGIS.Tools.Views.Custom.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Tools.Views.Custom
{
    public partial class LongExecutionView : LongExecutionViewBase, ILongExecutionView
    {
        public LongExecutionView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            
        }

        public ButtonBase OkButton
        {
            get { return btnRun; }
        }

        public double SecondsPerStep
        {
            get { return txtSecondsPerStep.DoubleValue; }
        }

        public bool RunInBackground
        {
            get { return chkBackground.Checked; }
        }

        public ProgressBar Progress
        {
            get { return progressBar1; }
        }

        public void DisableButtons()
        {
            btnClose.Enabled = false;
            btnRun.Enabled = false;
        }
    }

    public class LongExecutionViewBase : MapWindowView<ToolViewModel> { }
}
