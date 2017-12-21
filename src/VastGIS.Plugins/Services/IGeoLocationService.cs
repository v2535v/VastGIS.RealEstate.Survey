// -------------------------------------------------------------------------------------------
// <copyright file="IGeoLocationService.cs" company="MapWindow OSS Team - www.mapwindow.org">
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