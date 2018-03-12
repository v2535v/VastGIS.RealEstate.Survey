using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VastGIS.Plugins.RealEstate.CommonControls
{
    public delegate void SelectedComplateHandler(string content);
    public partial class ucTempMapping : UserControl
    {
        public event SelectedComplateHandler SelectedComplateEvent;
        public ucTempMapping()
        {
            InitializeComponent();
        }
        public ucTempMapping(string title, string content)
        {
            InitializeComponent();
            txtTitle.Text = title;
            txtContent.Text = content;
        }

        protected virtual void OnSelectedComplateEvent(string content)
        {
            SelectedComplateEvent?.Invoke(content);
        }

        private void txtContent_Click(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;
            OnSelectedComplateEvent(textBox.Text);
        }
    }
}
