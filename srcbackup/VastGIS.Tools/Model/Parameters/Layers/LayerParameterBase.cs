﻿// -------------------------------------------------------------------------------------------
// <copyright file="GenericLayerParameter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Linq;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Tools.Controls.Parameters;
using VastGIS.Tools.Controls.Parameters.Input;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Model.Parameters.Layers
{
    internal abstract class LayerParameterBase : BaseParameter, IInputParameter
    {
        public abstract DataSourceType DataSourceType { get; }

        public abstract ILayerSource Datasource { get; }

        /// <summary>
        /// Gets or sets the pointer of the datasource that was used during tool execution.
        /// </summary>
        public DatasourcePointer ClosedPointer { get; set; }

        /// <summary>
        /// Gets the name of the datasource, stored either in Datasource or ClosedPointer properties.
        /// </summary>
        public string DatasourceName
        {
            get
            {
                var ds = Datasource;
                if (ds != null)
                {
                    return Path.GetFileNameWithoutExtension(ds.Filename);
                }

                if (ClosedPointer != null)
                {
                    return ClosedPointer.Name;
                }

                return string.Empty;
            }
        }

        public override string ToString()
        {
            var info = Value as IDatasourceInput;
            return string.Format("{0}: {1}", DisplayName, info != null ? info.Name : string.Empty);
        }

        private IEnumerable<IDatasourceInput> Inputs
        {
            get
            {
                var blpc = Control as BatchLayerParameterControl;
                if (blpc != null)
                {
                    return blpc.Layers;
                }

                return new List<IDatasourceInput>();
            }
        }

        public object BatchInputs
        {
            get { return Inputs; }
        }

        public bool HasBatchInputs
        {
            get { return Inputs.Any(); }
        }
    }
}