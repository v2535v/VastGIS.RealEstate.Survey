using System.Collections.Generic;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.ShapeEditor.Views.Abstract
{
    public interface IAttributeView: IView<AttributeViewModel>
    {
        void FocusInvalidTextBox(int fieldIndex);
        Dictionary<int, string> Values { get; }
    }
}
