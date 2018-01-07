using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Dao.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Service;

namespace VastGIS.RealEstate.Data.Servcice.Impl.Tests
{
    [TestClass()]
    public class CadServiceImplTests
    {
        [TestMethod()]//测试通过
        public void InitTablesTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            CadService service = ServiceFactory.GetCadService();
            service.InitTables();

        }

            //[TestMethod()]//测试通过
            //public void SplitTmpCADToLayerTest()
            //{
            //    Assert.Fail();
            //}

        [TestMethod()]//测试通过
        public void ImportDxfDrawingTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            CadService service = ServiceFactory.GetCadService();
            string errorMsg;
            service.ImportDxfDrawing(@"h:\凤凰新村3.dxf", out errorMsg);
            Console.WriteLine("Error Message ={0}", errorMsg);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod()]//测试通过
        public void InitBasemapTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            BasemapService service = ServiceFactory.GetBasemapService();
            service.InitTables();

        }

        [TestMethod()]
        public void ImportTmpCadToBasemapTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            CadService service = ServiceFactory.GetCadService();
            service.ImportTmpCadToBasemap(true);
        }

        [TestMethod()]
        public void AssignTextTypeTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            SystemService systemService = ServiceFactory.GetSystemService();
            systemService.InitSettings();
            CadService service = ServiceFactory.GetCadService();
            
        }

        [TestMethod()]
        public void UpdateTmpCadYsdmTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClearCADTempsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClearCADTempsTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void HasCADDataTest()
        {
            Assert.Fail();
        }

        
    }
}