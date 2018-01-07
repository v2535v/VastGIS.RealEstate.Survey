using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.RealEstate.Data.Service.Tests
{
    [TestClass()]
    public class ServiceFactoryTests
    {
        [TestMethod()]
        public void GetSystemServiceTest()
        {
            if (!File.Exists(@"H:\redatabase.db"))
            {
                SQLiteHelper.CreateEmptyDatabase(@"H:\redatabase.db");
            }
            ServiceFactory.SetDatabaseName(@"H:\redatabase.db");
            SystemService service = ServiceFactory.GetSystemService();
            service.InitTables();
            // Assert.Fail();
        }

        [TestMethod()]
        public void GetCadServiceTest()
        {
            ServiceFactory.SetDatabaseName(@"H:\redatabase.net");
            CadService service=ServiceFactory.GetCadService();
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetBasemapServiceTest()
        {
            ServiceFactory.SetDatabaseName(@"H:\redatabase.db");
            BasemapService service = ServiceFactory.GetBasemapService();
            //Assert.Fail();
        }

       

        [TestMethod()]
        public void GetDomainServiceTest()
        {
            ServiceFactory.SetDatabaseName(@"H:\redatabase.db");
            DomainService service = ServiceFactory.GetDomainService();
           // Assert.Fail();
        }

        [TestMethod()]
        public void GetZdServiceTest()
        {
            ZdService service = ServiceFactory.GetZdService();
            //Assert.Fail();
        }

        [TestMethod()]
        public void SetDatabaseNameTest()
        {
            
            ServiceFactory.SetDatabaseName(@"H:\redatabase.db");
           // Assert.Fail();
        }
    }
}