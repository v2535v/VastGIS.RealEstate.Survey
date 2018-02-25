// -------------------------------------------------------------------------------------------
// <copyright file="AttributeExplorerPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Linq;
using VastGIS.Api.Interfaces;
using VastGIS.Attributes.Views.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;

namespace VastGIS.Attributes.Views
{
    public class AttributeExplorerPresenter : BasePresenter<IAttributeExplorer, ILayer>
    {
        private readonly IAppContext _context;

        public AttributeExplorerPresenter(IAttributeExplorer view, IAppContext context)
            : base(view)
        {
            _context = context;
            View.ZoomTo += ViewZoomTo;
            View.CurrentFeatureChanged += OnCurrentFeatureChanged;
        }

        private void OnCurrentFeatureChanged()
        {
            int index = View.CurrentFeatureIndex - 1;

            var feature = Model.FeatureSet.Features.Where(ft => ft.Selected).Skip(index).FirstOrDefault();
            if (feature != null)
            {
                _context.Map.ZoomToShape(Model.Handle, feature.Index);
            }
        }

        private void ViewZoomTo()
        {
            _context.Map.ZoomToSelected(Model.Handle);
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}