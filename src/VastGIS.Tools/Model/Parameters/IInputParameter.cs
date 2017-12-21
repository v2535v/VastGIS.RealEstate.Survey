using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Tools.Model.Parameters
{
    interface IInputParameter
    {
        object BatchInputs { get; }

        bool HasBatchInputs { get; }
    }
}
