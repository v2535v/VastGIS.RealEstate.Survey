using VastGIS.Gdal.Views;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Gdal.Legacy.Views
{
    public class GdalOptionsPresenter: BasePresenter<IGdalOptionsView, GdalOptionsModel>
    {
        public GdalOptionsPresenter(IGdalOptionsView view)
            : base(view)
        {
        }

        /// <summary>
        /// A handler for the IView.OkButton.Click event. 
        /// If the method returns true, View will be closed and presenter.ReturnValue set to true.
        /// If the method return false, no actions are taken, so View.Close, presenter.ReturnValue
        /// should be called / set manually.
        /// </summary>
        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
