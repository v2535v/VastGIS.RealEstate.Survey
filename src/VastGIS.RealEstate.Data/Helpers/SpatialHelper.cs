using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Settings;

namespace VastGIS.RealEstate.Data.Helpers
{
    public static class SpatialHelper
    {
        public static void AssignTextToPolygon(SQLiteConnection connection, TextAssignConfig config)
        {
            if (config.TextValues == null)
                AssignTextToPolygon(connection, config.AssignType, config.AssignTable, config.AssignField,
                    config.TextTable, config.TextField, config.TextWhereClause, null);
            else
                AssignTextToPolygon(connection, config.AssignType, config.AssignTable, config.AssignField,
                    config.TextTable, config.TextField, config.TextWhereClause, config.TextValues.ToArray());
        }

        public static void AssignTextToPolygon(
            SQLiteConnection connection,
            AssignTextType assignType,
            string polyTable,
            string polyFieldName,
            string textTable,
            string textFieldName,
            string whereClause,
            object values)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                string sql = "";
                if (string.IsNullOrEmpty(whereClause))
                    sql = string.Format(
                        "Select a.{0} as Wbnr,b.Id as polyid from {1} a JOIN {2} b on Within(a.geometry,b.geometry);",
                        textFieldName, textTable, polyTable);
                else
                    sql = string.Format(
                        "Select a.{0} as Wbnr,b.Id as polyid from {1} a JOIN {2} b on Within(a.geometry,b.geometry) where {3};",
                        textFieldName, textTable, polyTable, whereClause);
                command.CommandText = sql;

