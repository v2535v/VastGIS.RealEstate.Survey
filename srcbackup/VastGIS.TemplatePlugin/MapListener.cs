﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapListener.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The map listener.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace VastGIS.Plugins.TemplatePlugin
{
    #region

    using System;
    using System.Diagnostics;
    using System.IO;

    using VastGIS.Api.Events;
    using VastGIS.Api.Interfaces;
    using VastGIS.Api.Legend.Abstract;
    using VastGIS.Api.Legend.Events;
    using VastGIS.Plugins.Interfaces;

    #endregion

    /// <summary>
    ///     The map listener.
    /// </summary>
    public class MapListener
    {
        #region Fields

        /// <summary>
        ///     The context of the application, holding the menu, layers, project, etc.
        /// </summary>
        private readonly IAppContext _context;

        /// <summary>
        /// The _sample dock window.
        /// </summary>
        private readonly SampleDockWindow _sampleDockWindow;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapListener"/> class.
        /// </summary>
        /// <param name="context">
        /// The application context.
        /// </param>
        /// <param name="plugin">
        /// The plugin.
        /// </param>
        /// <param name="sampleDockWindow">
        /// Reference to the sample dock window
        /// </param>
        public MapListener(IAppContext context, InitPlugin plugin, SampleDockWindow sampleDockWindow)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }

            if (sampleDockWindow == null)
            {
                throw new ArgumentNullException("sampleDockWindow");
            }

            // Save local references:
            _context = context;
            _sampleDockWindow = sampleDockWindow;

            // As show case:
            Debug.WriteLine("Number of loaded layers; " + _context.Layers.Count);

            // Create event handlers:
            plugin.ExtentsChanged += this.PluginOnExtentsChanged;
            plugin.ChooseLayer += this.PluginOnChooseLayer;
            plugin.LayerSelected += this.PluginOnLayerSelected;
        }

        #endregion

        #region Methods

        /// <summary>
        /// The plugin on choose layer.
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void PluginOnChooseLayer(IMuteMap map, ChooseLayerEventArgs e)
        {
            if (e.LayerHandle == -1)
            {
                return;
            }

            _sampleDockWindow.Write(
                "MapListener.PluginOnChooseLayer", 
                "Selected layer name: " + Path.GetFileName(_context.Layers.ItemByHandle(e.LayerHandle).Filename));
        }

        /// <summary>
        /// The extents changed event handler
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        /// <param name="e">
        /// The event arguments
        /// </param>
        private void PluginOnExtentsChanged(IMuteMap map, EventArgs e)
        {
            _sampleDockWindow.Write("MapListener.PluginOnExtentsChanged", map.Extents.ToString());
        }

        /// <summary>
        /// The layer selected event handler
        /// </summary>
        /// <param name="legend">
        /// The legend.
        /// </param>
        /// <param name="e">
        /// The layer event arguments
        /// </param>
        private void PluginOnLayerSelected(IMuteLegend legend, LayerEventArgs e)
        {
            if (e.LayerHandle == -1)
            {
                return;
            }

            string filename = _context.Layers.ItemByHandle(e.LayerHandle).Filename;
            if (File.Exists(filename))
            {
                filename = Path.GetFileName(filename);
            }

            _sampleDockWindow.Write("MapListener.PluginOnLayerSelected", "Selected layer: " + filename);
        }

        #endregion
    }
}