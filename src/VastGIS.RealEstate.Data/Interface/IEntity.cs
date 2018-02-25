using System.Data.Entity.Spatial;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IEntity
    {
        long ID { get; set; }
        string EntityName { get; }
        string ObjectName { get; }
        string TableName { get; }
        string LayerName { get; }
        string SimpleLabelString { get; }
        string FullLabelString { get; }
        string[] NoCopyName { get; }
        bool Save(ISQLiteService dao);
        bool Delete(ISQLiteService dao);
        bool HasFlag { get; }
        bool HasYsdm { get; }
        bool HasGeometry { get; }
        bool HasGlobal { get; }
        bool HasSurvey { get; }
        void LoadFromReader(SQLiteDataReader reader);
        IEntity Copy();
        void CopyProperties(IEntity sourceEntity);
    }

}
