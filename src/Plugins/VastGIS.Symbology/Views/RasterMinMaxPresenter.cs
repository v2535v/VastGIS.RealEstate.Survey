using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.Symbology.Views.Abstract;

namespace VastGIS.Plugins.Symbology.Views
{
    public class RasterMinMaxPresenter: BasePresenter<IRasterMinMaxView, RasterMinMaxModel>
    {
        public RasterMinMaxPresenter(IRasterMinMaxView view) : base(view)
        {
            
        }

        public override bool ViewOkClicked()
        {
            View.UiToModel();

            Model.Calculate();
            
            return true;
        }
    }
}
