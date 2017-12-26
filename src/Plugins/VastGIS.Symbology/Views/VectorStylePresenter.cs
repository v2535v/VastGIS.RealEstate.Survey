// -------------------------------------------------------------------------------------------
// <copyright file="VectorStylePresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.Symbology.Controls.ImageCombo;
using VastGIS.Plugins.Symbology.Forms;
using VastGIS.Plugins.Symbology.Helpers;
using VastGIS.Plugins.Symbology.Views.Abstract;
using VastGIS.Projections.Helpers;
using VastGIS.Services.Serialization;
using VastGIS.Shared;

namespace VastGIS.Plugins.Symbology.Views
{
    public class VectorStylePresenter : ComplexPresenter<IVectorStyleView, VectorStyleCommand, ILegendLayer>
    {
        private readonly IAppContext _context;

        public VectorStylePresenter(IVectorStyleView view, IAppContext context )
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");

            _context = context;

            view.UpdateSpatialIndex += CreateSpatialIndex;
            view.ModifyCharts += () => RunCommand(VectorStyleCommand.ChartAppearance);
            view.ModifyLabels += () => RunCommand(VectorStyleCommand.LabelAppearance);
        }

        private IFeatureSet FeatureSet
        {
            get { return Model.FeatureSet; }
        }

        private IWin32Window ViewAsParent
        {
            get { return View as IWin32Window; }
        }

        public override void RunCommand(VectorStyleCommand command)
        {
            switch (command)
            {
                case VectorStyleCommand.ClearVisibilityExpression:
                    FeatureSet.VisibilityExpression = "";
                    View.UpdateView();
                    break;
                case VectorStyleCommand.ChangeVisibilityExpression:
                    string s = FeatureSet.VisibilityExpression;
                    if (FormHelper.ShowQueryBuilder(_context, Model, ViewAsParent, ref s, false))
                    {
                        FeatureSet.VisibilityExpression = s;
                        View.UpdateView();
                    }
                    break;
                case VectorStyleCommand.ClearLabels:
                    if (MessageService.Current.Ask("Do you want to remove labels?"))
                    {
                        FeatureSet.Labels.Items.Clear();
                        FeatureSet.Labels.Expression = "";
                    }
                    View.RefreshLabels();
                    break;
                case VectorStyleCommand.LabelAppearance:
                    using (var form = new LabelStyleForm(_context, Model))
                    {
                        _context.View.ShowChildView(form, ViewAsParent);
                    }
                    View.RefreshLabels();
                    break;
                case VectorStyleCommand.ClearCharts:
                    if (MessageService.Current.Ask("Do you want to remove charts?"))
                    {
                        FeatureSet.Diagrams.Fields.Clear();
                        FeatureSet.Diagrams.Clear();
                    }
                    View.RefreshCharts();
                    break;
                case VectorStyleCommand.OpenLocation:
                    string filename = Model.Filename;
                    if (!string.IsNullOrWhiteSpace(filename))
                    {
                        PathHelper.OpenFolderWithExplorer(filename);
                    }
                    else
                    {
                        MessageService.Current.Info("Can't find the datasource.");
                    }
                    break;
                case VectorStyleCommand.SaveStyle:
                    LayerSerializationHelper.SaveSettings(Model);
                    break;
                case VectorStyleCommand.RemoveStyle:
                    LayerSerializationHelper.RemoveSettings(Model, false);
                    break;
                case VectorStyleCommand.ProjectionDetails:
                    _context.ShowProjectionProperties(Model.Projection, View as IWin32Window);
                    break;
                case VectorStyleCommand.ChartsEditColorScheme:
                    FormHelper.EditColorSchemes(_context, SchemeTarget.Charts, ViewAsParent);
                    break;
                case VectorStyleCommand.ChartAppearance:
                    using (var form = new ChartStyleForm(_context, Model))
                    {
                        _context.View.ShowChildView(form, ViewAsParent);
                    }
                    View.RefreshCharts();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("command");
            }
        }

        public override bool ViewOkClicked()
        {
            return true;
        }

        private void CreateSpatialIndex()
        {
            var spatialIndex = FeatureSet.SpatialIndex;

            if (!View.SpatialIndex)
            {
                spatialIndex.UseDiskIndex = false;
                return;
            }

            if (spatialIndex.DiskIndexExists)
            {
                spatialIndex.UseDiskIndex = true;
                return;
            }

            if (!spatialIndex.DiskIndexExists)
            {
                View.LockView();
                try
                {
                    bool result = spatialIndex.CreateDiskIndex();
                    if (result)
                    {
                        MessageService.Current.Info("Spatial index was successfully created.");
                    }
                    else
                    {
                        MessageService.Current.Warn("Failed to create spatial index");
                    }
                }
                finally
                {
                    View.UnlockView();
                }
            }
        }
    }
}