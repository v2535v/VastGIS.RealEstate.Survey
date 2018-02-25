using System.Collections.Generic;
using System.Windows.Forms;
using VastGIS.Plugins.Mvp;
using VastGIS.Services.Controls;
using VastGIS.Services.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Services.Views
{
    public partial class MissingLayersView : MissingLayersViewBase, IMissingLayersView
    {
        public MissingLayersView()
        {
            InitializeComponent();
        }

        public override ViewStyle Style
        {
            get
            {
                return new ViewStyle()
                {
                    Modal = true,
                    Sizable = true
                };
            }   
        }

        public void Initialize()
        {
            missingLayersGrid1.DataSource = Model;
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }
    }

    public class MissingLayersViewBase: MapWindowView<List<MissingLayer>> { }
}
