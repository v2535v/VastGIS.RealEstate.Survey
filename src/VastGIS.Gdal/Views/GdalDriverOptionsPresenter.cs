using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Gdal.Model;
using VastGIS.Gdal.Views.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Helpers;
using VastGIS.Tools.Views;

namespace VastGIS.Gdal.Views
{
    public class GdalDriverOptionsPresenter: GdalPresenter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPresenter"/> class.
        /// </summary>
        public GdalDriverOptionsPresenter(IGdalDriverOptionsView view, IAppContext context)
            : base(view, context)
        {
        }

        public override bool ViewOkClicked()
        {
            SaveDriverConfig();

            return base.ViewOkClicked();
        }

        private void SaveDriverConfig()
        {
            var view = View as IGdalConvertView;
            if (view == null)
            {
                return;
            }

            var tool = Model.Tool as GdalRasterTool;
            if (tool != null)
            {
                tool.OutputFormat.SaveConfig(view.DriverParameters);
            }
        }
    }
}
