using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.RealEstate.Data.Entity
{
    public class CadLayerPair
    {
        public CadLayerPair(string cadLayerName, string tableName)
        {
            CadLayer = cadLayerName;
            TableName = tableName;
        }
        public string CadLayer { get; set; }

        public string TableName { get; set; }
    }
}
