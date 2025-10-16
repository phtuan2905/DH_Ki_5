using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTTQ_C6_BT6_5.Classes;

namespace LTTQ_C6_BT6_5.DanhMuc
{
    public partial class FormDangNhapNhanVien : Form
    {
        Classes.DataProcessor dtProcessor = new Classes.DataProcessor();
        public FormDangNhapNhanVien()
        {
            InitializeComponent();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            DataTable dtnv = dtProcessor.GetDataTable($"select * from tblNhanvien where MaNhanVien = '{textBox1.Text}' and Passw = '{textBox2.Text}'");

            if (dtnv.Rows.Count > 0 )
            {
                GlobalData.manv = textBox1.Text;
                FormHoaDon form = new FormHoaDon();
                form.ShowDialog();
            }
        }
    }
}
