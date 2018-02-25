﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Shared;
using VastGIS.UI.Helpers;

namespace VastGIS.Plugins.TableEditor.Helpers
{
    public class AttributeTypeConverter : IEnumConverter<AttributeType>
    {
        public string GetString(AttributeType value)
        {
            switch (value)
            {
                case AttributeType.String:
                    return "String";
                case AttributeType.Integer:
                    return "Integer";
                case AttributeType.Double:
                    return "Double";
            }
            return "Not defined";
        }
    }

    public class CalculatorFunctionConverter : IEnumConverter<CalculatorFunction>
    {
        public string GetString(CalculatorFunction value)
        {
            switch (value)
            {
                case CalculatorFunction.Shapes:
                    return "Shapes";
                case CalculatorFunction.Operators:
                    return "Operators";
                case CalculatorFunction.Booleans:
                    return "Boolean";
                case CalculatorFunction.Maths:
                    return "Math";
                case CalculatorFunction.Angles:
                    return "Angles";
                case CalculatorFunction.Statistics:
                    return "Statistics";
                case CalculatorFunction.Time:
                    return "Time";
                case CalculatorFunction.Other:
                    return "Other";
                case CalculatorFunction.Constants:
                    return "Constants";
            }
            return string.Empty;
        }
    }

    public class SearchDirectionConverter : IEnumConverter<SearchDirection>
    {
        public string GetString(SearchDirection value)
        {
            switch (value)
            {
                case SearchDirection.Down:
                    return "Down";
                case SearchDirection.Up:
                    return "Up";
            }

            return string.Empty;
        }
    }

    public class MatchTypeConverter : IEnumConverter<MatchType>
    {
        public string GetString(MatchType value)
        {
            switch (value)
            {
                case MatchType.Contains:
                    return "Contains";
                case MatchType.Match:
                    return "Whole field";
                case MatchType.Start:
                    return "Start of field";
            }

            return string.Empty;
        }
    }

    public class FunctionGroupConverter: IEnumConverter<FunctionGroup>
    {
        public string GetString(FunctionGroup value)
        {
            switch (value)
            {
                case FunctionGroup.Math:
                    return "Math";
                case FunctionGroup.Strings:
                    return "Strings";
                case FunctionGroup.Geometry:
                    return "Geometry";
                case FunctionGroup.Branching:
                    return "Branching";
                case FunctionGroup.Conversion:
                    return "Conversion";
            }

            return string.Empty;
        }
    }
}
