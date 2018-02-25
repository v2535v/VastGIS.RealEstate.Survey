// -------------------------------------------------------------------------------------------
// <copyright file="FieldWrapper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using VastGIS.Api.Interfaces;

namespace VastGIS.Attributes.Model
{
    public class FieldWrapper
    {
        private readonly IAttributeField _field;

        public FieldWrapper(IAttributeField field)
        {
            if (field == null) throw new ArgumentNullException("field");
            _field = field;
        }

        public string Name
        {
            get { return _field.Name; }
        }

        [DisplayName(" ")]
        public bool Selected { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}