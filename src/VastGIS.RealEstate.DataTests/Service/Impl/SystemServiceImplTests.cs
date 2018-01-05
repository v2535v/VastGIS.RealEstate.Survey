using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Dao.Impl;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.RealEstate.Data.Service.Impl.Tests
{
    [TestClass()]
    public class SystemServiceImplTests
    {
       
        [TestMethod()]
        public void GetGeometryColumnSRIDTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase.db");
            SystemService service = ServiceFactory.GetSystemService();
            int srid=service.GetGeometryColumnSRID("TmpCadd", "geometry");
            
        }

        [TestMethod()]
        public void AssignTextToPolygonTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindFirstRecordTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        
        public void CopyFeatureTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase.db");
            SystemService service = ServiceFactory.GetSystemService();
            service.CopyFeature("DXTQTM", 1, "DJZQ", false, true);
            
        }

        [TestMethod()]
        public void GetObjectclassesesTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase.db");
            SystemService service = ServiceFactory.GetSystemService();
            List<VgObjectclasses> classes = service.GetObjectclasseses(true);
            CollectionAssert.AllItemsAreUnique(classes);
        }
    }
}