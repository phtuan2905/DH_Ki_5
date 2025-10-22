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
    public partial class FormHoaDon : Form
    {
        Classes.DataProcessor dtProcessor = new Classes.DataProcessor();
        private DataTable dtHang;

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FillDgv()
        {
            DataTable dtHD = dtProcessor.GetDataTable($"select * from tblChiTietHDBan where MaHDBan = '{textBox_mahoadon.Text}'");
            dataGridView_hoadon.DataSource = dtHD;
            TinhTongTien(dtHD);
        }

        private void ClearForm()
        {
            textBox_mahoadon.Text = string.Empty;
            dateTimePicker_ngayban.Text = string.Empty;
            comboBox_makhachhang.SelectedIndex = -1;
            textBox_tenkhachhang.Text = string.Empty;
            textBox_diachi.Text = string.Empty;
            textBox_dienthoai.Text = string.Empty;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = dtProcessor.GetDataTable("select MaNhanVien from tblNhanvien");
            Functions.FillComboBox(comboBox_manhanvien, dtNhanVien, "MaNhanVien", "MaNhanVien");
            comboBox_manhanvien.SelectedIndex = -1;

            DataTable dtKhachHang = dtProcessor.GetDataTable("select MaKhach from tblKhach");
            Functions.FillComboBox(comboBox_makhachhang, dtKhachHang, "MaKhach", "MaKhach");
            comboBox_makhachhang.SelectedIndex = -1;

            DataTable dtHang = dtProcessor.GetDataTable("select MaHang from tblHang");
            Functions.FillComboBox(comboBox_mahang, dtHang, "MaHang", "MaHang");
            comboBox_mahang.SelectedIndex = -1;

            DataTable dtHoaDon = dtProcessor.GetDataTable("select MaHDBan from tblHDBan");
            Functions.FillComboBox(comboBox_mahoadon, dtHoaDon, "MaHDBan", "MaHDBan");
            comboBox_mahoadon.SelectedIndex = -1;

            comboBox_manhanvien.Text = GlobalData.manv;
        }

        private void comboBox_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_manhanvien.SelectedIndex == -1)
            {
                return;
            }
            DataTable dtNhanVien = dtProcessor.GetDataTable($"select TenNhanVien from tblNhanvien where MaNhanVien = '{comboBox_manhanvien.Text}'");
            if (dtNhanVien.Rows.Count > 0)
            textBox_tennhanvien.Text =  dtNhanVien.Rows[0]["TenNhanVien"].ToString(); 
        }

        private void comboBox_makhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_makhachhang.SelectedIndex == -1)
            {
                return;
            }

            DataTable dtKhachHang = dtProcessor.GetDataTable($"select * from tblKhach where MaKhach = '{comboBox_makhachhang.Text}'");
            if (dtKhachHang.Rows.Count > 0)
            {
                textBox_tenkhachhang.Text = dtKhachHang.Rows[0]["TenKhach"].ToString();
                textBox_diachi.Text = dtKhachHang.Rows[0]["DiaChi"].ToString();
                textBox_dienthoai.Text = dtKhachHang.Rows[0]["DienThoai"].ToString();
            }
        }

        private void comboBox_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_mahang.SelectedIndex == -1)
            {
                return;
            }
            dtHang = dtProcessor.GetDataTable($"select * from tblHang where MaHang = '{comboBox_mahang.Text}'");
            if (dtHang.Rows.Count > 0)
            {
                textBox_tenhang.Text = dtHang.Rows[0]["TenHang"].ToString();
                textBox_dongia.Text = dtHang.Rows[0]["DonGiaBan"].ToString();
            }
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox_mahoadon.Text.ToString());
            DataTable dtHoaDon = dtProcessor.GetDataTable($"select * from tblHDBan where MaHDBan = '{comboBox_mahoadon.Text}'");
            if (dtHoaDon.Rows.Count > 0)
            {
                textBox_mahoadon.Text = dtHoaDon.Rows[0]["MaHDBan"].ToString();
                dateTimePicker_ngayban.Text = dtHoaDon.Rows[0]["NgayBan"].ToString();
                comboBox_manhanvien.Text = dtHoaDon.Rows[0]["MaNhanVien"].ToString();
                comboBox_makhachhang.Text = dtHoaDon.Rows[0]["MaKhach"].ToString();
            }
            DataTable dtCTHoaDon = dtProcessor.GetDataTable($"select * from tblChiTietHDBan where MaHDBan = '{comboBox_mahoadon.Text}'");
            if (dtCTHoaDon.Rows.Count > 0)
            {
                FillDgv();
                dataGridView_hoadon.DataSource = dtCTHoaDon;
            }
        }

        private void button_themhoadon_Click(object sender, EventArgs e)
        {
            ClearForm();
            Guid randomUUID = Guid.NewGuid();
            Random random = new Random();
            textBox_mahoadon.Text = "HDB_" + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString() + "0" + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString();
            dateTimePicker_ngayban.Value = DateTime.Today;
            dataGridView_hoadon.DataSource = null;
        }

        private void button_khachhang_Click(object sender, EventArgs e)
        {
            FormKhachHang form = new FormKhachHang();
            form.ShowDialog();
;       }

        private void button_inhoadon_Click(object sender, EventArgs e)
        {
            if (textBox_mahoadon.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa thêm hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dateTimePicker_ngayban.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập ngày tạo hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBox_manhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (textBox_tennhanvien.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBox_makhachhang.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox_dienthoai.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dtProcessor.UpdateData($"insert into tblHDBan values" +
                $"('{textBox_mahoadon.Text}'," +
                $"'{comboBox_manhanvien.Text}'," +
                $"'{dateTimePicker_ngayban.Value.Year.ToString() + "-" + dateTimePicker_ngayban.Value.Month.ToString() + "-" + dateTimePicker_ngayban.Value.Day.ToString()}'," +
                $"'{comboBox_makhachhang.Text}'," +
                $"{(textBox_tongtien.Text == string.Empty ? "0" : textBox_tongtien.Text)})");
        }

        private void textBox_dienthoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                DataTable dtKhachHang = dtProcessor.GetDataTable($"select * from tblKhach where DienThoai = '{textBox_dienthoai.Text}'");
                if (dtKhachHang.Rows.Count > 0)
                {
                    comboBox_makhachhang.Text = dtKhachHang.Rows[0]["MaKhach"].ToString();
                    textBox_tenkhachhang.Text = dtKhachHang.Rows[0]["TenKhach"].ToString();
                    textBox_diachi.Text = dtKhachHang.Rows[0]["DiaChi"].ToString();
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void textBox_dienthoai_Leave(object sender, EventArgs e)
        {
            DataTable dtKhachHang = dtProcessor.GetDataTable($"select * from tblKhach where DienThoai = '{textBox_dienthoai.Text}'");
            if (dtKhachHang.Rows.Count > 0)
            {
                comboBox_makhachhang.Text = dtKhachHang.Rows[0]["MaKhach"].ToString();
                textBox_tenkhachhang.Text = dtKhachHang.Rows[0]["TenKhach"].ToString();
                textBox_diachi.Text = dtKhachHang.Rows[0]["DiaChi"].ToString();
            }
            else
            {
                MessageBox.Show("Khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void textBox_soluong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThanhTien();
            }
        }

        private void textBox_soluong_Leave(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void textBox_giamgia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThanhTien();
            }
        }

        private void textBox_giamgia_Leave(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private bool ThanhTien()
        {

            if (int.TryParse(textBox_soluong.Text, out int soluong))
            {
                if (soluong < 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Số lượng phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            if (int.Parse(dtHang.Rows[0]["SoLuong"].ToString()) < soluong)
            {
                MessageBox.Show($"Số lượng trong kho của món hàng chỉ còn {dtHang.Rows[0]["SoLuong"].ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (int.TryParse(textBox_giamgia.Text, out int giamgia))
            {
                if (giamgia < 0 || giamgia > 100)
                {
                    MessageBox.Show("Giảm giá phải trong khoảng 0% đến 100%", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                if (textBox_giamgia.Text == string.Empty)
                {
                    giamgia = 0;
                }
                else
                {
                    MessageBox.Show("Giảm giá phải là số nguyên dương trong khoảng 0% đến 100%", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            float tongTien = (float)soluong * float.Parse(textBox_dongia.Text);

            textBox_thanhtien.Text = (tongTien - ((float)giamgia / 100f) * tongTien).ToString();
            return true;
        }

        private void button_luu_Click(object sender, EventArgs e)
        {

            DataTable dtHoaDon = dtProcessor.GetDataTable($"select * from tblHDBan where MaHDBan = '{textBox_mahoadon.Text}'");
            if (dtHoaDon.Rows.Count == 0 )
            {
                MessageBox.Show("Chưa in hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBox_mahang.SelectedIndex == -1 )
            {
                MessageBox.Show("Chưa in hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ThanhTien())
            {
                return;
            }

            DataTable dtHang = dtProcessor.GetDataTable($"select * from tblChiTietHDBan where MaHang = '{comboBox_mahang.Text}'");
            if (dtHang.Rows.Count > 0)
            {
                DeleteHangFromCTHD(comboBox_mahang.Text, comboBox_mahoadon.Text);
            }

            dtProcessor.UpdateData($"insert into tblChiTietHDBan values" +
                $"('{textBox_mahoadon.Text}'," +
                $"'{comboBox_mahang.Text}'," +
                $"{textBox_soluong.Text.ToString()}," +
                $"{textBox_dongia.Text.ToString()}," +
                $"{(textBox_giamgia.Text == string.Empty ? "0" : textBox_giamgia.Text)}," +
                $"{textBox_thanhtien.Text})");

            dtProcessor.UpdateData($"update tblHang set SoLuong = SoLuong - {textBox_soluong.Text} where MaHang = '{comboBox_mahang.Text}'");

            FillDgv();
        }
   
        private void TinhTongTien(DataTable dt)
        {
            double tongtien = 0;
            foreach (DataRow dr in dt.Rows)
            {
                tongtien += double.Parse(dr["ThanhTien"].ToString());
            }

            textBox_tongtien.Text = tongtien.ToString();
        }

        private void dataGridView_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView_hoadon.CurrentRow;

            DeleteHangFromCTHD(row.Cells["MaHang"].Value.ToString(), row.Cells["MaHDBan"].Value.ToString());

            FillDgv();
        }

        private void DeleteHangFromCTHD(string mahang, string mahdban)
        {
            dtProcessor.UpdateData($"delete from tblChiTietHDBan where MaHang = '{mahang}' and MaHDBan = '{mahdban}'");
        }

        private void button_huyhoadon_Click(object sender, EventArgs e)
        {
            if (comboBox_mahoadon.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dtHoadon = dtProcessor.GetDataTable($"select * from tblHDBan where MaHDBan = '{comboBox_mahoadon.Text}'");

            if (dtHoadon.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach(DataGridViewRow row in dataGridView_hoadon.Rows )
            {
                DeleteHangFromCTHD(row.Cells["MaHang"].Value.ToString(), row.Cells["MaHDBan"].Value.ToString());
            }

            dtProcessor.UpdateData($"delete from tblHDBan where MaHDBan = '{comboBox_mahoadon.Text}'");

            ClearForm();

            FillDgv();
        }
    }
}
