using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Legend.Abstract;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Helpers
{
    public class LayerHelper
    {
        public static VgObjectclass GetVgObjectClassByLegend(List<VgObjectclass> classes, IMuteLegend legend)
        {
            if (legend.SelectedLayer == null) return null;
            if (legend.SelectedLayer.IsVector == false) return null;
            VgObjectclass oneclass = classes.FirstOrDefault(c => c.Zwmc == legend.SelectedLayer.Name);
            if (oneclass != null) return oneclass;
            return null;
        }
    }
}
