﻿// -------------------------------------------------------------------------------------------
// <copyright file="OptionsParameter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using VastGIS.Tools.Controls.Parameters;

namespace VastGIS.Tools.Model.Parameters
{
    public class OptionsParameter: BaseParameter, IXmlSerializable
    {
        /// <summary>
        /// List of options to be displayed in the combobox.
        /// </summary>
        public object Options { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            PreviousValue = reader.GetAttribute("Value");
        }

        public void WriteXml(XmlWriter writer)
        {
            if (Value != null)
            {
                writer.WriteAttributeString("Value", Value.ToString());
            }
        }

        public override bool Serializable
        {
            get { return true; }
        }

        public override bool IsEmpty
        {
            get { return Value == null || string.IsNullOrWhiteSpace(Value.ToString()); }
        }
    }
}