﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Plugins.Symbology.Properties;

namespace VastGIS.Plugins.Symbology.Services
{
    public class LabelMoverCursor
    {
        private static CustomCursor _cursor;
        
        public static CustomCursor Instance
        {
            get
            {
                var guid = new Guid("72E1E84F-6EBE-4FE0-B345-74D9CD8052AB");
                return _cursor ?? (_cursor = new CustomCursor(guid, Resources.cursor_label_move, 0, 0));
            }
        }
    }
}
