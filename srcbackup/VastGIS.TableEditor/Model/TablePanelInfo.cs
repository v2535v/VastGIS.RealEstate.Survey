﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.TableEditor.Editor;
using VastGIS.Plugins.TableEditor.Views;

namespace VastGIS.Plugins.TableEditor.Model
{
    internal class TablePanelInfo
    {
        public TablePanelInfo(TableEditorGrid grid, ILegendLayer layer, ITablePanel panel)
        {
            if (grid == null) throw new ArgumentNullException("grid");
            if (layer == null) throw new ArgumentNullException("layer");
            if (panel == null) throw new ArgumentNullException("panel");
            Grid = grid;
            Layer = layer;
            Panel = panel;
        }

        public TableEditorGrid Grid { get; private set; }

        public ILegendLayer Layer { get; private set; }

        public ITablePanel Panel { get; private set; }

        public FindReplacePresenter FindReplace { get; set;}
    }
}
