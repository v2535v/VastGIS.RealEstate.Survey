using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VastGIS.Api.Legend.Events
{
    public class ChartFieldClickedEventArgs: LayerMouseEventArgs
    {
        public int FieldIndex { get; internal set; }

        public ChartFieldClickedEventArgs(int layerHandle, MouseButtons buttons, int fieldIndex) : base(layerHandle, buttons)
        {
            FieldIndex = fieldIndex;
        }
    }
}
