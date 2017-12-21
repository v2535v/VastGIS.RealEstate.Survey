using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Views.Abstract;

namespace VastGIS.Views
{
    public class LegendGroupPresenter: BasePresenter<ILegendGroupView, ILegendGroup>
    {
        public LegendGroupPresenter(ILegendGroupView view) : base(view)
        {
        }

        public override bool ViewOkClicked()
        {
            if (string.IsNullOrWhiteSpace(View.GroupName))
            {
                MessageService.Current.Info("Group name can't be empty");
                return false;
            }

            Model.Text = View.GroupName;

            return true;
        }
    }
}
