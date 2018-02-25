using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.TableEditor.Menu;
using VastGIS.Plugins.TableEditor.Properties;

namespace VastGIS.Plugins.TableEditor.Commands
{
    public class CreateShowAttributeTable:BaseCommand
    {
        private IAppContext _context;
        public CreateShowAttributeTable(IAppContext context)
        {
            base._text = "打开属性表";
            base._key = MenuKeys.ShowTable;
            base._icon = Resources.table_editor;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExFile";
            _context = context;
        }

        public override void OnClick()
        {
           
        }
    }
}
