// -------------------------------------------------------------------------------------------
// <copyright file="FieldPropertiesModel.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;

namespace VastGIS.Plugins.TableEditor.Views
{
    internal class FieldPropertiesModel
    {
        private bool _allowEditing;

        public FieldPropertiesModel(IAttributeTable table, IAttributeField field, bool addField, bool allowEditing)
        {
            if (table == null) throw new ArgumentNullException("table");

            if (field == null) 
            {
                field = new AttributeField();
            }

            Field = field;
            AddField = addField;
            Table = table;

            _allowEditing = allowEditing;
        }

        public bool AddField { get; private set; }

        public bool AllowEditing
        {
            get { return _allowEditing; }
        }

        public IAttributeField Field { get; private set; }

        public IAttributeTable Table { get; private set; }
    }
}