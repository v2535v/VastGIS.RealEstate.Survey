using System;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Interfaces
{
    public interface IPlugin
    {
        string Description { get; }

        void Initialize(IAppContext context);

        void Terminate();
    }
}
