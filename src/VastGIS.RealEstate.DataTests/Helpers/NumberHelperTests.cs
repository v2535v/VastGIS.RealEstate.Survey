using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Dao.Impl;

namespace VastGIS.RealEstate.Data.Helpers.Tests
{
    [TestClass()]
    public class NumberHelperTests
    {
        [TestMethod()]
        public void GetMaxNumberTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            string totalNumber = "";
            int count=NumberHelper.GetMaxNumber(DbConnection.GetConnection(), "DJZQ", "DJZQDM", "310201000", 3, out totalNumber);
            Console.WriteLine("{0}:{1}", count, totalNumber);
        }
    }
}