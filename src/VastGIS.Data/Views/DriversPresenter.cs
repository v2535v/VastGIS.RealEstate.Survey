using VastGIS.Api.Concrete;
using VastGIS.Data.Views.Abstract;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Data.Views
{
    public class DriversPresenter: BasePresenter<IDriversView, DriverManager>
    {
        public DriversPresenter(IDriversView view) : base(view)
        {
            
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
