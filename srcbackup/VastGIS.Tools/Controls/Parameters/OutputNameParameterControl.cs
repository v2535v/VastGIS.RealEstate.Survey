﻿// -------------------------------------------------------------------------------------------
// <copyright file="OutputNameParameterControl.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.IO;
using VastGIS.Api.Enums;
using VastGIS.Tools.Controls.Parameters.Interfaces;
using VastGIS.Tools.Helpers;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Controls.Parameters
{
    /// <summary>
    /// Represents control for entering output name different from filename (e.g. layer name in database).
    /// </summary>
    /// <remarks>Supports tempalted names.</remarks>
    public partial class OutputNameParameterControl : StringParameterControl, IOuputputParameterControl
    {
        private readonly bool _batchMode;
        private string _inputFilename = string.Empty;
        private string _templateName = string.Empty;

        public OutputNameParameterControl(bool batchMode)
            : base(false)
        {
            _batchMode = batchMode;
        }

        public void SetExtension(string extension)
        {
            // not needed
        }

        /// <summary>
        /// Initializes output control with specified layer type.
        /// </summary>
        public void Initialize(LayerType layerType, bool supportsInMemory = true)
        {
            // do nothing
        }

        public void OnFilenameChanged(string filename)
        {
            _inputFilename = Path.GetFileNameWithoutExtension(filename);
            RefreshName();
        }

        public void OnDatasourceChanged(IDatasourceInput input)
        {
            _inputFilename = input.Name;
            RefreshName();
        }

        public override void SetValue(object value)
        {
            var s = Convert.ToString(value);
            _templateName = s;
            RefreshName();
        }

        private void RefreshName()
        {
            if (_batchMode)
            {
                textBoxExt1.Text = _templateName;
            }
            else
            {
                // TODO: remove when tested
                //textBoxExt1.Text = TemplateNameResolver.Resolve(_inputFilename, _templateName, false);
                textBoxExt1.Text = _templateName.Replace(TemplateNameResolver.Input, _inputFilename);
            }
        }
    }
}