using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_TH4_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();

        private void HienChiTiet(bool hien)
        {
            textBox_maspchitiet.Enabled = hien;
            textBox_tenspchitiet.Enabled = hien;
            dateTimePicker_ngaysx.Enabled = hien;
            dateTimePicker_ngayhh.Enabled = hien;
            textBox_donvi.Enabled = hien;
            textBox_dongia.Enabled = hien;
            textBox_ghichu.Enabled = hien;

            button_luu.Enabled = hien;
            button_huy.Enabled = hien;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtbase.DataReader("Select * from tblMatHang");
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            HienChiTiet(false);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            label_quanlysanpham.Text = "TÌM KIẾM MẶT HÀNG";
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            string sql = "SELECT * FROM tblMatHang where MaSP is not null ";
            if (textBox_masp.Text.Trim() != "")
            {
                sql += " and MaSP like '%" + textBox_masp.Text + "%'";
            }
            if (textBox_tensp.Text.Trim() != "")
            {
                sql += " AND TenSP like N'%" + textBox_tensp.Text + "%'";
            }
            dataGridView1.DataSource = dtbase.DataReader(sql);
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_them.Enabled = false;
            try
            {
                textBox_maspchitiet.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_tenspchitiet.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker_ngaysx.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
                dateTimePicker_ngayhh.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
                textBox_donvi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox_dongia.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox_ghichu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void XoaTrangChiTiet()
        {
            textBox_maspchitiet.Text = "";
            textBox_tenspchitiet.Text = "";
            dateTimePicker_ngaysx.Value = DateTime.Today;
            dateTimePicker_ngayhh.Value = DateTime.Today;
            textBox_donvi.Text = "";
            textBox_dongia.Text = "";
            textBox_ghichu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            label_quanlysanpham.Text = "THÊM MẶT HÀNG";
            XoaTrangChiTiet();
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            HienChiTiet(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            label_quanlysanpham.Text = "CẬP NHẬT MẶ HÀNG";
            button_them.Enabled = false;
            button_xoa.Enabled = false;
            HienChiTiet(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn  có  chắc  chắn  xóa  mã  mặt  hàng  " + textBox_maspchitiet.Text + " không ? Nếu  có  ấn  nút  Lưu, không  thì  ấn  nút  Hủy", "Xóa  sản  phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                label_quanlysanpham.Text = "XÓA MẶT HÀNG";
                button_them.Enabled = false;
                button_sua.Enabled = false;
                HienChiTiet(true);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra tên sản phầm có bị để trống không
            if (textBox_tenspchitiet.Text.Trim() == "")
            {
                errChiTiet.SetError(textBox_tenspchitiet, "Bạn không để trống tên sản phẩm!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm  tra  ngày  sản  xuất,  lỗi  nếu  người  sử  dụng  nhập  vào  ngày  sản  xuất  lớn  hơn ngày hiện tại
            if (dateTimePicker_ngaysx.Value > DateTime.Now)
            {
                errChiTiet.SetError(dateTimePicker_ngaysx, "Ngày sản xuất không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm tra ngày hết hạn xem có lớn hơn ngày sản xuất không
            if (dateTimePicker_ngayhh.Value < dateTimePicker_ngayhh.Value)
            {
                errChiTiet.SetError(dateTimePicker_ngayhh, "Ngay  hết  hạn  nhỏ  hơn  ngày  sản  xuất!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm  tra   đơn vị  xem có  để trống  không  
            if (textBox_donvi.Text.Trim() == "")
            {
                errChiTiet.SetError(textBox_donvi, "Bạn  không  để  trống  đơn  vi!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Kiểm  tra  đơn  giá  
            if (textBox_dongia.Text.Trim() == "")
            {
                errChiTiet.SetError(textBox_dongia, "Bạn  không  để  trống  đơn  giá!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            //Nếu  nút Thêm  enable  thì  thực  hiện thêm  mới  
            //Dùng  ký  tự  N'  trước mỗi giá  trị kiểu  text để  insert giá  trị có  dấu tiếng  việt vào  CSDL được  đúng 
            if (button_them.Enabled == true)
            {  //Kiểm  tra  xem  ô  nhập  MaSP  có  bị  trống  không  if
                if (textBox_maspchitiet.Text.Trim() == "")
                {
                    errChiTiet.SetError(textBox_maspchitiet, "Bạn  không  để  trống  mã  sản phẩm  trường  này!");
                    return;
                }
                else
                {  //Kiểm  tra  xem  mã  sản  phẩm  đã  tồn  tại  chưa  đẻ  tránh việc  insert  mới  bị  lỗi  
                    sql = "Select  *  From  tblMatHang  Where  MaSP  ='" + textBox_maspchitiet.Text + "'";
                    DataTable dtSP = dtbase.DataReader(sql);
                    if (dtSP.Rows.Count > 0)
                    {
                        errChiTiet.SetError(textBox_maspchitiet, "Mã sản phẩm trùng trong cơ sở dữ liệu");
                        return;
                    }
                    errChiTiet.Clear();
                }
                //Insert vao CSDL
                sql = "INSERT  INTO  tblMatHang(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu) VALUES(";
                sql += "N'" + textBox_maspchitiet.Text + "',N'" + textBox_tenspchitiet.Text + "','" + dateTimePicker_ngaysx.Value.Date + "','" +
                    dateTimePicker_ngayhh.Value.Date + "',N'" + textBox_donvi.Text + "',N'" + textBox_dongia.Text + "',N'" + textBox_ghichu.Text + "')";
            }
            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (button_sua.Enabled == true)
            {
                sql = "Update tblMatHang SET ";
                sql += "TenSP = N'" + textBox_tenspchitiet.Text + "',";
                sql += "NgaySX = '" + dateTimePicker_ngaysx.Value.Date + "',";
                sql += "NgayHH = '" + dateTimePicker_ngayhh.Value.Date + "',";
                sql += "DonVi = N'" + textBox_donvi.Text + "',";
                sql += "DonGia = '" + textBox_dongia.Text + "',";
                sql += "GhiChu = N'" + textBox_ghichu.Text + "' ";
                sql += "Where MaSP = N'" + textBox_maspchitiet.Text + "'";
            }
            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (button_xoa.Enabled == true)
            {
                sql = "Delete From tblMatHang Where MaSP =N'" + textBox_maspchitiet.Text + "'";
            }
            dtbase.DataChange(sql);
            //Cap nhat lai DataGrid
            sql = "Select * from tblMatHang";
            dataGridView1.DataSource = dtbase.DataReader(sql);
            //Ẩn hiện các nút phù hợp chức năng
            HienChiTiet(false);
            button_sua.Enabled = false;
            button_xoa.Enabled = false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            button_xoa.Enabled = false;
            button_sua.Enabled = false;
            button_them.Enabled = true;
            //xoa trang chi tiết
            XoaTrangChiTiet();
            //Cam nhap vào groupBox chi tiết
            HienChiTiet(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

    }
}
