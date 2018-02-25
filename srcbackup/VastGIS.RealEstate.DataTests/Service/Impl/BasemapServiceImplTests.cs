using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Dao.Impl;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.RealEstate.Data.Service.Impl.Tests
{
    [TestClass()]
    public class BasemapServiceImplTests
    {
        [TestMethod()]
        public void InitTablesTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            BasemapService service = ServiceFactory.GetBasemapService();
            service.InitTables();
        }

        /// <summary>
        /// 对某多边形图层数据做顺序纠正，包括起点一定为左上角点，顺序一定为顺时针方向，这样保证在宗地生成界址点时候可以直接按照这个顺序去对界址点编号，暂时未处理多边形孔状数据
        /// </summary>
        [TestMethod()]//测试通过
        public void ReorderAllPolygonTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            BasemapService service = ServiceFactory.GetBasemapService();
            service.ReorderAllPolygon("DXTJMDM");
        }


        [TestMethod()]
        public void UnionPolygonTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            BasemapService service = ServiceFactory.GetBasemapService();
            Dxtjmdm jmdm2 = service.GetDxtjmdm(2);
            Dxtjmdm jmdm3 = service.GetDxtjmdm(3);
            Dxtjmdm jmdm4 = service.GetDxtjmdm(4);
            List<IGeometry> geometries=new List<IGeometry>();
            geometries.Add(jmdm2.Geometry);
            geometries.Add(jmdm3.Geometry);
            //geometries.Add(jmdm2.Geometry);

            IGeometry newGeometry = GeometryHelper.UnionPolygons(geometries);
            Dxtdlssm dlssm=new Dxtdlssm() {DatabaseID = 0,Geometry = newGeometry};
            service.SaveDxtdlssm(dlssm);
        }
    }
}