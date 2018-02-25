using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using System.Linq;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class BasemapDaoImpl:SQLiteDao,BasemapDao
    {
        public Dictionary<string, string> _entityNames;
        //private BasemapDao _basemapDao;
        private string CREATE_VIEW_DXTQTD="CREATE VIEW DXTQTDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTQTD Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTQTD="CREATE TRIGGER [vw_ins_DXTQTDVIEW] INSTEAD OF INSERT ON [DXTQTDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTQTD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTQTD="CREATE TRIGGER [vw_upd_DXTQTDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTQTDVIEW] BEGIN  Update [DXTQTD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTQTD="CREATE TRIGGER vw_del_DXTQTDVIEW INSTEAD OF DELETE ON DXTQTDVIEW BEGIN DELETE FROM DXTQTD WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTQTDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtqtdview','geometry','rowid','dxtqtd','geometry',0)";
        private string SELECT_DXTQTD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTQTD Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTQTX="CREATE VIEW DXTQTXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTQTX Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTQTX="CREATE TRIGGER [vw_ins_DXTQTXVIEW] INSTEAD OF INSERT ON [DXTQTXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTQTX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTQTX="CREATE TRIGGER [vw_upd_DXTQTXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTQTXVIEW] BEGIN  Update [DXTQTX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTQTX="CREATE TRIGGER vw_del_DXTQTXVIEW INSTEAD OF DELETE ON DXTQTXVIEW BEGIN DELETE FROM DXTQTX WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTQTXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtqtxview','geometry','rowid','dxtqtx','geometry',0)";
        private string SELECT_DXTQTX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTQTX Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTQTM="CREATE VIEW DXTQTMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTQTM Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTQTM="CREATE TRIGGER [vw_ins_DXTQTMVIEW] INSTEAD OF INSERT ON [DXTQTMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTQTM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTQTM="CREATE TRIGGER [vw_upd_DXTQTMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTQTMVIEW] BEGIN  Update [DXTQTM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTQTM="CREATE TRIGGER vw_del_DXTQTMVIEW INSTEAD OF DELETE ON DXTQTMVIEW BEGIN DELETE FROM DXTQTM WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTQTMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtqtmview','geometry','rowid','dxtqtm','geometry',0)";
        private string SELECT_DXTQTM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTQTM Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTQTZJ="CREATE VIEW DXTQTZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTQTZJ Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTQTZJ="CREATE TRIGGER [vw_ins_DXTQTZJVIEW] INSTEAD OF INSERT ON [DXTQTZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTQTZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTQTZJ="CREATE TRIGGER [vw_upd_DXTQTZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTQTZJVIEW] BEGIN  Update [DXTQTZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTQTZJ="CREATE TRIGGER vw_del_DXTQTZJVIEW INSTEAD OF DELETE ON DXTQTZJVIEW BEGIN DELETE FROM DXTQTZJ WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTQTZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtqtzjview','geometry','rowid','dxtqtzj','geometry',0)";
        private string SELECT_DXTQTZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTQTZJ Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTZJD="CREATE VIEW DXTZJDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTZJD Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTZJD="CREATE TRIGGER [vw_ins_DXTZJDVIEW] INSTEAD OF INSERT ON [DXTZJDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTZJD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTZJD="CREATE TRIGGER [vw_upd_DXTZJDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTZJDVIEW] BEGIN  Update [DXTZJD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTZJD="CREATE TRIGGER vw_del_DXTZJDVIEW INSTEAD OF DELETE ON DXTZJDVIEW BEGIN DELETE FROM DXTZJD WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTZJDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtzjdview','geometry','rowid','dxtzjd','geometry',0)";
        private string SELECT_DXTZJD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTZJD Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTZJX="CREATE VIEW DXTZJXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTZJX Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTZJX="CREATE TRIGGER [vw_ins_DXTZJXVIEW] INSTEAD OF INSERT ON [DXTZJXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTZJX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTZJX="CREATE TRIGGER [vw_upd_DXTZJXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTZJXVIEW] BEGIN  Update [DXTZJX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTZJX="CREATE TRIGGER vw_del_DXTZJXVIEW INSTEAD OF DELETE ON DXTZJXVIEW BEGIN DELETE FROM DXTZJX WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTZJXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtzjxview','geometry','rowid','dxtzjx','geometry',0)";
        private string SELECT_DXTZJX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTZJX Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTZJM="CREATE VIEW DXTZJMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTZJM Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTZJM="CREATE TRIGGER [vw_ins_DXTZJMVIEW] INSTEAD OF INSERT ON [DXTZJMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTZJM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTZJM="CREATE TRIGGER [vw_upd_DXTZJMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTZJMVIEW] BEGIN  Update [DXTZJM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTZJM="CREATE TRIGGER vw_del_DXTZJMVIEW INSTEAD OF DELETE ON DXTZJMVIEW BEGIN DELETE FROM DXTZJM WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTZJMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtzjmview','geometry','rowid','dxtzjm','geometry',0)";
        private string SELECT_DXTZJM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTZJM Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTZJZJ="CREATE VIEW DXTZJZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTZJZJ Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTZJZJ="CREATE TRIGGER [vw_ins_DXTZJZJVIEW] INSTEAD OF INSERT ON [DXTZJZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTZJZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTZJZJ="CREATE TRIGGER [vw_upd_DXTZJZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTZJZJVIEW] BEGIN  Update [DXTZJZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTZJZJ="CREATE TRIGGER vw_del_DXTZJZJVIEW INSTEAD OF DELETE ON DXTZJZJVIEW BEGIN DELETE FROM DXTZJZJ WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTZJZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtzjzjview','geometry','rowid','dxtzjzj','geometry',0)";
        private string SELECT_DXTZJZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTZJZJ Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDMTZD="CREATE VIEW DXTDMTZDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDMTZD Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDMTZD="CREATE TRIGGER [vw_ins_DXTDMTZDVIEW] INSTEAD OF INSERT ON [DXTDMTZDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDMTZD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDMTZD="CREATE TRIGGER [vw_upd_DXTDMTZDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDMTZDVIEW] BEGIN  Update [DXTDMTZD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDMTZD="CREATE TRIGGER vw_del_DXTDMTZDVIEW INSTEAD OF DELETE ON DXTDMTZDVIEW BEGIN DELETE FROM DXTDMTZD WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDMTZDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdmtzdview','geometry','rowid','dxtdmtzd','geometry',0)";
        private string SELECT_DXTDMTZD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDMTZD Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDMTZX="CREATE VIEW DXTDMTZXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDMTZX Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDMTZX="CREATE TRIGGER [vw_ins_DXTDMTZXVIEW] INSTEAD OF INSERT ON [DXTDMTZXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDMTZX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDMTZX="CREATE TRIGGER [vw_upd_DXTDMTZXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDMTZXVIEW] BEGIN  Update [DXTDMTZX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDMTZX="CREATE TRIGGER vw_del_DXTDMTZXVIEW INSTEAD OF DELETE ON DXTDMTZXVIEW BEGIN DELETE FROM DXTDMTZX WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDMTZXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdmtzxview','geometry','rowid','dxtdmtzx','geometry',0)";
        private string SELECT_DXTDMTZX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDMTZX Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDMTZM="CREATE VIEW DXTDMTZMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDMTZM Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDMTZM="CREATE TRIGGER [vw_ins_DXTDMTZMVIEW] INSTEAD OF INSERT ON [DXTDMTZMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDMTZM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDMTZM="CREATE TRIGGER [vw_upd_DXTDMTZMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDMTZMVIEW] BEGIN  Update [DXTDMTZM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDMTZM="CREATE TRIGGER vw_del_DXTDMTZMVIEW INSTEAD OF DELETE ON DXTDMTZMVIEW BEGIN DELETE FROM DXTDMTZM WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDMTZMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdmtzmview','geometry','rowid','dxtdmtzm','geometry',0)";
        private string SELECT_DXTDMTZM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDMTZM Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDMTZZJ="CREATE VIEW DXTDMTZZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDMTZZJ Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDMTZZJ="CREATE TRIGGER [vw_ins_DXTDMTZZJVIEW] INSTEAD OF INSERT ON [DXTDMTZZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDMTZZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDMTZZJ="CREATE TRIGGER [vw_upd_DXTDMTZZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDMTZZJVIEW] BEGIN  Update [DXTDMTZZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDMTZZJ="CREATE TRIGGER vw_del_DXTDMTZZJVIEW INSTEAD OF DELETE ON DXTDMTZZJVIEW BEGIN DELETE FROM DXTDMTZZJ WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDMTZZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdmtzzjview','geometry','rowid','dxtdmtzzj','geometry',0)";
        private string SELECT_DXTDMTZZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDMTZZJ Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTSXSSD="CREATE VIEW DXTSXSSDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTSXSSD Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTSXSSD="CREATE TRIGGER [vw_ins_DXTSXSSDVIEW] INSTEAD OF INSERT ON [DXTSXSSDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTSXSSD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTSXSSD="CREATE TRIGGER [vw_upd_DXTSXSSDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTSXSSDVIEW] BEGIN  Update [DXTSXSSD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTSXSSD="CREATE TRIGGER vw_del_DXTSXSSDVIEW INSTEAD OF DELETE ON DXTSXSSDVIEW BEGIN DELETE FROM DXTSXSSD WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTSXSSDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtsxssdview','geometry','rowid','dxtsxssd','geometry',0)";
        private string SELECT_DXTSXSSD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTSXSSD Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTSXSSX="CREATE VIEW DXTSXSSXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTSXSSX Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTSXSSX="CREATE TRIGGER [vw_ins_DXTSXSSXVIEW] INSTEAD OF INSERT ON [DXTSXSSXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTSXSSX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTSXSSX="CREATE TRIGGER [vw_upd_DXTSXSSXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTSXSSXVIEW] BEGIN  Update [DXTSXSSX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTSXSSX="CREATE TRIGGER vw_del_DXTSXSSXVIEW INSTEAD OF DELETE ON DXTSXSSXVIEW BEGIN DELETE FROM DXTSXSSX WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTSXSSXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtsxssxview','geometry','rowid','dxtsxssx','geometry',0)";
        private string SELECT_DXTSXSSX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTSXSSX Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTSXSSM="CREATE VIEW DXTSXSSMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTSXSSM Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTSXSSM="CREATE TRIGGER [vw_ins_DXTSXSSMVIEW] INSTEAD OF INSERT ON [DXTSXSSMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTSXSSM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTSXSSM="CREATE TRIGGER [vw_upd_DXTSXSSMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTSXSSMVIEW] BEGIN  Update [DXTSXSSM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTSXSSM="CREATE TRIGGER vw_del_DXTSXSSMVIEW INSTEAD OF DELETE ON DXTSXSSMVIEW BEGIN DELETE FROM DXTSXSSM WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTSXSSMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtsxssmview','geometry','rowid','dxtsxssm','geometry',0)";
        private string SELECT_DXTSXSSM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTSXSSM Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTSXSSZJ="CREATE VIEW DXTSXSSZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTSXSSZJ Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTSXSSZJ="CREATE TRIGGER [vw_ins_DXTSXSSZJVIEW] INSTEAD OF INSERT ON [DXTSXSSZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTSXSSZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTSXSSZJ="CREATE TRIGGER [vw_upd_DXTSXSSZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTSXSSZJVIEW] BEGIN  Update [DXTSXSSZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTSXSSZJ="CREATE TRIGGER vw_del_DXTSXSSZJVIEW INSTEAD OF DELETE ON DXTSXSSZJVIEW BEGIN DELETE FROM DXTSXSSZJ WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTSXSSZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtsxsszjview','geometry','rowid','dxtsxsszj','geometry',0)";
        private string SELECT_DXTSXSSZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTSXSSZJ Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDLDWD="CREATE VIEW DXTDLDWDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLDWD Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDLDWD="CREATE TRIGGER [vw_ins_DXTDLDWDVIEW] INSTEAD OF INSERT ON [DXTDLDWDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDLDWD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDLDWD="CREATE TRIGGER [vw_upd_DXTDLDWDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDLDWDVIEW] BEGIN  Update [DXTDLDWD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDLDWD="CREATE TRIGGER vw_del_DXTDLDWDVIEW INSTEAD OF DELETE ON DXTDLDWDVIEW BEGIN DELETE FROM DXTDLDWD WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDLDWDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdldwdview','geometry','rowid','dxtdldwd','geometry',0)";
        private string SELECT_DXTDLDWD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLDWD Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDLDWX="CREATE VIEW DXTDLDWXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLDWX Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDLDWX="CREATE TRIGGER [vw_ins_DXTDLDWXVIEW] INSTEAD OF INSERT ON [DXTDLDWXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDLDWX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDLDWX="CREATE TRIGGER [vw_upd_DXTDLDWXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDLDWXVIEW] BEGIN  Update [DXTDLDWX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDLDWX="CREATE TRIGGER vw_del_DXTDLDWXVIEW INSTEAD OF DELETE ON DXTDLDWXVIEW BEGIN DELETE FROM DXTDLDWX WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDLDWXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdldwxview','geometry','rowid','dxtdldwx','geometry',0)";
        private string SELECT_DXTDLDWX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLDWX Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDLDWM="CREATE VIEW DXTDLDWMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLDWM Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDLDWM="CREATE TRIGGER [vw_ins_DXTDLDWMVIEW] INSTEAD OF INSERT ON [DXTDLDWMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDLDWM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDLDWM="CREATE TRIGGER [vw_upd_DXTDLDWMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDLDWMVIEW] BEGIN  Update [DXTDLDWM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDLDWM="CREATE TRIGGER vw_del_DXTDLDWMVIEW INSTEAD OF DELETE ON DXTDLDWMVIEW BEGIN DELETE FROM DXTDLDWM WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDLDWMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdldwmview','geometry','rowid','dxtdldwm','geometry',0)";
        private string SELECT_DXTDLDWM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLDWM Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDLDWZJ="CREATE VIEW DXTDLDWZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLDWZJ Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDLDWZJ="CREATE TRIGGER [vw_ins_DXTDLDWZJVIEW] INSTEAD OF INSERT ON [DXTDLDWZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDLDWZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDLDWZJ="CREATE TRIGGER [vw_upd_DXTDLDWZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDLDWZJVIEW] BEGIN  Update [DXTDLDWZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDLDWZJ="CREATE TRIGGER vw_del_DXTDLDWZJVIEW INSTEAD OF DELETE ON DXTDLDWZJVIEW BEGIN DELETE FROM DXTDLDWZJ WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDLDWZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdldwzjview','geometry','rowid','dxtdldwzj','geometry',0)";
        private string SELECT_DXTDLDWZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLDWZJ Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDLSSD="CREATE VIEW DXTDLSSDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLSSD Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDLSSD="CREATE TRIGGER [vw_ins_DXTDLSSDVIEW] INSTEAD OF INSERT ON [DXTDLSSDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDLSSD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDLSSD="CREATE TRIGGER [vw_upd_DXTDLSSDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDLSSDVIEW] BEGIN  Update [DXTDLSSD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDLSSD="CREATE TRIGGER vw_del_DXTDLSSDVIEW INSTEAD OF DELETE ON DXTDLSSDVIEW BEGIN DELETE FROM DXTDLSSD WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDLSSDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdlssdview','geometry','rowid','dxtdlssd','geometry',0)";
        private string SELECT_DXTDLSSD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLSSD Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDLSSX="CREATE VIEW DXTDLSSXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLSSX Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDLSSX="CREATE TRIGGER [vw_ins_DXTDLSSXVIEW] INSTEAD OF INSERT ON [DXTDLSSXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDLSSX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDLSSX="CREATE TRIGGER [vw_upd_DXTDLSSXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDLSSXVIEW] BEGIN  Update [DXTDLSSX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDLSSX="CREATE TRIGGER vw_del_DXTDLSSXVIEW INSTEAD OF DELETE ON DXTDLSSXVIEW BEGIN DELETE FROM DXTDLSSX WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDLSSXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdlssxview','geometry','rowid','dxtdlssx','geometry',0)";
        private string SELECT_DXTDLSSX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLSSX Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDLSSM="CREATE VIEW DXTDLSSMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLSSM Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDLSSM="CREATE TRIGGER [vw_ins_DXTDLSSMVIEW] INSTEAD OF INSERT ON [DXTDLSSMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDLSSM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDLSSM="CREATE TRIGGER [vw_upd_DXTDLSSMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDLSSMVIEW] BEGIN  Update [DXTDLSSM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDLSSM="CREATE TRIGGER vw_del_DXTDLSSMVIEW INSTEAD OF DELETE ON DXTDLSSMVIEW BEGIN DELETE FROM DXTDLSSM WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDLSSMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdlssmview','geometry','rowid','dxtdlssm','geometry',0)";
        private string SELECT_DXTDLSSM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLSSM Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTDLSSZJ="CREATE VIEW DXTDLSSZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLSSZJ Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTDLSSZJ="CREATE TRIGGER [vw_ins_DXTDLSSZJVIEW] INSTEAD OF INSERT ON [DXTDLSSZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTDLSSZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTDLSSZJ="CREATE TRIGGER [vw_upd_DXTDLSSZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTDLSSZJVIEW] BEGIN  Update [DXTDLSSZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTDLSSZJ="CREATE TRIGGER vw_del_DXTDLSSZJVIEW INSTEAD OF DELETE ON DXTDLSSZJVIEW BEGIN DELETE FROM DXTDLSSZJ WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTDLSSZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtdlsszjview','geometry','rowid','dxtdlsszj','geometry',0)";
        private string SELECT_DXTDLSSZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTDLSSZJ Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTJMDD="CREATE VIEW DXTJMDDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTJMDD Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTJMDD="CREATE TRIGGER [vw_ins_DXTJMDDVIEW] INSTEAD OF INSERT ON [DXTJMDDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTJMDD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTJMDD="CREATE TRIGGER [vw_upd_DXTJMDDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTJMDDVIEW] BEGIN  Update [DXTJMDD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTJMDD="CREATE TRIGGER vw_del_DXTJMDDVIEW INSTEAD OF DELETE ON DXTJMDDVIEW BEGIN DELETE FROM DXTJMDD WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTJMDDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtjmddview','geometry','rowid','dxtjmdd','geometry',0)";
        private string SELECT_DXTJMDD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTJMDD Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTJMDX="CREATE VIEW DXTJMDXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTJMDX Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTJMDX="CREATE TRIGGER [vw_ins_DXTJMDXVIEW] INSTEAD OF INSERT ON [DXTJMDXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTJMDX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTJMDX="CREATE TRIGGER [vw_upd_DXTJMDXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTJMDXVIEW] BEGIN  Update [DXTJMDX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTJMDX="CREATE TRIGGER vw_del_DXTJMDXVIEW INSTEAD OF DELETE ON DXTJMDXVIEW BEGIN DELETE FROM DXTJMDX WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTJMDXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtjmdxview','geometry','rowid','dxtjmdx','geometry',0)";
        private string SELECT_DXTJMDX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTJMDX Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTJMDM="CREATE VIEW DXTJMDMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTJMDM Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTJMDM="CREATE TRIGGER [vw_ins_DXTJMDMVIEW] INSTEAD OF INSERT ON [DXTJMDMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTJMDM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTJMDM="CREATE TRIGGER [vw_upd_DXTJMDMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTJMDMVIEW] BEGIN  Update [DXTJMDM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTJMDM="CREATE TRIGGER vw_del_DXTJMDMVIEW INSTEAD OF DELETE ON DXTJMDMVIEW BEGIN DELETE FROM DXTJMDM WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTJMDMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtjmdmview','geometry','rowid','dxtjmdm','geometry',0)";
        private string SELECT_DXTJMDM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTJMDM Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTJMDZJ="CREATE VIEW DXTJMDZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTJMDZJ Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTJMDZJ="CREATE TRIGGER [vw_ins_DXTJMDZJVIEW] INSTEAD OF INSERT ON [DXTJMDZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTJMDZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTJMDZJ="CREATE TRIGGER [vw_upd_DXTJMDZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTJMDZJVIEW] BEGIN  Update [DXTJMDZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTJMDZJ="CREATE TRIGGER vw_del_DXTJMDZJVIEW INSTEAD OF DELETE ON DXTJMDZJVIEW BEGIN DELETE FROM DXTJMDZJ WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTJMDZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtjmdzjview','geometry','rowid','dxtjmdzj','geometry',0)";
        private string SELECT_DXTJMDZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTJMDZJ Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTKZDD="CREATE VIEW DXTKZDDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTKZDD Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTKZDD="CREATE TRIGGER [vw_ins_DXTKZDDVIEW] INSTEAD OF INSERT ON [DXTKZDDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTKZDD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTKZDD="CREATE TRIGGER [vw_upd_DXTKZDDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTKZDDVIEW] BEGIN  Update [DXTKZDD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTKZDD="CREATE TRIGGER vw_del_DXTKZDDVIEW INSTEAD OF DELETE ON DXTKZDDVIEW BEGIN DELETE FROM DXTKZDD WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTKZDDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtkzddview','geometry','rowid','dxtkzdd','geometry',0)";
        private string SELECT_DXTKZDD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTKZDD Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTKZDX="CREATE VIEW DXTKZDXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTKZDX Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTKZDX="CREATE TRIGGER [vw_ins_DXTKZDXVIEW] INSTEAD OF INSERT ON [DXTKZDXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTKZDX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTKZDX="CREATE TRIGGER [vw_upd_DXTKZDXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTKZDXVIEW] BEGIN  Update [DXTKZDX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTKZDX="CREATE TRIGGER vw_del_DXTKZDXVIEW INSTEAD OF DELETE ON DXTKZDXVIEW BEGIN DELETE FROM DXTKZDX WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTKZDXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtkzdxview','geometry','rowid','dxtkzdx','geometry',0)";
        private string SELECT_DXTKZDX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTKZDX Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTKZDM="CREATE VIEW DXTKZDMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTKZDM Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTKZDM="CREATE TRIGGER [vw_ins_DXTKZDMVIEW] INSTEAD OF INSERT ON [DXTKZDMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTKZDM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTKZDM="CREATE TRIGGER [vw_upd_DXTKZDMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTKZDMVIEW] BEGIN  Update [DXTKZDM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTKZDM="CREATE TRIGGER vw_del_DXTKZDMVIEW INSTEAD OF DELETE ON DXTKZDMVIEW BEGIN DELETE FROM DXTKZDM WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTKZDMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtkzdmview','geometry','rowid','dxtkzdm','geometry',0)";
        private string SELECT_DXTKZDM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTKZDM Where [FLAGS] < 3";
        
        private string CREATE_VIEW_DXTKZDZJ="CREATE VIEW DXTKZDZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTKZDZJ Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_DXTKZDZJ="CREATE TRIGGER [vw_ins_DXTKZDZJVIEW] INSTEAD OF INSERT ON [DXTKZDZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTKZDZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ], NEW.[geometry]); END";
        
        private string CREATE_UPDATE_TRIGGER_DXTKZDZJ="CREATE TRIGGER [vw_upd_DXTKZDZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [XGR], [XGSJ], [geometry] ON [DXTKZDZJVIEW] BEGIN  Update [DXTKZDZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_DXTKZDZJ="CREATE TRIGGER vw_del_DXTKZDZJVIEW INSTEAD OF DELETE ON DXTKZDZJVIEW BEGIN DELETE FROM DXTKZDZJ WHERE ROWID=OLD.ROWID;END";
         
        private string GEOMETRY_REGISTER_DXTKZDZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtkzdzjview','geometry','rowid','dxtkzdzj','geometry',0)";
        private string SELECT_DXTKZDZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,geometry from DXTKZDZJ Where [FLAGS] < 3";
        
        
        public BasemapDaoImpl(): base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("DXTQTD","其他图层点");
            _entityNames.Add("DXTQTX","其他图层线");
            _entityNames.Add("DXTQTM","其他图层面");
            _entityNames.Add("DXTQTZJ","其他图层注记");
            _entityNames.Add("DXTZJD","注记点");
            _entityNames.Add("DXTZJX","注记线");
            _entityNames.Add("DXTZJM","注记面");
            _entityNames.Add("DXTZJZJ","注记注记");
            _entityNames.Add("DXTDMTZD","地貌土质点");
            _entityNames.Add("DXTDMTZX","地貌土质线");
            _entityNames.Add("DXTDMTZM","地貌土质面");
            _entityNames.Add("DXTDMTZZJ","地貌土质注记");
            _entityNames.Add("DXTSXSSD","水系设施点");
            _entityNames.Add("DXTSXSSX","水系设施线");
            _entityNames.Add("DXTSXSSM","水系设施面");
            _entityNames.Add("DXTSXSSZJ","水系设施注记");
            _entityNames.Add("DXTDLDWD","独立地物点");
            _entityNames.Add("DXTDLDWX","独立地物线");
            _entityNames.Add("DXTDLDWM","独立地物面");
            _entityNames.Add("DXTDLDWZJ","独立地物注记");
            _entityNames.Add("DXTDLSSD","道路设施点");
            _entityNames.Add("DXTDLSSX","道路设施线");
            _entityNames.Add("DXTDLSSM","道路设施面");
            _entityNames.Add("DXTDLSSZJ","道路设施注记");
            _entityNames.Add("DXTJMDD","居民地点");
            _entityNames.Add("DXTJMDX","居民地线");
            _entityNames.Add("DXTJMDM","居民地面");
            _entityNames.Add("DXTJMDZJ","居民地注记");
            _entityNames.Add("DXTKZDD","控制点点");
            _entityNames.Add("DXTKZDX","控制点线");
            _entityNames.Add("DXTKZDM","控制点面");
            _entityNames.Add("DXTKZDZJ","控制点注记");
        }
        
        private event EntityChangedEventHandler entityChanged;

        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        public  void OnEntityChanged(string tableName, string layerName, EntityOperationType operationType, List<long> ids)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs(tableName, layerName, operationType, ids));
            }
        }
        
        public string GetLayerName(string tableName)
        {
            tableName=tableName.ToUpper();
            if(_entityNames.ContainsKey(tableName))
                return _entityNames[tableName];
            else
                return "";
        }
        
        ///Dxtqtd函数
        public Dxtqtd GetDxtqtd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTQTD" + " where id="+id.ToString();
            IEnumerable<Dxtqtd> dxtqtds=connection.Query<Dxtqtd>(sql);
            if(dxtqtds != null && dxtqtds.Count()>0)
            {
                return dxtqtds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtd> GetDxtqtds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTQTD" + " where "+filter;
            var dxtqtds=connection.Query<Dxtqtd>(sql);
            
            return dxtqtds;
        }
        
        public bool SaveDxtqtd(Dxtqtd dxtqtd)
        {
            bool retVal= dxtqtd.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtqtd",GetLayerName("DXTQTD"),EntityOperationType.Save,new List<long>{dxtqtd.ID});
            }
            return retVal;
        }
        
        public void SaveDxtqtds(List<Dxtqtd> dxtqtds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtqtds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtqtds.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtqtd",GetLayerName("DXTQTD"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtqtd(Dxtqtd record)
        {
            record.Delete(this);
            OnEntityChanged("dxtqtd",GetLayerName("DXTQTD"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtqtd> rows=GetDxtqtds(filter);
                foreach(Dxtqtd row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtqtd",GetLayerName("DXTQTD"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtqtx函数
        public Dxtqtx GetDxtqtx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTQTX" + " where id="+id.ToString();
            IEnumerable<Dxtqtx> dxtqtxs=connection.Query<Dxtqtx>(sql);
            if(dxtqtxs != null && dxtqtxs.Count()>0)
            {
                return dxtqtxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtx> GetDxtqtxes(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTQTX" + " where "+filter;
            var dxtqtxs=connection.Query<Dxtqtx>(sql);
            
            return dxtqtxs;
        }
        
        public bool SaveDxtqtx(Dxtqtx dxtqtx)
        {
            bool retVal= dxtqtx.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtqtx",GetLayerName("DXTQTX"),EntityOperationType.Save,new List<long>{dxtqtx.ID});
            }
            return retVal;
        }
        
        public void SaveDxtqtxes(List<Dxtqtx> dxtqtxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtqtxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtqtxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtqtx",GetLayerName("DXTQTX"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtqtx(Dxtqtx record)
        {
            record.Delete(this);
            OnEntityChanged("dxtqtx",GetLayerName("DXTQTX"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtqtx> rows=GetDxtqtxes(filter);
                foreach(Dxtqtx row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtqtx",GetLayerName("DXTQTX"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtqtm函数
        public Dxtqtm GetDxtqtm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTQTM" + " where id="+id.ToString();
            IEnumerable<Dxtqtm> dxtqtms=connection.Query<Dxtqtm>(sql);
            if(dxtqtms != null && dxtqtms.Count()>0)
            {
                return dxtqtms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtm> GetDxtqtms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTQTM" + " where "+filter;
            var dxtqtms=connection.Query<Dxtqtm>(sql);
            
            return dxtqtms;
        }
        
        public bool SaveDxtqtm(Dxtqtm dxtqtm)
        {
            bool retVal= dxtqtm.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtqtm",GetLayerName("DXTQTM"),EntityOperationType.Save,new List<long>{dxtqtm.ID});
            }
            return retVal;
        }
        
        public void SaveDxtqtms(List<Dxtqtm> dxtqtms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtqtms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtqtms.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtqtm",GetLayerName("DXTQTM"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtqtm(Dxtqtm record)
        {
            record.Delete(this);
            OnEntityChanged("dxtqtm",GetLayerName("DXTQTM"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtqtm> rows=GetDxtqtms(filter);
                foreach(Dxtqtm row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtqtm",GetLayerName("DXTQTM"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtqtzj函数
        public Dxtqtzj GetDxtqtzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTQTZJ" + " where id="+id.ToString();
            IEnumerable<Dxtqtzj> dxtqtzjs=connection.Query<Dxtqtzj>(sql);
            if(dxtqtzjs != null && dxtqtzjs.Count()>0)
            {
                return dxtqtzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtzj> GetDxtqtzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTQTZJ" + " where "+filter;
            var dxtqtzjs=connection.Query<Dxtqtzj>(sql);
            
            return dxtqtzjs;
        }
        
        public bool SaveDxtqtzj(Dxtqtzj dxtqtzj)
        {
            bool retVal= dxtqtzj.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtqtzj",GetLayerName("DXTQTZJ"),EntityOperationType.Save,new List<long>{dxtqtzj.ID});
            }
            return retVal;
        }
        
        public void SaveDxtqtzjs(List<Dxtqtzj> dxtqtzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtqtzjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtqtzjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtqtzj",GetLayerName("DXTQTZJ"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtqtzj(Dxtqtzj record)
        {
            record.Delete(this);
            OnEntityChanged("dxtqtzj",GetLayerName("DXTQTZJ"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtqtzj> rows=GetDxtqtzjs(filter);
                foreach(Dxtqtzj row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtqtzj",GetLayerName("DXTQTZJ"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtzjd函数
        public Dxtzjd GetDxtzjd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTZJD" + " where id="+id.ToString();
            IEnumerable<Dxtzjd> dxtzjds=connection.Query<Dxtzjd>(sql);
            if(dxtzjds != null && dxtzjds.Count()>0)
            {
                return dxtzjds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjd> GetDxtzjds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTZJD" + " where "+filter;
            var dxtzjds=connection.Query<Dxtzjd>(sql);
            
            return dxtzjds;
        }
        
        public bool SaveDxtzjd(Dxtzjd dxtzjd)
        {
            bool retVal= dxtzjd.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtzjd",GetLayerName("DXTZJD"),EntityOperationType.Save,new List<long>{dxtzjd.ID});
            }
            return retVal;
        }
        
        public void SaveDxtzjds(List<Dxtzjd> dxtzjds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtzjds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtzjds.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtzjd",GetLayerName("DXTZJD"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtzjd(Dxtzjd record)
        {
            record.Delete(this);
            OnEntityChanged("dxtzjd",GetLayerName("DXTZJD"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtzjd> rows=GetDxtzjds(filter);
                foreach(Dxtzjd row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtzjd",GetLayerName("DXTZJD"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtzjx函数
        public Dxtzjx GetDxtzjx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTZJX" + " where id="+id.ToString();
            IEnumerable<Dxtzjx> dxtzjxs=connection.Query<Dxtzjx>(sql);
            if(dxtzjxs != null && dxtzjxs.Count()>0)
            {
                return dxtzjxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjx> GetDxtzjxes(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTZJX" + " where "+filter;
            var dxtzjxs=connection.Query<Dxtzjx>(sql);
            
            return dxtzjxs;
        }
        
        public bool SaveDxtzjx(Dxtzjx dxtzjx)
        {
            bool retVal= dxtzjx.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtzjx",GetLayerName("DXTZJX"),EntityOperationType.Save,new List<long>{dxtzjx.ID});
            }
            return retVal;
        }
        
        public void SaveDxtzjxes(List<Dxtzjx> dxtzjxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtzjxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtzjxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtzjx",GetLayerName("DXTZJX"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtzjx(Dxtzjx record)
        {
            record.Delete(this);
            OnEntityChanged("dxtzjx",GetLayerName("DXTZJX"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtzjx> rows=GetDxtzjxes(filter);
                foreach(Dxtzjx row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtzjx",GetLayerName("DXTZJX"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtzjm函数
        public Dxtzjm GetDxtzjm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTZJM" + " where id="+id.ToString();
            IEnumerable<Dxtzjm> dxtzjms=connection.Query<Dxtzjm>(sql);
            if(dxtzjms != null && dxtzjms.Count()>0)
            {
                return dxtzjms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjm> GetDxtzjms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTZJM" + " where "+filter;
            var dxtzjms=connection.Query<Dxtzjm>(sql);
            
            return dxtzjms;
        }
        
        public bool SaveDxtzjm(Dxtzjm dxtzjm)
        {
            bool retVal= dxtzjm.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtzjm",GetLayerName("DXTZJM"),EntityOperationType.Save,new List<long>{dxtzjm.ID});
            }
            return retVal;
        }
        
        public void SaveDxtzjms(List<Dxtzjm> dxtzjms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtzjms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtzjms.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtzjm",GetLayerName("DXTZJM"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtzjm(Dxtzjm record)
        {
            record.Delete(this);
            OnEntityChanged("dxtzjm",GetLayerName("DXTZJM"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtzjm> rows=GetDxtzjms(filter);
                foreach(Dxtzjm row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtzjm",GetLayerName("DXTZJM"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtzjzj函数
        public Dxtzjzj GetDxtzjzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTZJZJ" + " where id="+id.ToString();
            IEnumerable<Dxtzjzj> dxtzjzjs=connection.Query<Dxtzjzj>(sql);
            if(dxtzjzjs != null && dxtzjzjs.Count()>0)
            {
                return dxtzjzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjzj> GetDxtzjzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTZJZJ" + " where "+filter;
            var dxtzjzjs=connection.Query<Dxtzjzj>(sql);
            
            return dxtzjzjs;
        }
        
        public bool SaveDxtzjzj(Dxtzjzj dxtzjzj)
        {
            bool retVal= dxtzjzj.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtzjzj",GetLayerName("DXTZJZJ"),EntityOperationType.Save,new List<long>{dxtzjzj.ID});
            }
            return retVal;
        }
        
        public void SaveDxtzjzjs(List<Dxtzjzj> dxtzjzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtzjzjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtzjzjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtzjzj",GetLayerName("DXTZJZJ"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtzjzj(Dxtzjzj record)
        {
            record.Delete(this);
            OnEntityChanged("dxtzjzj",GetLayerName("DXTZJZJ"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtzjzj> rows=GetDxtzjzjs(filter);
                foreach(Dxtzjzj row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtzjzj",GetLayerName("DXTZJZJ"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdmtzd函数
        public Dxtdmtzd GetDxtdmtzd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDMTZD" + " where id="+id.ToString();
            IEnumerable<Dxtdmtzd> dxtdmtzds=connection.Query<Dxtdmtzd>(sql);
            if(dxtdmtzds != null && dxtdmtzds.Count()>0)
            {
                return dxtdmtzds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzd> GetDxtdmtzds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDMTZD" + " where "+filter;
            var dxtdmtzds=connection.Query<Dxtdmtzd>(sql);
            
            return dxtdmtzds;
        }
        
        public bool SaveDxtdmtzd(Dxtdmtzd dxtdmtzd)
        {
            bool retVal= dxtdmtzd.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdmtzd",GetLayerName("DXTDMTZD"),EntityOperationType.Save,new List<long>{dxtdmtzd.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdmtzds(List<Dxtdmtzd> dxtdmtzds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdmtzds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdmtzds.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdmtzd",GetLayerName("DXTDMTZD"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdmtzd(Dxtdmtzd record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdmtzd",GetLayerName("DXTDMTZD"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdmtzd> rows=GetDxtdmtzds(filter);
                foreach(Dxtdmtzd row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdmtzd",GetLayerName("DXTDMTZD"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdmtzx函数
        public Dxtdmtzx GetDxtdmtzx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDMTZX" + " where id="+id.ToString();
            IEnumerable<Dxtdmtzx> dxtdmtzxs=connection.Query<Dxtdmtzx>(sql);
            if(dxtdmtzxs != null && dxtdmtzxs.Count()>0)
            {
                return dxtdmtzxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzx> GetDxtdmtzxes(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDMTZX" + " where "+filter;
            var dxtdmtzxs=connection.Query<Dxtdmtzx>(sql);
            
            return dxtdmtzxs;
        }
        
        public bool SaveDxtdmtzx(Dxtdmtzx dxtdmtzx)
        {
            bool retVal= dxtdmtzx.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdmtzx",GetLayerName("DXTDMTZX"),EntityOperationType.Save,new List<long>{dxtdmtzx.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdmtzxes(List<Dxtdmtzx> dxtdmtzxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdmtzxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdmtzxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdmtzx",GetLayerName("DXTDMTZX"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdmtzx(Dxtdmtzx record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdmtzx",GetLayerName("DXTDMTZX"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdmtzx> rows=GetDxtdmtzxes(filter);
                foreach(Dxtdmtzx row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdmtzx",GetLayerName("DXTDMTZX"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdmtzm函数
        public Dxtdmtzm GetDxtdmtzm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDMTZM" + " where id="+id.ToString();
            IEnumerable<Dxtdmtzm> dxtdmtzms=connection.Query<Dxtdmtzm>(sql);
            if(dxtdmtzms != null && dxtdmtzms.Count()>0)
            {
                return dxtdmtzms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzm> GetDxtdmtzms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDMTZM" + " where "+filter;
            var dxtdmtzms=connection.Query<Dxtdmtzm>(sql);
            
            return dxtdmtzms;
        }
        
        public bool SaveDxtdmtzm(Dxtdmtzm dxtdmtzm)
        {
            bool retVal= dxtdmtzm.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdmtzm",GetLayerName("DXTDMTZM"),EntityOperationType.Save,new List<long>{dxtdmtzm.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdmtzms(List<Dxtdmtzm> dxtdmtzms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdmtzms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdmtzms.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdmtzm",GetLayerName("DXTDMTZM"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdmtzm(Dxtdmtzm record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdmtzm",GetLayerName("DXTDMTZM"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdmtzm> rows=GetDxtdmtzms(filter);
                foreach(Dxtdmtzm row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdmtzm",GetLayerName("DXTDMTZM"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdmtzzj函数
        public Dxtdmtzzj GetDxtdmtzzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDMTZZJ" + " where id="+id.ToString();
            IEnumerable<Dxtdmtzzj> dxtdmtzzjs=connection.Query<Dxtdmtzzj>(sql);
            if(dxtdmtzzjs != null && dxtdmtzzjs.Count()>0)
            {
                return dxtdmtzzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzzj> GetDxtdmtzzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDMTZZJ" + " where "+filter;
            var dxtdmtzzjs=connection.Query<Dxtdmtzzj>(sql);
            
            return dxtdmtzzjs;
        }
        
        public bool SaveDxtdmtzzj(Dxtdmtzzj dxtdmtzzj)
        {
            bool retVal= dxtdmtzzj.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdmtzzj",GetLayerName("DXTDMTZZJ"),EntityOperationType.Save,new List<long>{dxtdmtzzj.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdmtzzjs(List<Dxtdmtzzj> dxtdmtzzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdmtzzjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdmtzzjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdmtzzj",GetLayerName("DXTDMTZZJ"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdmtzzj(Dxtdmtzzj record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdmtzzj",GetLayerName("DXTDMTZZJ"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdmtzzj> rows=GetDxtdmtzzjs(filter);
                foreach(Dxtdmtzzj row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdmtzzj",GetLayerName("DXTDMTZZJ"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtsxssd函数
        public Dxtsxssd GetDxtsxssd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTSXSSD" + " where id="+id.ToString();
            IEnumerable<Dxtsxssd> dxtsxssds=connection.Query<Dxtsxssd>(sql);
            if(dxtsxssds != null && dxtsxssds.Count()>0)
            {
                return dxtsxssds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssd> GetDxtsxssds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTSXSSD" + " where "+filter;
            var dxtsxssds=connection.Query<Dxtsxssd>(sql);
            
            return dxtsxssds;
        }
        
        public bool SaveDxtsxssd(Dxtsxssd dxtsxssd)
        {
            bool retVal= dxtsxssd.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtsxssd",GetLayerName("DXTSXSSD"),EntityOperationType.Save,new List<long>{dxtsxssd.ID});
            }
            return retVal;
        }
        
        public void SaveDxtsxssds(List<Dxtsxssd> dxtsxssds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtsxssds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtsxssds.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtsxssd",GetLayerName("DXTSXSSD"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtsxssd(Dxtsxssd record)
        {
            record.Delete(this);
            OnEntityChanged("dxtsxssd",GetLayerName("DXTSXSSD"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtsxssd> rows=GetDxtsxssds(filter);
                foreach(Dxtsxssd row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtsxssd",GetLayerName("DXTSXSSD"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtsxssx函数
        public Dxtsxssx GetDxtsxssx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTSXSSX" + " where id="+id.ToString();
            IEnumerable<Dxtsxssx> dxtsxssxs=connection.Query<Dxtsxssx>(sql);
            if(dxtsxssxs != null && dxtsxssxs.Count()>0)
            {
                return dxtsxssxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssx> GetDxtsxssxes(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTSXSSX" + " where "+filter;
            var dxtsxssxs=connection.Query<Dxtsxssx>(sql);
            
            return dxtsxssxs;
        }
        
        public bool SaveDxtsxssx(Dxtsxssx dxtsxssx)
        {
            bool retVal= dxtsxssx.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtsxssx",GetLayerName("DXTSXSSX"),EntityOperationType.Save,new List<long>{dxtsxssx.ID});
            }
            return retVal;
        }
        
        public void SaveDxtsxssxes(List<Dxtsxssx> dxtsxssxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtsxssxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtsxssxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtsxssx",GetLayerName("DXTSXSSX"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtsxssx(Dxtsxssx record)
        {
            record.Delete(this);
            OnEntityChanged("dxtsxssx",GetLayerName("DXTSXSSX"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtsxssx> rows=GetDxtsxssxes(filter);
                foreach(Dxtsxssx row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtsxssx",GetLayerName("DXTSXSSX"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtsxssm函数
        public Dxtsxssm GetDxtsxssm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTSXSSM" + " where id="+id.ToString();
            IEnumerable<Dxtsxssm> dxtsxssms=connection.Query<Dxtsxssm>(sql);
            if(dxtsxssms != null && dxtsxssms.Count()>0)
            {
                return dxtsxssms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssm> GetDxtsxssms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTSXSSM" + " where "+filter;
            var dxtsxssms=connection.Query<Dxtsxssm>(sql);
            
            return dxtsxssms;
        }
        
        public bool SaveDxtsxssm(Dxtsxssm dxtsxssm)
        {
            bool retVal= dxtsxssm.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtsxssm",GetLayerName("DXTSXSSM"),EntityOperationType.Save,new List<long>{dxtsxssm.ID});
            }
            return retVal;
        }
        
        public void SaveDxtsxssms(List<Dxtsxssm> dxtsxssms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtsxssms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtsxssms.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtsxssm",GetLayerName("DXTSXSSM"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtsxssm(Dxtsxssm record)
        {
            record.Delete(this);
            OnEntityChanged("dxtsxssm",GetLayerName("DXTSXSSM"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtsxssm> rows=GetDxtsxssms(filter);
                foreach(Dxtsxssm row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtsxssm",GetLayerName("DXTSXSSM"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtsxsszj函数
        public Dxtsxsszj GetDxtsxsszj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTSXSSZJ" + " where id="+id.ToString();
            IEnumerable<Dxtsxsszj> dxtsxsszjs=connection.Query<Dxtsxsszj>(sql);
            if(dxtsxsszjs != null && dxtsxsszjs.Count()>0)
            {
                return dxtsxsszjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxsszj> GetDxtsxsszjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTSXSSZJ" + " where "+filter;
            var dxtsxsszjs=connection.Query<Dxtsxsszj>(sql);
            
            return dxtsxsszjs;
        }
        
        public bool SaveDxtsxsszj(Dxtsxsszj dxtsxsszj)
        {
            bool retVal= dxtsxsszj.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtsxsszj",GetLayerName("DXTSXSSZJ"),EntityOperationType.Save,new List<long>{dxtsxsszj.ID});
            }
            return retVal;
        }
        
        public void SaveDxtsxsszjs(List<Dxtsxsszj> dxtsxsszjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtsxsszjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtsxsszjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtsxsszj",GetLayerName("DXTSXSSZJ"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtsxsszj(Dxtsxsszj record)
        {
            record.Delete(this);
            OnEntityChanged("dxtsxsszj",GetLayerName("DXTSXSSZJ"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtsxsszj> rows=GetDxtsxsszjs(filter);
                foreach(Dxtsxsszj row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtsxsszj",GetLayerName("DXTSXSSZJ"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdldwd函数
        public Dxtdldwd GetDxtdldwd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLDWD" + " where id="+id.ToString();
            IEnumerable<Dxtdldwd> dxtdldwds=connection.Query<Dxtdldwd>(sql);
            if(dxtdldwds != null && dxtdldwds.Count()>0)
            {
                return dxtdldwds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwd> GetDxtdldwds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLDWD" + " where "+filter;
            var dxtdldwds=connection.Query<Dxtdldwd>(sql);
            
            return dxtdldwds;
        }
        
        public bool SaveDxtdldwd(Dxtdldwd dxtdldwd)
        {
            bool retVal= dxtdldwd.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdldwd",GetLayerName("DXTDLDWD"),EntityOperationType.Save,new List<long>{dxtdldwd.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdldwds(List<Dxtdldwd> dxtdldwds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdldwds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdldwds.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdldwd",GetLayerName("DXTDLDWD"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdldwd(Dxtdldwd record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdldwd",GetLayerName("DXTDLDWD"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdldwd> rows=GetDxtdldwds(filter);
                foreach(Dxtdldwd row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdldwd",GetLayerName("DXTDLDWD"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdldwx函数
        public Dxtdldwx GetDxtdldwx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLDWX" + " where id="+id.ToString();
            IEnumerable<Dxtdldwx> dxtdldwxs=connection.Query<Dxtdldwx>(sql);
            if(dxtdldwxs != null && dxtdldwxs.Count()>0)
            {
                return dxtdldwxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwx> GetDxtdldwxes(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLDWX" + " where "+filter;
            var dxtdldwxs=connection.Query<Dxtdldwx>(sql);
            
            return dxtdldwxs;
        }
        
        public bool SaveDxtdldwx(Dxtdldwx dxtdldwx)
        {
            bool retVal= dxtdldwx.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdldwx",GetLayerName("DXTDLDWX"),EntityOperationType.Save,new List<long>{dxtdldwx.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdldwxes(List<Dxtdldwx> dxtdldwxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdldwxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdldwxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdldwx",GetLayerName("DXTDLDWX"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdldwx(Dxtdldwx record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdldwx",GetLayerName("DXTDLDWX"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdldwx> rows=GetDxtdldwxes(filter);
                foreach(Dxtdldwx row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdldwx",GetLayerName("DXTDLDWX"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdldwm函数
        public Dxtdldwm GetDxtdldwm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLDWM" + " where id="+id.ToString();
            IEnumerable<Dxtdldwm> dxtdldwms=connection.Query<Dxtdldwm>(sql);
            if(dxtdldwms != null && dxtdldwms.Count()>0)
            {
                return dxtdldwms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwm> GetDxtdldwms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLDWM" + " where "+filter;
            var dxtdldwms=connection.Query<Dxtdldwm>(sql);
            
            return dxtdldwms;
        }
        
        public bool SaveDxtdldwm(Dxtdldwm dxtdldwm)
        {
            bool retVal= dxtdldwm.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdldwm",GetLayerName("DXTDLDWM"),EntityOperationType.Save,new List<long>{dxtdldwm.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdldwms(List<Dxtdldwm> dxtdldwms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdldwms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdldwms.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdldwm",GetLayerName("DXTDLDWM"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdldwm(Dxtdldwm record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdldwm",GetLayerName("DXTDLDWM"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdldwm> rows=GetDxtdldwms(filter);
                foreach(Dxtdldwm row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdldwm",GetLayerName("DXTDLDWM"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdldwzj函数
        public Dxtdldwzj GetDxtdldwzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLDWZJ" + " where id="+id.ToString();
            IEnumerable<Dxtdldwzj> dxtdldwzjs=connection.Query<Dxtdldwzj>(sql);
            if(dxtdldwzjs != null && dxtdldwzjs.Count()>0)
            {
                return dxtdldwzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwzj> GetDxtdldwzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLDWZJ" + " where "+filter;
            var dxtdldwzjs=connection.Query<Dxtdldwzj>(sql);
            
            return dxtdldwzjs;
        }
        
        public bool SaveDxtdldwzj(Dxtdldwzj dxtdldwzj)
        {
            bool retVal= dxtdldwzj.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdldwzj",GetLayerName("DXTDLDWZJ"),EntityOperationType.Save,new List<long>{dxtdldwzj.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdldwzjs(List<Dxtdldwzj> dxtdldwzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdldwzjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdldwzjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdldwzj",GetLayerName("DXTDLDWZJ"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdldwzj(Dxtdldwzj record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdldwzj",GetLayerName("DXTDLDWZJ"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdldwzj> rows=GetDxtdldwzjs(filter);
                foreach(Dxtdldwzj row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdldwzj",GetLayerName("DXTDLDWZJ"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdlssd函数
        public Dxtdlssd GetDxtdlssd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLSSD" + " where id="+id.ToString();
            IEnumerable<Dxtdlssd> dxtdlssds=connection.Query<Dxtdlssd>(sql);
            if(dxtdlssds != null && dxtdlssds.Count()>0)
            {
                return dxtdlssds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssd> GetDxtdlssds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLSSD" + " where "+filter;
            var dxtdlssds=connection.Query<Dxtdlssd>(sql);
            
            return dxtdlssds;
        }
        
        public bool SaveDxtdlssd(Dxtdlssd dxtdlssd)
        {
            bool retVal= dxtdlssd.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdlssd",GetLayerName("DXTDLSSD"),EntityOperationType.Save,new List<long>{dxtdlssd.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdlssds(List<Dxtdlssd> dxtdlssds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdlssds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdlssds.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdlssd",GetLayerName("DXTDLSSD"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdlssd(Dxtdlssd record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdlssd",GetLayerName("DXTDLSSD"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdlssd> rows=GetDxtdlssds(filter);
                foreach(Dxtdlssd row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdlssd",GetLayerName("DXTDLSSD"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdlssx函数
        public Dxtdlssx GetDxtdlssx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLSSX" + " where id="+id.ToString();
            IEnumerable<Dxtdlssx> dxtdlssxs=connection.Query<Dxtdlssx>(sql);
            if(dxtdlssxs != null && dxtdlssxs.Count()>0)
            {
                return dxtdlssxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssx> GetDxtdlssxes(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLSSX" + " where "+filter;
            var dxtdlssxs=connection.Query<Dxtdlssx>(sql);
            
            return dxtdlssxs;
        }
        
        public bool SaveDxtdlssx(Dxtdlssx dxtdlssx)
        {
            bool retVal= dxtdlssx.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdlssx",GetLayerName("DXTDLSSX"),EntityOperationType.Save,new List<long>{dxtdlssx.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdlssxes(List<Dxtdlssx> dxtdlssxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdlssxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdlssxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdlssx",GetLayerName("DXTDLSSX"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdlssx(Dxtdlssx record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdlssx",GetLayerName("DXTDLSSX"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdlssx> rows=GetDxtdlssxes(filter);
                foreach(Dxtdlssx row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdlssx",GetLayerName("DXTDLSSX"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdlssm函数
        public Dxtdlssm GetDxtdlssm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLSSM" + " where id="+id.ToString();
            IEnumerable<Dxtdlssm> dxtdlssms=connection.Query<Dxtdlssm>(sql);
            if(dxtdlssms != null && dxtdlssms.Count()>0)
            {
                return dxtdlssms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssm> GetDxtdlssms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLSSM" + " where "+filter;
            var dxtdlssms=connection.Query<Dxtdlssm>(sql);
            
            return dxtdlssms;
        }
        
        public bool SaveDxtdlssm(Dxtdlssm dxtdlssm)
        {
            bool retVal= dxtdlssm.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdlssm",GetLayerName("DXTDLSSM"),EntityOperationType.Save,new List<long>{dxtdlssm.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdlssms(List<Dxtdlssm> dxtdlssms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdlssms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdlssms.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdlssm",GetLayerName("DXTDLSSM"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdlssm(Dxtdlssm record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdlssm",GetLayerName("DXTDLSSM"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdlssm> rows=GetDxtdlssms(filter);
                foreach(Dxtdlssm row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdlssm",GetLayerName("DXTDLSSM"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtdlsszj函数
        public Dxtdlsszj GetDxtdlsszj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLSSZJ" + " where id="+id.ToString();
            IEnumerable<Dxtdlsszj> dxtdlsszjs=connection.Query<Dxtdlsszj>(sql);
            if(dxtdlsszjs != null && dxtdlsszjs.Count()>0)
            {
                return dxtdlsszjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlsszj> GetDxtdlsszjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTDLSSZJ" + " where "+filter;
            var dxtdlsszjs=connection.Query<Dxtdlsszj>(sql);
            
            return dxtdlsszjs;
        }
        
        public bool SaveDxtdlsszj(Dxtdlsszj dxtdlsszj)
        {
            bool retVal= dxtdlsszj.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtdlsszj",GetLayerName("DXTDLSSZJ"),EntityOperationType.Save,new List<long>{dxtdlsszj.ID});
            }
            return retVal;
        }
        
        public void SaveDxtdlsszjs(List<Dxtdlsszj> dxtdlsszjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdlsszjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtdlsszjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtdlsszj",GetLayerName("DXTDLSSZJ"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtdlsszj(Dxtdlsszj record)
        {
            record.Delete(this);
            OnEntityChanged("dxtdlsszj",GetLayerName("DXTDLSSZJ"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtdlsszj> rows=GetDxtdlsszjs(filter);
                foreach(Dxtdlsszj row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtdlsszj",GetLayerName("DXTDLSSZJ"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtjmdd函数
        public Dxtjmdd GetDxtjmdd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTJMDD" + " where id="+id.ToString();
            IEnumerable<Dxtjmdd> dxtjmdds=connection.Query<Dxtjmdd>(sql);
            if(dxtjmdds != null && dxtjmdds.Count()>0)
            {
                return dxtjmdds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdd> GetDxtjmdds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTJMDD" + " where "+filter;
            var dxtjmdds=connection.Query<Dxtjmdd>(sql);
            
            return dxtjmdds;
        }
        
        public bool SaveDxtjmdd(Dxtjmdd dxtjmdd)
        {
            bool retVal= dxtjmdd.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtjmdd",GetLayerName("DXTJMDD"),EntityOperationType.Save,new List<long>{dxtjmdd.ID});
            }
            return retVal;
        }
        
        public void SaveDxtjmdds(List<Dxtjmdd> dxtjmdds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtjmdds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtjmdds.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtjmdd",GetLayerName("DXTJMDD"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtjmdd(Dxtjmdd record)
        {
            record.Delete(this);
            OnEntityChanged("dxtjmdd",GetLayerName("DXTJMDD"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtjmdd> rows=GetDxtjmdds(filter);
                foreach(Dxtjmdd row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtjmdd",GetLayerName("DXTJMDD"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtjmdx函数
        public Dxtjmdx GetDxtjmdx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTJMDX" + " where id="+id.ToString();
            IEnumerable<Dxtjmdx> dxtjmdxs=connection.Query<Dxtjmdx>(sql);
            if(dxtjmdxs != null && dxtjmdxs.Count()>0)
            {
                return dxtjmdxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdx> GetDxtjmdxes(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTJMDX" + " where "+filter;
            var dxtjmdxs=connection.Query<Dxtjmdx>(sql);
            
            return dxtjmdxs;
        }
        
        public bool SaveDxtjmdx(Dxtjmdx dxtjmdx)
        {
            bool retVal= dxtjmdx.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtjmdx",GetLayerName("DXTJMDX"),EntityOperationType.Save,new List<long>{dxtjmdx.ID});
            }
            return retVal;
        }
        
        public void SaveDxtjmdxes(List<Dxtjmdx> dxtjmdxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtjmdxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtjmdxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtjmdx",GetLayerName("DXTJMDX"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtjmdx(Dxtjmdx record)
        {
            record.Delete(this);
            OnEntityChanged("dxtjmdx",GetLayerName("DXTJMDX"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtjmdx> rows=GetDxtjmdxes(filter);
                foreach(Dxtjmdx row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtjmdx",GetLayerName("DXTJMDX"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtjmdm函数
        public Dxtjmdm GetDxtjmdm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTJMDM" + " where id="+id.ToString();
            IEnumerable<Dxtjmdm> dxtjmdms=connection.Query<Dxtjmdm>(sql);
            if(dxtjmdms != null && dxtjmdms.Count()>0)
            {
                return dxtjmdms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdm> GetDxtjmdms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTJMDM" + " where "+filter;
            var dxtjmdms=connection.Query<Dxtjmdm>(sql);
            
            return dxtjmdms;
        }
        
        public bool SaveDxtjmdm(Dxtjmdm dxtjmdm)
        {
            bool retVal= dxtjmdm.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtjmdm",GetLayerName("DXTJMDM"),EntityOperationType.Save,new List<long>{dxtjmdm.ID});
            }
            return retVal;
        }
        
        public void SaveDxtjmdms(List<Dxtjmdm> dxtjmdms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtjmdms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtjmdms.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtjmdm",GetLayerName("DXTJMDM"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtjmdm(Dxtjmdm record)
        {
            record.Delete(this);
            OnEntityChanged("dxtjmdm",GetLayerName("DXTJMDM"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtjmdm> rows=GetDxtjmdms(filter);
                foreach(Dxtjmdm row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtjmdm",GetLayerName("DXTJMDM"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtjmdzj函数
        public Dxtjmdzj GetDxtjmdzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTJMDZJ" + " where id="+id.ToString();
            IEnumerable<Dxtjmdzj> dxtjmdzjs=connection.Query<Dxtjmdzj>(sql);
            if(dxtjmdzjs != null && dxtjmdzjs.Count()>0)
            {
                return dxtjmdzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdzj> GetDxtjmdzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTJMDZJ" + " where "+filter;
            var dxtjmdzjs=connection.Query<Dxtjmdzj>(sql);
            
            return dxtjmdzjs;
        }
        
        public bool SaveDxtjmdzj(Dxtjmdzj dxtjmdzj)
        {
            bool retVal= dxtjmdzj.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtjmdzj",GetLayerName("DXTJMDZJ"),EntityOperationType.Save,new List<long>{dxtjmdzj.ID});
            }
            return retVal;
        }
        
        public void SaveDxtjmdzjs(List<Dxtjmdzj> dxtjmdzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtjmdzjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtjmdzjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtjmdzj",GetLayerName("DXTJMDZJ"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtjmdzj(Dxtjmdzj record)
        {
            record.Delete(this);
            OnEntityChanged("dxtjmdzj",GetLayerName("DXTJMDZJ"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtjmdzj> rows=GetDxtjmdzjs(filter);
                foreach(Dxtjmdzj row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtjmdzj",GetLayerName("DXTJMDZJ"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtkzdd函数
        public Dxtkzdd GetDxtkzdd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTKZDD" + " where id="+id.ToString();
            IEnumerable<Dxtkzdd> dxtkzdds=connection.Query<Dxtkzdd>(sql);
            if(dxtkzdds != null && dxtkzdds.Count()>0)
            {
                return dxtkzdds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdd> GetDxtkzdds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTKZDD" + " where "+filter;
            var dxtkzdds=connection.Query<Dxtkzdd>(sql);
            
            return dxtkzdds;
        }
        
        public bool SaveDxtkzdd(Dxtkzdd dxtkzdd)
        {
            bool retVal= dxtkzdd.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtkzdd",GetLayerName("DXTKZDD"),EntityOperationType.Save,new List<long>{dxtkzdd.ID});
            }
            return retVal;
        }
        
        public void SaveDxtkzdds(List<Dxtkzdd> dxtkzdds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtkzdds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtkzdds.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtkzdd",GetLayerName("DXTKZDD"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtkzdd(Dxtkzdd record)
        {
            record.Delete(this);
            OnEntityChanged("dxtkzdd",GetLayerName("DXTKZDD"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtkzdd> rows=GetDxtkzdds(filter);
                foreach(Dxtkzdd row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtkzdd",GetLayerName("DXTKZDD"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtkzdx函数
        public Dxtkzdx GetDxtkzdx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTKZDX" + " where id="+id.ToString();
            IEnumerable<Dxtkzdx> dxtkzdxs=connection.Query<Dxtkzdx>(sql);
            if(dxtkzdxs != null && dxtkzdxs.Count()>0)
            {
                return dxtkzdxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdx> GetDxtkzdxes(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTKZDX" + " where "+filter;
            var dxtkzdxs=connection.Query<Dxtkzdx>(sql);
            
            return dxtkzdxs;
        }
        
        public bool SaveDxtkzdx(Dxtkzdx dxtkzdx)
        {
            bool retVal= dxtkzdx.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtkzdx",GetLayerName("DXTKZDX"),EntityOperationType.Save,new List<long>{dxtkzdx.ID});
            }
            return retVal;
        }
        
        public void SaveDxtkzdxes(List<Dxtkzdx> dxtkzdxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtkzdxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtkzdxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtkzdx",GetLayerName("DXTKZDX"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtkzdx(Dxtkzdx record)
        {
            record.Delete(this);
            OnEntityChanged("dxtkzdx",GetLayerName("DXTKZDX"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtkzdx> rows=GetDxtkzdxes(filter);
                foreach(Dxtkzdx row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtkzdx",GetLayerName("DXTKZDX"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtkzdm函数
        public Dxtkzdm GetDxtkzdm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTKZDM" + " where id="+id.ToString();
            IEnumerable<Dxtkzdm> dxtkzdms=connection.Query<Dxtkzdm>(sql);
            if(dxtkzdms != null && dxtkzdms.Count()>0)
            {
                return dxtkzdms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdm> GetDxtkzdms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTKZDM" + " where "+filter;
            var dxtkzdms=connection.Query<Dxtkzdm>(sql);
            
            return dxtkzdms;
        }
        
        public bool SaveDxtkzdm(Dxtkzdm dxtkzdm)
        {
            bool retVal= dxtkzdm.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtkzdm",GetLayerName("DXTKZDM"),EntityOperationType.Save,new List<long>{dxtkzdm.ID});
            }
            return retVal;
        }
        
        public void SaveDxtkzdms(List<Dxtkzdm> dxtkzdms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtkzdms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtkzdms.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtkzdm",GetLayerName("DXTKZDM"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtkzdm(Dxtkzdm record)
        {
            record.Delete(this);
            OnEntityChanged("dxtkzdm",GetLayerName("DXTKZDM"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtkzdm> rows=GetDxtkzdms(filter);
                foreach(Dxtkzdm row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtkzdm",GetLayerName("DXTKZDM"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///Dxtkzdzj函数
        public Dxtkzdzj GetDxtkzdzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTKZDZJ" + " where id="+id.ToString();
            IEnumerable<Dxtkzdzj> dxtkzdzjs=connection.Query<Dxtkzdzj>(sql);
            if(dxtkzdzjs != null && dxtkzdzjs.Count()>0)
            {
                return dxtkzdzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdzj> GetDxtkzdzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt from DXTKZDZJ" + " where "+filter;
            var dxtkzdzjs=connection.Query<Dxtkzdzj>(sql);
            
            return dxtkzdzjs;
        }
        
        public bool SaveDxtkzdzj(Dxtkzdzj dxtkzdzj)
        {
            bool retVal= dxtkzdzj.Save(this);
            if(retVal)
            {
                OnEntityChanged("dxtkzdzj",GetLayerName("DXTKZDZJ"),EntityOperationType.Save,new List<long>{dxtkzdzj.ID});
            }
            return retVal;
        }
        
        public void SaveDxtkzdzjs(List<Dxtkzdzj> dxtkzdzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtkzdzjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=dxtkzdzjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("dxtkzdzj",GetLayerName("DXTKZDZJ"),EntityOperationType.Save,ids);
        }
        
        public void DeleteDxtkzdzj(Dxtkzdzj record)
        {
            record.Delete(this);
            OnEntityChanged("dxtkzdzj",GetLayerName("DXTKZDZJ"),EntityOperationType.Delete,new List<long>{record.ID});
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
                IEnumerable<Dxtkzdzj> rows=GetDxtkzdzjs(filter);
                foreach(Dxtkzdzj row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("dxtkzdzj",GetLayerName("DXTKZDZJ"),EntityOperationType.Delete,null);
            }
        }
        
        
        
        
    }
}



