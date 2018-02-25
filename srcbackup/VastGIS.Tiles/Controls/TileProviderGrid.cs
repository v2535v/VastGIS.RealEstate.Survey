﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Model;
using VastGIS.UI.Controls;

namespace VastGIS.Tiles.Controls
{
    internal partial class TileProviderGrid : StronglyTypedGrid<TmsProvider>
    {
        public TileProviderGrid()
        {
            InitializeComponent();

            Adapter.ReadOnly = true;
        }

        protected override void UpdateColumns()
        {
            Adapter.HideColumns();

            Adapter.ShowColumn(p => p.Id);
            Adapter.ShowColumn(p => p.Name);
            Adapter.ShowColumn(p => p.Projection);
            Adapter.ShowColumn(p => p.Url);

            Adapter.GetColumn(p => p.Url).Width = 200;
        }
    }
}
