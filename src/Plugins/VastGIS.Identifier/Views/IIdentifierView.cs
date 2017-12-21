using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Events;
using VastGIS.Api.Legend.Events;
using VastGIS.Plugins.Identifier.Controls;
using VastGIS.Plugins.Identifier.Enums;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Identifier.Views
{
    public interface IIdentifierView : IMenuProvider
    {
        IdentifierMode Mode { get; }
        bool ZoomToShape { get; }
        void Clear();
        event Action ModeChanged;
        event Action ItemSelected;
        void UpdateView();
        IdentifierNodeMetadata SelectedItem { get; }
        IEnumerable<IdentifierNodeMetadata> GetLayerItems(int handle);
    }
}
