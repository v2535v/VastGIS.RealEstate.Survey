﻿// -------------------------------------------------------------------------------------------
// <copyright file="IInputParameterControl.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Services;

namespace VastGIS.Tools.Controls.Parameters.Interfaces
{
    /// <summary>
    /// Represents control for input datasource or filename selection.
    /// </summary>
    public interface IInputParameterControl
    {
        /// <summary>
        /// Occurs when control value is changed.
        /// </summary>
        event EventHandler<EventArgs> ValueChanged;

        /// <summary>
        /// Gets a value indicating whether control allows selection of multiple files (batch mode).
        /// </summary>
        bool BatchMode { get; }

        /// <summary>
        /// Gets values of the control.
        /// </summary>
        object GetValue();

        /// <summary>
        /// Initializes the control with specified datasource type.
        /// </summary>
        /// <param name="dataType">Type of the data.</param>
        /// <param name="dialogService">File dialog service.</param>
        /// <param name="current">The current layer</param>
        void Initialize(DataSourceType dataType, IFileDialogService dialogService, ILayer current);
    }
}