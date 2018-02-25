using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;

namespace VastGIS.Api.Interfaces
{
    public interface IRasterBandCollection
    {
        IEnumerator<RasterBand> GetEnumerator();
        RasterBand this[int index] { get; }
        int Count { get; }
    }
}
