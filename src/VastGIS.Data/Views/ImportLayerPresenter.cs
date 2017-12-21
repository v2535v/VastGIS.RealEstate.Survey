using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Data.Views.Abstract;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Data.Views
{
    public class ImportLayerPresenter : BasePresenter<IImportLayerView>
    {
        public ImportLayerPresenter(IImportLayerView view) : base(view)
        {
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
