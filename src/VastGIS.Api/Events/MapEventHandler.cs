using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;

namespace VastGIS.Api.Events
{
    public delegate void MapEventHandler<TArgs>(IMuteMap map, TArgs e)
        where TArgs : EventArgs;
}
