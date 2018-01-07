using Microsoft.VisualStudio.TestTools.UnitTesting;
using VastGIS.RealEstate.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Helpers.Tests
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass()]
    public class GeometryHelperTests
    {

        /// <summary>
        /// 距离交会测试
        /// </summary>
        [TestMethod()]//测试通过
        public void DistanceIntersectionTest()
        {
            ICoordinate point1 = new Coordinate(0, 0);
            ICoordinate point2 = new Coordinate(10, 0);
            ICoordinate inter1 = null;
            ICoordinate inter2 = null;
            int retVal = GeometryHelper.DistanceIntersection(point1, 6, point2, 5, out inter1, out inter2);
            Console.WriteLine("1:{0} {1}", inter1.X, inter1.Y);
            Console.WriteLine("2:{0} {1}", inter2.X, inter2.Y);
            
        }
    }
}