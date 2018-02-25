using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.TableEditor.Views.Abstract
{
    public interface IRenameFieldView : IView<IAttributeTable>
    {
        int FieldIndex { get; }
        string NewName { get; }
    }
}
