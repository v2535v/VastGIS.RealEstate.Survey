using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VastGIS.Plugins.RealEstate.Viewer
{
    public partial class frmImageViewer : Form
    {
        public frmImageViewer(List<string> files, string currentFile)
        {
            InitializeComponent();
            ucImageViewer1.LoadImages(files,currentFile);
        }
    }
}
