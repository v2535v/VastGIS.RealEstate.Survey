﻿using System;
using System.Linq.Expressions;
using VastGIS.Tools.Model.Layers;
using VastGIS.Tools.Model.Parameters;
using VastGIS.Tools.Services;

namespace VastGIS.Tools.Model
{
    /// <summary>
    /// Represents GIS tool with a list of parameters for UI generation.
    /// </summary>
    public interface IParametrizedTool
    {
        /// <summary>
        /// Gets the list of parameters.
        /// </summary>
        ParameterCollection Parameters { get; }

        /// <summary>
        /// Gets tool configuration.
        /// </summary>
        ToolConfiguration Configuration { get; }

        /// <summary>
        /// Strongly typed method to find parameter corresponding to particular property of the tool.
        /// </summary>
        BaseParameter FindParameter<TTool, T>(Expression<Func<TTool, T>> layer);
    }
}
