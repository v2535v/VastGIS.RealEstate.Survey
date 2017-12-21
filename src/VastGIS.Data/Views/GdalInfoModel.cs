using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Data.Repository;

namespace VastGIS.Data.Views
{
    public class GdalInfoModel
    {
        public GdalInfoModel(IFileItem item)
        {
            Filename = item.Filename;
            Datasource = item;
        }

        public IFileItem Datasource { get; private set;}

        public string Filename { get; private set; }
    }
}
