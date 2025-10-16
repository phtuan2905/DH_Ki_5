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

namespace LTTQ_C6_BT6_5.DanhMuc
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

            DataTable dtNhanvien = dtProcessor.GetDataTable("select * from tblNhanvien");
            dataGridView_nhanvien.DataSource = dtNhanvien;

            dtNhanvien.Dispose();

            button_luu.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_boqua.Enabled = false;
        }

        Classes.DataProcessor dtProcessor = new Classes.DataProcessor();
        string MaNhanVienGlobal = "";

        private void ResetForm()
        {
            textBox_manhanvien.Text = "";
            textBox_tennhanvien.Text = "";
            textBox_diachi.Text = "";
            textBox_dienthoai.Text = "";
        }

        private void FilldgvNhanVien()
        {
            DataTable dtNhanvien = dtProcessor.GetDataTable("select * from tblNhanvien");
            dataGridView_nhanvien.DataSource = dtNhanvien;
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

            textBox_manhanvien.Enabled = true;

            ResetForm();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (button_themmoi.Enabled)
            {
                if (textBox_manhanvien.Text == "" || textBox_tennhanvien.Text == "" || textBox_diachi.Text == "" || textBox_dienthoai.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (IsValidVietnamPhone(textBox_dienthoai.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dtmatrung = dtProcessor.GetDataTable($"select * from tblNhanvien where MaNhanVien = '{textBox_manhanvien.Text}'");
                if (dtmatrung.Rows.Count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string gioitinh = "";

                if (radioButton_nam.Checked)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }

                dtProcessor.UpdateData($"insert into tblNhanvien values ('{textBox_manhanvien.Text}'," +
                    $"'{textBox_tennhanvien.Text}'," +
                    $"'{gioitinh}'," +
                    $"'{textBox_diachi.Text}'," +
                    $"'{textBox_dienthoai.Text}'," +
                    $"'{dateTimePicker_ngaysinh.Text}')");

                FilldgvNhanVien();
            }
            else if (button_sua.Enabled)
            {
                if (textBox_manhanvien.Text == "" || textBox_tennhanvien.Text == "" || textBox_diachi.Text == "" || textBox_dienthoai.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                if (IsValidVietnamPhone(textBox_dienthoai.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //DataTable dtmatrung = dtProcessor.GetDataTable($"select * from tblHang where MaHang = '{textBox_MaNhanVien.Text}'");
                //if (dtmatrung.Rows.Count > 0)
                //{
                //    if (textBox_MaNhanVien.Text != maHangGlobal)
                //    {
                //        MessageBox.Show("Không được nhập trùng Mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}
                string gioitinh = "";

                if (radioButton_nam.Checked)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nu";
                }

                textBox_manhanvien.Enabled = false;

                dtProcessor.UpdateData($"update tblNhanvien set " +
                    $"MaNhanVien = '{textBox_manhanvien.Text}'," +
                    $"TenNhanVien = '{textBox_tennhanvien.Text}," +
                    $"GioiTinh = '{gioitinh}'" +
                    $"DiaChi = '{textBox_diachi.Text}'," +
                    $"DienThoai = '{textBox_dienthoai.Text}'," +
                    $"NgaySinh = '{dateTimePicker_ngaysinh.Text}'");

                FilldgvNhanVien();

                textBox_manhanvien.Enabled = true;
            }
        }

        private void dataGridView_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_themmoi.Enabled = false;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_luu.Enabled = false;
            button_boqua.Enabled = true;

            ResetForm();

            DataGridViewRow row = dataGridView_nhanvien.CurrentRow;

            textBox_manhanvien.Text = row.Cells["MaNhanVien"].Value.ToString();
            textBox_tennhanvien.Text = row.Cells["TenNhanVien"].Value.ToString();
            textBox_diachi.Text = row.Cells["DiaChi"].Value.ToString();
            textBox_dienthoai.Text = row.Cells["DienThoai"].Value.ToString();
            dateTimePicker_ngaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
            
            if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                radioButton_nam.Checked = true;
            }
            else
            {
                radioButton_nu.Checked = true;
            }

            MaNhanVienGlobal = textBox_manhanvien.Text;
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

            if (MessageBox.Show($"Bạn có muốn xóa {textBox_manhanvien} ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtProcessor.UpdateData($"delete from tblNhanvien where MaNhanVien = '{textBox_manhanvien.Text}'");

                FilldgvNhanVien();
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
