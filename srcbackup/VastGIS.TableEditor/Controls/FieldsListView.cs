using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Attributes.Model;
using VastGIS.Plugins.TableEditor.Model;

namespace VastGIS.Plugins.TableEditor.Controls
{
    public partial class FieldsListView : ListView
    {
        public FieldsListView()
        {
            InitializeComponent();

            View = View.SmallIcon;
        }

        public void SetFields(IEnumerable<FieldWrapper> fields) 
        {
            if (fields == null)
            {
                return;
            }

            Items.Clear();
            foreach (var fld in fields)
            {
                Items.Add(new ListViewItem()
                {
                    Text = fld.Name,
                    Checked = fld.Selected
                });
            }
        }
    }
}
