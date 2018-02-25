using System;

namespace VastGIS.RealEstate.Data.Service
{
    using System.Collections.Generic;
    using VastGIS.RealEstate.Data.Entity;
    using VastGIS.RealEstate.Data.Enums;
    using VastGIS.RealEstate.Data.Interface;

    /// <summary>
    /// Defines the <see cref="SystemService" />
    /// </summary>
    public partial interface SystemService
    {
        /// <summary>
        /// 创建空数据库
        /// </summary>
        /// <param name="dbName">The <see cref="string"/></param>
        void CreateEmptyDatabase(string dbName);

        void InitializeDatabase(int srid);
        /// <summary>
        /// 使用内部配置初始化数据库
        /// </summary>
        void InternalInitTables();

        /// <summary>
        /// 使用外部SQL初始化数据库
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        bool InitTables();

        /// <summary>
        /// 关闭数据库链接
        /// </summary>
        void Close();

        /// <summary>
        /// 得到对象类
        /// </summary>
        /// <param name="isDeep">是否按照级别查询 <see cref="bool"/></param>
        /// <returns>返回对象类集合 <see cref="List{VgObjectclass}"/></returns>
        List<VgObjectclass> GetObjectclasses(bool isDeep);

        /// <summary>
        /// 保存参数
        /// </summary>
        /// <param name="setting">设置对象 <see cref="VgSettings"/></param>
        /// <returns>The <see cref="bool"/></returns>
        bool SaveVgSetting2(VgSetting setting);

        /// <summary>
        /// 保存参数
        /// </summary>
        /// <param name="csmc">参数名称 <see cref="string"/></param>
        /// <param name="csz">参数值 <see cref="string"/></param>
        /// <returns>是否成功保存 <see cref="bool"/></returns>
        bool SaveVgSetting2(string csmc, string csz);

        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="csmc">参数名称 <see cref="string"/></param>
        /// <returns>参数对象 <see cref="VgSettings"/></returns>
        VgSetting GetVgSettingByName(string csmc);

        /// <summary>
        /// 初始化参数
        /// </summary>
        void InitSettings();

        /// <summary>
        /// 获取数据库坐标系
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        int GetSystemSRID();

        /// <summary>
        /// 获取对象类图形坐标系
        /// </summary>
        /// <param name="tableName">The <see cref="string"/></param>
        /// <param name="columnName">The <see cref="string"/></param>
        /// <returns>The <see cref="int"/></returns>
        int GetGeometryColumnSRID(string tableName, string columnName);

        /// <summary>
        /// 依据空间关系将文本数据赋值到多边形
        /// </summary>
        /// <param name="assignType">The <see cref="AssignTextType"/></param>
        /// <param name="polyTable">The <see cref="string"/></param>
        /// <param name="polyFieldName">The <see cref="string"/></param>
        /// <param name="textTable">The <see cref="string"/></param>
        /// <param name="textFieldName">The <see cref="string"/></param>
        /// <param name="whereClause">The <see cref="string"/></param>
        /// <param name="values">The <see cref="object"/></param>
        void AssignTextToPolygon(
                AssignTextType assignType,
                string polyTable,
                string polyFieldName,
                string textTable,
                string textFieldName,
                string whereClause,
                object values);

        /// <summary>
        /// 依据级别获得行政代码
        /// </summary>
        /// <param name="parentCode">父代码 <see cref="string"/></param>
        /// <param name="jb">级别 <see cref="int"/></param>
        /// <returns>The <see cref="IEnumerable{VgAreacode}"/></returns>
        IEnumerable<VgAreacode> GetAreaCodesByJB(string parentCode, int jb);

        /// <summary>
        /// 计算数据库内要素图形范围
        /// </summary>
        /// <param name="xmin">最小X <see cref="double"/></param>
        /// <param name="ymin">最小Y <see cref="double"/></param>
        /// <param name="xmax">最大X <see cref="double"/></param>
        /// <param name="ymax">最大Y <see cref="double"/></param>
        void RecalculateDBExtent(out double xmin, out double ymin, out double xmax, out double ymax);

  
        IEnumerable<VgAttachment> GetVgAttachmentsByWydm(string wydm);

        IEnumerable<VgAttachment> GetVgAttachmentsByWydm(Guid wydm);
        VgClassdetail GetVgClassdetailByTableName(string tbName);
        string GetTemporaryAttachmentName();
        
    }
}
