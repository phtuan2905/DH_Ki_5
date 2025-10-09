using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_C6_BT6._5.DanhMuc
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        Classes.DataProcessor dtProcessor = new Classes.DataProcessor();
        string MaKhachGlobal = "";

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKhach = dtProcessor.GetDataTable("select * from tblKhach");
            dataGridView_khachhang.DataSource = dtKhach;

            dtKhach.Dispose();

            button_luu.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_boqua.Enabled = false;
        }

        private void ResetForm()
        {
            textBox_makhachhang.Text = "";
            textBox_tenkhachhang.Text = "";
            textBox_diachi.Text = "";
            textBox_dienthoai.Text = "";
        }

        private void FilldgvKhach()
        {
            DataTable dtKhach = dtProcessor.GetDataTable("select * from tblKhach");
            dataGridView_khachhang.DataSource = dtKhach;
        }

        public static bool IsValidVietnamPhone(string phone)
        {
            string pattern = @"^(?:\+84|84|0)(3|5|7|8|9)[0-9]{8}$";
            return Regex.IsMatch(phone, pattern);
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

            textBox_makhachhang.Enabled = true;

            ResetForm();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (button_themmoi.Enabled)
            {
                if (textBox_makhachhang.Text == "" || textBox_tenkhachhang.Text == "" || textBox_diachi.Text == "" || textBox_dienthoai.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (IsValidVietnamPhone(textBox_dienthoai.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dtmatrung = dtProcessor.GetDataTable($"select * from tblKhach where MaKhach = '{textBox_makhachhang.Text}'");
                if (dtmatrung.Rows.Count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dtProcessor.UpdateData($"insert into tblKhach values ('{textBox_makhachhang.Text}'," +
                    $"'{textBox_tenkhachhang.Text}'," +
                    $"'{textBox_diachi.Text}'," +
                    $"'{textBox_dienthoai.Text}')");

                FilldgvKhach();
            }
            else if (button_sua.Enabled)
            {
                if (textBox_makhachhang.Text == "" || textBox_tenkhachhang.Text == "" || textBox_diachi.Text == "" || textBox_dienthoai.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                if (IsValidVietnamPhone(textBox_dienthoai.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //DataTable dtmatrung = dtProcessor.GetDataTable($"select * from tblHang where MaHang = '{textBox_MaKhach.Text}'");
                //if (dtmatrung.Rows.Count > 0)
                //{
                //    if (textBox_MaKhach.Text != maHangGlobal)
                //    {
                //        MessageBox.Show("Không được nhập trùng Mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}

                textBox_makhachhang.Enabled = false;

                dtProcessor.UpdateData($"update tblKhach set " +
                    $"MaKhach = '{textBox_makhachhang.Text}'," +
                    $"TenKhach = '{textBox_tenkhachhang.Text}," +
                    $"DiaChi = '{textBox_diachi.Text}'," +
                    $"DienThoai = '{textBox_dienthoai.Text}'");

                FilldgvKhach();

                textBox_makhachhang.Enabled = true;
            }
        }

        private void dataGridView_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_themmoi.Enabled = false;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_luu.Enabled = false;
            button_boqua.Enabled = true;

            ResetForm();

            DataGridViewRow row = dataGridView_khachhang.CurrentRow;

            textBox_makhachhang.Text = row.Cells["MaKhach"].Value.ToString();
            textBox_tenkhachhang.Text = row.Cells["TenKhach"].Value.ToString();
            textBox_diachi.Text = row.Cells["DiaChi"].Value.ToString();
            textBox_dienthoai.Text = row.Cells["DienThoai"].Value.ToString();

            MaKhachGlobal = textBox_makhachhang.Text;
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

            if (MessageBox.Show($"Bạn có muốn xóa {textBox_makhachhang} ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtProcessor.UpdateData($"delete from tblKhach where MaKhach = '{textBox_makhachhang.Text}'");

                FilldgvKhach();
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
