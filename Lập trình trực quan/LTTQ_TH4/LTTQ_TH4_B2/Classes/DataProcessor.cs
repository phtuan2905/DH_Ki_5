using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LTTQ_TH4_B2.Classes
{
    internal class DataProcessor
    {
        string strConnect = "Server=DESKTOP-4G4NL83\\SQLEXPRESS;" +
                "DataBase=QLBanHang_TH4_2;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True;";
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
