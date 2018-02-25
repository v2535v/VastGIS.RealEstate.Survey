using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Views.Abstract;

namespace VastGIS.Views
{
    public class MeasuringPresenter:  BasePresenter<IMeasuringView, IMeasuringSettings>
    {
        private readonly IAppContext _context;

        public MeasuringPresenter(IAppContext context, IMeasuringView view) : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public override bool ViewOkClicked()
        {
            View.UiToModel();
            _context.Map.Redraw(RedrawType.SkipDataLayers);
            return true;
        }
    }
}
