﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Plugins.TableEditor.Model
{
    public class DockPanelMetadata
    {
        public DockPanelMetadata(string key)
        {
            Key = key;
        }

        public string Key { get; private set; }
    }
}
