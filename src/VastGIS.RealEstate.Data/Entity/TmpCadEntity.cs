using System.Data.Entity.Spatial;

namespace VastGIS.RealEstate.Data.Entity
{
    public abstract class TmpCadEntity : Feature, IEntity
    {
        public int Id { get; set; }
        public string EntityType { get; set; }

        public string Handle { get; set; }

        public string FileName { get; set; }
    }
}