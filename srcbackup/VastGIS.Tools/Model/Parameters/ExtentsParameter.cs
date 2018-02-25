using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Tools.Model.Parameters
{
    /// <summary>
    /// Represents map extents.
    /// </summary>
    internal class ExtentsParameter: StringParameter
    {
        public override bool IsEmpty
        {
            get { return Value == null; }
        }
    }
}
