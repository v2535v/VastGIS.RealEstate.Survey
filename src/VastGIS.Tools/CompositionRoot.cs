// -------------------------------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Services.Views;
using VastGIS.Services.Views.Abstract;
using VastGIS.Shared;
using VastGIS.Tools.Controls.Parameters;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Helpers;
using VastGIS.Tools.Model;
using VastGIS.Tools.Services;
using VastGIS.Tools.Toolbox;
using VastGIS.Tools.Views;
using VastGIS.Tools.Views.Abstract;
using VastGIS.Tools.Views.Custom;
using VastGIS.Tools.Views.Custom.Abstract;

namespace VastGIS.Tools
{
    /// <summary>
    /// The composition root.
    /// </summary>
    internal static class CompositionRoot
    {
        /// <summary>
        /// Composes the specified container.
        /// </summary>
        /// <param name="container">The container.</param>
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterView<IToolView, ToolView>()
                .RegisterView<ITaskLogView, TaskLogView>()
                .RegisterView<IRandomPointsView, RandomPointsView>()
                .RegisterView<ILongExecutionView, LongExecutionView>()
                .RegisterSingleton<ITaskCollection, TaskCollection>()
                .RegisterService<ParameterControlFactory>()
                .RegisterService<ParameterControlGenerator>()
                .RegisterSingleton<ToolboxPresenter>()
                .RegisterSingleton<ToolboxDockPanel>()
                .RegisterSingleton<TasksDockPanel>()
                .RegisterSingleton<TasksPresenter>()
                .RegisterService<OutputManager>();

            EnumHelper.RegisterConverter(new FieldOperationValidityConverter());
        }
    }
}