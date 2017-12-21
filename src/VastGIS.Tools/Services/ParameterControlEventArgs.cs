using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Tools.Controls.Parameters;

namespace VastGIS.Tools.Services
{
    public class ParameterControlEventArgs: EventArgs
    {
        public ParameterControlEventArgs(ParameterControlBase control)
        {
            if (control == null) throw new ArgumentNullException("control");
            Control = control;
        }

        public ParameterControlBase Control { get; private set; }

        public object Value
        {
            get { return Control != null ? Control.GetValue(): null; }
        }
    }
}
