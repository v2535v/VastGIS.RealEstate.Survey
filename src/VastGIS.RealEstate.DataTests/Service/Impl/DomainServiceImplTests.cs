using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Dao.Impl;

namespace VastGIS.RealEstate.Data.Service.Impl.Tests
{
    [TestClass()]
    public class DomainServiceImplTests
    {
        [TestMethod()]
        public void InternalInitTablesTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            DomainService service = ServiceFactory.GetDomainService();
            service.InternalInitTables();
        }

        [TestMethod()]
        public void InitTablesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDictionaryByNameTest()
        {
            Assert.Fail();
        }
    }
}