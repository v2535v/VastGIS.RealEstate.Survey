using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Events;

namespace VastGIS.Plugins.Interfaces
{
    public interface IComboBoxMenuItem: IMenuItem
    {
        StringCollection DataSource { get; }
        int Width { get; set; }
        event EventHandler<StringValueChangedEventArgs> ValueChanged;
        void Focus();
    }
}
