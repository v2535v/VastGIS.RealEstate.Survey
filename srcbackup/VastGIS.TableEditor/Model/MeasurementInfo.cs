﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;

namespace VastGIS.Plugins.TableEditor.Model
{
    public class MeasurementInfo
    {
        public MeasurementInfo(UpdateMeasurementType type, string name, int width, int precision, int fieldIndex)
        {
            Type = type;
            Name = name;
            Width = width;
            Precision = precision;
            FieldIndex = fieldIndex;
        }

        public bool Active
        {
            get { return Type != UpdateMeasurementType.Ignore; }
        }

        public UpdateMeasurementType Type { get; private set; }
        public string Name { get; private set; }
        public int Width { get; private set; }
        public int Precision { get; private set; }
        public int FieldIndex { get; set; }
        public string DefaultName { get; set; }
        
    }
}
