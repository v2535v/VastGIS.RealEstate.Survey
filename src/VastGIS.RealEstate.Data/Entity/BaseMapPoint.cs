using System.Data;
using System.Data.Entity.Spatial;
using System.Data.SQLite;
using System.Text;

namespace VastGIS.RealEstate.Data.Entity
{
    public abstract class BaseMapPoint : Feature, IEntity
    {
        public int Id { get; set; }
        public string Tc { get; set; }
        public string Cassdm { get; set; }
        public string Fh { get; set; }
        public double? Fhdx { get; set; }
        public double? Xzjd { get; set; }
        public string Fsxx1 { get; set; }
        public string Fsxx2 { get; set; }
        public string Ysdm { get; set; }

        

        public virtual string DeleteSql(string tbName)
        {
            return string.Format("delete from {0} where Id={1}", tbName, Id);
        }
      
    }
}