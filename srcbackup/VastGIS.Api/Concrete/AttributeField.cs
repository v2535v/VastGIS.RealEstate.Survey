﻿using System;
using System.ComponentModel;
using MapWinGIS;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Shared;

namespace VastGIS.Api.Concrete
{
    public class AttributeField : ConvertibleBase, IAttributeField
    {
        private readonly Field _field;
        private readonly int _index = -1;

        public AttributeField()
        {
            _field = new Field();
        }

        internal AttributeField(Field field, int index)
        {
            if (field == null)
            {
                throw new NullReferenceException("Field reference is null.");
            }

            _field = field;
            _index = index;
        }

        public IAttributeField Clone()
        {
            // obviously index becomes invalid when field is separated from shapefile
            return new AttributeField(_field.Clone(), -1);
        }

        [Browsable(false)]
        public int Index
        {
            get { return _index; }
        }

        public AttributeType Type
        {
            get { return (AttributeType)_field.Type; }
            set { _field.Type = (FieldType)value; }
        }

        public string Name
        {
            get { return _field.Name; }
            set { _field.Name = value; }
        }

        public int Precision
        {
            get { return _field.Precision; }
            set { _field.Precision = value; }
        }

        public int Width
        {
            get { return _field.Width; }
            set { _field.Width = value; }
        }

        public bool Visible
        {
            get { return _field.Visible; }
            set { _field.Visible = value; }
        }

        public string Alias
        {
            get { return _field.Alias; }
            set { _field.Alias = value; }
        }

        public object InternalObject
        {
            get { return _field; }
        }

        public string LastError
        {
            get { return _field.ErrorMsg[_field.LastErrorCode]; }
        }

        public string Tag
        {
            get { return _field.Key; }
            set { _field.Key = value; }
        }

        public string Expression
        {
            get { return _field.Expression; }
            set { _field.Expression = value; }
        }

        [Browsable(false)]
        public string DisplayName
        {
            get { return !string.IsNullOrWhiteSpace(Alias) ? Alias : Name; }
        }

        public override string ToString()
        {
            return DisplayName;
        }

        public override string ToString(IFormatProvider provider)
        {
            return DisplayName;
        }

        public bool Joined
        {
            get { return _field.Joined; }
        }

        [Browsable(false)]
        public string Abbreviation 
        {
            get
            {
                switch (Type)
                {
                    case AttributeType.String:
                        return "az";
                    case AttributeType.Integer:
                        return "09";
                    case AttributeType.Double:
                        return ".0";
                    default:
                        throw new ArgumentOutOfRangeException("Unexpected field type");
                }
            }
        }

        public bool Modified
        {
            get { return _field.Modified; }
            set { _field.Modified = value; }
        }
    }
}