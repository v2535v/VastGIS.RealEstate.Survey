using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Events;
using VastGIS.Services.Serialization;
using VastGIS.Shared;

namespace VastGIS.Services.Concrete
{
    public class ProjectLoaderBase : IProjectLoaderBase
    {
        protected void FireProgressChanged(int step, int total, string message)
        {
            double percent = step / (double)total * 100.0;

            DelegateHelper.FireEvent(this, ProgressChanged, new ProgressEventArgs(message, Convert.ToInt32(percent)));
        }

        public event EventHandler<ProgressEventArgs> ProgressChanged;
    }
}
