using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_TrenLop_BT11_tr72
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_dsmathang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_dsmathang_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_hangdatmua.Items.Contains(listBox_dsmathang.Items[listBox_dsmathang.SelectedIndex]))
            {
                MessageBox.Show("Bạn đã chọn mua " + listBox_dsmathang.Items[listBox_dsmathang.SelectedIndex] + " rồi!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                listBox_hangdatmua.Items.Add(listBox_dsmathang.Items[listBox_dsmathang.SelectedIndex]);
            }
        }

        private void listBox_hangdatmua_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + listBox_dsmathang.Items[listBox_dsmathang.SelectedIndex] + " ko?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                listBox_hangdatmua.Items.RemoveAt(listBox_hangdatmua.SelectedIndex);
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_dongy_Click(object sender, EventArgs e)
        {
            if (textBox_hoten.Text == null || textBox_hoten.Text.Length == 0)
            {
                MessageBox.Show("Không được để họ tên trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox_dienthoai.Text == null || textBox_dienthoai.Text.Length == 0)
            {
                MessageBox.Show("Không được để số điện thoại trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> dsptll = new List<string>();
            if (checkBox_dienthoai.Checked)
            {
                dsptll.Add(checkBox_dienthoai.Text);
            }

            if (checkBox_fax.Checked)
            {
                dsptll.Add(checkBox_fax.Text);
            }

            if (checkBox_email.Checked)
            {
                dsptll.Add(checkBox_email.Text);
            }

            if (dsptll.Count == 0)
            {
                MessageBox.Show("Không được để phương thức liên lạc trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string hdm = "";
            foreach (string item in listBox_hangdatmua.Items)
            {
                hdm += "- " + item + "/n";
            }

            string ptll = "";
            foreach (string item in dsptll)
            {
                ptll += "" + item + ",";
            }

            MessageBox.Show("Họ tên khách hàng: " + textBox_hoten.Text
                + "/nĐiện thoại: " + textBox_dienthoai.Text 
                + "/nDanh sách hàng đặt mua:"
                + hdm
                , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
