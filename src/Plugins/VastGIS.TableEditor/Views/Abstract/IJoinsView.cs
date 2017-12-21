using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.TableEditor.Views.Abstract
{
    public interface IJoinsView: IView<IAttributeTable>, IMenuProvider
    {
        FieldJoin SelectedJoin { get; }
        event Action JoinDoubleClicked;
    }
}
