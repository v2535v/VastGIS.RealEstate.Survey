using System.Data.SQLite;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IBasemapText:IDatabaseFeature
    {
    
        string Wbnr { get; set; }

        string Tc { get; set; }

        string Cassdm { get; set; }

        string Fh { get; set; }

        double? Fhdx { get; set; }

        double? Xzjd { get; set; }

   
    
    }
}