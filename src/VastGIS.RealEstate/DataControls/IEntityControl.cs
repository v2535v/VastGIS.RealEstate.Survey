// -------------------------------------------------------------------------------------------
// <copyright file="IEntityControl.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2018
// </copyright>
// -------------------------------------------------------------------------------------------
namespace VastGIS.Plugins.RealEstate.DataControls
{
    public interface IEntityControl
    {
         bool HasChanged { get; }

        bool Save();

        void Delete();
    }
}