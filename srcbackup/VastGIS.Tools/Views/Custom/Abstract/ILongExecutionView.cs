using System.Windows.Forms;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Tools.Views.Custom.Abstract
{
    public interface ILongExecutionView: IView<ToolViewModel>
    {
        double SecondsPerStep { get; }

        bool RunInBackground { get; }

        ProgressBar Progress { get; }

        void DisableButtons();
    }
}
