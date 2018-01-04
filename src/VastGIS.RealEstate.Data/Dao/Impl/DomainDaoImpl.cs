using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class DomainDaoImpl
    {
        protected const string VG_DICTIONARYNAME =
            "CREATE TABLE [vg_dictoryname] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [ZDMC] CHAR(30),   [ZDSM] CHAR(200));";

        protected const string VG_DICTIONARY =
            "CREATE TABLE [vg_dictionary] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [ZDMC] CHAR(30),   [ZDZ] CHAR(30),   [ZDSM] CHAR(200),   [SFQS] BOOLEAN DEFAULT 0,   [PX] INT DEFAULT 0);";

        public bool InitTables()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = VG_DICTIONARYNAME;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = VG_DICTIONARY;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    string dataFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        "Templates\\Dictionary.sql");

                    StreamReader reader = File.OpenText(dataFile);
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine().Trim();
                        if (string.IsNullOrEmpty(line)) continue;
                        cmd.CommandText = line;
                        cmd.ExecuteNonQuery();
                    }
                    reader.Close();
                }
                trans.Commit();
            }
            return true;
        }
        
    }
}



