using System.Data.Entity.Spatial;

namespace VastGIS.RealEstate.Data.Entity
{
    public abstract class BaseMapText : Feature, IEntity
    {
        public int Id { get; set; }
        public string Tc { get; set; }
        public string Zjwb { get; set; }
        public string Cassdm { get; set; }
        public double? Zjdx { get; set; }
        public string Zt { get; set; }
   
        public double? Xzjd { get; set; }
        public string Ysdm { get; set; }
      
    }
}