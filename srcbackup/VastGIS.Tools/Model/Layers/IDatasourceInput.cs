using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Tools.Enums;

namespace VastGIS.Tools.Model.Layers
{
    public interface IDatasourceInput: IDisposable
    {
        /// <summary>
        /// Gets a value indicating whether the datasource must be closed after the task is completed.
        /// </summary>
        bool CloseAfterRun { get; }

        /// <summary>
        /// Gets or sets the datasource serving as input for GIS task.
        /// </summary>
        ILayerSource Datasource { get; set; }

        /// <summary>
        /// Gets the name of the datasource.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets filename of the datasource.
        /// </summary>
        string Filename { get; }

        /// <summary>
        /// A pointer to datasource holding either identity or layer handler, sufficient to reopen 
        /// the datasource in the future.
        /// </summary>
        DatasourcePointer Pointer { get; }

        /// <summary>
        /// Gets the type of the input.
        /// </summary>
        InputType InputType { get; }

        /// <summary>
        /// Closes the input layer if CloseAfterRun flag was set.
        /// </summary>
        void Close();

        /// <summary>
        /// Gets the layer handle of the input datasource. If datasource isn't added to the map -1 will be returned.
        /// </summary>
        int LayerHandle { get; }
    }
}
