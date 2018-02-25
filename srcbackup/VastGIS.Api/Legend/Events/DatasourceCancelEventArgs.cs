﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;

namespace VastGIS.Api.Legend.Events
{
    public class DatasourceCancelEventArgs: CancelEventArgs
    {
        public DatasourceCancelEventArgs(ILayerSource datasource)
        {
            Datasource = datasource;
        }

        public ILayerSource Datasource { get; private set; }
    }
}
