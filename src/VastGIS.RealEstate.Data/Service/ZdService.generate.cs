using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service
{
    public partial interface ZdService:ISQLiteService
    {	
        #region C方法
        C GetC(long id);
        IEnumerable<C> GetCS(string filter);
        bool SaveC(C c);
        void SaveCS(List<C> cs);
        void DeleteC(C rec);
        void DeleteC(long id);
        void DeleteC(string filter);
        #endregion
        
        #region Cfdj方法
        Cfdj GetCfdj(long id);
        IEnumerable<Cfdj> GetCfdjs(string filter);
        bool SaveCfdj(Cfdj cfdj);
        void SaveCfdjs(List<Cfdj> cfdjs);
        void DeleteCfdj(Cfdj rec);
        void DeleteCfdj(long id);
        void DeleteCfdj(string filter);
        #endregion
        
        #region Djq方法
        Djq GetDjq(long id);
        IEnumerable<Djq> GetDjqs(string filter);
        bool SaveDjq(Djq djq);
        void SaveDjqs(List<Djq> djqs);
        void DeleteDjq(Djq rec);
        void DeleteDjq(long id);
        void DeleteDjq(string filter);
        #endregion
        
        #region Djzq方法
        Djzq GetDjzq(long id);
        IEnumerable<Djzq> GetDjzqs(string filter);
        bool SaveDjzq(Djzq djzq);
        void SaveDjzqs(List<Djzq> djzqs);
        void DeleteDjzq(Djzq rec);
        void DeleteDjzq(long id);
        void DeleteDjzq(string filter);
        #endregion
        
        #region Dyaq方法
        Dyaq GetDyaq(long id);
        IEnumerable<Dyaq> GetDyaqs(string filter);
        bool SaveDyaq(Dyaq dyaq);
        void SaveDyaqs(List<Dyaq> dyaqs);
        void DeleteDyaq(Dyaq rec);
        void DeleteDyaq(long id);
        void DeleteDyaq(string filter);
        #endregion
        
        #region Dyiq方法
        Dyiq GetDyiq(long id);
        IEnumerable<Dyiq> GetDyiqs(string filter);
        bool SaveDyiq(Dyiq dyiq);
        void SaveDyiqs(List<Dyiq> dyiqs);
        void DeleteDyiq(Dyiq rec);
        void DeleteDyiq(long id);
        void DeleteDyiq(string filter);
        #endregion
        
        #region Dzdzw方法
        Dzdzw GetDzdzw(long id);
        IEnumerable<Dzdzw> GetDzdzws(string filter);
        bool SaveDzdzw(Dzdzw dzdzw);
        void SaveDzdzws(List<Dzdzw> dzdzws);
        void DeleteDzdzw(Dzdzw rec);
        void DeleteDzdzw(long id);
        void DeleteDzdzw(string filter);
        #endregion
        
        #region Fdcq1方法
        Fdcq1 GetFdcq1(long id);
        IEnumerable<Fdcq1> GetFdcq1s(string filter);
        bool SaveFdcq1(Fdcq1 fdcq1);
        void SaveFdcq1s(List<Fdcq1> fdcq1s);
        void DeleteFdcq1(Fdcq1 rec);
        void DeleteFdcq1(long id);
        void DeleteFdcq1(string filter);
        #endregion
        
        #region Fdcq2方法
        Fdcq2 GetFdcq2(long id);
        IEnumerable<Fdcq2> GetFdcq2s(string filter);
        bool SaveFdcq2(Fdcq2 fdcq2);
        void SaveFdcq2s(List<Fdcq2> fdcq2s);
        void DeleteFdcq2(Fdcq2 rec);
        void DeleteFdcq2(long id);
        void DeleteFdcq2(string filter);
        #endregion
        
        #region Fdcq3方法
        Fdcq3 GetFdcq3(long id);
        IEnumerable<Fdcq3> GetFdcq3s(string filter);
        bool SaveFdcq3(Fdcq3 fdcq3);
        void SaveFdcq3s(List<Fdcq3> fdcq3s);
        void DeleteFdcq3(Fdcq3 rec);
        void DeleteFdcq3(long id);
        void DeleteFdcq3(string filter);
        #endregion
        
        #region Fdcqxm方法
        Fdcqxm GetFdcqxm(long id);
        IEnumerable<Fdcqxm> GetFdcqxms(string filter);
        bool SaveFdcqxm(Fdcqxm fdcqxm);
        void SaveFdcqxms(List<Fdcqxm> fdcqxms);
        void DeleteFdcqxm(Fdcqxm rec);
        void DeleteFdcqxm(long id);
        void DeleteFdcqxm(string filter);
        #endregion
        
        #region Fz方法
        Fz GetFz(long id);
        IEnumerable<Fz> GetFzs(string filter);
        bool SaveFz(Fz fz);
        void SaveFzs(List<Fz> fzs);
        void DeleteFz(Fz rec);
        void DeleteFz(long id);
        void DeleteFz(string filter);
        #endregion
        
        #region Gd方法
        Gd GetGd(long id);
        IEnumerable<Gd> GetGds(string filter);
        bool SaveGd(Gd gd);
        void SaveGds(List<Gd> gds);
        void DeleteGd(Gd rec);
        void DeleteGd(long id);
        void DeleteGd(string filter);
        #endregion
        
        #region Gjzwsyq方法
        Gjzwsyq GetGjzwsyq(long id);
        IEnumerable<Gjzwsyq> GetGjzwsyqs(string filter);
        bool SaveGjzwsyq(Gjzwsyq gjzwsyq);
        void SaveGjzwsyqs(List<Gjzwsyq> gjzwsyqs);
        void DeleteGjzwsyq(Gjzwsyq rec);
        void DeleteGjzwsyq(long id);
        void DeleteGjzwsyq(string filter);
        #endregion
        
        #region Gzw方法
        Gzw GetGzw(long id);
        IEnumerable<Gzw> GetGzws(string filter);
        bool SaveGzw(Gzw gzw);
        void SaveGzws(List<Gzw> gzws);
        void DeleteGzw(Gzw rec);
        void DeleteGzw(long id);
        void DeleteGzw(string filter);
        #endregion
        
        #region H方法
        H GetH(long id);
        IEnumerable<H> GetHS(string filter);
        bool SaveH(H h);
        void SaveHS(List<H> hs);
        void DeleteH(H rec);
        void DeleteH(long id);
        void DeleteH(string filter);
        #endregion
        
        #region Hysyq方法
        Hysyq GetHysyq(long id);
        IEnumerable<Hysyq> GetHysyqs(string filter);
        bool SaveHysyq(Hysyq hysyq);
        void SaveHysyqs(List<Hysyq> hysyqs);
        void DeleteHysyq(Hysyq rec);
        void DeleteHysyq(long id);
        void DeleteHysyq(string filter);
        #endregion
        
        #region Jsydsyq方法
        Jsydsyq GetJsydsyq(long id);
        IEnumerable<Jsydsyq> GetJsydsyqs(string filter);
        bool SaveJsydsyq(Jsydsyq jsydsyq);
        void SaveJsydsyqs(List<Jsydsyq> jsydsyqs);
        void DeleteJsydsyq(Jsydsyq rec);
        void DeleteJsydsyq(long id);
        void DeleteJsydsyq(string filter);
        #endregion
        
        #region Jzd方法
        Jzd GetJzd(long id);
        IEnumerable<Jzd> GetJzds(string filter);
        bool SaveJzd(Jzd jzd);
        void SaveJzds(List<Jzd> jzds);
        void DeleteJzd(Jzd rec);
        void DeleteJzd(long id);
        void DeleteJzd(string filter);
        #endregion
        
        #region Jzdzj方法
        Jzdzj GetJzdzj(long id);
        IEnumerable<Jzdzj> GetJzdzjs(string filter);
        bool SaveJzdzj(Jzdzj jzdzj);
        void SaveJzdzjs(List<Jzdzj> jzdzjs);
        void DeleteJzdzj(Jzdzj rec);
        void DeleteJzdzj(long id);
        void DeleteJzdzj(string filter);
        #endregion
        
        #region Jzx方法
        Jzx GetJzx(long id);
        IEnumerable<Jzx> GetJzxes(string filter);
        bool SaveJzx(Jzx jzx);
        void SaveJzxes(List<Jzx> jzxes);
        void DeleteJzx(Jzx rec);
        void DeleteJzx(long id);
        void DeleteJzx(string filter);
        #endregion
        
        #region Jzxzj方法
        Jzxzj GetJzxzj(long id);
        IEnumerable<Jzxzj> GetJzxzjs(string filter);
        bool SaveJzxzj(Jzxzj jzxzj);
        void SaveJzxzjs(List<Jzxzj> jzxzjs);
        void DeleteJzxzj(Jzxzj rec);
        void DeleteJzxzj(long id);
        void DeleteJzxzj(string filter);
        #endregion
        
        #region Ljz方法
        Ljz GetLjz(long id);
        IEnumerable<Ljz> GetLjzs(string filter);
        bool SaveLjz(Ljz ljz);
        void SaveLjzs(List<Ljz> ljzs);
        void DeleteLjz(Ljz rec);
        void DeleteLjz(long id);
        void DeleteLjz(string filter);
        #endregion
        
        #region Lq方法
        Lq GetLq(long id);
        IEnumerable<Lq> GetLqs(string filter);
        bool SaveLq(Lq lq);
        void SaveLqs(List<Lq> lqs);
        void DeleteLq(Lq rec);
        void DeleteLq(long id);
        void DeleteLq(string filter);
        #endregion
        
        #region Mzdzw方法
        Mzdzw GetMzdzw(long id);
        IEnumerable<Mzdzw> GetMzdzws(string filter);
        bool SaveMzdzw(Mzdzw mzdzw);
        void SaveMzdzws(List<Mzdzw> mzdzws);
        void DeleteMzdzw(Mzdzw rec);
        void DeleteMzdzw(long id);
        void DeleteMzdzw(string filter);
        #endregion
        
        #region Nydsyq方法
        Nydsyq GetNydsyq(long id);
        IEnumerable<Nydsyq> GetNydsyqs(string filter);
        bool SaveNydsyq(Nydsyq nydsyq);
        void SaveNydsyqs(List<Nydsyq> nydsyqs);
        void DeleteNydsyq(Nydsyq rec);
        void DeleteNydsyq(long id);
        void DeleteNydsyq(string filter);
        #endregion
        
        #region Qlr方法
        Qlr GetQlr(long id);
        IEnumerable<Qlr> GetQlrs(string filter);
        bool SaveQlr(Qlr qlr);
        void SaveQlrs(List<Qlr> qlrs);
        void DeleteQlr(Qlr rec);
        void DeleteQlr(long id);
        void DeleteQlr(string filter);
        #endregion
        
        #region Qtxgql方法
        Qtxgql GetQtxgql(long id);
        IEnumerable<Qtxgql> GetQtxgqls(string filter);
        bool SaveQtxgql(Qtxgql qtxgql);
        void SaveQtxgqls(List<Qtxgql> qtxgqls);
        void DeleteQtxgql(Qtxgql rec);
        void DeleteQtxgql(long id);
        void DeleteQtxgql(string filter);
        #endregion
        
        #region Qxzd方法
        Qxzd GetQxzd(long id);
        IEnumerable<Qxzd> GetQxzds(string filter);
        bool SaveQxzd(Qxzd qxzd);
        void SaveQxzds(List<Qxzd> qxzds);
        void DeleteQxzd(Qxzd rec);
        void DeleteQxzd(long id);
        void DeleteQxzd(string filter);
        #endregion
        
        #region R方法
        R GetR(long id);
        IEnumerable<R> GetRS(string filter);
        bool SaveR(R r);
        void SaveRS(List<R> rs);
        void DeleteR(R rec);
        void DeleteR(long id);
        void DeleteR(string filter);
        #endregion
        
        #region Sf方法
        Sf GetSf(long id);
        IEnumerable<Sf> GetSfs(string filter);
        bool SaveSf(Sf sf);
        void SaveSfs(List<Sf> sfs);
        void DeleteSf(Sf rec);
        void DeleteSf(long id);
        void DeleteSf(string filter);
        #endregion
        
        #region Sgsj方法
        Sgsj GetSgsj(long id);
        IEnumerable<Sgsj> GetSgsjs(string filter);
        bool SaveSgsj(Sgsj sgsj);
        void SaveSgsjs(List<Sgsj> sgsjs);
        void DeleteSgsj(Sgsj rec);
        void DeleteSgsj(long id);
        void DeleteSgsj(string filter);
        #endregion
        
        #region Sh方法
        Sh GetSh(long id);
        IEnumerable<Sh> GetShes(string filter);
        bool SaveSh(Sh sh);
        void SaveShes(List<Sh> shes);
        void DeleteSh(Sh rec);
        void DeleteSh(long id);
        void DeleteSh(string filter);
        #endregion
        
        #region Sj方法
        Sj GetSj(long id);
        IEnumerable<Sj> GetSjs(string filter);
        bool SaveSj(Sj sj);
        void SaveSjs(List<Sj> sjs);
        void DeleteSj(Sj rec);
        void DeleteSj(long id);
        void DeleteSj(string filter);
        #endregion
        
        #region Slsq方法
        Slsq GetSlsq(long id);
        IEnumerable<Slsq> GetSlsqs(string filter);
        bool SaveSlsq(Slsq slsq);
        void SaveSlsqs(List<Slsq> slsqs);
        void DeleteSlsq(Slsq rec);
        void DeleteSlsq(long id);
        void DeleteSlsq(string filter);
        #endregion
        
        #region Sqr方法
        Sqr GetSqr(long id);
        IEnumerable<Sqr> GetSqrs(string filter);
        bool SaveSqr(Sqr sqr);
        void SaveSqrs(List<Sqr> sqrs);
        void DeleteSqr(Sqr rec);
        void DeleteSqr(long id);
        void DeleteSqr(string filter);
        #endregion
        
        #region Sz方法
        Sz GetSz(long id);
        IEnumerable<Sz> GetSzs(string filter);
        bool SaveSz(Sz sz);
        void SaveSzs(List<Sz> szs);
        void DeleteSz(Sz rec);
        void DeleteSz(long id);
        void DeleteSz(string filter);
        #endregion
        
        #region Tdsyq方法
        Tdsyq GetTdsyq(long id);
        IEnumerable<Tdsyq> GetTdsyqs(string filter);
        bool SaveTdsyq(Tdsyq tdsyq);
        void SaveTdsyqs(List<Tdsyq> tdsyqs);
        void DeleteTdsyq(Tdsyq rec);
        void DeleteTdsyq(long id);
        void DeleteTdsyq(string filter);
        #endregion
        
        #region Xzdzw方法
        Xzdzw GetXzdzw(long id);
        IEnumerable<Xzdzw> GetXzdzws(string filter);
        bool SaveXzdzw(Xzdzw xzdzw);
        void SaveXzdzws(List<Xzdzw> xzdzws);
        void DeleteXzdzw(Xzdzw rec);
        void DeleteXzdzw(long id);
        void DeleteXzdzw(string filter);
        #endregion
        
        #region Xzq方法
        Xzq GetXzq(long id);
        IEnumerable<Xzq> GetXzqs(string filter);
        bool SaveXzq(Xzq xzq);
        void SaveXzqs(List<Xzq> xzqs);
        void DeleteXzq(Xzq rec);
        void DeleteXzq(long id);
        void DeleteXzq(string filter);
        #endregion
        
        #region Xzqjx方法
        Xzqjx GetXzqjx(long id);
        IEnumerable<Xzqjx> GetXzqjxes(string filter);
        bool SaveXzqjx(Xzqjx xzqjx);
        void SaveXzqjxes(List<Xzqjx> xzqjxes);
        void DeleteXzqjx(Xzqjx rec);
        void DeleteXzqjx(long id);
        void DeleteXzqjx(string filter);
        #endregion
        
        #region Xzqzj方法
        Xzqzj GetXzqzj(long id);
        IEnumerable<Xzqzj> GetXzqzjs(string filter);
        bool SaveXzqzj(Xzqzj xzqzj);
        void SaveXzqzjs(List<Xzqzj> xzqzjs);
        void DeleteXzqzj(Xzqzj rec);
        void DeleteXzqzj(long id);
        void DeleteXzqzj(string filter);
        #endregion
        
        #region Ygdj方法
        Ygdj GetYgdj(long id);
        IEnumerable<Ygdj> GetYgdjs(string filter);
        bool SaveYgdj(Ygdj ygdj);
        void SaveYgdjs(List<Ygdj> ygdjs);
        void DeleteYgdj(Ygdj rec);
        void DeleteYgdj(long id);
        void DeleteYgdj(string filter);
        #endregion
        
        #region Yhydzb方法
        Yhydzb GetYhydzb(long id);
        IEnumerable<Yhydzb> GetYhydzbs(string filter);
        bool SaveYhydzb(Yhydzb yhydzb);
        void SaveYhydzbs(List<Yhydzb> yhydzbs);
        void DeleteYhydzb(Yhydzb rec);
        void DeleteYhydzb(long id);
        void DeleteYhydzb(string filter);
        #endregion
        
        #region Yhzk方法
        Yhzk GetYhzk(long id);
        IEnumerable<Yhzk> GetYhzks(string filter);
        bool SaveYhzk(Yhzk yhzk);
        void SaveYhzks(List<Yhzk> yhzks);
        void DeleteYhzk(Yhzk rec);
        void DeleteYhzk(long id);
        void DeleteYhzk(string filter);
        #endregion
        
        #region Yydj方法
        Yydj GetYydj(long id);
        IEnumerable<Yydj> GetYydjs(string filter);
        bool SaveYydj(Yydj yydj);
        void SaveYydjs(List<Yydj> yydjs);
        void DeleteYydj(Yydj rec);
        void DeleteYydj(long id);
        void DeleteYydj(string filter);
        #endregion
        
        #region Zdbhqk方法
        Zdbhqk GetZdbhqk(long id);
        IEnumerable<Zdbhqk> GetZdbhqks(string filter);
        bool SaveZdbhqk(Zdbhqk zdbhqk);
        void SaveZdbhqks(List<Zdbhqk> zdbhqks);
        void DeleteZdbhqk(Zdbhqk rec);
        void DeleteZdbhqk(long id);
        void DeleteZdbhqk(string filter);
        #endregion
        
        #region Zdjbxx方法
        Zdjbxx GetZdjbxx(long id);
        IEnumerable<Zdjbxx> GetZdjbxxes(string filter);
        bool SaveZdjbxx(Zdjbxx zdjbxx);
        void SaveZdjbxxes(List<Zdjbxx> zdjbxxes);
        void DeleteZdjbxx(Zdjbxx rec);
        void DeleteZdjbxx(long id);
        void DeleteZdjbxx(string filter);
        #endregion
        
        #region Zdjbxxzj方法
        Zdjbxxzj GetZdjbxxzj(long id);
        IEnumerable<Zdjbxxzj> GetZdjbxxzjs(string filter);
        bool SaveZdjbxxzj(Zdjbxxzj zdjbxxzj);
        void SaveZdjbxxzjs(List<Zdjbxxzj> zdjbxxzjs);
        void DeleteZdjbxxzj(Zdjbxxzj rec);
        void DeleteZdjbxxzj(long id);
        void DeleteZdjbxxzj(string filter);
        #endregion
        
        #region Zdtojzd方法
        Zdtojzd GetZdtojzd(long id);
        IEnumerable<Zdtojzd> GetZdtojzds(string filter);
        bool SaveZdtojzd(Zdtojzd zdtojzd);
        void SaveZdtojzds(List<Zdtojzd> zdtojzds);
        void DeleteZdtojzd(Zdtojzd rec);
        void DeleteZdtojzd(long id);
        void DeleteZdtojzd(string filter);
        #endregion
        
        #region Zdtojzx方法
        Zdtojzx GetZdtojzx(long id);
        IEnumerable<Zdtojzx> GetZdtojzxes(string filter);
        bool SaveZdtojzx(Zdtojzx zdtojzx);
        void SaveZdtojzxes(List<Zdtojzx> zdtojzxes);
        void DeleteZdtojzx(Zdtojzx rec);
        void DeleteZdtojzx(long id);
        void DeleteZdtojzx(string filter);
        #endregion
        
        #region Zhbhqk方法
        Zhbhqk GetZhbhqk(long id);
        IEnumerable<Zhbhqk> GetZhbhqks(string filter);
        bool SaveZhbhqk(Zhbhqk zhbhqk);
        void SaveZhbhqks(List<Zhbhqk> zhbhqks);
        void DeleteZhbhqk(Zhbhqk rec);
        void DeleteZhbhqk(long id);
        void DeleteZhbhqk(string filter);
        #endregion
        
        #region Zhjbxx方法
        Zhjbxx GetZhjbxx(long id);
        IEnumerable<Zhjbxx> GetZhjbxxes(string filter);
        bool SaveZhjbxx(Zhjbxx zhjbxx);
        void SaveZhjbxxes(List<Zhjbxx> zhjbxxes);
        void DeleteZhjbxx(Zhjbxx rec);
        void DeleteZhjbxx(long id);
        void DeleteZhjbxx(string filter);
        #endregion
        
        #region Zj方法
        Zj GetZj(long id);
        IEnumerable<Zj> GetZjs(string filter);
        bool SaveZj(Zj zj);
        void SaveZjs(List<Zj> zjs);
        void DeleteZj(Zj rec);
        void DeleteZj(long id);
        void DeleteZj(string filter);
        #endregion
        
        #region Zrz方法
        Zrz GetZrz(long id);
        IEnumerable<Zrz> GetZrzs(string filter);
        bool SaveZrz(Zrz zrz);
        void SaveZrzs(List<Zrz> zrzs);
        void DeleteZrz(Zrz rec);
        void DeleteZrz(long id);
        void DeleteZrz(string filter);
        #endregion
        
        
    }
}