﻿using System.Collections.Generic;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;

namespace VastGIS.Api.Interfaces
{
    public interface IFeatureCategoryList : IEnumerable<IFeatureCategory>, ISerializableComWrapper
    {
        int IndexByName(string categoryName);

        string Caption { get; set; }

        string ClassificationField { get; set; }

        bool AddRange(int fieldIndex, Classification classification, int numClasses, object minValue, object maxValue);

        void ApplyColorScheme(SchemeType type, ColorRamp colorScheme);

        void ApplyColorScheme(SchemeType type, ColorRamp colorScheme, StyleElement shapeElement);

        void ApplyColorScheme(SchemeType type, ColorRamp colorScheme, StyleElement shapeElement,
                                int categoryStartIndex, int categoryEndIndex);

        void ApplyExpression(int categoryIndex);

        void ApplyExpressions();

        bool Generate(int fieldIndex, Classification classification, int numClasses);

        bool Generate(string fieldName, Classification classification, int numClasses);

        bool GenerateUniqueValues(string fieldName);

        bool GenerateUniqueValues(int fieldIndex);

        bool GeneratePolygonColors(ColorRamp scheme = null);

        bool MoveDown(int index);

        bool MoveUp(int index);

        bool LoadFromFile(string filename);

        bool SaveToFile(string filename);
    }
}
