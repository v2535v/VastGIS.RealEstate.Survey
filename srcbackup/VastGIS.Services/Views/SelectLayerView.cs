using System;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Plugins.Mvp;
using VastGIS.Services.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Services.Views
{
    public partial class SelectLayerView : SelectLayerViewBase, ISelectLayerView
    {
        public SelectLayerView()
        {
            InitializeComponent();

            chkSelectAll.CheckedChanged += OnSelectAllChecked;
        }

        private void OnSelectAllChecked(object sender, EventArgs e)
        {
            selectLayerGrid1.Adapter.SetPropertyForEach(item => item.Selected, chkSelectAll.Checked);
        }

        public override ViewStyle Style
        {
            get { return new ViewStyle() { Sizable = true, Modal = true }; }
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            selectLayerGrid1.DataSource = Model.Layers;
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }
    }

    public class SelectLayerViewBase : MapWindowView<SelectLayerModel> { }
}
