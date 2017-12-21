using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;

namespace VastGIS.Api.Interfaces
{
    public interface IShapesList : IEnumerable<SelectionItem>
    {
        void AddShape(int layerHandle, int shapeIndex);
        void AddPixel(int layerHandle, int column, int row);
        void Clear();
        int Count { get; }
        void RemoveByLayerHandle(int layerHandle);
    }
}
