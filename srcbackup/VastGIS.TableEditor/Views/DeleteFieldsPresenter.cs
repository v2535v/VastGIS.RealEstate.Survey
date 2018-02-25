using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Attributes.Helpers;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.TableEditor.Helpers;
using VastGIS.Plugins.TableEditor.Views.Abstract;

namespace VastGIS.Plugins.TableEditor.Views
{
    public class DeleteFieldsPresenter: BasePresenter<IDeleteFieldsView, IAttributeTable>
    {
        public DeleteFieldsPresenter(IDeleteFieldsView view) : base(view)
        {
        }

        public override bool ViewOkClicked()
        {
            var list = View.FieldsToRemove.OrderByDescending(i => i);

            if (!list.Any())
            {
                MessageService.Current.Info("No fields are selected.");
                return false;
            }

            if (MessageService.Current.Ask("Fields will be removed: " + list.Count() + "." + Environment.NewLine + "Continue?"))
            {
                foreach (var i in list)
                {
                    Model.Fields.Remove(i);
                }

                return true;
            }

            return false;
        }
    }
}
