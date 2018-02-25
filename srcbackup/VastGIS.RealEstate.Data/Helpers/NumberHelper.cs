using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.RealEstate.Data.Helpers
{
    /// <summary>
    /// 编号公共功能模块
    /// </summary>
    public static class NumberHelper
    {

        /// <summary>
        /// 获取某表中某字段最大编号值
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="table">表名，如DJQ</param>
        ///  <param name="fieldName">字段名,</param>
        /// <param name="preNum">编号前缀</param>
        /// <param name="numLength">编号长度，如3位</param>
        /// <param name="totalNumber">新整体编号</param>
        /// <returns></returns>
        public static int GetMaxNumber(
            SQLiteConnection connection,
            string table,
            string fieldName,
            string preNum,
            int numLength,
            out string totalNumber)
        {
            string sql = string.Format("select Max({0}) from {1} where {0} Like '{2}%';", fieldName, table, preNum);
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                string maxStr = command.ExecuteScalar().ToString();
                if (string.IsNullOrEmpty(maxStr))
                {
                    totalNumber = preNum + "1".PadLeft(numLength, '0');
                    return 1;
                }
                int count = Convert.ToInt32(maxStr.Substring(preNum.Length));
                count = count + 1;
                totalNumber = preNum + count.ToString().PadLeft(numLength, '0');
                return count;

            }
        }
    }
}
