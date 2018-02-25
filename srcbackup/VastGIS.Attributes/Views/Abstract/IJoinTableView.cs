using System;
using System.Collections.Generic;
using VastGIS.Attributes.Model;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Attributes.Views.Abstract
{
    public interface IJoinTableView : IView<JoinViewModel>
    {
        event Action OpenClicked;
        event Action TryJoin;
        FieldWrapper FieldFrom { get; }
        FieldWrapper FieldTo { get; }
        IEnumerable<FieldWrapper> SelectedFields { get; }
        void SetRowCount(int rowCount, int joinRowCount);
        void SetDatasource();
    }
}
