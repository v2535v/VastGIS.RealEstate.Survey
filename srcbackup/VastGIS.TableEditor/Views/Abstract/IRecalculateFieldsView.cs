using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.TableEditor.Model;

namespace VastGIS.Plugins.TableEditor.Views.Abstract
{
    internal interface IRecalculateFieldsView: IView<IAttributeTable>
    {
        IEnumerable<RecalculateFieldWrapper> Fields { get; }

        void UpdateField(RecalculateFieldWrapper wrapper);
    }
}
