using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service
{
    public partial interface BasemapService:ISQLiteService
    {	
        #region Dxtdldwd方法
        Dxtdldwd GetDxtdldwd(long id);
        IEnumerable<Dxtdldwd> GetDxtdldwds(string filter);
        bool SaveDxtdldwd(Dxtdldwd dxtdldwd);
        void SaveDxtdldwds(List<Dxtdldwd> dxtdldwds);
        void DeleteDxtdldwd(Dxtdldwd rec);
        void DeleteDxtdldwd(long id);
        void DeleteDxtdldwd(string filter);
        #endregion
        
        #region Dxtdldwm方法
        Dxtdldwm GetDxtdldwm(long id);
        IEnumerable<Dxtdldwm> GetDxtdldwms(string filter);
        bool SaveDxtdldwm(Dxtdldwm dxtdldwm);
        void SaveDxtdldwms(List<Dxtdldwm> dxtdldwms);
        void DeleteDxtdldwm(Dxtdldwm rec);
        void DeleteDxtdldwm(long id);
        void DeleteDxtdldwm(string filter);
        #endregion
        
        #region Dxtdldwx方法
        Dxtdldwx GetDxtdldwx(long id);
        IEnumerable<Dxtdldwx> GetDxtdldwxes(string filter);
        bool SaveDxtdldwx(Dxtdldwx dxtdldwx);
        void SaveDxtdldwxes(List<Dxtdldwx> dxtdldwxes);
        void DeleteDxtdldwx(Dxtdldwx rec);
        void DeleteDxtdldwx(long id);
        void DeleteDxtdldwx(string filter);
        #endregion
        
        #region Dxtdldwzj方法
        Dxtdldwzj GetDxtdldwzj(long id);
        IEnumerable<Dxtdldwzj> GetDxtdldwzjs(string filter);
        bool SaveDxtdldwzj(Dxtdldwzj dxtdldwzj);
        void SaveDxtdldwzjs(List<Dxtdldwzj> dxtdldwzjs);
        void DeleteDxtdldwzj(Dxtdldwzj rec);
        void DeleteDxtdldwzj(long id);
        void DeleteDxtdldwzj(string filter);
        #endregion
        
        #region Dxtdlssd方法
        Dxtdlssd GetDxtdlssd(long id);
        IEnumerable<Dxtdlssd> GetDxtdlssds(string filter);
        bool SaveDxtdlssd(Dxtdlssd dxtdlssd);
        void SaveDxtdlssds(List<Dxtdlssd> dxtdlssds);
        void DeleteDxtdlssd(Dxtdlssd rec);
        void DeleteDxtdlssd(long id);
        void DeleteDxtdlssd(string filter);
        #endregion
        
        #region Dxtdlssm方法
        Dxtdlssm GetDxtdlssm(long id);
        IEnumerable<Dxtdlssm> GetDxtdlssms(string filter);
        bool SaveDxtdlssm(Dxtdlssm dxtdlssm);
        void SaveDxtdlssms(List<Dxtdlssm> dxtdlssms);
        void DeleteDxtdlssm(Dxtdlssm rec);
        void DeleteDxtdlssm(long id);
        void DeleteDxtdlssm(string filter);
        #endregion
        
        #region Dxtdlssx方法
        Dxtdlssx GetDxtdlssx(long id);
        IEnumerable<Dxtdlssx> GetDxtdlssxes(string filter);
        bool SaveDxtdlssx(Dxtdlssx dxtdlssx);
        void SaveDxtdlssxes(List<Dxtdlssx> dxtdlssxes);
        void DeleteDxtdlssx(Dxtdlssx rec);
        void DeleteDxtdlssx(long id);
        void DeleteDxtdlssx(string filter);
        #endregion
        
        #region Dxtdlsszj方法
        Dxtdlsszj GetDxtdlsszj(long id);
        IEnumerable<Dxtdlsszj> GetDxtdlsszjs(string filter);
        bool SaveDxtdlsszj(Dxtdlsszj dxtdlsszj);
        void SaveDxtdlsszjs(List<Dxtdlsszj> dxtdlsszjs);
        void DeleteDxtdlsszj(Dxtdlsszj rec);
        void DeleteDxtdlsszj(long id);
        void DeleteDxtdlsszj(string filter);
        #endregion
        
        #region Dxtdmtzd方法
        Dxtdmtzd GetDxtdmtzd(long id);
        IEnumerable<Dxtdmtzd> GetDxtdmtzds(string filter);
        bool SaveDxtdmtzd(Dxtdmtzd dxtdmtzd);
        void SaveDxtdmtzds(List<Dxtdmtzd> dxtdmtzds);
        void DeleteDxtdmtzd(Dxtdmtzd rec);
        void DeleteDxtdmtzd(long id);
        void DeleteDxtdmtzd(string filter);
        #endregion
        
        #region Dxtdmtzm方法
        Dxtdmtzm GetDxtdmtzm(long id);
        IEnumerable<Dxtdmtzm> GetDxtdmtzms(string filter);
        bool SaveDxtdmtzm(Dxtdmtzm dxtdmtzm);
        void SaveDxtdmtzms(List<Dxtdmtzm> dxtdmtzms);
        void DeleteDxtdmtzm(Dxtdmtzm rec);
        void DeleteDxtdmtzm(long id);
        void DeleteDxtdmtzm(string filter);
        #endregion
        
        #region Dxtdmtzx方法
        Dxtdmtzx GetDxtdmtzx(long id);
        IEnumerable<Dxtdmtzx> GetDxtdmtzxes(string filter);
        bool SaveDxtdmtzx(Dxtdmtzx dxtdmtzx);
        void SaveDxtdmtzxes(List<Dxtdmtzx> dxtdmtzxes);
        void DeleteDxtdmtzx(Dxtdmtzx rec);
        void DeleteDxtdmtzx(long id);
        void DeleteDxtdmtzx(string filter);
        #endregion
        
        #region Dxtdmtzzj方法
        Dxtdmtzzj GetDxtdmtzzj(long id);
        IEnumerable<Dxtdmtzzj> GetDxtdmtzzjs(string filter);
        bool SaveDxtdmtzzj(Dxtdmtzzj dxtdmtzzj);
        void SaveDxtdmtzzjs(List<Dxtdmtzzj> dxtdmtzzjs);
        void DeleteDxtdmtzzj(Dxtdmtzzj rec);
        void DeleteDxtdmtzzj(long id);
        void DeleteDxtdmtzzj(string filter);
        #endregion
        
        #region Dxtjmdd方法
        Dxtjmdd GetDxtjmdd(long id);
        IEnumerable<Dxtjmdd> GetDxtjmdds(string filter);
        bool SaveDxtjmdd(Dxtjmdd dxtjmdd);
        void SaveDxtjmdds(List<Dxtjmdd> dxtjmdds);
        void DeleteDxtjmdd(Dxtjmdd rec);
        void DeleteDxtjmdd(long id);
        void DeleteDxtjmdd(string filter);
        #endregion
        
        #region Dxtjmdm方法
        Dxtjmdm GetDxtjmdm(long id);
        IEnumerable<Dxtjmdm> GetDxtjmdms(string filter);
        bool SaveDxtjmdm(Dxtjmdm dxtjmdm);
        void SaveDxtjmdms(List<Dxtjmdm> dxtjmdms);
        void DeleteDxtjmdm(Dxtjmdm rec);
        void DeleteDxtjmdm(long id);
        void DeleteDxtjmdm(string filter);
        #endregion
        
        #region Dxtjmdx方法
        Dxtjmdx GetDxtjmdx(long id);
        IEnumerable<Dxtjmdx> GetDxtjmdxes(string filter);
        bool SaveDxtjmdx(Dxtjmdx dxtjmdx);
        void SaveDxtjmdxes(List<Dxtjmdx> dxtjmdxes);
        void DeleteDxtjmdx(Dxtjmdx rec);
        void DeleteDxtjmdx(long id);
        void DeleteDxtjmdx(string filter);
        #endregion
        
        #region Dxtjmdzj方法
        Dxtjmdzj GetDxtjmdzj(long id);
        IEnumerable<Dxtjmdzj> GetDxtjmdzjs(string filter);
        bool SaveDxtjmdzj(Dxtjmdzj dxtjmdzj);
        void SaveDxtjmdzjs(List<Dxtjmdzj> dxtjmdzjs);
        void DeleteDxtjmdzj(Dxtjmdzj rec);
        void DeleteDxtjmdzj(long id);
        void DeleteDxtjmdzj(string filter);
        #endregion
        
        #region Dxtkzdd方法
        Dxtkzdd GetDxtkzdd(long id);
        IEnumerable<Dxtkzdd> GetDxtkzdds(string filter);
        bool SaveDxtkzdd(Dxtkzdd dxtkzdd);
        void SaveDxtkzdds(List<Dxtkzdd> dxtkzdds);
        void DeleteDxtkzdd(Dxtkzdd rec);
        void DeleteDxtkzdd(long id);
        void DeleteDxtkzdd(string filter);
        #endregion
        
        #region Dxtkzdm方法
        Dxtkzdm GetDxtkzdm(long id);
        IEnumerable<Dxtkzdm> GetDxtkzdms(string filter);
        bool SaveDxtkzdm(Dxtkzdm dxtkzdm);
        void SaveDxtkzdms(List<Dxtkzdm> dxtkzdms);
        void DeleteDxtkzdm(Dxtkzdm rec);
        void DeleteDxtkzdm(long id);
        void DeleteDxtkzdm(string filter);
        #endregion
        
        #region Dxtkzdx方法
        Dxtkzdx GetDxtkzdx(long id);
        IEnumerable<Dxtkzdx> GetDxtkzdxes(string filter);
        bool SaveDxtkzdx(Dxtkzdx dxtkzdx);
        void SaveDxtkzdxes(List<Dxtkzdx> dxtkzdxes);
        void DeleteDxtkzdx(Dxtkzdx rec);
        void DeleteDxtkzdx(long id);
        void DeleteDxtkzdx(string filter);
        #endregion
        
        #region Dxtkzdzj方法
        Dxtkzdzj GetDxtkzdzj(long id);
        IEnumerable<Dxtkzdzj> GetDxtkzdzjs(string filter);
        bool SaveDxtkzdzj(Dxtkzdzj dxtkzdzj);
        void SaveDxtkzdzjs(List<Dxtkzdzj> dxtkzdzjs);
        void DeleteDxtkzdzj(Dxtkzdzj rec);
        void DeleteDxtkzdzj(long id);
        void DeleteDxtkzdzj(string filter);
        #endregion
        
        #region Dxtqtd方法
        Dxtqtd GetDxtqtd(long id);
        IEnumerable<Dxtqtd> GetDxtqtds(string filter);
        bool SaveDxtqtd(Dxtqtd dxtqtd);
        void SaveDxtqtds(List<Dxtqtd> dxtqtds);
        void DeleteDxtqtd(Dxtqtd rec);
        void DeleteDxtqtd(long id);
        void DeleteDxtqtd(string filter);
        #endregion
        
        #region Dxtqtm方法
        Dxtqtm GetDxtqtm(long id);
        IEnumerable<Dxtqtm> GetDxtqtms(string filter);
        bool SaveDxtqtm(Dxtqtm dxtqtm);
        void SaveDxtqtms(List<Dxtqtm> dxtqtms);
        void DeleteDxtqtm(Dxtqtm rec);
        void DeleteDxtqtm(long id);
        void DeleteDxtqtm(string filter);
        #endregion
        
        #region Dxtqtx方法
        Dxtqtx GetDxtqtx(long id);
        IEnumerable<Dxtqtx> GetDxtqtxes(string filter);
        bool SaveDxtqtx(Dxtqtx dxtqtx);
        void SaveDxtqtxes(List<Dxtqtx> dxtqtxes);
        void DeleteDxtqtx(Dxtqtx rec);
        void DeleteDxtqtx(long id);
        void DeleteDxtqtx(string filter);
        #endregion
        
        #region Dxtqtzj方法
        Dxtqtzj GetDxtqtzj(long id);
        IEnumerable<Dxtqtzj> GetDxtqtzjs(string filter);
        bool SaveDxtqtzj(Dxtqtzj dxtqtzj);
        void SaveDxtqtzjs(List<Dxtqtzj> dxtqtzjs);
        void DeleteDxtqtzj(Dxtqtzj rec);
        void DeleteDxtqtzj(long id);
        void DeleteDxtqtzj(string filter);
        #endregion
        
        #region Dxtsxssd方法
        Dxtsxssd GetDxtsxssd(long id);
        IEnumerable<Dxtsxssd> GetDxtsxssds(string filter);
        bool SaveDxtsxssd(Dxtsxssd dxtsxssd);
        void SaveDxtsxssds(List<Dxtsxssd> dxtsxssds);
        void DeleteDxtsxssd(Dxtsxssd rec);
        void DeleteDxtsxssd(long id);
        void DeleteDxtsxssd(string filter);
        #endregion
        
        #region Dxtsxssm方法
        Dxtsxssm GetDxtsxssm(long id);
        IEnumerable<Dxtsxssm> GetDxtsxssms(string filter);
        bool SaveDxtsxssm(Dxtsxssm dxtsxssm);
        void SaveDxtsxssms(List<Dxtsxssm> dxtsxssms);
        void DeleteDxtsxssm(Dxtsxssm rec);
        void DeleteDxtsxssm(long id);
        void DeleteDxtsxssm(string filter);
        #endregion
        
        #region Dxtsxssx方法
        Dxtsxssx GetDxtsxssx(long id);
        IEnumerable<Dxtsxssx> GetDxtsxssxes(string filter);
        bool SaveDxtsxssx(Dxtsxssx dxtsxssx);
        void SaveDxtsxssxes(List<Dxtsxssx> dxtsxssxes);
        void DeleteDxtsxssx(Dxtsxssx rec);
        void DeleteDxtsxssx(long id);
        void DeleteDxtsxssx(string filter);
        #endregion
        
        #region Dxtsxsszj方法
        Dxtsxsszj GetDxtsxsszj(long id);
        IEnumerable<Dxtsxsszj> GetDxtsxsszjs(string filter);
        bool SaveDxtsxsszj(Dxtsxsszj dxtsxsszj);
        void SaveDxtsxsszjs(List<Dxtsxsszj> dxtsxsszjs);
        void DeleteDxtsxsszj(Dxtsxsszj rec);
        void DeleteDxtsxsszj(long id);
        void DeleteDxtsxsszj(string filter);
        #endregion
        
        #region Dxtzjd方法
        Dxtzjd GetDxtzjd(long id);
        IEnumerable<Dxtzjd> GetDxtzjds(string filter);
        bool SaveDxtzjd(Dxtzjd dxtzjd);
        void SaveDxtzjds(List<Dxtzjd> dxtzjds);
        void DeleteDxtzjd(Dxtzjd rec);
        void DeleteDxtzjd(long id);
        void DeleteDxtzjd(string filter);
        #endregion
        
        #region Dxtzjm方法
        Dxtzjm GetDxtzjm(long id);
        IEnumerable<Dxtzjm> GetDxtzjms(string filter);
        bool SaveDxtzjm(Dxtzjm dxtzjm);
        void SaveDxtzjms(List<Dxtzjm> dxtzjms);
        void DeleteDxtzjm(Dxtzjm rec);
        void DeleteDxtzjm(long id);
        void DeleteDxtzjm(string filter);
        #endregion
        
        #region Dxtzjx方法
        Dxtzjx GetDxtzjx(long id);
        IEnumerable<Dxtzjx> GetDxtzjxes(string filter);
        bool SaveDxtzjx(Dxtzjx dxtzjx);
        void SaveDxtzjxes(List<Dxtzjx> dxtzjxes);
        void DeleteDxtzjx(Dxtzjx rec);
        void DeleteDxtzjx(long id);
        void DeleteDxtzjx(string filter);
        #endregion
        
        #region Dxtzjzj方法
        Dxtzjzj GetDxtzjzj(long id);
        IEnumerable<Dxtzjzj> GetDxtzjzjs(string filter);
        bool SaveDxtzjzj(Dxtzjzj dxtzjzj);
        void SaveDxtzjzjs(List<Dxtzjzj> dxtzjzjs);
        void DeleteDxtzjzj(Dxtzjzj rec);
        void DeleteDxtzjzj(long id);
        void DeleteDxtzjzj(string filter);
        #endregion
        
        
    }
}