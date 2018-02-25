using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Data.Db;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Interfaces.Projections;
using VastGIS.Plugins.Services;
using VastGIS.Property.Forms;
using VastGIS.Property.Helpers;

namespace VastGIS.Property.Services
{
    public class BDCDatabaseService : IBDCDatabaseService
    {
        private readonly IAppContext _context;
        private string _connectionString;
        private DatabaseConnection _connection;
        private string _dbName;
        public BDCDatabaseService(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }
        

        public string ConnectionString
        {
            get { return _connectionString; }
        }

        public DatabaseConnection Connection { get { return _connection; } }

        public bool AddDatabaseToMap(string dbName)
        {
            FileInfo info=new FileInfo(dbName);
            _connection=new DatabaseConnection(GeoDatabaseType.SpatiaLite, info.Name,dbName,dbName);
            _dbName = dbName;
            _connectionString = "Data Source=" + dbName + ";VERSION=3;";

            BDCDataSource dataSource=new BDCDataSource(_connectionString);


            return true;
        }

      
    }

    public class SpatialiteLoader
    {
        private static readonly object Lock = new object();

        private static bool _haveSetPath;

        /// <summary>
        /// Loads mod_spatialite.dll on the given connection
        /// </summary>
        public static void Load(SQLiteConnection conn)
        {
            lock (Lock)
            {
                //Need to work out where the file is and add it to the path so it can load all the other dlls too
                if (!_haveSetPath)
                {
                    var spatialitePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), (Environment.Is64BitProcess ? "x64" : "x86"), "spatialite");
                    //spatialitePath = Path.Combine(spatialitePath, "mod_spatialite.dll");
                    Environment.SetEnvironmentVariable("PATH", spatialitePath + ";" + Environment.GetEnvironmentVariable("PATH"));

                    _haveSetPath = true;
                }
            }

            conn.LoadExtension("mod_spatialite.dll");
        }
    }
}
