using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service
{

    public partial interface BasemapService:IEntityChanged
    {
              
        ///Dxtqtd函数
        Dxtqtd GetDxtqtd(long id);
        IEnumerable<Dxtqtd> GetDxtqtds(string filter);
        bool SaveDxtqtd(Dxtqtd dxtqtd);
        void SaveDxtqtds(List<Dxtqtd> dxtqtds);
        void DeleteDxtqtd(long id);
        void DeleteDxtqtd(string filter);
            
            
        ///Dxtqtx函数
        Dxtqtx GetDxtqtx(long id);
        IEnumerable<Dxtqtx> GetDxtqtxs(string filter);
        bool SaveDxtqtx(Dxtqtx dxtqtx);
        void SaveDxtqtxs(List<Dxtqtx> dxtqtxs);
        void DeleteDxtqtx(long id);
        void DeleteDxtqtx(string filter);
            
            
        ///Dxtqtm函数
        Dxtqtm GetDxtqtm(long id);
        IEnumerable<Dxtqtm> GetDxtqtms(string filter);
        bool SaveDxtqtm(Dxtqtm dxtqtm);
        void SaveDxtqtms(List<Dxtqtm> dxtqtms);
        void DeleteDxtqtm(long id);
        void DeleteDxtqtm(string filter);
            
            
        ///Dxtqtzj函数
        Dxtqtzj GetDxtqtzj(long id);
        IEnumerable<Dxtqtzj> GetDxtqtzjs(string filter);
        bool SaveDxtqtzj(Dxtqtzj dxtqtzj);
        void SaveDxtqtzjs(List<Dxtqtzj> dxtqtzjs);
        void DeleteDxtqtzj(long id);
        void DeleteDxtqtzj(string filter);
            
            
        ///Dxtzjd函数
        Dxtzjd GetDxtzjd(long id);
        IEnumerable<Dxtzjd> GetDxtzjds(string filter);
        bool SaveDxtzjd(Dxtzjd dxtzjd);
        void SaveDxtzjds(List<Dxtzjd> dxtzjds);
        void DeleteDxtzjd(long id);
        void DeleteDxtzjd(string filter);
            
            
        ///Dxtzjx函数
        Dxtzjx GetDxtzjx(long id);
        IEnumerable<Dxtzjx> GetDxtzjxs(string filter);
        bool SaveDxtzjx(Dxtzjx dxtzjx);
        void SaveDxtzjxs(List<Dxtzjx> dxtzjxs);
        void DeleteDxtzjx(long id);
        void DeleteDxtzjx(string filter);
            
            
        ///Dxtzjm函数
        Dxtzjm GetDxtzjm(long id);
        IEnumerable<Dxtzjm> GetDxtzjms(string filter);
        bool SaveDxtzjm(Dxtzjm dxtzjm);
        void SaveDxtzjms(List<Dxtzjm> dxtzjms);
        void DeleteDxtzjm(long id);
        void DeleteDxtzjm(string filter);
            
            
        ///Dxtzjzj函数
        Dxtzjzj GetDxtzjzj(long id);
        IEnumerable<Dxtzjzj> GetDxtzjzjs(string filter);
        bool SaveDxtzjzj(Dxtzjzj dxtzjzj);
        void SaveDxtzjzjs(List<Dxtzjzj> dxtzjzjs);
        void DeleteDxtzjzj(long id);
        void DeleteDxtzjzj(string filter);
            
            
        ///Dxtdmtzd函数
        Dxtdmtzd GetDxtdmtzd(long id);
        IEnumerable<Dxtdmtzd> GetDxtdmtzds(string filter);
        bool SaveDxtdmtzd(Dxtdmtzd dxtdmtzd);
        void SaveDxtdmtzds(List<Dxtdmtzd> dxtdmtzds);
        void DeleteDxtdmtzd(long id);
        void DeleteDxtdmtzd(string filter);
            
            
        ///Dxtdmtzx函数
        Dxtdmtzx GetDxtdmtzx(long id);
        IEnumerable<Dxtdmtzx> GetDxtdmtzxs(string filter);
        bool SaveDxtdmtzx(Dxtdmtzx dxtdmtzx);
        void SaveDxtdmtzxs(List<Dxtdmtzx> dxtdmtzxs);
        void DeleteDxtdmtzx(long id);
        void DeleteDxtdmtzx(string filter);
            
            
        ///Dxtdmtzm函数
        Dxtdmtzm GetDxtdmtzm(long id);
        IEnumerable<Dxtdmtzm> GetDxtdmtzms(string filter);
        bool SaveDxtdmtzm(Dxtdmtzm dxtdmtzm);
        void SaveDxtdmtzms(List<Dxtdmtzm> dxtdmtzms);
        void DeleteDxtdmtzm(long id);
        void DeleteDxtdmtzm(string filter);
            
            
        ///Dxtdmtzzj函数
        Dxtdmtzzj GetDxtdmtzzj(long id);
        IEnumerable<Dxtdmtzzj> GetDxtdmtzzjs(string filter);
        bool SaveDxtdmtzzj(Dxtdmtzzj dxtdmtzzj);
        void SaveDxtdmtzzjs(List<Dxtdmtzzj> dxtdmtzzjs);
        void DeleteDxtdmtzzj(long id);
        void DeleteDxtdmtzzj(string filter);
            
            
        ///Dxtsxssd函数
        Dxtsxssd GetDxtsxssd(long id);
        IEnumerable<Dxtsxssd> GetDxtsxssds(string filter);
        bool SaveDxtsxssd(Dxtsxssd dxtsxssd);
        void SaveDxtsxssds(List<Dxtsxssd> dxtsxssds);
        void DeleteDxtsxssd(long id);
        void DeleteDxtsxssd(string filter);
            
            
        ///Dxtsxssx函数
        Dxtsxssx GetDxtsxssx(long id);
        IEnumerable<Dxtsxssx> GetDxtsxssxs(string filter);
        bool SaveDxtsxssx(Dxtsxssx dxtsxssx);
        void SaveDxtsxssxs(List<Dxtsxssx> dxtsxssxs);
        void DeleteDxtsxssx(long id);
        void DeleteDxtsxssx(string filter);
            
            
        ///Dxtsxssm函数
        Dxtsxssm GetDxtsxssm(long id);
        IEnumerable<Dxtsxssm> GetDxtsxssms(string filter);
        bool SaveDxtsxssm(Dxtsxssm dxtsxssm);
        void SaveDxtsxssms(List<Dxtsxssm> dxtsxssms);
        void DeleteDxtsxssm(long id);
        void DeleteDxtsxssm(string filter);
            
            
        ///Dxtsxsszj函数
        Dxtsxsszj GetDxtsxsszj(long id);
        IEnumerable<Dxtsxsszj> GetDxtsxsszjs(string filter);
        bool SaveDxtsxsszj(Dxtsxsszj dxtsxsszj);
        void SaveDxtsxsszjs(List<Dxtsxsszj> dxtsxsszjs);
        void DeleteDxtsxsszj(long id);
        void DeleteDxtsxsszj(string filter);
            
            
        ///Dxtdldwd函数
        Dxtdldwd GetDxtdldwd(long id);
        IEnumerable<Dxtdldwd> GetDxtdldwds(string filter);
        bool SaveDxtdldwd(Dxtdldwd dxtdldwd);
        void SaveDxtdldwds(List<Dxtdldwd> dxtdldwds);
        void DeleteDxtdldwd(long id);
        void DeleteDxtdldwd(string filter);
            
            
        ///Dxtdldwx函数
        Dxtdldwx GetDxtdldwx(long id);
        IEnumerable<Dxtdldwx> GetDxtdldwxs(string filter);
        bool SaveDxtdldwx(Dxtdldwx dxtdldwx);
        void SaveDxtdldwxs(List<Dxtdldwx> dxtdldwxs);
        void DeleteDxtdldwx(long id);
        void DeleteDxtdldwx(string filter);
            
            
        ///Dxtdldwm函数
        Dxtdldwm GetDxtdldwm(long id);
        IEnumerable<Dxtdldwm> GetDxtdldwms(string filter);
        bool SaveDxtdldwm(Dxtdldwm dxtdldwm);
        void SaveDxtdldwms(List<Dxtdldwm> dxtdldwms);
        void DeleteDxtdldwm(long id);
        void DeleteDxtdldwm(string filter);
            
            
        ///Dxtdldwzj函数
        Dxtdldwzj GetDxtdldwzj(long id);
        IEnumerable<Dxtdldwzj> GetDxtdldwzjs(string filter);
        bool SaveDxtdldwzj(Dxtdldwzj dxtdldwzj);
        void SaveDxtdldwzjs(List<Dxtdldwzj> dxtdldwzjs);
        void DeleteDxtdldwzj(long id);
        void DeleteDxtdldwzj(string filter);
            
            
        ///Dxtdlssd函数
        Dxtdlssd GetDxtdlssd(long id);
        IEnumerable<Dxtdlssd> GetDxtdlssds(string filter);
        bool SaveDxtdlssd(Dxtdlssd dxtdlssd);
        void SaveDxtdlssds(List<Dxtdlssd> dxtdlssds);
        void DeleteDxtdlssd(long id);
        void DeleteDxtdlssd(string filter);
            
            
        ///Dxtdlssx函数
        Dxtdlssx GetDxtdlssx(long id);
        IEnumerable<Dxtdlssx> GetDxtdlssxs(string filter);
        bool SaveDxtdlssx(Dxtdlssx dxtdlssx);
        void SaveDxtdlssxs(List<Dxtdlssx> dxtdlssxs);
        void DeleteDxtdlssx(long id);
        void DeleteDxtdlssx(string filter);
            
            
        ///Dxtdlssm函数
        Dxtdlssm GetDxtdlssm(long id);
        IEnumerable<Dxtdlssm> GetDxtdlssms(string filter);
        bool SaveDxtdlssm(Dxtdlssm dxtdlssm);
        void SaveDxtdlssms(List<Dxtdlssm> dxtdlssms);
        void DeleteDxtdlssm(long id);
        void DeleteDxtdlssm(string filter);
            
            
        ///Dxtdlsszj函数
        Dxtdlsszj GetDxtdlsszj(long id);
        IEnumerable<Dxtdlsszj> GetDxtdlsszjs(string filter);
        bool SaveDxtdlsszj(Dxtdlsszj dxtdlsszj);
        void SaveDxtdlsszjs(List<Dxtdlsszj> dxtdlsszjs);
        void DeleteDxtdlsszj(long id);
        void DeleteDxtdlsszj(string filter);
            
            
        ///Dxtjmdd函数
        Dxtjmdd GetDxtjmdd(long id);
        IEnumerable<Dxtjmdd> GetDxtjmdds(string filter);
        bool SaveDxtjmdd(Dxtjmdd dxtjmdd);
        void SaveDxtjmdds(List<Dxtjmdd> dxtjmdds);
        void DeleteDxtjmdd(long id);
        void DeleteDxtjmdd(string filter);
            
            
        ///Dxtjmdx函数
        Dxtjmdx GetDxtjmdx(long id);
        IEnumerable<Dxtjmdx> GetDxtjmdxs(string filter);
        bool SaveDxtjmdx(Dxtjmdx dxtjmdx);
        void SaveDxtjmdxs(List<Dxtjmdx> dxtjmdxs);
        void DeleteDxtjmdx(long id);
        void DeleteDxtjmdx(string filter);
            
            
        ///Dxtjmdm函数
        Dxtjmdm GetDxtjmdm(long id);
        IEnumerable<Dxtjmdm> GetDxtjmdms(string filter);
        bool SaveDxtjmdm(Dxtjmdm dxtjmdm);
        void SaveDxtjmdms(List<Dxtjmdm> dxtjmdms);
        void DeleteDxtjmdm(long id);
        void DeleteDxtjmdm(string filter);
            
            
        ///Dxtjmdzj函数
        Dxtjmdzj GetDxtjmdzj(long id);
        IEnumerable<Dxtjmdzj> GetDxtjmdzjs(string filter);
        bool SaveDxtjmdzj(Dxtjmdzj dxtjmdzj);
        void SaveDxtjmdzjs(List<Dxtjmdzj> dxtjmdzjs);
        void DeleteDxtjmdzj(long id);
        void DeleteDxtjmdzj(string filter);
            
            
        ///Dxtkzdd函数
        Dxtkzdd GetDxtkzdd(long id);
        IEnumerable<Dxtkzdd> GetDxtkzdds(string filter);
        bool SaveDxtkzdd(Dxtkzdd dxtkzdd);
        void SaveDxtkzdds(List<Dxtkzdd> dxtkzdds);
        void DeleteDxtkzdd(long id);
        void DeleteDxtkzdd(string filter);
            
            
        ///Dxtkzdx函数
        Dxtkzdx GetDxtkzdx(long id);
        IEnumerable<Dxtkzdx> GetDxtkzdxs(string filter);
        bool SaveDxtkzdx(Dxtkzdx dxtkzdx);
        void SaveDxtkzdxs(List<Dxtkzdx> dxtkzdxs);
        void DeleteDxtkzdx(long id);
        void DeleteDxtkzdx(string filter);
            
            
        ///Dxtkzdm函数
        Dxtkzdm GetDxtkzdm(long id);
        IEnumerable<Dxtkzdm> GetDxtkzdms(string filter);
        bool SaveDxtkzdm(Dxtkzdm dxtkzdm);
        void SaveDxtkzdms(List<Dxtkzdm> dxtkzdms);
        void DeleteDxtkzdm(long id);
        void DeleteDxtkzdm(string filter);
            
            
        ///Dxtkzdzj函数
        Dxtkzdzj GetDxtkzdzj(long id);
        IEnumerable<Dxtkzdzj> GetDxtkzdzjs(string filter);
        bool SaveDxtkzdzj(Dxtkzdzj dxtkzdzj);
        void SaveDxtkzdzjs(List<Dxtkzdzj> dxtkzdzjs);
        void DeleteDxtkzdzj(long id);
        void DeleteDxtkzdzj(string filter);
            
            
        
    }

}



