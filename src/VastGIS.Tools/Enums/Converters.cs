using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Shared;

namespace VastGIS.Tools.Enums
{
    internal class FieldOperationValidityConverter : IEnumConverter<VastGIS.Api.Enums.FieldOperationValidity>
    {
        public string GetString(FieldOperationValidity value)
        {
            switch (value)
            {
                case FieldOperationValidity.Valid:
                    return "Valid";
                case FieldOperationValidity.FieldNotFound:
                    return "Field wasn't found";
                case FieldOperationValidity.NotSupported:
                    return "Operations isn't supported for the given field type.";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }
}
