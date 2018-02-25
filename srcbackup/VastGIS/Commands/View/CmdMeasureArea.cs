using VastGIS.Api.Enums;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdMeasureArea : BaseCommand
    {
        private IAppContext _context;
        public CmdMeasureArea(IAppContext context)
        {
            base._text = "面积量测";
            base._key = MenuKeys.MeasureArea;
            base._icon = Resources.icon_measure_area;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.Measuring.Type = MeasuringType.Area;
            _context.Map.MapCursor = MapCursor.Measure;
        }
    }
}