                SQLiteDataReader reader = command.ExecuteReader();
                string[] conValues = null;
                if (assignType == AssignTextType.String)
                {
                    conValues = values as string[];
                }
                string updateSQL = "";
                using (SQLiteTransaction tran = connection.BeginTransaction())
                {
                    SQLiteCommand command2 = new SQLiteCommand(connection);
                    while (reader.Read())
                    {
                        string textContext = reader.GetString(0).Trim();
                        int polyId = reader.GetInt32(1);
                        if (assignType == AssignTextType.String)
                        {
                            if (conValues.Contains(textContext))
                            {
                                updateSQL = String.Format("update {0} set {1}='{2}' where Id={3}", polyTable,
                                    polyFieldName, textContext, polyId);
                                command2.CommandText = updateSQL;
                                command2.ExecuteNonQuery();
                                continue;
                            }
                            continue;
                        }
                        if (assignType == AssignTextType.Integer || assignType == AssignTextType.Float)
                        {
                            if (!string.IsNullOrEmpty(textContext) && IsNumberic(textContext))
                            {
                                updateSQL = String.Format("update {0} set {1}='{2}' where Id={3}", polyTable,
                                    polyFieldName, textContext, polyId);
                                command2.CommandText = updateSQL;
                                command2.ExecuteNonQuery();
                                continue;
                            }
                            continue;
                        }
                    }
                    reader.Close();
                    tran.Commit();
                }
            }
        }

        public static bool CopyFeature(
            SQLiteConnection connection,
            string sourceTable,
            int id,
            string targetTable,
            bool isDelete = false,
            bool isAttributeAutoTransform = true)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    List<string> sourceColumns = SQLiteHelper.GetAllColumns(connection, sourceTable);
                    List<string> targetColumns = SQLiteHelper.GetAllColumns(connection, targetTable);
                    Dictionary<string, string> mappingColumns =
                        SQLiteHelper.AutoMappingColumn(sourceColumns, targetColumns);
                    StringBuilder builder = new StringBuilder();
                    if (targetColumns.Contains("wx_wydm"))
                        builder.Append("insert into " + targetTable + "(wx_wydm, geometry");
                    else builder.Append("insert into " + targetTable + "(geometry");
                    foreach (var mappingColumn in mappingColumns)
                    {
                        if (mappingColumn.Value.ToLower().Equals("geometry")) continue;
                        builder.Append("," + mappingColumn.Value);
                    }
                    if (targetColumns.Contains("wx_wydm"))
                        builder.Append(") SELECT '" + Guid.NewGuid().ToString() + "', geometry");
                    else builder.Append(") SELECT geometry");
                    foreach (var mappingColumn in mappingColumns)
                    {
                        if (mappingColumn.Value.ToLower().Equals("geometry")) continue;
                        builder.Append("," + mappingColumn.Value);
                    }
                    builder.Append(" from " + sourceTable + " where Id=" + id.ToString());
                    command.CommandText = builder.ToString();
                    command.ExecuteNonQuery();
                    if (isDelete)
                    {
                        command.CommandText = "delete " + sourceTable + " from Id=" + id.ToString();
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsNumberic(string oText)
        {
            try
            {
                int var1 = Convert.ToInt32(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 重新对多边形顶点进行排序，按照从上到下，从左到右进行
        /// </summary>
        /// <param name="geometry"></param>
        /// <returns></returns>
        public static IGeometry ReorderPolygonVertex(IGeometry geometry)
        {
            double xMin = geometry.Extents.MinX;
            double yMax = geometry.Extents.MaxY;
            int startIndex = -1;
           
            double dist = 9999999.00;
            for (int i = 0; i < geometry.Points.Count; i++)
            {
                ICoordinate coord = geometry.Points[i];
                double dist2 = Math.Sqrt((xMin - coord.X) * (xMin - coord.X) + (yMax - coord.Y) * (yMax - coord.Y));
                if (dist2 < dist)
                {
                    dist = dist2;
                    startIndex = i;
                }
            }

            if (startIndex == 0) return geometry;

            IGeometry newPoly = new Geometry(GeometryType.Polygon, ZValueType.None);
            for (int i = startIndex; i < geometry.Points.Count; i++)
            {
                ICoordinate coord = geometry.Points[i];
                newPoly.Points.Add(new Coordinate(coord.X,coord.Y));
            }
           
             for (int i = 1; i <=startIndex; i++)
             {
                ICoordinate coord = geometry.Points[i];
                 newPoly.Points.Add(new Coordinate(coord.X, coord.Y));
            }
            return newPoly;
        }


        /// <summary>
        ///依据输入的图形对象中心点位置找到指定表中多边形，并返回序号，关键字段值以及图形
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="table"></param>
        /// <param name="fieldName"></param>
        /// <param name="queryGeometry"></param>
        /// <param name="keyValue"></param>
        /// <param name="overlayGeometry"></param>
        /// <returns></returns>
        public static long FindInPolygonRecord(
            SQLiteConnection connection,
            string table,
            string fieldName,
            IGeometry queryGeometry,
            out string keyValue,
            out IGeometry overlayGeometry)
        {
            ICoordinate centerPoint;
            if (queryGeometry.GeometryType != GeometryType.Point) centerPoint = queryGeometry.Centroid;
            else centerPoint = new Coordinate(queryGeometry.Points[0].X, queryGeometry.Points[0].Y);
            string sql =
                string.Format(
                    "select ID,AsText(geometry),{0} from {1} where Within(GeomFromText('Point({2} {3})'),geometry);",
                    fieldName, table, centerPoint.X, centerPoint.Y);
            using (SQLiteCommand command = new SQLiteCommand(sql,connection))
            {
                SQLiteDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    reader.Close();
                    keyValue = string.Empty;
                    overlayGeometry = null;
                    return -1;
                }

                keyValue = reader.GetString(2);
                overlayGeometry = new Geometry(GeometryType.Polygon, ZValueType.None);
                overlayGeometry.ImportFromWkt(reader.GetString(1));
                long id = reader.GetInt64(0);
                reader.Close();
                return id;
            }
        }

        public static string SearchSQLBuilder(string tableName, int[] ids)
        {
            string sql =
                string.Format("Select Id,AsText(geometry) as Wkt,Ysdm,'{0}' as TableName from {0} Where Id in (",
                    tableName);
            for (int i = 0; i < ids.Length; i++)
            {
                if (i == 0) sql += i.ToString();
                else
                {
                    sql += "," + i.ToString();
                }
            }
            sql += ");";
            return sql;
        }
        public static string SearchSQLBuilder(
            string tableName,
            GeometryType geometryType,
            double dx,
            double dy,
            double radius = 2.0)
        {
            string sql = "";
            if (geometryType == GeometryType.Polygon)
            {
                sql= string.Format(
                    "Select Id,AsText(geometry) as Wkt,Ysdm,'{0}' as TableName from {0} Where Flags<3 AND Within( GeomFromText('POINT({1} {2})'),geometry);",tableName,
                    dx, dy);
            }
            else if (geometryType == GeometryType.Polyline)
            {
                sql = string.Format(
                    "Select Id,AsText(geometry) as Wkt,Ysdm,'{0}' as TableName from {0} Where Flags<3 AND Intersects( GeomFromText('{1}'),geometry)=1;", tableName,
                    GeometryHelper.CreateRectangleWkt(dx,dy,radius));
            }
            else if (geometryType == GeometryType.Point || geometryType == GeometryType.TextPoint)
            {
                sql = string.Format(
                    "Select Id,AsText(geometry) as Wkt,Ysdm,'{0}' as TableName from {0} Where Flags<3 AND Within(geometry,GeomFromText('{1}'))=1;", tableName,
                    GeometryHelper.CreateRectangleWkt(dx, dy, radius));
            }
            return sql;
        }
    }
}