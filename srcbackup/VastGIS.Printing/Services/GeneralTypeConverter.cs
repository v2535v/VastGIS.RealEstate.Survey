// -------------------------------------------------------------------------------------------
// <copyright file="GeneralTypeConverter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Globalization;

namespace VastGIS.Plugins.Printing.Services
{
    /// <summary>
    /// PropertyGridTypeConverter
    /// </summary>
    public class GeneralTypeConverter : StringConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return true;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(
            ITypeDescriptorContext context,
            CultureInfo culture,
            object value,
            Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return value == null ? "[Empty]" : "[Edit...]";
            }
            return null;
        }
    }
}