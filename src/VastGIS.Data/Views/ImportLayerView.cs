using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Data.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Data.Views
{
    public partial class ImportLayerView : MapWindowView, IImportLayerView
    {
        public ImportLayerView()
        {
            InitializeComponent();
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }
    }
}
