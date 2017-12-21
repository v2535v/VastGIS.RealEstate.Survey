using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.TableEditor.Views.Abstract;

namespace VastGIS.Plugins.TableEditor.Views
{
    internal class FieldStatsPresenter: BasePresenter<IFieldStatsView, FieldStatsModel>
    {
        public FieldStatsPresenter(IFieldStatsView view)
            : base(view)
        {
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
