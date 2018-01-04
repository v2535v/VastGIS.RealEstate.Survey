using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.RealEstate.Data.Service
{

    public partial interface ZdService
    {
       
            ///Djq函数
            Djq GetDjq(long id);
            IEnumerable<Djq> GetDjqs(string filter);
            bool SaveDjq(Djq djq);
            void SaveDjqs(List<Djq> djqs);
            void DeleteDjq(long id);
            void DeleteDjq(string filter);
            
            
            ///Djzq函数
            Djzq GetDjzq(long id);
            IEnumerable<Djzq> GetDjzqs(string filter);
            bool SaveDjzq(Djzq djzq);
            void SaveDjzqs(List<Djzq> djzqs);
            void DeleteDjzq(long id);
            void DeleteDjzq(string filter);
            
            
            ///Jzd函数
            Jzd GetJzd(long id);
            IEnumerable<Jzd> GetJzds(string filter);
            bool SaveJzd(Jzd jzd);
            void SaveJzds(List<Jzd> jzds);
            void DeleteJzd(long id);
            void DeleteJzd(string filter);
            
            
            ///Jzdzj函数
            Jzdzj GetJzdzj(long id);
            IEnumerable<Jzdzj> GetJzdzjs(string filter);
            bool SaveJzdzj(Jzdzj jzdzj);
            void SaveJzdzjs(List<Jzdzj> jzdzjs);
            void DeleteJzdzj(long id);
            void DeleteJzdzj(string filter);
            
            
            ///Jzx函数
            Jzx GetJzx(long id);
            IEnumerable<Jzx> GetJzxs(string filter);
            bool SaveJzx(Jzx jzx);
            void SaveJzxs(List<Jzx> jzxs);
            void DeleteJzx(long id);
            void DeleteJzx(string filter);
            
            
            ///Jzxzj函数
            Jzxzj GetJzxzj(long id);
            IEnumerable<Jzxzj> GetJzxzjs(string filter);
            bool SaveJzxzj(Jzxzj jzxzj);
            void SaveJzxzjs(List<Jzxzj> jzxzjs);
            void DeleteJzxzj(long id);
            void DeleteJzxzj(string filter);
            
            
            ///Xzq函数
            Xzq GetXzq(long id);
            IEnumerable<Xzq> GetXzqs(string filter);
            bool SaveXzq(Xzq xzq);
            void SaveXzqs(List<Xzq> xzqs);
            void DeleteXzq(long id);
            void DeleteXzq(string filter);
            
            
            ///Xzqjx函数
            Xzqjx GetXzqjx(long id);
            IEnumerable<Xzqjx> GetXzqjxs(string filter);
            bool SaveXzqjx(Xzqjx xzqjx);
            void SaveXzqjxs(List<Xzqjx> xzqjxs);
            void DeleteXzqjx(long id);
            void DeleteXzqjx(string filter);
            
            
            ///Zdbhqk函数
            Zdbhqk GetZdbhqk(long id);
            IEnumerable<Zdbhqk> GetZdbhqks(string filter);
            bool SaveZdbhqk(Zdbhqk zdbhqk);
            void SaveZdbhqks(List<Zdbhqk> zdbhqks);
            void DeleteZdbhqk(long id);
            void DeleteZdbhqk(string filter);
            
            
            ///Zdjbxx函数
            Zdjbxx GetZdjbxx(long id);
            IEnumerable<Zdjbxx> GetZdjbxxs(string filter);
            bool SaveZdjbxx(Zdjbxx zdjbxx);
            void SaveZdjbxxs(List<Zdjbxx> zdjbxxs);
            void DeleteZdjbxx(long id);
            void DeleteZdjbxx(string filter);
            
            
            ///Zdjbxxzj函数
            Zdjbxxzj GetZdjbxxzj(long id);
            IEnumerable<Zdjbxxzj> GetZdjbxxzjs(string filter);
            bool SaveZdjbxxzj(Zdjbxxzj zdjbxxzj);
            void SaveZdjbxxzjs(List<Zdjbxxzj> zdjbxxzjs);
            void DeleteZdjbxxzj(long id);
            void DeleteZdjbxxzj(string filter);
            
            
            ///Zdtojzd函数
            Zdtojzd GetZdtojzd(long id);
            IEnumerable<Zdtojzd> GetZdtojzds(string filter);
            bool SaveZdtojzd(Zdtojzd zdtojzd);
            void SaveZdtojzds(List<Zdtojzd> zdtojzds);
            void DeleteZdtojzd(long id);
            void DeleteZdtojzd(string filter);
            
            
            ///Zdtojzx函数
            Zdtojzx GetZdtojzx(long id);
            IEnumerable<Zdtojzx> GetZdtojzxs(string filter);
            bool SaveZdtojzx(Zdtojzx zdtojzx);
            void SaveZdtojzxs(List<Zdtojzx> zdtojzxs);
            void DeleteZdtojzx(long id);
            void DeleteZdtojzx(string filter);
            
            
        
    }

}



