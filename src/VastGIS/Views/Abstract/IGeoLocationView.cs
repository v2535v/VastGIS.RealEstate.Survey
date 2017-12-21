using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    internal interface IGeoLocationView: IView
    {
        string LocationQuery { get; }

        KnownExtents KnownExtents { get; }

        bool UseGeoLocation { get; }

        event Action Search;

        void SetInputFocus();
    }
}
