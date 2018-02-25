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
    public class GdalConvertPresenter: GdalDriverOptionsPresenter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPresenter"/> class.
        /// </summary>
        public GdalConvertPresenter(IGdalConvertView view, IAppContext context)
            : base(view, context)
        {
        }
    }
}
