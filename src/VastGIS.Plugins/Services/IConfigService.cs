// -------------------------------------------------------------------------------------------
// <copyright file="IConfigService.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
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