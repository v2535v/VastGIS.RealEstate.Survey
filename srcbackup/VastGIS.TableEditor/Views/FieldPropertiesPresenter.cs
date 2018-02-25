// -------------------------------------------------------------------------------------------
// <copyright file="FieldPropertiesPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Api.Interfaces;
using VastGIS.Attributes.Helpers;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.TableEditor.Helpers;
using VastGIS.Plugins.TableEditor.Views.Abstract;
using VastGIS.Shared;

namespace VastGIS.Plugins.TableEditor.Views
{
    internal class FieldPropertiesPresenter : BasePresenter<IFieldPropertiesView, FieldPropertiesModel>
    {
        public FieldPropertiesPresenter(IFieldPropertiesView view)
            : base(view)
        {
        }

        private bool Validate(IAttributeField field)
        {
            string errorMessage;

            bool nameChanged = Model.AddField || (Model.AllowEditing && !field.Name.EqualsIgnoreCase(Model.Field.Name));

            if (nameChanged && !Model.Table.ValidateFieldName(field.Name, out errorMessage))
            {
                MessageService.Current.Info(errorMessage);
                return false;
            }

            return true;
        }

        public override bool ViewOkClicked()
        {
            var fld = View.NewField;

            if (!Validate(fld))
            {
                return false;
            }

            if (Model.AddField)
            {
                Model.Table.Fields.Add(fld);
            }
            else
            {
                Model.Field.Name = fld.Name;
                Model.Field.Visible = fld.Visible;
                Model.Field.Alias = fld.Alias;
            }

            return true;
        }
    }
}