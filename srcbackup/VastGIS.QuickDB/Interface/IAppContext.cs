using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.QuickDB.Interface
{
   public  interface IAppContext
    {
        IApplicationContainer Container { get; }

        IBDCDatabase CurrentDatabase { get; }

        IAppView View { get; }
    }
}
