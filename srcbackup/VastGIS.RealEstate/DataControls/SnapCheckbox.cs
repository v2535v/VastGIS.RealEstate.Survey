using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class SnapCheckbox : CheckBox
    {
        private RealEstateEditor _plugin;
        public SnapCheckbox()
        {
            InitializeComponent();
        }

        public SnapCheckbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void BindPlugin(RealEstateEditor plugin)
        {
            _plugin = plugin;
            this.DataBindings.Add("Checked", _plugin.Config, "IsSnapping");
        }
    }
}
