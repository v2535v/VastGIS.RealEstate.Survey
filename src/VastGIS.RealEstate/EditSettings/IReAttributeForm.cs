// -------------------------------------------------------------------------------------------
// <copyright file="IReAttributeForm.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2018
// </copyright>
// -------------------------------------------------------------------------------------------
namespace VastGIS.Plugins.RealEstate.EditSettings
{
    public interface IReAttributeForm
    {
        string ObjectKey { get; set; }
        object LinkedObject { get; set; }
        string FormName { get; set; }
    }
}