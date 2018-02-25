using System.Collections.Generic;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.TableEditor.Views.Abstract
{
    public interface IDeleteFieldsView : IView<IAttributeTable>
    {
        IEnumerable<int> FieldsToRemove { get; }
    }
}
