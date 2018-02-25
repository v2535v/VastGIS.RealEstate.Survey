﻿using VastGIS.Plugins.ImageRegistration.Model;
using VastGIS.UI.Controls;

namespace VastGIS.Plugins.ImageRegistration.Controls
{
    internal partial class PointPairGrid : StronglyTypedGrid<PointPair>
    {
        public PointPairGrid()
        {
            InitializeComponent();

            Adapter.HotTracking = false;
            Adapter.ReadOnly = false;
            Adapter.AllowCurrentCell = false;
        }

        protected override void UpdateColumns()
        {
            // do nothing
            Adapter.HideColumns();

            Adapter.ShowColumn(p => p.Selected);
            Adapter.ShowColumn(p => p.Index);
            Adapter.ShowColumn(p => p.X1);
            Adapter.ShowColumn(p => p.Y1);
            Adapter.ShowColumn(p => p.X2);
            Adapter.ShowColumn(p => p.Y2);
            Adapter.ShowColumn(p => p.DeviationString);
        }
    }
}
