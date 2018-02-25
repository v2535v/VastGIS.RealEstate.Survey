// -------------------------------------------------------------------------------------------
// <copyright file="IGeoLocationService.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Api.Interfaces;

namespace VastGIS.Plugins.Services
{
    public interface IGeoLocationService
    {
        string License { get; }

        IEnvelope FindLocation(string query);
    }
}