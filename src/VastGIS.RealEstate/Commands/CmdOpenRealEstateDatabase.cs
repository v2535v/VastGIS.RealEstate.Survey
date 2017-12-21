using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Services;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdOpenRealEstateDatabase:BaseCommand
    {
        private IAppContext _context;
        public CmdOpenRealEstateDatabase(IAppContext context)
        {
            base._key = "reOpenRealEstateDatabase";
            base._text = "打开不动产数据库";
            base._icon = Properties.Resources.DatabaseServersFolder32;
            _context = context;
        }

        public override void OnClick()
        {
            IRealEstateEditingService  _realEstateEditingService=_context.Container.GetSingleton<IRealEstateEditingService>();
            _realEstateEditingService.OpenREDatabase();
        }
    }
}
