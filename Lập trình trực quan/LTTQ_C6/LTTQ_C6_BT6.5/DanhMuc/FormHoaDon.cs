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
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = dtProcessor.GetDataTable("select MaNhanVien from tblNhanvien");
            Functions.FillComboBox(comboBox_manhanvien, dtNhanVien, "MaNhanVien", "MaNhanVien");
            comboBox_manhanvien.SelectedIndex = -1;

            DataTable dtKhachHang = dtProcessor.GetDataTable("select MaKhachHang from tblKhach");
            Functions.FillComboBox(comboBox_makhachhang, dtKhachHang, "MaKhach", "MaKhach");
            comboBox_makhachhang.SelectedIndex = -1;

            DataTable dtHang = dtProcessor.GetDataTable("select MaHang from tblHang");
            Functions.FillComboBox(comboBox_mahang, dtHang, "MaHang", "MaHang");
            comboBox_mahang.SelectedIndex = -1;

            DataTable dtHoaDon = dtProcessor.GetDataTable("select MaHDBan from tblHDBan");
            Functions.FillComboBox(comboBox_mahoadon, dtHoaDon, "MaHDBan", "MaHDBan");
            comboBox_mahoadon.SelectedIndex = -1;
        }

        private void comboBox_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtNhanVien = dtProcessor.GetDataTable($"select TenNhanVien from tblNhanvien where MaNhanVien = '{comboBox_manhanvien.SelectedValue.ToString()}'");
            textBox_tennhanvien.Text =  dtNhanVien.Rows[0]["TenNhanVien"].ToString(); 
        }

        private void comboBox_makhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtKhachHang = dtProcessor.GetDataTable($"select * from tblKhach where MaKhach = '{comboBox_makhachhang.SelectedValue.ToString()}'");
            textBox_tenkhachhang.Text = dtKhachHang.Rows[0]["TenKhach"].ToString();
            textBox_diachi.Text = dtKhachHang.Rows[0]["DiaChi"].ToString();
            textBox_dienthoai.Text = dtKhachHang.Rows[0]["DienThoai"].ToString();
        }

        private void comboBox_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtHang = dtProcessor.GetDataTable($"select * from tblHang where MaHang = '{comboBox_mahang.SelectedValue.ToString()}'");
            textBox_tenhang.Text = dtHang.Rows[0]["TenHang"].ToString();
            textBox_dongia.Text = dtHang.Rows[0]["DonGiaBan"].ToString();
        }
    }
}
