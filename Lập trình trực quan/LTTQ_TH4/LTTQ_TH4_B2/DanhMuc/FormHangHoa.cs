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
using LTTQ_TH4_B2.Classes;
using LTTQ_TH4_B2;

namespace LTTQ_TH4_B2
{
    public partial class FormHangHoa : Form
    {
        Classes.DataProcessor dtProcessor = new Classes.DataProcessor();
        string imgPath = "";
        string maHangGlobal = "";

        public FormHangHoa()
        {
            InitializeComponent();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtHangHoa = dtProcessor.GetDataTable("select * from tblHang");
            dataGridView_hanghoa.DataSource = dtHangHoa;

            dtHangHoa.Dispose();

            button_luu.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_boqua.Enabled = false;

            label_xinchao.Text = "Xin chào " + GlobalData.username;
        }

        private void ResetForm()
        {
            textBox_mahang.Text = "";
            textBox_tenhang.Text = "";
            comboBox_chatlieu.SelectedIndex = -1;
            textBox_soluong.Text = "";
            textBox_dongianhap.Text = "";
            textBox_dongiaban.Text = "";
            textBox_ghichu.Text = "";
            pictureBox_anh.Image = null;
        }

        private void FilldgvHangHoa()
        {
            DataTable dtHangHoa = dtProcessor.GetDataTable("select * from tblHang");
            dataGridView_hanghoa.DataSource = dtHangHoa;
        }

        private void button_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images|*.bmp|All files|*.*";
            fileDialog.InitialDirectory = Application.StartupPath;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_anh.Image = Image.FromFile(fileDialog.FileName);
                imgPath = Path.GetFileName(fileDialog.FileName.ToString());
            }
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

            textBox_mahang.Enabled = true;

            ResetForm();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (button_themmoi.Enabled)
            {
                if (textBox_mahang.Text == "" || textBox_tenhang.Text == "" || comboBox_chatlieu.SelectedItem == null || textBox_soluong.Text == "" || textBox_dongianhap.Text == "" || textBox_dongiaban.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!int.TryParse(textBox_soluong.Text, out int soluong))
                {
                    MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (soluong < 0)
                    {
                        MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (!float.TryParse(textBox_dongianhap.Text, out float dongianhap))
                {
                    MessageBox.Show("Đơn giá nhập phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (dongianhap < 0)
                    {
                        MessageBox.Show("Đơn giá nhập phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (!float.TryParse(textBox_dongiaban.Text, out float dongiaban))
                {
                    MessageBox.Show("Đơn giá bán phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (dongiaban < 0)
                    {
                        MessageBox.Show("Đơn giá bán phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                DataTable dtmatrung = dtProcessor.GetDataTable($"select * from tblHang where MaHang = '{textBox_mahang.Text}'");
                if (dtmatrung.Rows.Count > 0)
                {
                    MessageBox.Show("Không được nhập trùng Mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dtProcessor.UpdateData($"insert into tblHang values ('{textBox_mahang.Text}'," +
                    $"'{textBox_tenhang.Text}'," +
                    $"'{comboBox_chatlieu.SelectedItem.ToString()}'," +
                    $"{textBox_soluong.Text}," +
                    $"{textBox_dongianhap.Text}," +
                    $"{textBox_dongiaban.Text})");

                FilldgvHangHoa();
            }
            else if (button_sua.Enabled)
            {
                if (textBox_mahang.Text == "" || textBox_tenhang.Text == "" || comboBox_chatlieu.SelectedItem == null || textBox_soluong.Text == "" || textBox_dongianhap.Text == "" || textBox_dongiaban.Text == "")
                {
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!int.TryParse(textBox_soluong.Text, out int soluong))
                {
                    MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (soluong < 0)
                    {
                        MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (!float.TryParse(textBox_dongianhap.Text, out float dongianhap))
                {
                    MessageBox.Show("Đơn giá nhập phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (dongianhap < 0)
                    {
                        MessageBox.Show("Đơn giá nhập phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (!float.TryParse(textBox_dongiaban.Text, out float dongiaban))
                {
                    MessageBox.Show("Đơn giá bán phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (dongiaban < 0)
                    {
                        MessageBox.Show("Đơn giá bán phải là số lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                //DataTable dtmatrung = dtProcessor.GetDataTable($"select * from tblHang where MaHang = '{textBox_mahang.Text}'");
                //if (dtmatrung.Rows.Count > 0)
                //{
                //    if (textBox_mahang.Text != maHangGlobal)
                //    {
                //        MessageBox.Show("Không được nhập trùng Mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}

                textBox_mahang.Enabled = false;

                dtProcessor.UpdateData($"update tblHang set " +
                    $"TenHang = '{textBox_tenhang.Text}'," +
                    $"ChatLieu = '{comboBox_chatlieu.SelectedItem.ToString()}'," +
                    $"SoLuong = {textBox_soluong.Text}," +
                    $"DonGiaNhap = {textBox_dongianhap.Text}," +
                    $"DonGiaBan = {textBox_dongiaban.Text}" +
                    $"where MaHang = '{textBox_mahang.Text}'");

                FilldgvHangHoa();

                textBox_mahang.Enabled = true;
            }
        }

        private void dataGridView_hanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_themmoi.Enabled = false;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_luu.Enabled = false;
            button_boqua.Enabled = true;

            ResetForm();

            DataGridViewRow row = dataGridView_hanghoa.CurrentRow;

            textBox_mahang.Text = row.Cells["MaHang"].Value.ToString();
            textBox_tenhang.Text = row.Cells["TenHang"].Value.ToString();
            textBox_soluong.Text = row.Cells["SoLuong"].Value.ToString();
            textBox_dongianhap.Text = row.Cells["DonGiaNhap"].Value.ToString();
            textBox_dongiaban.Text = row.Cells["DonGiaBan"].Value.ToString();

            //if (row.Cells["Anh"].Value.ToString() != "")
            //{
            //    string imgPath = Path.Combine(Application.StartupPath, "Images", "Hang", row.Cells["Anh"].Value.ToString());
            //    pictureBox_anh.Image = Image.FromFile(imgPath);
            //}

            comboBox_chatlieu.SelectedItem = row.Cells["ChatLieu"].Value.ToString();

            maHangGlobal = textBox_mahang.Text;
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

            if (MessageBox.Show($"Bạn có muốn xóa {textBox_mahang} ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtProcessor.UpdateData($"delete from tblHang where MaHang = '{textBox_mahang.Text}'");

                FilldgvHangHoa();
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
