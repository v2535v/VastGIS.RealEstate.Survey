using System.Threading;
using VastGIS.Shared.Log;

namespace VastGIS.Plugins.Interfaces
{
    public interface ITaskHandle
    {
        ITaskProgress Progress { get; }

        WaitHandle PauseHandle { get; }

        bool IsCancelled { get; }

        void AbortIfCancelled();

        void CheckPauseAndCancel();

        IGlobalListener Callback { get; }
    }
}
