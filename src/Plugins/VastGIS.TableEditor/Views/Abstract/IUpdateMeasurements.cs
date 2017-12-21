using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.TableEditor.Model;

namespace VastGIS.Plugins.TableEditor.Views.Abstract
{
    public interface IUpdateMeasurementsView: IView<IFeatureSet>
    {
        MeasurementInfo AreaInfo { get; }
        MeasurementInfo LengthInfo { get; }
        AreaUnits AreaUnits { get; }
        LengthUnits LengthUnits { get; }
    }
}
