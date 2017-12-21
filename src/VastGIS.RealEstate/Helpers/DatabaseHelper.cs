using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.RealEstate.Helpers
{
    public static class DatabaseHelper
    {
        public static string ChooseEditingDatabase(IAppContext context,List<string> databases)
        {
            using (var form = new frmSelectEditDatabase(databases))
            {
                if (context.View.ShowChildView(form))
                {
                    var database = form.SelectedDatabase;
                    return database;
                }
            }
            return "";
        }
    }
}
