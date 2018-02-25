using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Projections.Views.Abstract
{
    public interface IProjectionMismatchView : IView<ProjectionMismatchModel>
    {
        event Action DetailsClicked;
    }
}
