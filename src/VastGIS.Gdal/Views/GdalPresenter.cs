using VastGIS.Gdal.Model;
using VastGIS.Gdal.Tools;
using VastGIS.Gdal.Views.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Helpers;
using VastGIS.Tools.Views;

namespace VastGIS.Gdal.Views
{
    public class GdalPresenter: ToolPresenter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPresenter"/> class.
        /// </summary>
        public GdalPresenter(IGdalView view, IAppContext context)
            : base(view, context)
        {
        }
    }
}
