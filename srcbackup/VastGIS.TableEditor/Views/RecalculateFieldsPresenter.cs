using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.TableEditor.Model;
using VastGIS.Plugins.TableEditor.Views.Abstract;
using VastGIS.Shared;

namespace VastGIS.Plugins.TableEditor.Views
{
    internal class RecalculateFieldsPresenter: BasePresenter<IRecalculateFieldsView, IAttributeTable>
    {
        public RecalculateFieldsPresenter(IRecalculateFieldsView view)
            : base(view)
        {
        }

        public override bool ViewOkClicked()
        {
            var fields = View.Fields.ToList();

            if (fields.Count == 0)
            {
                MessageService.Current.Info("No fields are selected for calculation.");
                return false;
            }

            CalculateFields();

            return false;
        }

        private void CalculateFields()
        {
            var fields = View.Fields.ToList();

            foreach (var f in fields)
            {
                f.ClearResult();
            }

            foreach (var f in fields)
            {
                CalculateField(f);
                View.UpdateField(f);
            }
        }

        private void CalculateField(RecalculateFieldWrapper field)
        {
            var eval = new ExpressionEvaluator();

            if (!eval.ParseForTable(field.Expression, Model))
            {
                field.SetResult(RecalculateFieldResult.Failure, "Failed to parse.");
                return;
            }

            var count = 0;
            var rowCount = Model.NumRows;
            bool errorReported = false;

            for (var i = 0; i < rowCount; i++)
            {
                if (!eval.CalculateForTableRow(i, field.Index))
                {
                    if (!errorReported)
                    {
                        // report only the very first error
                        string s = "Failed to calculate expression for a row: " + i + ". " + eval.LastErrorMessage;
                        Logger.Current.Info(s);
                        errorReported = true;
                    }
                    continue;
                }

                count++;
            }

            if (count == rowCount)
            {
                field.SetResult(RecalculateFieldResult.Success, "Success");
            }
            else
            {
                field.SetResult(RecalculateFieldResult.SomeRows, string.Format("{0} from {1}", count, rowCount));
            }
        }
    }
}
