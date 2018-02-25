using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Service.Impl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VastGIS.RealEstate.Data.Dao.Impl;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Settings;

namespace VastGIS.RealEstate.Data.Service.Impl.Tests
{
    [TestClass()]
    public class SystemServiceImplTests
    {

        [TestMethod()] //测试通过，新建空数据库，因为涉及到坐标系初始化等工作，耗时很长，所以一般情况不用该功能
        public void CreateEmptyTableTest()
        {
            SQLiteHelper.CreateEmptyDatabase(@"H:\redatabase2.db");
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            SystemService service = ServiceFactory.GetSystemService();


        }

        [TestMethod()] //测试通过,初始化系统表，在这儿系统表的原始数据有dll来初始化，一般情况不用该功能
        public void InitTablesTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            SystemService service = ServiceFactory.GetSystemService();
            service.InternalInitTables();
        }

        [TestMethod()]//测试通过,1-省级；2-地市级；3-县级
        public void QueryAreaCodes()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            SystemService service = ServiceFactory.GetSystemService();
            IEnumerable<VgAreacode> codes = service.GetAreaCodesByJB("", 1);
            foreach (VgAreacode areacodes in codes)
            {
                Console.WriteLine("{0}  {1}",areacodes.Xzqhmc,areacodes.Xzqhdm);
            }

            codes = service.GetAreaCodesByJB("130000", 2);
            foreach (VgAreacode areacodes in codes)
            {
                Console.WriteLine("{0}  {1}", areacodes.Xzqhmc, areacodes.Xzqhdm);
            }

            codes = service.GetAreaCodesByJB("130100", 3);
            foreach (VgAreacode areacodes in codes)
            {
                Console.WriteLine("{0}  {1}", areacodes.Xzqhmc, areacodes.Xzqhdm);
            }

        }

        [TestMethod()]//测试通过,不会重复写入设置参数
        public void InsertSettingsTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            SystemService service = ServiceFactory.GetSystemService();
            VgSetting settings = new VgSetting() { Csmc = "SRID", Csz = "4539" };
            service.SaveVgSetting2(settings);
            service.SaveVgSetting2("SRID", "4539");
            settings = new VgSetting() { Csmc = "SRID", Csz = "4539" };
            service.SaveVgSetting2(settings);

            settings = new VgSetting() { Csmc = "XZQHDM", Csz = "320200" };
            service.SaveVgSetting2(settings);

            settings = new VgSetting() { Csmc = "WXDCY", Csz = "王先生" };
            service.SaveVgSetting2(settings);

            settings = new VgSetting() { Csmc = "WXCLY", Csz = "张先生" };
            service.SaveVgSetting2(settings);

        }

        [TestMethod()]//测试通过,
        public void SaveTextAssignConfigTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            SystemService service = ServiceFactory.GetSystemService();
            List<TextAssignConfig> configs = new List<TextAssignConfig>();
            TextAssignConfig config = new TextAssignConfig("居民地楼层识别", "DXTJMDM", "FSXX1", AssignTextType.Integer, null);
            config.TextField = "Wbnr";
            config.TextTable = "DXTZJZJ";
            config.TextWhereClause = "[a].TC='ZJ'";
            configs.Add(config);

            config = new TextAssignConfig("居民地材质识别", "DXTJMDM", "FSXX2", AssignTextType.String, new List<string>() { "混", "砖", "砼", "破", "建" });
            config.TextField = "Wbnr";
            config.TextTable = "DXTZJZJ";
            config.TextWhereClause = "[a].TC='ZJ'";
            configs.Add(config);

            string configStr = JsonConvert.SerializeObject(configs);
            VgSetting setting = new VgSetting() { Csmc = "DXTWZSXSB", Csz = configStr };
            service.SaveVgSetting2(setting);
        }


        [TestMethod()]//测试通过,
        public void LoadTextAssignConfigTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            SystemService service = ServiceFactory.GetSystemService();
            VgSetting setting = service.GetVgSettingByName("DXTWZSXSB");
            List<TextAssignConfig> configs = JsonConvert.DeserializeObject<List<TextAssignConfig>>(setting.Csz);

            foreach (TextAssignConfig config in configs)
            {
               Console.WriteLine("{0}",config.Name);
                SpatialHelper.AssignTextToPolygon(DbConnection.GetConnection(),config);
            }
            
        }


        [TestMethod()]
        public void CopyFeatureToAnotherTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase2.db");
            SystemService service = ServiceFactory.GetSystemService();
            bool retVal=SpatialHelper.CopyFeature(DbConnection.GetConnection(), "DXTQTM", 1, "DJZQ", true, true);
            Assert.AreNotEqual(true,retVal);

        }

        //[TestMethod()]//依据参数名称获取参数,通过
        //public void GetSettingsTest()
        //{
        //    DbConnection.SetDatabaseName(@"H:\redatabase2.db");
        //    SystemService service = ServiceFactory.GetSystemService();
        //    VgSettings setting = service.GetVgSettings("SRID");
        //    Console.WriteLine("Csmc is {0}, Csz is {1}", setting.Csmc, setting.Csz);
        //}

        //[TestMethod()]//依据参数名称获取参数
        //public void GetSridTest()
        //{
        //    DbConnection.SetDatabaseName(@"H:\redatabase2.db");
        //    SystemService service = ServiceFactory.GetSystemService();
        //    int srid = service.GetSystemSRID();
        //    Console.WriteLine("SRID is {0}", srid.ToString());
        //}



        //[TestMethod()]
        //public void GetGeometryColumnSRIDTest()
        //{
        //    DbConnection.SetDatabaseName(@"H:\redatabase2.db");
        //    SystemService service = ServiceFactory.GetSystemService();
        //    int srid=service.GetGeometryColumnSRID("TmpCadd", "geometry");

        //}

        //[TestMethod()]
        //public void AssignTextToPolygonTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void FindFirstRecordTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]

        //public void CopyFeatureTest()
        //{
        //    DbConnection.SetDatabaseName(@"H:\redatabase.db");
        //    SystemService service = ServiceFactory.GetSystemService();
        //    service.CopyFeature("DXTQTM", 1, "DJZQ", false, true);

        //}

        [TestMethod()]
        public void GetObjectclassesesTest()
        {
            DbConnection.SetDatabaseName(@"H:\redatabase.db");
            SystemService service = ServiceFactory.GetSystemService();
            List<VgObjectclass> classes = service.GetObjectclasses(true);
            foreach (var classname in classes)
            {
                DisplayInformation(classname,0);
            }
            CollectionAssert.AllItemsAreUnique(classes);
        }

        private void DisplayInformation(VgObjectclass oneclass,int step)
        {
            if (oneclass.Dxlx == 0)
            {
                Console.WriteLine("{0}:{1}  {2}", oneclass.Mc, oneclass.Zwmc, step);
                if (oneclass.SubClasses == null) return;
                foreach (var subclass in oneclass.SubClasses)
                {
                    DisplayInformation(subclass, step + 1);
                }
            }
            else
            {
                Console.WriteLine("{0}:{1}  {2}",oneclass.Mc,oneclass.Zwmc,step);
            }
        }

    }
}