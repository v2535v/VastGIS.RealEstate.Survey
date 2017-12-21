using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.TableEditor.Views.Abstract
{
    internal interface IFieldPropertiesView : IView<FieldPropertiesModel>
    {
        IAttributeField NewField { get;}
    }
}
