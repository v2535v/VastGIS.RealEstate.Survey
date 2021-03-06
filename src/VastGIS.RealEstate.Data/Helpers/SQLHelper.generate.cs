﻿using System;
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

namespace VastGIS.RealEstate.Data.Helpers
{
  public partial class SQLHelper
  {
    private static SQLHelper instance;
    public Dictionary<string, string> _dictionary;
    
    public static SQLHelper Instance()
    {
      //--- Note: Not thread safe!
      if(instance == null)
      {
        instance = new SQLHelper();
      }
      return instance;
    }
    
    public string GetQuerySql(string tableName)
    {
        string key="SYS_SELECT_"+tableName.ToUpper();
        if(_dictionary.ContainsKey(key)==false)return "";
        return _dictionary[key];
    }
    
    protected SQLHelper()
    {
        _dictionary=new Dictionary<string,string>();
        _dictionary.Add("SYS_SELECT_VG_AREACODE","SELECT  Id,XZQHMC,XZQHDM,XZQHJB FROM vg_areacode "); 
        _dictionary.Add("SYS_SELECT_VG_ATTACHMENT","SELECT  Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS,XGR,XGSJ FROM vg_attachment WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_VG_CADCODE","SELECT  Id,XH,SFCY,TC,CASSDM,TXLX,XTC,YSDM,YSLX,YSZL FROM vg_cadcode "); 
        _dictionary.Add("SYS_SELECT_VG_CLASSDETAIL","SELECT  Id,GroupName,ObjectTableName,CreateImpl,InterfaceName FROM vg_classdetail "); 
        _dictionary.Add("SYS_SELECT_VG_CLASSGROUP","SELECT  Id,GroupName,CreateImpl FROM vg_classgroup "); 
        _dictionary.Add("SYS_SELECT_VG_DICTIONARY","SELECT  Id,ZDMC,ZDZ,ZDSM,SFQS,PX FROM vg_dictionary "); 
        _dictionary.Add("SYS_SELECT_VG_DICTORYNAME","SELECT  Id,ZDMC,ZDSM FROM vg_dictoryname "); 
        _dictionary.Add("SYS_SELECT_VG_FIELDINFO","SELECT  Id,BM,BNSX,ZDZWMC,ZDMC,ZDLX,ZDCD,ZDXSWS,SYZD,YS,SYZDYW FROM vg_fieldinfo "); 
        _dictionary.Add("SYS_SELECT_VG_LAYERGROUP","SELECT  Id,ZM FROM vg_layergroup "); 
        _dictionary.Add("SYS_SELECT_VG_LAYERGROUPDETAIL","SELECT  Id,ZM,Mc,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE FROM vg_layergroupdetail "); 
        _dictionary.Add("SYS_SELECT_VG_OBJECTYSDM","SELECT  Id,YSDM,YSMC,XSSX,QSBG,QSFH,SFKJ FROM vg_objectysdm "); 
        _dictionary.Add("SYS_SELECT_VG_SETTING","SELECT  Id,CSMC,CSZ FROM vg_setting "); 
        _dictionary.Add("SYS_SELECT_VG_OBJECTCLASS","SELECT  Id,MC,DXLX,ZWMC,FBMC,XHZDMC,TXZDMC,TXLX,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE,XSSX,FILTER,QSDM,BJCT,BHFJ FROM vg_objectclass "); 
        _dictionary.Add("SYS_SELECT_CFDJ","SELECT  Id,YSDM,BDCDYH,YWH,CFJG,CFLX,CFWJ,CFWH,CFQSSJ,CFJSSJ,CFFW,QXDM,DJJG,DBR,DJSJ,JFYWH,JFJG,JFWJ,JFWH,JFDBR,JFDJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM CFDJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DJQ","SELECT  Id,YSDM,DJQDM,DJQMC,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DJQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DJZQ","SELECT  Id,YSDM,DJZQDM,DJZQMC,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DJZQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDLDWD","SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDLDWD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDLDWM","SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDLDWM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDLDWX","SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDLDWX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDLDWZJ","SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDLDWZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDLSSD","SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDLSSD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDLSSM","SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDLSSM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDLSSX","SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDLSSX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDLSSZJ","SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDLSSZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDMTZD","SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDMTZD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDMTZM","SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDMTZM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDMTZX","SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDMTZX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTDMTZZJ","SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTDMTZZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTJMDD","SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTJMDD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTJMDM","SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTJMDM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTJMDX","SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTJMDX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTJMDZJ","SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTJMDZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTKZDD","SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTKZDD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTKZDM","SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTKZDM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTKZDX","SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTKZDX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTKZDZJ","SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTKZDZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTQTD","SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTQTD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTQTM","SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTQTM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTQTX","SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTQTX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTQTZJ","SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTQTZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTSXSSD","SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTSXSSD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTSXSSM","SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTSXSSM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTSXSSX","SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTSXSSX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTSXSSZJ","SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTSXSSZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTZJD","SELECT  Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTZJD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTZJM","SELECT  Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTZJM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTZJX","SELECT  Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTZJX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DXTZJZJ","SELECT  Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DXTZJZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DYAQ","SELECT  Id,YSDM,BDCDYH,YWH,DYBDCLX,DYR,DYFS,DJLX,DJYY,ZJJZWZL,ZJJZWDYFW,BDBZZQSE,ZWLXQSSJ,ZWLXJSSJ,ZGZQQDSS,ZGZQSE,ZXDYYWH,ZXDYYY,ZXSJ,BDCDJZMH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM DYAQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DYIQ","SELECT  Id,YSDM,YWH,GYDBDCDYH,GYDQLR,GYDQLRZJZL,GYDQLRZJH,XYDBDCDYH,XYDZL,XYDQLR,XYDQLRZJZL,XYDQLRZJH,DJLX,DJYY,DYQNR,BDCDJZMH,QLQSSJ,QLJSSJ,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM DYIQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_DZDZW","SELECT  Id,YSDM,BDCDYH,ZDZHDM,DZDZWLX,DZWMC,MJDW,MJ,DAH,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM DZDZW WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_FDCQ1","SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,FDZL,TDSYQR,DYTDMJ,FTTDMJ,TDSYQSSJ,TDSYJSSJ,FDCJYJG,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,FCFHT,QSZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM FDCQ1 WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_FDCQ2","SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,FDZL,TDSYQR,DYTDMJ,FTTDMJ,TDSYQSSJ,TDSYJSSJ,FDCJYJG,GHYT,FWXZ,FWJG,SZC,ZCS,JZMJ,ZYJZMJ,FTJZMJ,JGSJ,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM FDCQ2 WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_FDCQ3","SELECT  Id,YSDM,BDCDYH,YWH,QLLX,JGZWBH,JGZWMC,JGZWSL,JGZWMJ,FTTDMJ,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM FDCQ3 WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_FDCQXM","SELECT  Id,BDCDYH,XMMC,ZH,ZCS,GHYT,FWJG,JZMJ,JGSJ,ZTS,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM FDCQXM WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_FZ","SELECT  Id,YWH,YSDM,FZRY,FZSJ,FZMC,FZSL,HFZSH,LZRXM,LZRZJLB,LZRZJH,LZRDH,LZRDZ,LZRYB,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM FZ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_GD","SELECT  Id,YWH,YSDM,DJDL,DJXL,ZL,QZHM,WJJS,ZYS,GDRY,GDSJ,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM GD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_GJZWSYQ","SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,ZL,TDHYSYQR,TDHYSYMJ,TDHYSYQSSJ,TDHYSYJSSJ,GJZWLX,GJZWGHYT,GJZWMJ,JGSJ,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,GJZWPMT,QSZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM GJZWSYQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_GZW","SELECT  Id,YSDM,BDCDYH,ZDZHDM,GZWMC,ZL,MJDW,MJ,DAH,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM GZW WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_H","SELECT  Id,BDCDYH,FWBM,YSDM,ZRZH,LJZH,CH,ZL,MJDW,SJCS,HH,SHBW,HX,HXJG,FWYT1,FWYT2,FWYT3,YCJZMJ,YCTNJZMJ,YCFTJZMJ,YCDXBFJZMJ,YCQTJZMJ,YCFTXS,SCJZMJ,SCTNJZMJ,SCFTJZMJ,SCDXBFJZMJ,SCQTJZMJ,SCFTXS,GYTDMJ,FTTDMJ,DYTDMJ,FWLX,FWXZ,FCFHT,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM H WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_HYSYQ","SELECT  Id,YSDM,ZHHDDM,BDCDYH,YWH,QLLX,DJLX,DJYY,SYQMJ,SYQQSSJ,SYQJSSJ,SYJZE,SYJBZYJ,SYJJNQK,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM HYSYQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_JSYDSYQ","SELECT  Id,YSDM,ZDDM,BDCDYH,YWH,QLLX,DJLX,DJYY,SYQMJ,SYQQSSJ,SYQJSSJ,QDJG,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM JSYDSYQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_JZD","SELECT  Id,ZDZHDM,YSDM,JZDH,SXH,JBLX,JZDLX,XZBZ,YZBZ,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM JZD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_JZDZJ","SELECT  Id,GLYSBH,YSDM,ZJNR,ZT,YS,BS,XZ,XHX,KD,GD,ZJDZXJXZB,ZJDZXJYZB,ZJFX,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM JZDZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_JZX","SELECT  Id,ZDZHDM,YSDM,JZXCD,JZXLB,JZXWZ,JXXZ,QSJXXYSBH,QSJXXYS,QSZYYYSBH,QSZYYYS,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM JZX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_JZXZJ","SELECT  Id,GLYSBH,YSDM,ZJNR,ZT,YS,BS,XZ,XHX,KD,GD,ZJDZXJXZB,ZJDZXJYZB,ZJFX,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM JZXZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_LJZ","SELECT  Id,LJZH,ZRZH,YSDM,MPH,YCJZMJ,YCDXMJ,YCQTMJ,SCJZMJ,SCDXMJ,SCQTMJ,JGRQ,FWJG1,FWJG2,FWJG3,JZWZT,FWYT1,FWYT2,FWYT3,ZCS,DSCS,DXCS,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM LJZ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_LQ","SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,FBF,SYQMJ,LDSYQSSJ,LDSYJSSJ,LDSYQXZ,SLLMSYQR1,SLLMSYQR2,ZYSZ,ZS,LZ,QY,ZLND,LB,XB,XDM,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM LQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_MZDZW","SELECT  Id,YSDM,BDCDYH,ZDZHDM,MZDZWLX,DZWMC,MJDW,MJ,DAH,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM MZDZW WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_NYDSYQ","SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,ZL,FBFDM,FBFMC,CBMJ,CBQSSJ,CBJSSJ,TDSYQXZ,SYTTLX,YZYFS,CYZL,SYZCL,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM NYDSYQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_QTXGQL","SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,QLQSSJ,QLJSSJ,QSFS,SYLX,QSL,QSYT,KCMJ,KCFS,KCKZ,SCGM,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,FT,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM QTXGQL WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_QXZD","SELECT  Id,XZQHDM,XZQHMC,DatabaseId,FLAGS,XGR,XGSJ FROM QXZD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_R","SELECT  Id,YSDM,QLRMC,QLRPY,PYSX,ZJZL,ZJH,FZJG,SSHY,GJ,HJSZSS,XB,DH,DZ,YB,GZDW,DZYJ,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM R WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_SF","SELECT  Id,YWH,YSDM,JFRY,JFRQ,SFKMMC,SFEWSF,SFJS,SFLX,YSJE,ZKHYSJE,SFRY,SFRQ,FFF,SJFFR,SSJE,SFDW,DatabaseId,FLAGS,XGR,XGSJ FROM SF WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_SGSJ","SELECT  Id,YSDM,SJWJM,TWJM,YSJWJM,DatabaseId,FLAGS,XGR,XGSJ FROM SGSJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_SH","SELECT  Id,YWH,YSDM,JDMC,SXH,SHRYXM,SHKSSJ,SHJSSJ,SHYJ,CZJG,DatabaseId,FLAGS,XGR,XGSJ FROM SH WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_SJ","SELECT  Id,YWH,YSDM,SJSJ,SJLX,SJMC,SJSL,SFSJSY,SFEWSJ,SFBCSJ,YS,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM SJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_SLSQ","SELECT  Id,YSDM,YWH,DJDL,DJXL,SQZSBS,SQFBCZ,QXDM,SLRY,SLSJ,ZL,TZRXM,TZFS,TZRDH,TZRYDDH,TZRDZYJ,SFWTAJ,JSSJ,AJZT,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM SLSQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_SQR","SELECT  Id,YWH,YSDM,QLRMC,QLRZJZL,QLRZJH,QLRTXDZ,QLRYB,QLRFRMC,QLRFRDH,QLRDLRMC,QLRDLRDH,QLRDLJG,YWRMC,YWRZJZL,YWRZJH,YWRTXDZ,YWRYB,YWRFRMC,YWRFRDH,YWRDLRMC,YWRDLRDH,YWRDLJG,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM SQR WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_SZ","SELECT  Id,YWH,YSDM,SZMC,SZZH,YSXLH,SZRY,SZSJ,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM SZ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_TDSYQ","SELECT  Id,YSDM,ZDDM,BDCDYH,YWH,QLLX,DJLX,DJYY,MJDW,NYDMJ,GDMJ,LDMJ,CDMJ,QTNYDMJ,JSYDMJ,WLYDMJ,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM TDSYQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_TMPCADD","SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM TmpCadd WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_TMPCADM","SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM TmpCadm WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_TMPCADX","SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM TmpCadx WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_TMPCADXDATA","SELECT  Id,Handle,Tc,Wbnr,Cassdm,Fsxx1,Fsxx2,Xzjd,Fh,Fhdx,Ysdm,FileName,DatabaseId,FLAGS,XGR,XGSJ FROM TmpCadxdata WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_TMPCADZJ","SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM TmpCadzj WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_XZDZW","SELECT  Id,YSDM,BDCDYH,ZDZHDM,XZDZWLX,DZWMC,MJDW,MJ,DAH,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM XZDZW WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_XZQ","SELECT  Id,YSDM,XZQDM,XZQMC,XZQMJ,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM XZQ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_XZQJX","SELECT  Id,YSDM,JXLX,JXXZ,JXSM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM XZQJX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_XZQZJ","SELECT  Id,YSDM,ZJNR,ZT,YS,BS,XZ,XHX,KD,GD,ZJDZXJXZB,ZJDZXJYZB,ZJFX,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM XZQZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_YGDJ","SELECT  Id,YSDM,BDCDYH,YWH,BDCZL,YWR,YWRZJZL,YWRZJH,YGDJZL,DJLX,DJYY,TDSYQR,GHYT,FWXZ,FWJG,SZC,ZCS,JZMJ,QDJG,BDCDJZMH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM YGDJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_YHYDZB","SELECT  Id,ZHHDDM,XH,BW,DJ,DatabaseId,FLAGS,XGR,XGSJ FROM YHYDZB WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_YHZK","SELECT  Id,ZHDM,YHFS,YHMJ,JTYT,SYJSE,DatabaseId,FLAGS,XGR,XGSJ FROM YHZK WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_YYDJ","SELECT  Id,YSDM,BDCDYH,YWH,YYSX,BDCDJZMH,QXDM,DJJG,DBR,DJSJ,ZXYYYWH,ZXYYYY,ZXYYDBR,ZXYYDJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM YYDJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZDJBXX","SELECT  Id,YSDM,ZDDM,BDCDYH,ZDTZM,ZL,ZDMJ,MJDW,YT,DJ,JG,QLLX,QLXZ,QLSDFS,RJL,JZMD,JZXG,ZDSZD,ZDSZN,ZDSZX,ZDSZB,ZDT,TFH,DJH,DAH,BZ,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM ZDJBXX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZDJBXXZJ","SELECT  Id,GLYSDM,YSDM,ZJNR,ZT,YS,BS,XZ,XHX,KD,GD,ZJDZXJXZB,ZJDZXJYZB,ZJFX,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM ZDJBXXZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZDTOJZD","SELECT  Id,ZD_WYDM,JZD_WYDM,SXH,DatabaseId,FLAGS,XGR,XGSJ FROM ZDTOJZD WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZDTOJZX","SELECT  Id,ZD_WYDM,JZX_WYDM,SXH,DatabaseId,FLAGS,XGR,XGSJ FROM ZDTOJZX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZHJBXX","SELECT  Id,YSDM,ZHDM,BDCDYH,ZHTZM,XMMC,XMXZ,YHZMJ,ZHMJ,DB,ZHAX,YHLXA,YHLXB,YHWZSM,HDMC,HDDM,YDFW,YDMJ,HDWZ,HDYT,ZHT,DAH,ZT,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM ZHJBXX WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZJ","SELECT  Id,YSDM,ZJNR,ZT,YS,BS,XZ,XHX,KD,GD,ZJDZXJXZB,ZJDZXJYZB,ZJFX,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM ZJ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZRZ","SELECT  Id,YSDM,BDCDYH,ZDDM,ZRZH,XMMC,JZWMC,JGRQ,JZWGD,ZZDMJ,ZYDMJ,YCJZMJ,SCJZMJ,ZCS,DSCS,DXCS,DXSD,GHYT,FWJG,ZTS,JZWJBYT,DAH,BZ,ZT,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM ZRZ WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_VG_OBJECTITEM","SELECT  Id,YSDM,YSMC,YSBM,SFKJ,YSLX,SM FROM vg_objectitem "); 
        _dictionary.Add("SYS_SELECT_VG_CLASSRELATION","SELECT  Id,YSBM,GLBM,YSZD,GLZD,GLLX,GXB,YSGX,GLGX FROM vg_classrelation "); 
        _dictionary.Add("SYS_SELECT_C","SELECT  Id,CFWLX,JSBL,CH,ZRZH,YSDM,SJC,MYC,CJZMJ,CTNJZMJ,CYTMJ,CGYJZMJ,CFTJZMJ,CBQMJ,CG,SPTYMJ,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM C WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZDBHQK","SELECT  Id,ZDDM,BHYY,BHNR,DJSJ,DBR,FJ,DatabaseId,FLAGS,XGR,XGSJ,WX_WYDM FROM ZDBHQK WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_ZHBHQK","SELECT  Id,ZHDM,BHYY,BHNR,DJSJ,DBR,DatabaseId,FLAGS,XGR,XGSJ,WX_WYDM FROM ZHBHQK WHERE [FLAGS]<3"); 
        _dictionary.Add("SYS_SELECT_QLR","SELECT  Id,YSDM,BDCDYH,SXH,QLRMC,BDCQZH,QZYSXLH,SFCZR,ZJZL,ZJH,FZJG,SSHY,GJ,HJSZSS,XB,DH,DZ,YB,GZDW,DZYJ,QLRLX,QLBL,GYFS,GYQK,BZ,DatabaseId,FLAGS,XGR,XGSJ,WX_WYDM FROM QLR WHERE [FLAGS]<3"); 
    }

    
  }
}