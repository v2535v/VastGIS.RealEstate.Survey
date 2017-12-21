using System;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Attributes.Views.Abstract
{
    public interface IQueryBuilderView: IView<QueryBuilderModel>
    {
        event Action TestClicked;
        
        event Action RunClicked;

        bool ValidateOnTheFly(bool silent);

        string Expression { get; }

        string ValidationResults { get; set; }
    }
}
