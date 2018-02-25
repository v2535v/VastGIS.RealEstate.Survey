using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Tools.Model.Parameters
{
    interface ISupportsValidation
    {
        bool Validate(out string errorMessage);
    }
}
