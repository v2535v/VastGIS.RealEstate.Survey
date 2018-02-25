﻿// -------------------------------------------------------------------------------------------
// <copyright file="AttributeTableHelper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Attributes.Model;
using VastGIS.Shared;

namespace VastGIS.Attributes.Helpers
{
    public static class AttributeTableHelper
    {
        public static bool ValidateFieldNameSlack(this IAttributeTable table, string newName, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(newName))
            {
                errorMessage = "Field name is empty.";
                return false;
            }

            if (newName.Length > 10)
            {
                errorMessage = "Maximum field length is 10.";
                return false;
            }

            return true;
        }

        public static bool ValidateFieldName(this IAttributeTable table, string newName, out string errorMessage)
        {
            if (!ValidateFieldNameSlack(table, newName, out errorMessage))
            {
                return false;
            }

            if (table.Fields.Any(f => f.Name.EqualsIgnoreCase(newName)))
            {
                errorMessage = "Field name already exists.";
                return false;
            }

            return true;
        }

        public static IEnumerable<ValueCountItem> GetUniqueValues(this IAttributeTable table, int fieldIndex)
        {
            var hashTable = new SortedDictionary<object, int>();

            var type = table.Fields[fieldIndex].Type;

            for (int i = 0; i < table.NumRows; i++)
            {
                var obj = table.CellValue(fieldIndex, i);

                switch (type)
                {
                    case AttributeType.String:
                        string s = obj != null ? obj.ToString() : string.Empty;
                        s = "\"" + s + "\"";
                        obj = s;
                        break;
                    case AttributeType.Integer:
                        obj = obj ?? 0;
                        break;
                    case AttributeType.Double:
                        obj = obj ?? 0.0;
                        break;
                }

                if (hashTable.ContainsKey(obj))
                {
                    hashTable[obj] += 1;
                }
                else
                {
                    hashTable.Add(obj, 1);
                }
            }

            switch (type)
            {
                case AttributeType.String:
                    return hashTable.Select(item => new ValueCountItem(item.Key.ToString(), item.Value));
                case AttributeType.Integer:
                    return hashTable.Select(item => new ValueCountItem((int)item.Key, item.Value));
                case AttributeType.Double:
                    return hashTable.Select(item => new ValueCountItem((double)item.Key, item.Value));
            }

            return new List<ValueCountItem>();
        }
    }
}