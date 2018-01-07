using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Service
{

    public partial interface CadService
    {

        /// <summary>
        /// 在数据库新建的时候调用，创建CAD需要的表
        /// </summary>
        /// <returns></returns>
        bool InitTables();

        /// <summary>
        /// 在Dxf文件导入后调用，将依据CASS代码对应生成标准的要素代码
        /// </summary>
        void UpdateTmpCadYsdm();

        /// <summary>
        /// 清楚Cad临时表数据
        /// </summary>
        void ClearCADTemps();

        /// <summary>
        /// 依据DXF名称删除临时表数据
        /// </summary>
        /// <param name="insertMethod"></param>
        /// <param name="dxfName"></param>
        void ClearCADTemps(CADInsertMethod insertMethod, string dxfName);

        /// <summary>
        /// 检查CAD临时表中是否有对应的文件的数据
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        bool HasCADData(string fileName);
        
        /// <summary>
        /// 依据CAD图层名称将数据分别转入对应的基础底图图层，没有对应的图层的转入DXFQT图层
        /// </summary>
        /// <param name="cadLayerName"></param>
        /// <param name="tableName"></param>
        /// <param name="fileName"></param>
        /// <param name="isClear"></param>
        void SplitTmpCADToLayer(string cadLayerName, string tableName, string fileName = "", bool isClear = true);

        /// <summary>
        /// 导入DXF文件
        /// </summary>
        /// <param name="dxfName"></param>
        /// <param name="errorMsg"></param>
        /// <returns></returns>
        bool ImportDxfDrawing(string dxfName, out string errorMsg);


        /// <summary>
        /// 一次性将CAD临时文件数据导入到底图图层
        /// </summary>
        /// <param name="isClearBasemap"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        bool ImportTmpCadToBasemap(bool isClearBasemap = true, string fileName = "");
        
    }
}



