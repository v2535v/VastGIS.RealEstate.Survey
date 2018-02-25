using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Symbology.Views.Abstract;

namespace VastGIS.Plugins.Symbology.Views
{
    public class HistogramOptionsPresenter: BasePresenter<IHistogramOptionsView, HistogramOptionsModel>
    {
        public HistogramOptionsPresenter(IHistogramOptionsView view) : base(view)
        {
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
