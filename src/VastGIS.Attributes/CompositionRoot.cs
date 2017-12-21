using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Attributes.Views;
using VastGIS.Attributes.Views.Abstract;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Attributes
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterView<IQueryBuilderView, QueryBuilderView>()
                .RegisterView<IAttributeExplorer, AttributeExplorerView>()
                .RegisterView<IJoinTableView, JoinTableView>();
        }
    }
}
