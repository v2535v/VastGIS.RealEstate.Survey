using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Tools.Model.Layers;
using VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools;
using VastGIS.Tools.Views.Custom.Abstract;

namespace VastGIS.Tools.Views.Custom
{
    public class RandomPointsPresenter: BasePresenter<IRandomPointsView, ToolViewModel>
    {
        private readonly IAppContext _context;

        public RandomPointsPresenter(IAppContext context, IRandomPointsView view)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public override bool ViewOkClicked()
        {
            var tool = Model.Tool as RandomPointsTool;
            if (tool == null) throw new InvalidCastException("RandomPointsTool was expected");

            tool.NumPoints = View.NumPoints;
            tool.InputLayer = new DatasourceInput(View.Input);
            tool.OutputLayer = new Model.OutputLayerInfo() { Filename = View.OutputName, MemoryLayer = true, AddToMap = true };

            if (!tool.Validate())
            {
                return false;
            }

            var task = Model.CreateTask();

            task.RunAsync();

            return true;
        }
    }
}
