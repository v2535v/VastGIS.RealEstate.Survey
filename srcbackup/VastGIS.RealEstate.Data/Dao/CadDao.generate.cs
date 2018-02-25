using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Dao
{

    public partial interface CadDao:IEntityChanged
    {
        string GetLayerName(string tableName);
        ///TmpCadd函数
        TmpCadd GetTmpCadd(long id);
        IEnumerable<TmpCadd> GetTmpCadds(string filter);
        bool SaveTmpCadd(TmpCadd tmpcadd);
        void SaveTmpCadds(List<TmpCadd> tmpCadds);
        void DeleteTmpCadd(long id);
        void DeleteTmpCadd(string filter);
            
        ///TmpCadm函数
        TmpCadm GetTmpCadm(long id);
        IEnumerable<TmpCadm> GetTmpCadms(string filter);
        bool SaveTmpCadm(TmpCadm tmpcadm);
        void SaveTmpCadms(List<TmpCadm> tmpCadms);
        void DeleteTmpCadm(long id);
        void DeleteTmpCadm(string filter);
            
        ///TmpCadx函数
        TmpCadx GetTmpCadx(long id);
        IEnumerable<TmpCadx> GetTmpCadxes(string filter);
        bool SaveTmpCadx(TmpCadx tmpcadx);
        void SaveTmpCadxes(List<TmpCadx> tmpCadxes);
        void DeleteTmpCadx(long id);
        void DeleteTmpCadx(string filter);
            
        ///TmpCadzj函数
        TmpCadzj GetTmpCadzj(long id);
        IEnumerable<TmpCadzj> GetTmpCadzjs(string filter);
        bool SaveTmpCadzj(TmpCadzj tmpcadzj);
        void SaveTmpCadzjs(List<TmpCadzj> tmpCadzjs);
        void DeleteTmpCadzj(long id);
        void DeleteTmpCadzj(string filter);
            
        ///TmpCadxdata函数
        TmpCadxdata GetTmpCadxdata(long id);
        IEnumerable<TmpCadxdata> GetTmpCadxdatas(string filter);
        bool SaveTmpCadxdata(TmpCadxdata tmpcadxdatum);
        void SaveTmpCadxdatas(List<TmpCadxdata> tmpCadxdatas);
        void DeleteTmpCadxdata(long id);
        void DeleteTmpCadxdata(string filter);
            
    }

}

