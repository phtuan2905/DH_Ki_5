using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTTQ_TH4_B2;
using LTTQ_TH4_B2.Classes;
namespace LTTQ_TH4_B2
{
    public partial class FormMain : Form
    {
        DataProcessor dtProcessor = new Classes.DataProcessor();
        public FormMain()
        {
            InitializeComponent();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHangHoa formHangHoa = new FormHangHoa();
            formHangHoa.Show();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            string taikhoan = textBox_taikhoan.Text;
            string matkhau = textBox_matkhau.Text;

            DataTable dtUser = dtProcessor.GetDataTable($"select * from tblUser where userName = N'{taikhoan}' and passWord = N'{matkhau}'");

            if (dtUser.Rows.Count > 0)
            {
                FormHangHoa form = new FormHangHoa();
                GlobalData.username = taikhoan;
                form.Show();
            }
            else
            {
                label1.Visible=true;
            }
        }

        private void button_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
