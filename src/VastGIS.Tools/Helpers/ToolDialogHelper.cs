// -------------------------------------------------------------------------------------------
// <copyright file="ToolDialogHelper.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Shared;
using VastGIS.Tools.Model;
using VastGIS.Tools.Views;

namespace VastGIS.Tools.Helpers
{
    /// <summary>
    /// Extension methods for choosing UI to set parameters of the GIS tool.
    /// </summary>
    public static class ToolDialogHelper
    {
        /// <summary>
        /// Gets MVP presenter to display UI for the tool.
        /// </summary>
        public static IPresenter<ToolViewModel> GetPresenter(this ITool tool, IAppContext context)
        {
            var attr = AttributeHelper.GetAttribute<GisToolAttribute>(tool.GetType());
            if (attr.PresenterType != null)
            {
                return context.Container.GetInstance(attr.PresenterType) as IPresenter<ToolViewModel>;
            }

            return context.Container.GetInstance<ToolPresenter>();
        }
    }
}