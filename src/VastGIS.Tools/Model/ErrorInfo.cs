using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.Tools.Enums;

namespace VastGIS.Tools.Model
{
    /// <summary>
    /// Holds information about invalid shape in the shapefile.
    /// </summary>
    internal class ErrorInfo
    {
        public ErrorInfo(int shapeIndex, string message)
        {
            ShapeIndex = shapeIndex;
            Message = message;
        }

        public string Message { get; private set; }

        public int ShapeIndex { get; private set; }

        public ValidationError ErrorType { get; set;}

        public ICoordinate Location { get; set; }
    }
}
