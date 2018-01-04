using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Service
{

    public partial interface SystemService
    {
        bool InitTables();
        void Close();
        int GetGeometryColumnSRID(string tableName, string columnName);

        void AssignTextToPolygon(
            AssignTextType assignType,
            string polyTable,
            string polyFieldName,
            string textTable,
            string textFieldName,
            string whereClause,
            object values);

        IFeature FindFirstRecord(string[] getSearchLayers, double dx, double dy);

        /// <summary>
        /// 复制要素到另外一个表
        /// </summary>
        /// <param name="sourceTable">要素来源表</param>
        /// <param name="id">要素id</param>
        /// <param name="targetTable">目标要素表</param>
        /// <param name="isDelete">是否从来源表中删除</param>
        ///  <param name="isAttributeAutoTransform">是否自动传递同名属性</param>
        /// <returns></returns>
        bool CopyFeature(string sourceTable, int id, string targetTable, bool isDelete = false, bool isAttributeAutoTransform = true);


        List<VgObjectclasses> GetObjectclasseses(bool isDeep = true);


    }
}



