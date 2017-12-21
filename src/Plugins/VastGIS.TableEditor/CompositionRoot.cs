using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.TableEditor.Editor;
using VastGIS.Plugins.TableEditor.Helpers;
using VastGIS.Plugins.TableEditor.Views;
using VastGIS.Plugins.TableEditor.Views.Abstract;
using VastGIS.Shared;

namespace VastGIS.Plugins.TableEditor
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<TableEditorPresenter>()
                .RegisterService<ITableEditorView, TableEditorView>()
                .RegisterView<IFieldCalculatorView, FieldCalculatorView>()
                .RegisterView<IUpdateMeasurementsView, UpdateMeasurementsView>()
                .RegisterView<IDeleteFieldsView, DeleteFieldsView>()
                .RegisterView<IJoinsView, JoinsView>()
                .RegisterView<IFieldPropertiesView, FieldPropertiesView>()
                .RegisterView<IFieldStatsView, FieldStatsView>()
                .RegisterView<IFindReplaceView, FindReplaceView>()
                .RegisterView<IRecalculateFieldsView, RecalculateFieldsView>();

            EnumHelper.RegisterConverter(new FunctionGroupConverter());
            EnumHelper.RegisterConverter(new MatchTypeConverter());
            EnumHelper.RegisterConverter(new SearchDirectionConverter());
            EnumHelper.RegisterConverter(new AttributeTypeConverter());
            EnumHelper.RegisterConverter(new CalculatorFunctionConverter());
        }
    }
}
