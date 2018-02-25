using System;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Events;
using VastGIS.Api.Interfaces;

namespace VastGIS.Plugins.Interfaces
{
    public interface IMapTool
    {
        MapCursor MapCursor { get; set; }
        void OnAfterShapeEdit(IMuteMap map, AfterShapeEditEventArgs e);

        void OnMapCursorChanged(IMuteMap map, EventArgs e);

        void OnMouseDoubleClick(IMuteMap map, EventArgs e);

        void OnMouseDown(IMuteMap map, MouseEventArgs e);
        void OnMouseMove(IMuteMap map, MouseEventArgs e);
        void OnMouseUp(IMuteMap map, MouseEventArgs e);

        void Activiate();

        void Deactiviate();
    }
}