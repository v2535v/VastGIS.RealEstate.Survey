using VastGIS.Api.Enums;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdMeasureDistance : BaseCommand
    {
        private IAppContext _context;
        public CmdMeasureDistance(IAppContext context)
        {
            base._text = "æ‡¿Î¡ø≤‚";
            base._key = MenuKeys.MeasureDistance;
            base._icon = Resources.icon_measure_distance;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.Measuring.Type = MeasuringType.Distance;
            _context.Map.MapCursor = MapCursor.Measure;
        }
    }
}