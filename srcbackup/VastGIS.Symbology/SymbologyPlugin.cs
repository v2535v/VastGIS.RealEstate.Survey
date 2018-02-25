﻿using System.Collections.Generic;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Symbology.Controls.ImageCombo;
using VastGIS.Plugins.Symbology.Menu;
using VastGIS.Plugins.Symbology.Model;
using VastGIS.Plugins.Symbology.Services;

namespace VastGIS.Plugins.Symbology
{
    [MapWindowPlugin(loadOnStartUp: true)]
    public class SymbologyPlugin : BasePlugin
    {
        private static IAppContext _context;
        private LegendListener _legendListener;
        private MenuGenerator _menuGenerator;
        private MenuListener _menuListener;
        private LabelMover _labelMover;
        private SymbologyMetadataService _metadataService;

        internal static SymbologyMetadata GetMetadata(int layerHandle)
        {
            var service = _context.Container.Resolve<SymbologyMetadataService>();
            var metadata = service.Get(layerHandle);

            if (!metadata.Initialized)
            {
                var layer = _context.Layers.ItemByHandle(layerHandle);
                if (layer != null && layer.FeatureSet != null)
                {
                    metadata.ShowLayerPreview = layer.FeatureSet.NumFeatures < 5000;
                    metadata.Initialized = true;
                }
            }

            return metadata;
        }

        internal static void SaveMetadata(int layerHandle, SymbologyMetadata metadata)
        {
            var service = _context.Container.Resolve<SymbologyMetadataService>();
            service.Save(layerHandle, new SymbologyMetadata());
        }

        public override IEnumerable<IConfigPage> ConfigPages
        {
            get { yield return _context.Container.GetInstance<SymbologyConfigPage>(); }
        }

        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);

            ColorSchemeProvider.Load();
        }

        public override void Initialize(IAppContext context)
        {
            _context = context;

            _metadataService = context.Container.GetSingleton<SymbologyMetadataService>();
            _labelMover = context.Container.GetSingleton<LabelMover>();
            _legendListener = context.Container.GetInstance<LegendListener>();
            _menuGenerator = context.Container.GetInstance<MenuGenerator>();
            _menuListener = context.Container.GetInstance<MenuListener>();
        }

        public override void Terminate()
        {
            _menuListener.OnPluginUnloaded();
        }
    }
}
