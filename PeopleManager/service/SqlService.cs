using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.service
{
    class SqlService
    {
       
        string connectionstr = @"Data Source=DESKTOP-C9DHR7I\SQLEXPRESS;Initial Catalog=PeopleManagerDB;Integrated Security=True";
        public DataTable GetTable(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionstr))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public int Query(string query)
        {
            try
            {
                int s = -1;
                using (SqlConnection conn = new SqlConnection(connectionstr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                 s=    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                return s;
            }
            catch(Exception e)
            {
                return -1;
            }
        }
        public bool InsertRow(string table,string[] values)
        {
            try
            {
              var row=  string.Join(",", values);

                string query = $@"INSERT INTO {table}
                                VALUES ({row})";
                Query(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
       
    }
}
