using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOConnectDataBaseDemo.DAO
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionStr = "server=DESKTOP-JC1AF1T;database=PRN211;user=sa;password=17122001";
            return new SqlConnection(ConnectionStr);
        }
        public static DataTable GetDataBySql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
