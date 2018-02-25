using System.Data.SQLite;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IBasemapPoint: IDatabaseFeature
    {
      
        string Tc { get; set; }

        string Cassdm { get; set; }

        string Fh { get; set; }

        double? Fhdx { get; set; }

        double? Xzjd { get; set; }

        string Fsxx1 { get; set; }

        string Fsxx2 { get; set; }

 

    
    }
}