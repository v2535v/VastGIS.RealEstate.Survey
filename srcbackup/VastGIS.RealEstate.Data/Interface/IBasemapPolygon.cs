using System.Data.SQLite;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IBasemapPolygon:IDatabaseFeature
    {
     

        string Tc { get; set; }

        string Cassdm { get; set; }

        string Fsxx1 { get; set; }

        string Fsxx2 { get; set; }
      

   
    }
}