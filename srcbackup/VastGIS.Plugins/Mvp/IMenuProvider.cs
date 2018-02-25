using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Mvp
{
    public interface IMenuProvider
    {
        IEnumerable<ToolStripItemCollection> ToolStrips { get; }
        IEnumerable<Control> Buttons { get; }
    }
}
