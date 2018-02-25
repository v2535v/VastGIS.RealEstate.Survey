// -------------------------------------------------------------------------------------------
// <copyright file="FieldOperationGridAdapter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.Tools.Controls
{
    /// <summary>
    /// A data structure to choose group operation for a given field.
    /// </summary>
    internal class FieldOperationGridAdapter
    {
        private IAttributeField _field;

        public FieldOperationGridAdapter(IAttributeField field)
        {
            if (field == null) throw new ArgumentNullException("field");

            _field = field;
        }

        [DisplayName(" ")]
        public object Delete { get; set; }

        /// <remarks>
        /// GridGroupControl doesn't 
        /// http ://www.syncfusion.com/forums/54409/data-binding-custom-object-ilist-with-descendant-objects-in-the-list</remarks>
        [DisplayName("Field name")]
        public IAttributeField Field
        {
            get { return _field as AttributeField; }
            set { _field = value; }
        }

        [DisplayName("Operation")]
        public GroupOperation GroupOperation { get; set; }
    }
}