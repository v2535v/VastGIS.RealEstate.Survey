using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using Dapper;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class DomainDaoImpl
    {
        protected const string VG_DICTIONARYNAME =
                "CREATE TABLE [vg_dictoryname] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[ZDMC] CHAR(30) CONSTRAINT[cn_vgdictionary_zdmc] UNIQUE ON CONFLICT ROLLBACK, [ZDSM] CHAR(200));CREATE UNIQUE INDEX[ix_dictionaryname_zdmc] ON[vg_dictoryname] ([ZDMC]);"
            ;
        protected const string VG_DICTIONARY =
            "CREATE TABLE [vg_dictionary] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [ZDMC] CHAR(30) CONSTRAINT [fk_vg_dictionary_name] REFERENCES [vg_dictoryname]([ZDMC]),   [ZDZ] CHAR(30),   [ZDSM] CHAR(200),   [SFQS] BOOLEAN DEFAULT 0,   [PX] INT DEFAULT 0);";

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
                    cmd.CommandText = GetRegisterGroupSql("Domain");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("Domain", "vg_dictionary");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("Domain", "vg_dictoryname");
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

        public List<VgDictionary> GetDictionaryByName(string dictionaryName)
        {
           
            string sql = "select * from vg_dictionary where ZDMC='" + dictionaryName + "'";
            List<VgDictionary> values = connection.Query<VgDictionary>(sql).ToList();
            return values;

        }

        public void InternalInitTables()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = VG_DICTIONARYNAME;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = VG_DICTIONARY;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterGroupSql("Domain");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("Domain", "vg_dictionary");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("Domain", "vg_dictoryname");
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    
                        cmd.CommandText = Properties.Resources.Dictionary;
                        cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
        }
    }
}



