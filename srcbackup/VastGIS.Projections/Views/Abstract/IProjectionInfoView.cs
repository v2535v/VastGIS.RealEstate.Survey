using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;
using VastGIS.Projections.BL;

namespace VastGIS.Projections.Views.Abstract
{
    public interface IProjectionInfoView : IComplexView<ProjectionInfoModel>
    {
        ProjectionDialect SelectedDialect { get; set; }

        event Action EditDialect;
    }
}
