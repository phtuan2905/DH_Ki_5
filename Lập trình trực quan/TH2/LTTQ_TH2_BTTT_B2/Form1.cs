using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LTTQ_TH2_BTTT_B2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Thoat(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void button_themmoi_Click(object sender, EventArgs e)
        {
            textBox_hoten.Text = "";
            radioButton_cangay.Checked = false;
            radioButton_nuangay.Checked = false;
            textBox_giaduthuyen.Text = "";
            comboBox_douong.SelectedItem = null;
            comboBox_soluong.SelectedItem = null;
            textBox_tien.Text = "";
        }

        Dictionary<string, double> douong = new Dictionary<string, double>()
        {
            {"Coca cola", 0.5},
            {"Pepsi", 0.8},
            {"Seven up", 1},
        };

        private void radioButton_cangay_Click(object sender, EventArgs e)
        {
            textBox_giaduthuyen.Text = "200";
        }

        private void radioButton_nuangay_Click(object sender, EventArgs e)
        {
            textBox_giaduthuyen.Text = "100";
        }

        private void comboBox_douong_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhDoUongTien();
        }

        private void comboBox_soluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhDoUongTien();
        }

        private void TinhDoUongTien()
        {
            if (comboBox_soluong.SelectedItem == null || comboBox_douong.SelectedItem == null)
            {
                return;
            }

            double tongtien = douong[comboBox_douong.SelectedItem.ToString()] * double.Parse(comboBox_soluong.SelectedItem.ToString());

            textBox_tien.Text = tongtien.ToString();
        }

        private void button_themvaods_Click(object sender, EventArgs e)
        {
            if (textBox_hoten.Text == null || textBox_hoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox_giaduthuyen.Text == null || textBox_giaduthuyen.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giờ thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string giothue = radioButton_cangay.Checked ? "Cả Ngày" : "Nửa Ngày";

            string khTxt = textBox_hoten.Text + " | "
                            + giothue + " | "
                            + textBox_giaduthuyen.Text + "$" + " | "
                            + "Đồ Uống " + (textBox_tien.Text == "" ? "0" : textBox_tien.Text) + "$" + " | "
                            + "Tổng " + (double.Parse(textBox_tien.Text == "" ? "0" : textBox_tien.Text) + int.Parse(textBox_giaduthuyen.Text));

            listBox_dskh.Items.Add(khTxt);
        }
    }
}
