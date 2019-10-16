using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateModels
{
    /// <summary>
    /// 数据帮助类
    /// </summary>
    public class DBHelper
    {
        public static string DataBaseName { get; set; } 
          private static string Constr
        {
            get { return $"server=.;uid=sa;pwd=malove;database={DataBaseName}"; }
        }
        /// <summary>
        /// 获取数据返回一个临时表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql,params SqlParameter [] paras)
        {

            //访问数据库
            //第一步：创建连接对象
            //using带异常捕获处理释放结构
            using (SqlConnection conn = new SqlConnection(Constr))
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(paras);
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
                dataAdapter.Fill(dt);
                return dt;
            }
               
        }
    }
}
