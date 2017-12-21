// -------------------------------------------------------------------------------------------
// <copyright file="IConfigService.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Concrete;

namespace VastGIS.Plugins.Services
{
    public interface IConfigService
    {
        AppConfig Config { get; }

        string ConfigPath { get; }

        void LoadAll();

        bool LoadConfig();

        void SaveAll();

        bool SaveConfig();
    }
}