using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTTQ_C6_BT6_5.Classes;

namespace LTTQ_C6_BT6_5.DanhMuc
{
    public partial class FormChatLieu : Form
    {
        public FormChatLieu()
        {
            InitializeComponent();
        }

        Classes.DataProcessor dtProcessor = new Classes.DataProcessor();
        string maChatLieuGlobal = "";

        private void FormChatlieu_Load(object sender, EventArgs e)
        {
            DataTable dtChatLieu = dtProcessor.GetDataTable("select * from tblChatlieu");
            dataGridView_chatlieu.DataSource = dtChatLieu;

            dtChatLieu.Dispose();

            button_luu.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_boqua.Enabled = false;
        }

        private void ResetForm()
        {
            textBox_machatlieu.Text = "";
            textBox_tenchatlieu.Text = "";
        }

        private void FilldgvChatLieu()
        {
            DataTable dtChatLieu = dtProcessor.GetDataTable("select * from tblChatlieu");
            dataGridView_chatlieu.DataSource = dtChatLieu;
        }

        private void button_themmoi_Click(object sender, EventArgs e)
        {
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_luu.Enabled = true;
            button_boqua.Enabled = true;

            ResetForm();
        }

        private void button_boqua_Click(object sender, EventArgs e)
        {
            button_themmoi.Enabled = true;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_luu.Enabled = false;
            button_boqua.Enabled = false;

            textBox_machatlieu.Enabled = true;

            ResetForm();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (button_themmoi.Enabled)
            {
                if (textBox_machatlieu.Text == "" || textBox_tenchatlieu.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dtmatrung = dtProcessor.GetDataTable($"select * from tblChatlieu where MaChatLieu = '{textBox_machatlieu.Text}'");
                if (dtmatrung.Rows.Count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dtProcessor.UpdateData($"insert into tblChatlieu values ('{textBox_machatlieu.Text}'," +
                    $"'{textBox_tenchatlieu.Text}')");

                FilldgvChatLieu();
            }
            else if (button_sua.Enabled)
            {
                if (textBox_machatlieu.Text == "" || textBox_tenchatlieu.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //DataTable dtmatrung = dtProcessor.GetDataTable($"select * from tblHang where MaHang = '{textBox_machatlieu.Text}'");
                //if (dtmatrung.Rows.Count > 0)
                //{
                //    if (textBox_machatlieu.Text != maHangGlobal)
                //    {
                //        MessageBox.Show("Không được nhập trùng Mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}

                textBox_machatlieu.Enabled = false;

                dtProcessor.UpdateData($"update tblChatlieu set " +
                    $"TenHang = '{textBox_tenchatlieu.Text}'");

                FilldgvChatLieu();

                textBox_machatlieu.Enabled = true;
            }
        }

        private void dataGridView_chatlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_themmoi.Enabled = false;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_luu.Enabled = false;
            button_boqua.Enabled = true;

            ResetForm();

            DataGridViewRow row = dataGridView_chatlieu.CurrentRow;

            textBox_machatlieu.Text = row.Cells["MaChatLieu"].Value.ToString();
            textBox_tenchatlieu.Text = row.Cells["TenChatLieu"].Value.ToString();

            maChatLieuGlobal = textBox_machatlieu.Text;
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            button_themmoi.Enabled = false;
            button_sua.Enabled = true;
            button_xoa.Enabled = false;
            button_luu.Enabled = true;
            button_boqua.Enabled = true;
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            button_themmoi.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = true;
            button_luu.Enabled = true;
            button_boqua.Enabled = true;

            if (MessageBox.Show($"Bạn có muốn xóa {textBox_machatlieu} ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtProcessor.UpdateData($"delete from tblChatlieu where MaHang = '{textBox_machatlieu.Text}'");

                FilldgvChatLieu();
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
