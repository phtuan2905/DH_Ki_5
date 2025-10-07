using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTTQ_C6_BT6._5.Classes;

namespace LTTQ_C6_BT6._5
{
    public partial class FormHangHoa : Form
    {
        Classes.DataProcessor dtProcessor = new Classes.DataProcessor();
        public FormHangHoa()
        {
            InitializeComponent();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtChatLieu = dtProcessor.GetDataTable("select * from tblChatLieu");
            Functions.FillComboBox(comboBox_chatlieu, dtChatLieu, "TenChatLieu", "MaChatLieu");
            comboBox_chatlieu.SelectedIndex = -1;

            DataTable dtHangHoa = dtProcessor.GetDataTable("select * from tblHang");
            dataGridView_hanghoa.DataSource = dtChatLieu;

            dataGridView_hanghoa.Columns[0].HeaderText = "Mã hàng";
            dataGridView_hanghoa.Columns[1].HeaderText = "Tên hàng";
            dataGridView_hanghoa.Columns[2].HeaderText = "Tên chất liệu";
            dataGridView_hanghoa.Columns[3].HeaderText = "Số lượng";
            dataGridView_hanghoa.Columns[4].HeaderText = "Đơn giá nhập";
            dataGridView_hanghoa.Columns[5].HeaderText = "Đơn giá bán";
            dataGridView_hanghoa.Columns[6].HeaderText = "File ảnh";
            dataGridView_hanghoa.Columns[7].HeaderText = "Ghi chú";

            dtHangHoa.Dispose();

            button_luu.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_boqua.Enabled = false;
        }
    }
}
