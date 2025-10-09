using System.Data;
using System.Data.SqlClient;

namespace LTTQ_TH4_B1.Classes
{
    class DataBaseProcess
    {
        //Khai báo biến toàn cục, bạn phải thay đổi chuối kết nối phù hợp
        string strConnect = "Server=THENAME\\SQLEXPRESS;" +
                "DataBase=LTTQ_BanHang;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True;";
        SqlConnection sqlConnect = null;
        //Phương thức mở kết nối
        void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Phương thức đóng kết nối
        void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        //Phương thức thực thi câu lệnh Select trả về một DataTable
        public DataTable DataReader(string sqlSelct)
        {
            DataTable tableData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelct, sqlConnect);
            sqlData.Fill(tableData);
            CloseConnect();
            return tableData;
        }
        //Phương thức thực hiện câu lệnh dạng insert,update,delete
        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConnect;
            sqlcomma.CommandText = sql;
            sqlcomma.ExecuteNonQuery();
            CloseConnect();
        }
    }
}

