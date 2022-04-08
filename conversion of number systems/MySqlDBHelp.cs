using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zack
{
    public class MySqlDBHelp
    {


        public static string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        public static int Execute(string SQLString)
        {
            return ExecuteSql(SQLString);
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString)
        {
         
            int rows = -2;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(SQLString, connection))
                {
                    try
                    {
                        cmd.CommandTimeout = 1000;
                        connection.Open();
                        rows = cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        rows = -1;                      
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return rows;
        }

        /// <summary>
        /// 执行（查）询语句，返回DataTable
        /// </summary>
        /// <param name="SQLString"></param>
        /// <returns></returns>
        public static DataTable getTable(string SQLString)
        {
            DataTable rtv = null;
            DataSet ds = Query(SQLString);
            if (ds.Tables.Count > 0)
            {
                rtv = ds.Tables[0];
            }
            return rtv;
        }

        /// <summary>
        /// 执行（查）询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString"></param>
        /// <returns></returns>
        public static DataSet Query(string SQLString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    MySqlDataAdapter command = new MySqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
    }
}
