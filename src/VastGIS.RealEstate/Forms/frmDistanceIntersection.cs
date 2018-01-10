using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmDistanceIntersection : MapEditingForm
    {
        public frmDistanceIntersection(IAppContext context):base(context)
        {
            InitializeComponent();
        }
    }
}
