using VastGIS.Api.Concrete;

namespace VastGIS.Plugins.RealEstate.Services
{
    public interface IRealEstateEditingService
    {
        void OpenREDatabase();

        bool StartEditing();

        bool SaveEditing(bool isStop);

        bool StopEditing(bool isSave);
        bool SetEditingLayer();

        string SpatialiteDB { get; }

        VectorLayer CurrentEditingLayer { get; }

    }
}