using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Tools.Model.Parameters
{
    interface IOutputParameter
    {
        void ResolveTemplateName(string inputFilename);
    }
}
