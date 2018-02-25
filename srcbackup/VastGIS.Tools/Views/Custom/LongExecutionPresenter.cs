using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;
using VastGIS.Tools.Tools.Fake;
using VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools;
using VastGIS.Tools.Views.Custom.Abstract;

namespace VastGIS.Tools.Views.Custom
{
    #if DEBUG
    public class LongExecutionPresenter: BasePresenter<ILongExecutionView, ToolViewModel>
    {
        private readonly IAppContext _context;

        public LongExecutionPresenter(IAppContext context, ILongExecutionView view)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public override bool ViewOkClicked()
        {
            var tool = Model.Tool as LongExecutionTool;
            if (tool == null) throw new InvalidCastException("LongExecutionTool was expected");

            tool.SecondsPerStep = View.SecondsPerStep;

            if (!tool.Validate())
            {
                return false;
            }

            View.DisableButtons();

            var task = Model.CreateTask();

            if (!View.RunInBackground)
            {
                task.StatusChanged += OnStatusChanged;
                task.Progress.ProgressChanged += OnProgressChanged;
            }

            task.RunAsync();

            return View.RunInBackground;
        }

        private void OnStatusChanged(object sender, TaskStatusChangedEventArgs e)
        {
            if (e.Task.IsFinished)
            {
                _context.Tasks.Add(e.Task);
                View.Close();
            }
        }

        private void OnProgressChanged(object sender, ProgressEventArgs e)
        {
            var progress = View.Progress;
            Action action = () => progress.Value = e.Percent;
            progress.SafeInvoke(action);
        }
    }
#endif
}
