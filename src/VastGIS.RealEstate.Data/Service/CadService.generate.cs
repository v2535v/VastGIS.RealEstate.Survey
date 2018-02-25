using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service
{
    public partial interface CadService:ISQLiteService
    {	
        #region TmpCadd方法
        TmpCadd GetTmpCadd(long id);
        IEnumerable<TmpCadd> GetTmpCadds(string filter);
        bool SaveTmpCadd(TmpCadd tmpcadd);
        void SaveTmpCadds(List<TmpCadd> tmpCadds);
        void DeleteTmpCadd(TmpCadd rec);
        void DeleteTmpCadd(long id);
        void DeleteTmpCadd(string filter);
        #endregion
        
        #region TmpCadm方法
        TmpCadm GetTmpCadm(long id);
        IEnumerable<TmpCadm> GetTmpCadms(string filter);
        bool SaveTmpCadm(TmpCadm tmpcadm);
        void SaveTmpCadms(List<TmpCadm> tmpCadms);
        void DeleteTmpCadm(TmpCadm rec);
        void DeleteTmpCadm(long id);
        void DeleteTmpCadm(string filter);
        #endregion
        
        #region TmpCadx方法
        TmpCadx GetTmpCadx(long id);
        IEnumerable<TmpCadx> GetTmpCadxes(string filter);
        bool SaveTmpCadx(TmpCadx tmpcadx);
        void SaveTmpCadxes(List<TmpCadx> tmpCadxes);
        void DeleteTmpCadx(TmpCadx rec);
        void DeleteTmpCadx(long id);
        void DeleteTmpCadx(string filter);
        #endregion
        
        #region TmpCadxdata方法
        TmpCadxdata GetTmpCadxdata(long id);
        IEnumerable<TmpCadxdata> GetTmpCadxdatas(string filter);
        bool SaveTmpCadxdata(TmpCadxdata tmpcadxdatum);
        void SaveTmpCadxdatas(List<TmpCadxdata> tmpCadxdatas);
        void DeleteTmpCadxdata(TmpCadxdata rec);
        void DeleteTmpCadxdata(long id);
        void DeleteTmpCadxdata(string filter);
        #endregion
        
        #region TmpCadzj方法
        TmpCadzj GetTmpCadzj(long id);
        IEnumerable<TmpCadzj> GetTmpCadzjs(string filter);
        bool SaveTmpCadzj(TmpCadzj tmpcadzj);
        void SaveTmpCadzjs(List<TmpCadzj> tmpCadzjs);
        void DeleteTmpCadzj(TmpCadzj rec);
        void DeleteTmpCadzj(long id);
        void DeleteTmpCadzj(string filter);
        #endregion
        
        
    }
}