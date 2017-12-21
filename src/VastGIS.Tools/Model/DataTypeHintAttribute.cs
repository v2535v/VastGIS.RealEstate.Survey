using System;
using VastGIS.Plugins.Enums;

namespace VastGIS.Tools.Model
{
    public class DataTypeHintAttribute: Attribute
    {
        public DataTypeHintAttribute(DataSourceType dataType)
        {
            DataType = dataType;
        }

        public DataSourceType DataType { get; private set; }
    }
}
