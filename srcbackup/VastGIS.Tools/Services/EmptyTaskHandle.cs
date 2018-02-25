﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared.Log;

namespace VastGIS.Tools.Services
{
    /// <summary>
    /// A mock for ITaskHandle to enable calling IGisTool.Run inherited from ITool.
    /// </summary>
    public class EmptyTaskHandle: ITaskHandle
    {
        private readonly WaitHandle _waitHandle = new ManualResetEvent(true);
        private readonly EmptyProgress _progress = new EmptyProgress();

        public ITaskProgress Progress
        {
            get { return _progress; }
        }

        public WaitHandle PauseHandle
        {
            get { return _waitHandle; }
        }

        public bool IsCancelled
        {
            get { return false; }
        }

        public void AbortIfCancelled()
        {
            
        }

        public void CheckPauseAndCancel()
        {
            
        }

        public IGlobalListener Callback { get; private set; }
    }
}
