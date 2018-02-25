using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Dao.Impl;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.RealEstate.Data.Service.Impl.Tests
{
    [TestClass()]
    public class ZdServiceImplTests
    {
        [TestMethod()]//测试通过
        public void InitTablesTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            ZdService service = ServiceFactory.GetZdService();
            service.InitTables();
           
        }

        /// <summary>
        /// 测试是否可以对多边形端点进行重新排序，按照从上到下，从左到右规则
        /// </summary>
        [TestMethod()]//测试通过
        public void GetDjzqAndReorderTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            ZdService service = ServiceFactory.GetZdService();
            Djzq djzq = service.GetDjzq(1);
            for (int i = 0; i < djzq.Geometry.Points.Count; i++)
            {
                Console.WriteLine("{0}: {1} {2}",i+1,djzq.Geometry.Points[i].X, djzq.Geometry.Points[i].Y);
            }
           Console.WriteLine("{0}", "开始重新排序端点");

           IGeometry newGeometry = SpatialHelper.ReorderPolygonVertex(djzq.Geometry);

            for (int i = 0; i < newGeometry.Points.Count; i++)
            {
                Console.WriteLine("{0}: {1} {2}", i + 1, newGeometry.Points[i].X, newGeometry.Points[i].Y);
            }

            djzq.Geometry = newGeometry;
            string totalNumber = "";
            int count = NumberHelper.GetMaxNumber(DbConnection.GetConnection(), "DJZQ", "DJZQDM", "310201000", 3, out totalNumber);
            djzq.Djzqdm = totalNumber;
            service.SaveDjzq(djzq);
        }


        /// <summary>
        /// 测试是否可以通过一个位置获取所在的地籍子区的信息
        /// </summary>
        [TestMethod()]//测试通过
        public void QueryDjzqAndKeyValueTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            ZdService service = ServiceFactory.GetZdService();
            Djzq djzq = service.GetDjzq(1);
            ICoordinate center = djzq.Geometry.Centroid;
            IGeometry queryGeometry = new Geometry(GeometryType.Point, ZValueType.None);
            queryGeometry.Points.Add(center);
            IGeometry newGeometry = null;
            string keyValue = "";
            long backId = SpatialHelper.FindInPolygonRecord(DbConnection.GetConnection(), "DJZQ", "DJZQDM", queryGeometry, out keyValue,
                out newGeometry);

            Console.WriteLine("{0}:{1}", backId, keyValue);
        }
    }
}