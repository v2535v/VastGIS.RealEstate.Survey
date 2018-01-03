using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;

namespace VastGIS.RealEstate.Data.Dao
{
    public interface MainDao
    {
        void Close();

        int GetGeometryColumnSRID(string tableName, string columnName);
        void ClearCADTemps();
        void ClearCADTemps(CADInsertMethod insertMethod, string dxfName);

        bool HasCADData(string fileName);

        void SplitTmpCADToLayer(string cadLayerName, string tableName, string fileName = "", bool isClear = true);

        void AssignTextToPolygon(
            AssignTextType assignType,
            string polyTable,
            string polyFieldName,
            string textTable,
            string textFieldName,
            string whereClause,
            object values);

        void UpdateTmpCadYsdm();

        IFeature FindFirstRecord(string[] getSearchLayers, double dx, double dy);
    }

   
}