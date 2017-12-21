using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Forms;

namespace VastGIS.Mvp.Sample
{
    public partial class SampleView : SampleViewBase, ISampleView
    {
        public SampleView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            textBox1.Text = Model.Name;
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get { yield return toolStrip1.Items; }
        }

        public IEnumerable<Control> Buttons
        {
            get { yield return btnTestButton; }
        }
    }

    public class SampleViewBase : MapWindowView<SampleViewModel> { }
}
