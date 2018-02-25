using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Tools.Services
{
    public class CallbackProgress : TaskProgressBase
    {
        private readonly Action<string, int> _progress;

        public CallbackProgress(Action<string, int> progress)
        {
            if (progress == null) throw new ArgumentNullException("progress");
            _progress = progress;
        }

        public override void Update(string msg, int value)
        {
            _progress(msg, value);
        }

        public override void Clear()
        {
            _progress(string.Empty, 100);
        }

        public override event EventHandler<ProgressEventArgs> ProgressChanged;

        public override event EventHandler Hide;
    }
}
