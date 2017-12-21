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
using VastGIS.Plugins.TableEditor.Model;
using VastGIS.Plugins.TableEditor.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.TableEditor.Views
{
    internal partial class RecalculateFieldsView : RecalculateFieldsViewBase, IRecalculateFieldsView
    {
        private List<RecalculateFieldWrapper> _fields = new List<RecalculateFieldWrapper>();

        public RecalculateFieldsView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            _fields = Model.Fields.Where(f => !string.IsNullOrWhiteSpace(f.Expression))
                                   .Select(f => new RecalculateFieldWrapper(f)).ToList();

            recalculateFieldsGrid1.DataSource = _fields;
        }

        public ButtonBase OkButton
        {
            get  { return btnOk; }
        }

        private void chkSelectAllChecked(object sender, EventArgs e)
        {
            recalculateFieldsGrid1.Adapter.SetPropertyForEach(item => item.Selected, chkSelectAll.Checked);
        }

        public void UpdateField(RecalculateFieldWrapper wrapper)
        {
            recalculateFieldsGrid1.Adapter.ReReadRecord(wrapper);
            recalculateFieldsGrid1.Refresh();
        }

        public IEnumerable<RecalculateFieldWrapper> Fields
        {
            get { return _fields.Where(f => f.Selected); }
        }
    }

    internal class RecalculateFieldsViewBase : MapWindowView<IAttributeTable>
    {
        
    }
}
