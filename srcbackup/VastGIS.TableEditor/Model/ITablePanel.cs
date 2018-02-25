using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.TableEditor.Model
{
    public interface ITablePanel: IDockPanel
    {
        int LayerHandle { get; }
    }
}
