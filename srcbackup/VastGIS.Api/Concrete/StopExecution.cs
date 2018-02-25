using System;
using MapWinGIS;
using VastGIS.Api.Interfaces;

namespace VastGIS.Api.Concrete
{
    internal class StopExecution: IStopExecution
    {
        private readonly IStopExecutionCallback _callback;

        internal StopExecution(IStopExecutionCallback callback)
        {
            _callback = callback;
            if (callback == null)
            {
                throw new NullReferenceException("Internal reference is null.");
            }
        }

        public bool StopFunction()
        {
            return _callback.Stop();
        }
    }
}
