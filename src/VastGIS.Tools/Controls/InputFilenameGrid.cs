using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Services.Helpers;
using VastGIS.Services.Views;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;
using VastGIS.UI.Controls;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace VastGIS.Tools.Controls
{
    internal partial class InputFilenameGrid : StronglyTypedGrid<InputFilenameGridAdapter>
    {
        public InputFilenameGrid()
        {
            InitializeComponent();

            Adapter.HotTracking = false;
            Adapter.ReadOnly = false;
            Adapter.AllowCurrentCell = false;

            ShowColumnHeaders = false;
        }

        protected override void UpdateColumns()
        {
            Adapter.HideColumns();

            Adapter.ShowColumn(f => f.Filename);
            Adapter.GetColumn(f => f.Filename).Width = Width - 30;
        }
    }
}
