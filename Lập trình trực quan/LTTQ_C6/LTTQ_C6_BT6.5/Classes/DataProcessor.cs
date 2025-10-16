using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LTTQ_C6_BT6_5.Classes
{
    internal class DataProcessor
    {
        string strConnect = "Server=THENAME\\SQLEXPRESS;DataBase=LTTQ_QLBanHang;Integrated Security=True";
        SqlConnection sqlConnect = null;

        public void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open) 
                sqlConnect.Open();
        }

        public void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed) 
                sqlConnect.Close();
            sqlConnect.Dispose();
        }

        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnect);
            adapter.Fill(dt);
            CloseConnect();
            return dt;
        }

        public void UpdateData(string cmd)
        {
            OpenConnect();
            SqlCommand command = new SqlCommand(cmd, sqlConnect);
            command.ExecuteNonQuery();
            command.Dispose();
            CloseConnect();
        }
    }
}
