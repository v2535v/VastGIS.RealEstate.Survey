using System;
using Dapper;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Dao.Impl
{
    public partial class BasemapDaoImpl : SQLiteDao,BasemapDao
    {	
        public Dictionary<string,string> _entityNames;        
        
        
        #region DXTDLDWD SQL语句
        private string CREATE_VIEW_DXTDLDWD="CREATE VIEW DXTDLDWDVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLDWD WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDLDWD="CREATE TRIGGER [vw_ins_DXTDLDWDVIEW] INSTEAD OF INSERT ON [DXTDLDWDVIEW] BEGIN INSERT OR REPLACE INTO [DXTDLDWD] ([Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDLDWD="CREATE TRIGGER [vw_upd_DXTDLDWDVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDLDWDVIEW] BEGIN UPDATE [DXTDLDWD] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDLDWD="CREATE TRIGGER [vw_del_DXTDLDWDVIEW] INSTEAD OF DELETE ON [DXTDLDWDVIEW] BEGIN DELETE FROM [DXTDLDWD] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDLDWD="SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLDWD WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDLDWDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdldwdview','geometry','rowid','dxtdldwd','geometry',0)";
        #endregion        
        
        
        #region DXTDLDWM SQL语句
        private string CREATE_VIEW_DXTDLDWM="CREATE VIEW DXTDLDWMVIEW AS SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLDWM WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDLDWM="CREATE TRIGGER [vw_ins_DXTDLDWMVIEW] INSTEAD OF INSERT ON [DXTDLDWMVIEW] BEGIN INSERT OR REPLACE INTO [DXTDLDWM] ([Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDLDWM="CREATE TRIGGER [vw_upd_DXTDLDWMVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDLDWMVIEW] BEGIN UPDATE [DXTDLDWM] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDLDWM="CREATE TRIGGER [vw_del_DXTDLDWMVIEW] INSTEAD OF DELETE ON [DXTDLDWMVIEW] BEGIN DELETE FROM [DXTDLDWM] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDLDWM="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLDWM WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDLDWMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdldwmview','geometry','rowid','dxtdldwm','geometry',0)";
        #endregion        
        
        
        #region DXTDLDWX SQL语句
        private string CREATE_VIEW_DXTDLDWX="CREATE VIEW DXTDLDWXVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLDWX WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDLDWX="CREATE TRIGGER [vw_ins_DXTDLDWXVIEW] INSTEAD OF INSERT ON [DXTDLDWXVIEW] BEGIN INSERT OR REPLACE INTO [DXTDLDWX] ([Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDLDWX="CREATE TRIGGER [vw_upd_DXTDLDWXVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDLDWXVIEW] BEGIN UPDATE [DXTDLDWX] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDLDWX="CREATE TRIGGER [vw_del_DXTDLDWXVIEW] INSTEAD OF DELETE ON [DXTDLDWXVIEW] BEGIN DELETE FROM [DXTDLDWX] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDLDWX="SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLDWX WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDLDWXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdldwxview','geometry','rowid','dxtdldwx','geometry',0)";
        #endregion        
        
        
        #region DXTDLDWZJ SQL语句
        private string CREATE_VIEW_DXTDLDWZJ="CREATE VIEW DXTDLDWZJVIEW AS SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLDWZJ WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDLDWZJ="CREATE TRIGGER [vw_ins_DXTDLDWZJVIEW] INSTEAD OF INSERT ON [DXTDLDWZJVIEW] BEGIN INSERT OR REPLACE INTO [DXTDLDWZJ] ([Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[WBNR],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDLDWZJ="CREATE TRIGGER [vw_upd_DXTDLDWZJVIEW] INSTEAD OF UPDATE OF [Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDLDWZJVIEW] BEGIN UPDATE [DXTDLDWZJ] SET [Id]=NEW.[Id],[WBNR]=NEW.[WBNR],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDLDWZJ="CREATE TRIGGER [vw_del_DXTDLDWZJVIEW] INSTEAD OF DELETE ON [DXTDLDWZJVIEW] BEGIN DELETE FROM [DXTDLDWZJ] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDLDWZJ="SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLDWZJ WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDLDWZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdldwzjview','geometry','rowid','dxtdldwzj','geometry',0)";
        #endregion        
        
        
        #region DXTDLSSD SQL语句
        private string CREATE_VIEW_DXTDLSSD="CREATE VIEW DXTDLSSDVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLSSD WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDLSSD="CREATE TRIGGER [vw_ins_DXTDLSSDVIEW] INSTEAD OF INSERT ON [DXTDLSSDVIEW] BEGIN INSERT OR REPLACE INTO [DXTDLSSD] ([Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDLSSD="CREATE TRIGGER [vw_upd_DXTDLSSDVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDLSSDVIEW] BEGIN UPDATE [DXTDLSSD] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDLSSD="CREATE TRIGGER [vw_del_DXTDLSSDVIEW] INSTEAD OF DELETE ON [DXTDLSSDVIEW] BEGIN DELETE FROM [DXTDLSSD] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDLSSD="SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLSSD WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDLSSDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdlssdview','geometry','rowid','dxtdlssd','geometry',0)";
        #endregion        
        
        
        #region DXTDLSSM SQL语句
        private string CREATE_VIEW_DXTDLSSM="CREATE VIEW DXTDLSSMVIEW AS SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLSSM WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDLSSM="CREATE TRIGGER [vw_ins_DXTDLSSMVIEW] INSTEAD OF INSERT ON [DXTDLSSMVIEW] BEGIN INSERT OR REPLACE INTO [DXTDLSSM] ([Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDLSSM="CREATE TRIGGER [vw_upd_DXTDLSSMVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDLSSMVIEW] BEGIN UPDATE [DXTDLSSM] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDLSSM="CREATE TRIGGER [vw_del_DXTDLSSMVIEW] INSTEAD OF DELETE ON [DXTDLSSMVIEW] BEGIN DELETE FROM [DXTDLSSM] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDLSSM="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLSSM WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDLSSMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdlssmview','geometry','rowid','dxtdlssm','geometry',0)";
        #endregion        
        
        
        #region DXTDLSSX SQL语句
        private string CREATE_VIEW_DXTDLSSX="CREATE VIEW DXTDLSSXVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLSSX WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDLSSX="CREATE TRIGGER [vw_ins_DXTDLSSXVIEW] INSTEAD OF INSERT ON [DXTDLSSXVIEW] BEGIN INSERT OR REPLACE INTO [DXTDLSSX] ([Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDLSSX="CREATE TRIGGER [vw_upd_DXTDLSSXVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDLSSXVIEW] BEGIN UPDATE [DXTDLSSX] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDLSSX="CREATE TRIGGER [vw_del_DXTDLSSXVIEW] INSTEAD OF DELETE ON [DXTDLSSXVIEW] BEGIN DELETE FROM [DXTDLSSX] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDLSSX="SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLSSX WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDLSSXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdlssxview','geometry','rowid','dxtdlssx','geometry',0)";
        #endregion        
        
        
        #region DXTDLSSZJ SQL语句
        private string CREATE_VIEW_DXTDLSSZJ="CREATE VIEW DXTDLSSZJVIEW AS SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLSSZJ WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDLSSZJ="CREATE TRIGGER [vw_ins_DXTDLSSZJVIEW] INSTEAD OF INSERT ON [DXTDLSSZJVIEW] BEGIN INSERT OR REPLACE INTO [DXTDLSSZJ] ([Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[WBNR],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDLSSZJ="CREATE TRIGGER [vw_upd_DXTDLSSZJVIEW] INSTEAD OF UPDATE OF [Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDLSSZJVIEW] BEGIN UPDATE [DXTDLSSZJ] SET [Id]=NEW.[Id],[WBNR]=NEW.[WBNR],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDLSSZJ="CREATE TRIGGER [vw_del_DXTDLSSZJVIEW] INSTEAD OF DELETE ON [DXTDLSSZJVIEW] BEGIN DELETE FROM [DXTDLSSZJ] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDLSSZJ="SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDLSSZJ WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDLSSZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdlsszjview','geometry','rowid','dxtdlsszj','geometry',0)";
        #endregion        
        
        
        #region DXTDMTZD SQL语句
        private string CREATE_VIEW_DXTDMTZD="CREATE VIEW DXTDMTZDVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDMTZD WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDMTZD="CREATE TRIGGER [vw_ins_DXTDMTZDVIEW] INSTEAD OF INSERT ON [DXTDMTZDVIEW] BEGIN INSERT OR REPLACE INTO [DXTDMTZD] ([Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDMTZD="CREATE TRIGGER [vw_upd_DXTDMTZDVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDMTZDVIEW] BEGIN UPDATE [DXTDMTZD] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDMTZD="CREATE TRIGGER [vw_del_DXTDMTZDVIEW] INSTEAD OF DELETE ON [DXTDMTZDVIEW] BEGIN DELETE FROM [DXTDMTZD] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDMTZD="SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDMTZD WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDMTZDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdmtzdview','geometry','rowid','dxtdmtzd','geometry',0)";
        #endregion        
        
        
        #region DXTDMTZM SQL语句
        private string CREATE_VIEW_DXTDMTZM="CREATE VIEW DXTDMTZMVIEW AS SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDMTZM WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDMTZM="CREATE TRIGGER [vw_ins_DXTDMTZMVIEW] INSTEAD OF INSERT ON [DXTDMTZMVIEW] BEGIN INSERT OR REPLACE INTO [DXTDMTZM] ([Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDMTZM="CREATE TRIGGER [vw_upd_DXTDMTZMVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDMTZMVIEW] BEGIN UPDATE [DXTDMTZM] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDMTZM="CREATE TRIGGER [vw_del_DXTDMTZMVIEW] INSTEAD OF DELETE ON [DXTDMTZMVIEW] BEGIN DELETE FROM [DXTDMTZM] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDMTZM="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDMTZM WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDMTZMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdmtzmview','geometry','rowid','dxtdmtzm','geometry',0)";
        #endregion        
        
        
        #region DXTDMTZX SQL语句
        private string CREATE_VIEW_DXTDMTZX="CREATE VIEW DXTDMTZXVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDMTZX WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDMTZX="CREATE TRIGGER [vw_ins_DXTDMTZXVIEW] INSTEAD OF INSERT ON [DXTDMTZXVIEW] BEGIN INSERT OR REPLACE INTO [DXTDMTZX] ([Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDMTZX="CREATE TRIGGER [vw_upd_DXTDMTZXVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDMTZXVIEW] BEGIN UPDATE [DXTDMTZX] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDMTZX="CREATE TRIGGER [vw_del_DXTDMTZXVIEW] INSTEAD OF DELETE ON [DXTDMTZXVIEW] BEGIN DELETE FROM [DXTDMTZX] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDMTZX="SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDMTZX WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDMTZXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdmtzxview','geometry','rowid','dxtdmtzx','geometry',0)";
        #endregion        
        
        
        #region DXTDMTZZJ SQL语句
        private string CREATE_VIEW_DXTDMTZZJ="CREATE VIEW DXTDMTZZJVIEW AS SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDMTZZJ WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTDMTZZJ="CREATE TRIGGER [vw_ins_DXTDMTZZJVIEW] INSTEAD OF INSERT ON [DXTDMTZZJVIEW] BEGIN INSERT OR REPLACE INTO [DXTDMTZZJ] ([Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[WBNR],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTDMTZZJ="CREATE TRIGGER [vw_upd_DXTDMTZZJVIEW] INSTEAD OF UPDATE OF [Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTDMTZZJVIEW] BEGIN UPDATE [DXTDMTZZJ] SET [Id]=NEW.[Id],[WBNR]=NEW.[WBNR],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTDMTZZJ="CREATE TRIGGER [vw_del_DXTDMTZZJVIEW] INSTEAD OF DELETE ON [DXTDMTZZJVIEW] BEGIN DELETE FROM [DXTDMTZZJ] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTDMTZZJ="SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTDMTZZJ WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTDMTZZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdmtzzjview','geometry','rowid','dxtdmtzzj','geometry',0)";
        #endregion        
        
        
        #region DXTJMDD SQL语句
        private string CREATE_VIEW_DXTJMDD="CREATE VIEW DXTJMDDVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTJMDD WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTJMDD="CREATE TRIGGER [vw_ins_DXTJMDDVIEW] INSTEAD OF INSERT ON [DXTJMDDVIEW] BEGIN INSERT OR REPLACE INTO [DXTJMDD] ([Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTJMDD="CREATE TRIGGER [vw_upd_DXTJMDDVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTJMDDVIEW] BEGIN UPDATE [DXTJMDD] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTJMDD="CREATE TRIGGER [vw_del_DXTJMDDVIEW] INSTEAD OF DELETE ON [DXTJMDDVIEW] BEGIN DELETE FROM [DXTJMDD] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTJMDD="SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTJMDD WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTJMDDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtjmddview','geometry','rowid','dxtjmdd','geometry',0)";
        #endregion        
        
        
        #region DXTJMDM SQL语句
        private string CREATE_VIEW_DXTJMDM="CREATE VIEW DXTJMDMVIEW AS SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTJMDM WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTJMDM="CREATE TRIGGER [vw_ins_DXTJMDMVIEW] INSTEAD OF INSERT ON [DXTJMDMVIEW] BEGIN INSERT OR REPLACE INTO [DXTJMDM] ([Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTJMDM="CREATE TRIGGER [vw_upd_DXTJMDMVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTJMDMVIEW] BEGIN UPDATE [DXTJMDM] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTJMDM="CREATE TRIGGER [vw_del_DXTJMDMVIEW] INSTEAD OF DELETE ON [DXTJMDMVIEW] BEGIN DELETE FROM [DXTJMDM] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTJMDM="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTJMDM WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTJMDMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtjmdmview','geometry','rowid','dxtjmdm','geometry',0)";
        #endregion        
        
        
        #region DXTJMDX SQL语句
        private string CREATE_VIEW_DXTJMDX="CREATE VIEW DXTJMDXVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTJMDX WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTJMDX="CREATE TRIGGER [vw_ins_DXTJMDXVIEW] INSTEAD OF INSERT ON [DXTJMDXVIEW] BEGIN INSERT OR REPLACE INTO [DXTJMDX] ([Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTJMDX="CREATE TRIGGER [vw_upd_DXTJMDXVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTJMDXVIEW] BEGIN UPDATE [DXTJMDX] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTJMDX="CREATE TRIGGER [vw_del_DXTJMDXVIEW] INSTEAD OF DELETE ON [DXTJMDXVIEW] BEGIN DELETE FROM [DXTJMDX] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTJMDX="SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTJMDX WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTJMDXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtjmdxview','geometry','rowid','dxtjmdx','geometry',0)";
        #endregion        
        
        
        #region DXTJMDZJ SQL语句
        private string CREATE_VIEW_DXTJMDZJ="CREATE VIEW DXTJMDZJVIEW AS SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTJMDZJ WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTJMDZJ="CREATE TRIGGER [vw_ins_DXTJMDZJVIEW] INSTEAD OF INSERT ON [DXTJMDZJVIEW] BEGIN INSERT OR REPLACE INTO [DXTJMDZJ] ([Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[WBNR],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTJMDZJ="CREATE TRIGGER [vw_upd_DXTJMDZJVIEW] INSTEAD OF UPDATE OF [Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTJMDZJVIEW] BEGIN UPDATE [DXTJMDZJ] SET [Id]=NEW.[Id],[WBNR]=NEW.[WBNR],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTJMDZJ="CREATE TRIGGER [vw_del_DXTJMDZJVIEW] INSTEAD OF DELETE ON [DXTJMDZJVIEW] BEGIN DELETE FROM [DXTJMDZJ] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTJMDZJ="SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTJMDZJ WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTJMDZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtjmdzjview','geometry','rowid','dxtjmdzj','geometry',0)";
        #endregion        
        
        
        #region DXTKZDD SQL语句
        private string CREATE_VIEW_DXTKZDD="CREATE VIEW DXTKZDDVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTKZDD WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTKZDD="CREATE TRIGGER [vw_ins_DXTKZDDVIEW] INSTEAD OF INSERT ON [DXTKZDDVIEW] BEGIN INSERT OR REPLACE INTO [DXTKZDD] ([Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTKZDD="CREATE TRIGGER [vw_upd_DXTKZDDVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTKZDDVIEW] BEGIN UPDATE [DXTKZDD] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTKZDD="CREATE TRIGGER [vw_del_DXTKZDDVIEW] INSTEAD OF DELETE ON [DXTKZDDVIEW] BEGIN DELETE FROM [DXTKZDD] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTKZDD="SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTKZDD WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTKZDDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtkzddview','geometry','rowid','dxtkzdd','geometry',0)";
        #endregion        
        
        
        #region DXTKZDM SQL语句
        private string CREATE_VIEW_DXTKZDM="CREATE VIEW DXTKZDMVIEW AS SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTKZDM WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTKZDM="CREATE TRIGGER [vw_ins_DXTKZDMVIEW] INSTEAD OF INSERT ON [DXTKZDMVIEW] BEGIN INSERT OR REPLACE INTO [DXTKZDM] ([Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTKZDM="CREATE TRIGGER [vw_upd_DXTKZDMVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTKZDMVIEW] BEGIN UPDATE [DXTKZDM] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTKZDM="CREATE TRIGGER [vw_del_DXTKZDMVIEW] INSTEAD OF DELETE ON [DXTKZDMVIEW] BEGIN DELETE FROM [DXTKZDM] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTKZDM="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTKZDM WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTKZDMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtkzdmview','geometry','rowid','dxtkzdm','geometry',0)";
        #endregion        
        
        
        #region DXTKZDX SQL语句
        private string CREATE_VIEW_DXTKZDX="CREATE VIEW DXTKZDXVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTKZDX WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTKZDX="CREATE TRIGGER [vw_ins_DXTKZDXVIEW] INSTEAD OF INSERT ON [DXTKZDXVIEW] BEGIN INSERT OR REPLACE INTO [DXTKZDX] ([Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTKZDX="CREATE TRIGGER [vw_upd_DXTKZDXVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTKZDXVIEW] BEGIN UPDATE [DXTKZDX] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTKZDX="CREATE TRIGGER [vw_del_DXTKZDXVIEW] INSTEAD OF DELETE ON [DXTKZDXVIEW] BEGIN DELETE FROM [DXTKZDX] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTKZDX="SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTKZDX WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTKZDXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtkzdxview','geometry','rowid','dxtkzdx','geometry',0)";
        #endregion        
        
        
        #region DXTKZDZJ SQL语句
        private string CREATE_VIEW_DXTKZDZJ="CREATE VIEW DXTKZDZJVIEW AS SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTKZDZJ WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTKZDZJ="CREATE TRIGGER [vw_ins_DXTKZDZJVIEW] INSTEAD OF INSERT ON [DXTKZDZJVIEW] BEGIN INSERT OR REPLACE INTO [DXTKZDZJ] ([Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[WBNR],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTKZDZJ="CREATE TRIGGER [vw_upd_DXTKZDZJVIEW] INSTEAD OF UPDATE OF [Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTKZDZJVIEW] BEGIN UPDATE [DXTKZDZJ] SET [Id]=NEW.[Id],[WBNR]=NEW.[WBNR],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTKZDZJ="CREATE TRIGGER [vw_del_DXTKZDZJVIEW] INSTEAD OF DELETE ON [DXTKZDZJVIEW] BEGIN DELETE FROM [DXTKZDZJ] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTKZDZJ="SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTKZDZJ WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTKZDZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtkzdzjview','geometry','rowid','dxtkzdzj','geometry',0)";
        #endregion        
        
        
        #region DXTQTD SQL语句
        private string CREATE_VIEW_DXTQTD="CREATE VIEW DXTQTDVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTQTD WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTQTD="CREATE TRIGGER [vw_ins_DXTQTDVIEW] INSTEAD OF INSERT ON [DXTQTDVIEW] BEGIN INSERT OR REPLACE INTO [DXTQTD] ([Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTQTD="CREATE TRIGGER [vw_upd_DXTQTDVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTQTDVIEW] BEGIN UPDATE [DXTQTD] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTQTD="CREATE TRIGGER [vw_del_DXTQTDVIEW] INSTEAD OF DELETE ON [DXTQTDVIEW] BEGIN DELETE FROM [DXTQTD] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTQTD="SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTQTD WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTQTDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtqtdview','geometry','rowid','dxtqtd','geometry',0)";
        #endregion        
        
        
        #region DXTQTM SQL语句
        private string CREATE_VIEW_DXTQTM="CREATE VIEW DXTQTMVIEW AS SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTQTM WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTQTM="CREATE TRIGGER [vw_ins_DXTQTMVIEW] INSTEAD OF INSERT ON [DXTQTMVIEW] BEGIN INSERT OR REPLACE INTO [DXTQTM] ([Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTQTM="CREATE TRIGGER [vw_upd_DXTQTMVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTQTMVIEW] BEGIN UPDATE [DXTQTM] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTQTM="CREATE TRIGGER [vw_del_DXTQTMVIEW] INSTEAD OF DELETE ON [DXTQTMVIEW] BEGIN DELETE FROM [DXTQTM] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTQTM="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTQTM WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTQTMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtqtmview','geometry','rowid','dxtqtm','geometry',0)";
        #endregion        
        
        
        #region DXTQTX SQL语句
        private string CREATE_VIEW_DXTQTX="CREATE VIEW DXTQTXVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTQTX WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTQTX="CREATE TRIGGER [vw_ins_DXTQTXVIEW] INSTEAD OF INSERT ON [DXTQTXVIEW] BEGIN INSERT OR REPLACE INTO [DXTQTX] ([Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTQTX="CREATE TRIGGER [vw_upd_DXTQTXVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTQTXVIEW] BEGIN UPDATE [DXTQTX] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTQTX="CREATE TRIGGER [vw_del_DXTQTXVIEW] INSTEAD OF DELETE ON [DXTQTXVIEW] BEGIN DELETE FROM [DXTQTX] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTQTX="SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTQTX WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTQTXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtqtxview','geometry','rowid','dxtqtx','geometry',0)";
        #endregion        
        
        
        #region DXTQTZJ SQL语句
        private string CREATE_VIEW_DXTQTZJ="CREATE VIEW DXTQTZJVIEW AS SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTQTZJ WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTQTZJ="CREATE TRIGGER [vw_ins_DXTQTZJVIEW] INSTEAD OF INSERT ON [DXTQTZJVIEW] BEGIN INSERT OR REPLACE INTO [DXTQTZJ] ([Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[WBNR],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTQTZJ="CREATE TRIGGER [vw_upd_DXTQTZJVIEW] INSTEAD OF UPDATE OF [Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTQTZJVIEW] BEGIN UPDATE [DXTQTZJ] SET [Id]=NEW.[Id],[WBNR]=NEW.[WBNR],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTQTZJ="CREATE TRIGGER [vw_del_DXTQTZJVIEW] INSTEAD OF DELETE ON [DXTQTZJVIEW] BEGIN DELETE FROM [DXTQTZJ] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTQTZJ="SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTQTZJ WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTQTZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtqtzjview','geometry','rowid','dxtqtzj','geometry',0)";
        #endregion        
        
        
        #region DXTSXSSD SQL语句
        private string CREATE_VIEW_DXTSXSSD="CREATE VIEW DXTSXSSDVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTSXSSD WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTSXSSD="CREATE TRIGGER [vw_ins_DXTSXSSDVIEW] INSTEAD OF INSERT ON [DXTSXSSDVIEW] BEGIN INSERT OR REPLACE INTO [DXTSXSSD] ([Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTSXSSD="CREATE TRIGGER [vw_upd_DXTSXSSDVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTSXSSDVIEW] BEGIN UPDATE [DXTSXSSD] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTSXSSD="CREATE TRIGGER [vw_del_DXTSXSSDVIEW] INSTEAD OF DELETE ON [DXTSXSSDVIEW] BEGIN DELETE FROM [DXTSXSSD] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTSXSSD="SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTSXSSD WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTSXSSDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtsxssdview','geometry','rowid','dxtsxssd','geometry',0)";
        #endregion        
        
        
        #region DXTSXSSM SQL语句
        private string CREATE_VIEW_DXTSXSSM="CREATE VIEW DXTSXSSMVIEW AS SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTSXSSM WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTSXSSM="CREATE TRIGGER [vw_ins_DXTSXSSMVIEW] INSTEAD OF INSERT ON [DXTSXSSMVIEW] BEGIN INSERT OR REPLACE INTO [DXTSXSSM] ([Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTSXSSM="CREATE TRIGGER [vw_upd_DXTSXSSMVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTSXSSMVIEW] BEGIN UPDATE [DXTSXSSM] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTSXSSM="CREATE TRIGGER [vw_del_DXTSXSSMVIEW] INSTEAD OF DELETE ON [DXTSXSSMVIEW] BEGIN DELETE FROM [DXTSXSSM] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTSXSSM="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTSXSSM WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTSXSSMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtsxssmview','geometry','rowid','dxtsxssm','geometry',0)";
        #endregion        
        
        
        #region DXTSXSSX SQL语句
        private string CREATE_VIEW_DXTSXSSX="CREATE VIEW DXTSXSSXVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTSXSSX WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTSXSSX="CREATE TRIGGER [vw_ins_DXTSXSSXVIEW] INSTEAD OF INSERT ON [DXTSXSSXVIEW] BEGIN INSERT OR REPLACE INTO [DXTSXSSX] ([Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTSXSSX="CREATE TRIGGER [vw_upd_DXTSXSSXVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTSXSSXVIEW] BEGIN UPDATE [DXTSXSSX] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTSXSSX="CREATE TRIGGER [vw_del_DXTSXSSXVIEW] INSTEAD OF DELETE ON [DXTSXSSXVIEW] BEGIN DELETE FROM [DXTSXSSX] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTSXSSX="SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTSXSSX WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTSXSSXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtsxssxview','geometry','rowid','dxtsxssx','geometry',0)";
        #endregion        
        
        
        #region DXTSXSSZJ SQL语句
        private string CREATE_VIEW_DXTSXSSZJ="CREATE VIEW DXTSXSSZJVIEW AS SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTSXSSZJ WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTSXSSZJ="CREATE TRIGGER [vw_ins_DXTSXSSZJVIEW] INSTEAD OF INSERT ON [DXTSXSSZJVIEW] BEGIN INSERT OR REPLACE INTO [DXTSXSSZJ] ([Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[WBNR],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTSXSSZJ="CREATE TRIGGER [vw_upd_DXTSXSSZJVIEW] INSTEAD OF UPDATE OF [Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTSXSSZJVIEW] BEGIN UPDATE [DXTSXSSZJ] SET [Id]=NEW.[Id],[WBNR]=NEW.[WBNR],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTSXSSZJ="CREATE TRIGGER [vw_del_DXTSXSSZJVIEW] INSTEAD OF DELETE ON [DXTSXSSZJVIEW] BEGIN DELETE FROM [DXTSXSSZJ] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTSXSSZJ="SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTSXSSZJ WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTSXSSZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtsxsszjview','geometry','rowid','dxtsxsszj','geometry',0)";
        #endregion        
        
        
        #region DXTZJD SQL语句
        private string CREATE_VIEW_DXTZJD="CREATE VIEW DXTZJDVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTZJD WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTZJD="CREATE TRIGGER [vw_ins_DXTZJDVIEW] INSTEAD OF INSERT ON [DXTZJDVIEW] BEGIN INSERT OR REPLACE INTO [DXTZJD] ([Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTZJD="CREATE TRIGGER [vw_upd_DXTZJDVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[XZJD],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTZJDVIEW] BEGIN UPDATE [DXTZJD] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTZJD="CREATE TRIGGER [vw_del_DXTZJDVIEW] INSTEAD OF DELETE ON [DXTZJDVIEW] BEGIN DELETE FROM [DXTZJD] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTZJD="SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTZJD WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTZJDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtzjdview','geometry','rowid','dxtzjd','geometry',0)";
        #endregion        
        
        
        #region DXTZJM SQL语句
        private string CREATE_VIEW_DXTZJM="CREATE VIEW DXTZJMVIEW AS SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTZJM WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTZJM="CREATE TRIGGER [vw_ins_DXTZJMVIEW] INSTEAD OF INSERT ON [DXTZJMVIEW] BEGIN INSERT OR REPLACE INTO [DXTZJM] ([Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTZJM="CREATE TRIGGER [vw_upd_DXTZJMVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTZJMVIEW] BEGIN UPDATE [DXTZJM] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTZJM="CREATE TRIGGER [vw_del_DXTZJMVIEW] INSTEAD OF DELETE ON [DXTZJMVIEW] BEGIN DELETE FROM [DXTZJM] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTZJM="SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTZJM WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTZJMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtzjmview','geometry','rowid','dxtzjm','geometry',0)";
        #endregion        
        
        
        #region DXTZJX SQL语句
        private string CREATE_VIEW_DXTZJX="CREATE VIEW DXTZJXVIEW AS SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTZJX WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTZJX="CREATE TRIGGER [vw_ins_DXTZJXVIEW] INSTEAD OF INSERT ON [DXTZJXVIEW] BEGIN INSERT OR REPLACE INTO [DXTZJX] ([Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[FSXX1],NEW.[FSXX2],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTZJX="CREATE TRIGGER [vw_upd_DXTZJXVIEW] INSTEAD OF UPDATE OF [Id],[TC],[CASSDM],[FH],[FHDX],[FSXX1],[FSXX2],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTZJXVIEW] BEGIN UPDATE [DXTZJX] SET [Id]=NEW.[Id],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[FSXX1]=NEW.[FSXX1],[FSXX2]=NEW.[FSXX2],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTZJX="CREATE TRIGGER [vw_del_DXTZJXVIEW] INSTEAD OF DELETE ON [DXTZJXVIEW] BEGIN DELETE FROM [DXTZJX] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTZJX="SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTZJX WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTZJXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtzjxview','geometry','rowid','dxtzjx','geometry',0)";
        #endregion        
        
        
        #region DXTZJZJ SQL语句
        private string CREATE_VIEW_DXTZJZJ="CREATE VIEW DXTZJZJVIEW AS SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTZJZJ WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_DXTZJZJ="CREATE TRIGGER [vw_ins_DXTZJZJVIEW] INSTEAD OF INSERT ON [DXTZJZJVIEW] BEGIN INSERT OR REPLACE INTO [DXTZJZJ] ([Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[WBNR],NEW.[TC],NEW.[CASSDM],NEW.[FH],NEW.[FHDX],NEW.[XZJD],NEW.[YSDM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_DXTZJZJ="CREATE TRIGGER [vw_upd_DXTZJZJVIEW] INSTEAD OF UPDATE OF [Id],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [DXTZJZJVIEW] BEGIN UPDATE [DXTZJZJ] SET [Id]=NEW.[Id],[WBNR]=NEW.[WBNR],[TC]=NEW.[TC],[CASSDM]=NEW.[CASSDM],[FH]=NEW.[FH],[FHDX]=NEW.[FHDX],[XZJD]=NEW.[XZJD],[YSDM]=NEW.[YSDM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_DXTZJZJ="CREATE TRIGGER [vw_del_DXTZJZJVIEW] INSTEAD OF DELETE ON [DXTZJZJVIEW] BEGIN DELETE FROM [DXTZJZJ] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_DXTZJZJ="SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM DXTZJZJ WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_DXTZJZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtzjzjview','geometry','rowid','dxtzjzj','geometry',0)";
        #endregion        
        
        
        #region 初始化
        public BasemapDaoImpl():base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("DXTDLDWD","独立地物点");
            _entityNames.Add("DXTDLDWM","独立地物面");
            _entityNames.Add("DXTDLDWX","独立地物线");
            _entityNames.Add("DXTDLDWZJ","独立地物注记");
            _entityNames.Add("DXTDLSSD","道路设施点");
            _entityNames.Add("DXTDLSSM","道路设施面");
            _entityNames.Add("DXTDLSSX","道路设施线");
            _entityNames.Add("DXTDLSSZJ","道路设施注记");
            _entityNames.Add("DXTDMTZD","地貌土质点");
            _entityNames.Add("DXTDMTZM","地貌土质面");
            _entityNames.Add("DXTDMTZX","地貌土质线");
            _entityNames.Add("DXTDMTZZJ","地貌土质注记");
            _entityNames.Add("DXTJMDD","居民地点");
            _entityNames.Add("DXTJMDM","居民地面");
            _entityNames.Add("DXTJMDX","居民地线");
            _entityNames.Add("DXTJMDZJ","居民地注记");
            _entityNames.Add("DXTKZDD","控制点点");
            _entityNames.Add("DXTKZDM","控制点面");
            _entityNames.Add("DXTKZDX","控制点线");
            _entityNames.Add("DXTKZDZJ","控制点注记");
            _entityNames.Add("DXTQTD","其他图层点");
            _entityNames.Add("DXTQTM","其他图层面");
            _entityNames.Add("DXTQTX","其他图层线");
            _entityNames.Add("DXTQTZJ","其他图层注记");
            _entityNames.Add("DXTSXSSD","水系设施点");
            _entityNames.Add("DXTSXSSM","水系设施面");
            _entityNames.Add("DXTSXSSX","水系设施线");
            _entityNames.Add("DXTSXSSZJ","水系设施注记");
            _entityNames.Add("DXTZJD","注记点");
            _entityNames.Add("DXTZJM","注记面");
            _entityNames.Add("DXTZJX","注记线");
            _entityNames.Add("DXTZJZJ","注记注记");
             //RebuildSelectDictionary();
        }
        #endregion
        
                
        public string GetLayerName(string tableName)
        {
            tableName=tableName.ToUpper();
            if(_entityNames.ContainsKey(tableName))
                return _entityNames[tableName];
            else
                return "";
        }
        
       
        
        #region Dxtdldwd方法
        public Dxtdldwd GetDxtdldwd(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLDWD " + " where id="+id.ToString();
            IEnumerable<Dxtdldwd> records=connection.Query<Dxtdldwd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwd> GetDxtdldwds(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLDWD " + " where "+filter;
            var records=connection.Query<Dxtdldwd>(sql);            
            return records;
        }
        public bool SaveDxtdldwd(Dxtdldwd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdldwds(List<Dxtdldwd> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdldwd(Dxtdldwd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdldwd(long id)
        {
           Dxtdldwd record=GetDxtdldwd(id);
           if(record !=null)
           DeleteDxtdldwd(record);        
        }
        public void DeleteDxtdldwd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdldwd> records=GetDxtdldwds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdldwd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdldwm方法
        public Dxtdldwm GetDxtdldwm(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLDWM " + " where id="+id.ToString();
            IEnumerable<Dxtdldwm> records=connection.Query<Dxtdldwm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwm> GetDxtdldwms(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLDWM " + " where "+filter;
            var records=connection.Query<Dxtdldwm>(sql);            
            return records;
        }
        public bool SaveDxtdldwm(Dxtdldwm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdldwms(List<Dxtdldwm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdldwm(Dxtdldwm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdldwm(long id)
        {
           Dxtdldwm record=GetDxtdldwm(id);
           if(record !=null)
           DeleteDxtdldwm(record);        
        }
        public void DeleteDxtdldwm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdldwm> records=GetDxtdldwms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdldwm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdldwx方法
        public Dxtdldwx GetDxtdldwx(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLDWX " + " where id="+id.ToString();
            IEnumerable<Dxtdldwx> records=connection.Query<Dxtdldwx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwx> GetDxtdldwxes(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLDWX " + " where "+filter;
            var records=connection.Query<Dxtdldwx>(sql);            
            return records;
        }
        public bool SaveDxtdldwx(Dxtdldwx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdldwxes(List<Dxtdldwx> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdldwx(Dxtdldwx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdldwx(long id)
        {
           Dxtdldwx record=GetDxtdldwx(id);
           if(record !=null)
           DeleteDxtdldwx(record);        
        }
        public void DeleteDxtdldwx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdldwx> records=GetDxtdldwxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdldwx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdldwzj方法
        public Dxtdldwzj GetDxtdldwzj(long id)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLDWZJ " + " where id="+id.ToString();
            IEnumerable<Dxtdldwzj> records=connection.Query<Dxtdldwzj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwzj> GetDxtdldwzjs(string filter)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLDWZJ " + " where "+filter;
            var records=connection.Query<Dxtdldwzj>(sql);            
            return records;
        }
        public bool SaveDxtdldwzj(Dxtdldwzj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdldwzjs(List<Dxtdldwzj> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdldwzj(Dxtdldwzj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdldwzj(long id)
        {
           Dxtdldwzj record=GetDxtdldwzj(id);
           if(record !=null)
           DeleteDxtdldwzj(record);        
        }
        public void DeleteDxtdldwzj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdldwzj> records=GetDxtdldwzjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdldwzj record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdlssd方法
        public Dxtdlssd GetDxtdlssd(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLSSD " + " where id="+id.ToString();
            IEnumerable<Dxtdlssd> records=connection.Query<Dxtdlssd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssd> GetDxtdlssds(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLSSD " + " where "+filter;
            var records=connection.Query<Dxtdlssd>(sql);            
            return records;
        }
        public bool SaveDxtdlssd(Dxtdlssd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdlssds(List<Dxtdlssd> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdlssd(Dxtdlssd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdlssd(long id)
        {
           Dxtdlssd record=GetDxtdlssd(id);
           if(record !=null)
           DeleteDxtdlssd(record);        
        }
        public void DeleteDxtdlssd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdlssd> records=GetDxtdlssds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdlssd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdlssm方法
        public Dxtdlssm GetDxtdlssm(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLSSM " + " where id="+id.ToString();
            IEnumerable<Dxtdlssm> records=connection.Query<Dxtdlssm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssm> GetDxtdlssms(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLSSM " + " where "+filter;
            var records=connection.Query<Dxtdlssm>(sql);            
            return records;
        }
        public bool SaveDxtdlssm(Dxtdlssm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdlssms(List<Dxtdlssm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdlssm(Dxtdlssm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdlssm(long id)
        {
           Dxtdlssm record=GetDxtdlssm(id);
           if(record !=null)
           DeleteDxtdlssm(record);        
        }
        public void DeleteDxtdlssm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdlssm> records=GetDxtdlssms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdlssm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdlssx方法
        public Dxtdlssx GetDxtdlssx(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLSSX " + " where id="+id.ToString();
            IEnumerable<Dxtdlssx> records=connection.Query<Dxtdlssx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssx> GetDxtdlssxes(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLSSX " + " where "+filter;
            var records=connection.Query<Dxtdlssx>(sql);            
            return records;
        }
        public bool SaveDxtdlssx(Dxtdlssx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdlssxes(List<Dxtdlssx> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdlssx(Dxtdlssx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdlssx(long id)
        {
           Dxtdlssx record=GetDxtdlssx(id);
           if(record !=null)
           DeleteDxtdlssx(record);        
        }
        public void DeleteDxtdlssx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdlssx> records=GetDxtdlssxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdlssx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdlsszj方法
        public Dxtdlsszj GetDxtdlsszj(long id)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLSSZJ " + " where id="+id.ToString();
            IEnumerable<Dxtdlsszj> records=connection.Query<Dxtdlsszj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlsszj> GetDxtdlsszjs(string filter)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDLSSZJ " + " where "+filter;
            var records=connection.Query<Dxtdlsszj>(sql);            
            return records;
        }
        public bool SaveDxtdlsszj(Dxtdlsszj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdlsszjs(List<Dxtdlsszj> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdlsszj(Dxtdlsszj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdlsszj(long id)
        {
           Dxtdlsszj record=GetDxtdlsszj(id);
           if(record !=null)
           DeleteDxtdlsszj(record);        
        }
        public void DeleteDxtdlsszj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdlsszj> records=GetDxtdlsszjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdlsszj record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdmtzd方法
        public Dxtdmtzd GetDxtdmtzd(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDMTZD " + " where id="+id.ToString();
            IEnumerable<Dxtdmtzd> records=connection.Query<Dxtdmtzd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzd> GetDxtdmtzds(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDMTZD " + " where "+filter;
            var records=connection.Query<Dxtdmtzd>(sql);            
            return records;
        }
        public bool SaveDxtdmtzd(Dxtdmtzd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdmtzds(List<Dxtdmtzd> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdmtzd(Dxtdmtzd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdmtzd(long id)
        {
           Dxtdmtzd record=GetDxtdmtzd(id);
           if(record !=null)
           DeleteDxtdmtzd(record);        
        }
        public void DeleteDxtdmtzd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdmtzd> records=GetDxtdmtzds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdmtzd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdmtzm方法
        public Dxtdmtzm GetDxtdmtzm(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDMTZM " + " where id="+id.ToString();
            IEnumerable<Dxtdmtzm> records=connection.Query<Dxtdmtzm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzm> GetDxtdmtzms(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDMTZM " + " where "+filter;
            var records=connection.Query<Dxtdmtzm>(sql);            
            return records;
        }
        public bool SaveDxtdmtzm(Dxtdmtzm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdmtzms(List<Dxtdmtzm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdmtzm(Dxtdmtzm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdmtzm(long id)
        {
           Dxtdmtzm record=GetDxtdmtzm(id);
           if(record !=null)
           DeleteDxtdmtzm(record);        
        }
        public void DeleteDxtdmtzm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdmtzm> records=GetDxtdmtzms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdmtzm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdmtzx方法
        public Dxtdmtzx GetDxtdmtzx(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDMTZX " + " where id="+id.ToString();
            IEnumerable<Dxtdmtzx> records=connection.Query<Dxtdmtzx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzx> GetDxtdmtzxes(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDMTZX " + " where "+filter;
            var records=connection.Query<Dxtdmtzx>(sql);            
            return records;
        }
        public bool SaveDxtdmtzx(Dxtdmtzx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdmtzxes(List<Dxtdmtzx> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdmtzx(Dxtdmtzx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdmtzx(long id)
        {
           Dxtdmtzx record=GetDxtdmtzx(id);
           if(record !=null)
           DeleteDxtdmtzx(record);        
        }
        public void DeleteDxtdmtzx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdmtzx> records=GetDxtdmtzxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdmtzx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtdmtzzj方法
        public Dxtdmtzzj GetDxtdmtzzj(long id)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDMTZZJ " + " where id="+id.ToString();
            IEnumerable<Dxtdmtzzj> records=connection.Query<Dxtdmtzzj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzzj> GetDxtdmtzzjs(string filter)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTDMTZZJ " + " where "+filter;
            var records=connection.Query<Dxtdmtzzj>(sql);            
            return records;
        }
        public bool SaveDxtdmtzzj(Dxtdmtzzj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtdmtzzjs(List<Dxtdmtzzj> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtdmtzzj(Dxtdmtzzj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtdmtzzj(long id)
        {
           Dxtdmtzzj record=GetDxtdmtzzj(id);
           if(record !=null)
           DeleteDxtdmtzzj(record);        
        }
        public void DeleteDxtdmtzzj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtdmtzzj> records=GetDxtdmtzzjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtdmtzzj record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtjmdd方法
        public Dxtjmdd GetDxtjmdd(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTJMDD " + " where id="+id.ToString();
            IEnumerable<Dxtjmdd> records=connection.Query<Dxtjmdd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdd> GetDxtjmdds(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTJMDD " + " where "+filter;
            var records=connection.Query<Dxtjmdd>(sql);            
            return records;
        }
        public bool SaveDxtjmdd(Dxtjmdd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtjmdds(List<Dxtjmdd> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtjmdd(Dxtjmdd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtjmdd(long id)
        {
           Dxtjmdd record=GetDxtjmdd(id);
           if(record !=null)
           DeleteDxtjmdd(record);        
        }
        public void DeleteDxtjmdd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtjmdd> records=GetDxtjmdds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtjmdd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtjmdm方法
        public Dxtjmdm GetDxtjmdm(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTJMDM " + " where id="+id.ToString();
            IEnumerable<Dxtjmdm> records=connection.Query<Dxtjmdm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdm> GetDxtjmdms(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTJMDM " + " where "+filter;
            var records=connection.Query<Dxtjmdm>(sql);            
            return records;
        }
        public bool SaveDxtjmdm(Dxtjmdm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtjmdms(List<Dxtjmdm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtjmdm(Dxtjmdm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtjmdm(long id)
        {
           Dxtjmdm record=GetDxtjmdm(id);
           if(record !=null)
           DeleteDxtjmdm(record);        
        }
        public void DeleteDxtjmdm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtjmdm> records=GetDxtjmdms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtjmdm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtjmdx方法
        public Dxtjmdx GetDxtjmdx(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTJMDX " + " where id="+id.ToString();
            IEnumerable<Dxtjmdx> records=connection.Query<Dxtjmdx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdx> GetDxtjmdxes(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTJMDX " + " where "+filter;
            var records=connection.Query<Dxtjmdx>(sql);            
            return records;
        }
        public bool SaveDxtjmdx(Dxtjmdx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtjmdxes(List<Dxtjmdx> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtjmdx(Dxtjmdx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtjmdx(long id)
        {
           Dxtjmdx record=GetDxtjmdx(id);
           if(record !=null)
           DeleteDxtjmdx(record);        
        }
        public void DeleteDxtjmdx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtjmdx> records=GetDxtjmdxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtjmdx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtjmdzj方法
        public Dxtjmdzj GetDxtjmdzj(long id)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTJMDZJ " + " where id="+id.ToString();
            IEnumerable<Dxtjmdzj> records=connection.Query<Dxtjmdzj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdzj> GetDxtjmdzjs(string filter)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTJMDZJ " + " where "+filter;
            var records=connection.Query<Dxtjmdzj>(sql);            
            return records;
        }
        public bool SaveDxtjmdzj(Dxtjmdzj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtjmdzjs(List<Dxtjmdzj> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtjmdzj(Dxtjmdzj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtjmdzj(long id)
        {
           Dxtjmdzj record=GetDxtjmdzj(id);
           if(record !=null)
           DeleteDxtjmdzj(record);        
        }
        public void DeleteDxtjmdzj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtjmdzj> records=GetDxtjmdzjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtjmdzj record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtkzdd方法
        public Dxtkzdd GetDxtkzdd(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTKZDD " + " where id="+id.ToString();
            IEnumerable<Dxtkzdd> records=connection.Query<Dxtkzdd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdd> GetDxtkzdds(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTKZDD " + " where "+filter;
            var records=connection.Query<Dxtkzdd>(sql);            
            return records;
        }
        public bool SaveDxtkzdd(Dxtkzdd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtkzdds(List<Dxtkzdd> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtkzdd(Dxtkzdd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtkzdd(long id)
        {
           Dxtkzdd record=GetDxtkzdd(id);
           if(record !=null)
           DeleteDxtkzdd(record);        
        }
        public void DeleteDxtkzdd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtkzdd> records=GetDxtkzdds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtkzdd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtkzdm方法
        public Dxtkzdm GetDxtkzdm(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTKZDM " + " where id="+id.ToString();
            IEnumerable<Dxtkzdm> records=connection.Query<Dxtkzdm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdm> GetDxtkzdms(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTKZDM " + " where "+filter;
            var records=connection.Query<Dxtkzdm>(sql);            
            return records;
        }
        public bool SaveDxtkzdm(Dxtkzdm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtkzdms(List<Dxtkzdm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtkzdm(Dxtkzdm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtkzdm(long id)
        {
           Dxtkzdm record=GetDxtkzdm(id);
           if(record !=null)
           DeleteDxtkzdm(record);        
        }
        public void DeleteDxtkzdm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtkzdm> records=GetDxtkzdms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtkzdm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtkzdx方法
        public Dxtkzdx GetDxtkzdx(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTKZDX " + " where id="+id.ToString();
            IEnumerable<Dxtkzdx> records=connection.Query<Dxtkzdx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdx> GetDxtkzdxes(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTKZDX " + " where "+filter;
            var records=connection.Query<Dxtkzdx>(sql);            
            return records;
        }
        public bool SaveDxtkzdx(Dxtkzdx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtkzdxes(List<Dxtkzdx> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtkzdx(Dxtkzdx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtkzdx(long id)
        {
           Dxtkzdx record=GetDxtkzdx(id);
           if(record !=null)
           DeleteDxtkzdx(record);        
        }
        public void DeleteDxtkzdx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtkzdx> records=GetDxtkzdxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtkzdx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtkzdzj方法
        public Dxtkzdzj GetDxtkzdzj(long id)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTKZDZJ " + " where id="+id.ToString();
            IEnumerable<Dxtkzdzj> records=connection.Query<Dxtkzdzj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdzj> GetDxtkzdzjs(string filter)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTKZDZJ " + " where "+filter;
            var records=connection.Query<Dxtkzdzj>(sql);            
            return records;
        }
        public bool SaveDxtkzdzj(Dxtkzdzj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtkzdzjs(List<Dxtkzdzj> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtkzdzj(Dxtkzdzj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtkzdzj(long id)
        {
           Dxtkzdzj record=GetDxtkzdzj(id);
           if(record !=null)
           DeleteDxtkzdzj(record);        
        }
        public void DeleteDxtkzdzj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtkzdzj> records=GetDxtkzdzjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtkzdzj record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtqtd方法
        public Dxtqtd GetDxtqtd(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTQTD " + " where id="+id.ToString();
            IEnumerable<Dxtqtd> records=connection.Query<Dxtqtd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtd> GetDxtqtds(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTQTD " + " where "+filter;
            var records=connection.Query<Dxtqtd>(sql);            
            return records;
        }
        public bool SaveDxtqtd(Dxtqtd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtqtds(List<Dxtqtd> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtqtd(Dxtqtd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtqtd(long id)
        {
           Dxtqtd record=GetDxtqtd(id);
           if(record !=null)
           DeleteDxtqtd(record);        
        }
        public void DeleteDxtqtd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtqtd> records=GetDxtqtds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtqtd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtqtm方法
        public Dxtqtm GetDxtqtm(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTQTM " + " where id="+id.ToString();
            IEnumerable<Dxtqtm> records=connection.Query<Dxtqtm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtm> GetDxtqtms(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTQTM " + " where "+filter;
            var records=connection.Query<Dxtqtm>(sql);            
            return records;
        }
        public bool SaveDxtqtm(Dxtqtm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtqtms(List<Dxtqtm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtqtm(Dxtqtm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtqtm(long id)
        {
           Dxtqtm record=GetDxtqtm(id);
           if(record !=null)
           DeleteDxtqtm(record);        
        }
        public void DeleteDxtqtm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtqtm> records=GetDxtqtms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtqtm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtqtx方法
        public Dxtqtx GetDxtqtx(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTQTX " + " where id="+id.ToString();
            IEnumerable<Dxtqtx> records=connection.Query<Dxtqtx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtx> GetDxtqtxes(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTQTX " + " where "+filter;
            var records=connection.Query<Dxtqtx>(sql);            
            return records;
        }
        public bool SaveDxtqtx(Dxtqtx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtqtxes(List<Dxtqtx> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtqtx(Dxtqtx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtqtx(long id)
        {
           Dxtqtx record=GetDxtqtx(id);
           if(record !=null)
           DeleteDxtqtx(record);        
        }
        public void DeleteDxtqtx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtqtx> records=GetDxtqtxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtqtx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtqtzj方法
        public Dxtqtzj GetDxtqtzj(long id)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTQTZJ " + " where id="+id.ToString();
            IEnumerable<Dxtqtzj> records=connection.Query<Dxtqtzj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtzj> GetDxtqtzjs(string filter)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTQTZJ " + " where "+filter;
            var records=connection.Query<Dxtqtzj>(sql);            
            return records;
        }
        public bool SaveDxtqtzj(Dxtqtzj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtqtzjs(List<Dxtqtzj> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtqtzj(Dxtqtzj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtqtzj(long id)
        {
           Dxtqtzj record=GetDxtqtzj(id);
           if(record !=null)
           DeleteDxtqtzj(record);        
        }
        public void DeleteDxtqtzj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtqtzj> records=GetDxtqtzjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtqtzj record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtsxssd方法
        public Dxtsxssd GetDxtsxssd(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTSXSSD " + " where id="+id.ToString();
            IEnumerable<Dxtsxssd> records=connection.Query<Dxtsxssd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssd> GetDxtsxssds(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTSXSSD " + " where "+filter;
            var records=connection.Query<Dxtsxssd>(sql);            
            return records;
        }
        public bool SaveDxtsxssd(Dxtsxssd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtsxssds(List<Dxtsxssd> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtsxssd(Dxtsxssd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtsxssd(long id)
        {
           Dxtsxssd record=GetDxtsxssd(id);
           if(record !=null)
           DeleteDxtsxssd(record);        
        }
        public void DeleteDxtsxssd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtsxssd> records=GetDxtsxssds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtsxssd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtsxssm方法
        public Dxtsxssm GetDxtsxssm(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTSXSSM " + " where id="+id.ToString();
            IEnumerable<Dxtsxssm> records=connection.Query<Dxtsxssm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssm> GetDxtsxssms(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTSXSSM " + " where "+filter;
            var records=connection.Query<Dxtsxssm>(sql);            
            return records;
        }
        public bool SaveDxtsxssm(Dxtsxssm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtsxssms(List<Dxtsxssm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtsxssm(Dxtsxssm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtsxssm(long id)
        {
           Dxtsxssm record=GetDxtsxssm(id);
           if(record !=null)
           DeleteDxtsxssm(record);        
        }
        public void DeleteDxtsxssm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtsxssm> records=GetDxtsxssms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtsxssm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtsxssx方法
        public Dxtsxssx GetDxtsxssx(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTSXSSX " + " where id="+id.ToString();
            IEnumerable<Dxtsxssx> records=connection.Query<Dxtsxssx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssx> GetDxtsxssxes(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTSXSSX " + " where "+filter;
            var records=connection.Query<Dxtsxssx>(sql);            
            return records;
        }
        public bool SaveDxtsxssx(Dxtsxssx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtsxssxes(List<Dxtsxssx> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtsxssx(Dxtsxssx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtsxssx(long id)
        {
           Dxtsxssx record=GetDxtsxssx(id);
           if(record !=null)
           DeleteDxtsxssx(record);        
        }
        public void DeleteDxtsxssx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtsxssx> records=GetDxtsxssxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtsxssx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtsxsszj方法
        public Dxtsxsszj GetDxtsxsszj(long id)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTSXSSZJ " + " where id="+id.ToString();
            IEnumerable<Dxtsxsszj> records=connection.Query<Dxtsxsszj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxsszj> GetDxtsxsszjs(string filter)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTSXSSZJ " + " where "+filter;
            var records=connection.Query<Dxtsxsszj>(sql);            
            return records;
        }
        public bool SaveDxtsxsszj(Dxtsxsszj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtsxsszjs(List<Dxtsxsszj> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtsxsszj(Dxtsxsszj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtsxsszj(long id)
        {
           Dxtsxsszj record=GetDxtsxsszj(id);
           if(record !=null)
           DeleteDxtsxsszj(record);        
        }
        public void DeleteDxtsxsszj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtsxsszj> records=GetDxtsxsszjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtsxsszj record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtzjd方法
        public Dxtzjd GetDxtzjd(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTZJD " + " where id="+id.ToString();
            IEnumerable<Dxtzjd> records=connection.Query<Dxtzjd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjd> GetDxtzjds(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTZJD " + " where "+filter;
            var records=connection.Query<Dxtzjd>(sql);            
            return records;
        }
        public bool SaveDxtzjd(Dxtzjd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtzjds(List<Dxtzjd> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtzjd(Dxtzjd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtzjd(long id)
        {
           Dxtzjd record=GetDxtzjd(id);
           if(record !=null)
           DeleteDxtzjd(record);        
        }
        public void DeleteDxtzjd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtzjd> records=GetDxtzjds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtzjd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtzjm方法
        public Dxtzjm GetDxtzjm(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTZJM " + " where id="+id.ToString();
            IEnumerable<Dxtzjm> records=connection.Query<Dxtzjm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjm> GetDxtzjms(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTZJM " + " where "+filter;
            var records=connection.Query<Dxtzjm>(sql);            
            return records;
        }
        public bool SaveDxtzjm(Dxtzjm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtzjms(List<Dxtzjm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtzjm(Dxtzjm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtzjm(long id)
        {
           Dxtzjm record=GetDxtzjm(id);
           if(record !=null)
           DeleteDxtzjm(record);        
        }
        public void DeleteDxtzjm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtzjm> records=GetDxtzjms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtzjm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtzjx方法
        public Dxtzjx GetDxtzjx(long id)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTZJX " + " where id="+id.ToString();
            IEnumerable<Dxtzjx> records=connection.Query<Dxtzjx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjx> GetDxtzjxes(string filter)
        {
            string sql="SELECT  Id As ID,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,FSXX1 As Fsxx1,FSXX2 As Fsxx2,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTZJX " + " where "+filter;
            var records=connection.Query<Dxtzjx>(sql);            
            return records;
        }
        public bool SaveDxtzjx(Dxtzjx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtzjxes(List<Dxtzjx> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtzjx(Dxtzjx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtzjx(long id)
        {
           Dxtzjx record=GetDxtzjx(id);
           if(record !=null)
           DeleteDxtzjx(record);        
        }
        public void DeleteDxtzjx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtzjx> records=GetDxtzjxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtzjx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region Dxtzjzj方法
        public Dxtzjzj GetDxtzjzj(long id)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTZJZJ " + " where id="+id.ToString();
            IEnumerable<Dxtzjzj> records=connection.Query<Dxtzjzj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjzj> GetDxtzjzjs(string filter)
        {
            string sql="SELECT  Id As ID,WBNR As Wbnr,TC As Tc,CASSDM As Cassdm,FH As Fh,FHDX As Fhdx,XZJD As Xzjd,YSDM As Ysdm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM DXTZJZJ " + " where "+filter;
            var records=connection.Query<Dxtzjzj>(sql);            
            return records;
        }
        public bool SaveDxtzjzj(Dxtzjzj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveDxtzjzjs(List<Dxtzjzj> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteDxtzjzj(Dxtzjzj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteDxtzjzj(long id)
        {
           Dxtzjzj record=GetDxtzjzj(id);
           if(record !=null)
           DeleteDxtzjzj(record);        
        }
        public void DeleteDxtzjzj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<Dxtzjzj> records=GetDxtzjzjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(Dxtzjzj record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        
    }
}