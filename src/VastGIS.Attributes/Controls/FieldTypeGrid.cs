// -------------------------------------------------------------------------------------------
// <copyright file="FieldTypeGrid.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Drawing;
using VastGIS.Attributes.Model;
using VastGIS.UI.Controls;
using Syncfusion.Windows.Forms.Grid;

namespace VastGIS.Attributes.Controls
{
    public class FieldTypeGrid : StronglyTypedGrid<FieldTypeWrapper>
    {
        public FieldTypeGrid()
        {
            Adapter.HotTracking = false;
            Adapter.ReadOnly = false;
            Adapter.AllowCurrentCell = false;
        }

        protected override void UpdateColumns()
        {
            Adapter.HideColumns();

            Adapter.ShowColumn(f => f.Type);
            Adapter.ShowColumn(f => f.Name);

            const int scrollbarWidth = 40;
            const int typeWidth = 40;

            var cmn = Adapter.GetColumn(f => f.Type);
            cmn.Width = typeWidth;
            cmn.Appearance.AnyCell.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.LightGray);

            cmn = Adapter.GetColumn(f => f.Name);
            cmn.Width = Width - typeWidth - scrollbarWidth;
        }
    }
}