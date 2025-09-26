using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_TH3_B4
{
    public partial class BTDienTu : Form
    {
        public BTDienTu()
        {
            InitializeComponent();
        }

        public BTDienTu(BaiTapDienTu baiTapDienTu)
        {
            InitializeComponent();
            richTextBox_debai.Text = baiTapDienTu.Debai;
            bt = baiTapDienTu;
        }

        BaiTapDienTu bt = new BaiTapDienTu();

        private void BTDienTu_Load(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            int diem = 0;

            if (textBox1.Text == bt.Dapantungcau[0])
            {
                textBox1.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text == bt.Dapantungcau[1])
            {
                textBox2.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == bt.Dapantungcau[2])
            {
                textBox3.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text == bt.Dapantungcau[3])
            {
                textBox4.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if (textBox5.Text == bt.Dapantungcau[4])
            {
                textBox5.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }

            if (textBox6.Text == bt.Dapantungcau[5])
            {
                textBox6.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }

            if (textBox7.Text == bt.Dapantungcau[6])
            {
                textBox7.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }

            if (textBox8.Text == bt.Dapantungcau[7])
            {
                textBox8.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox8.BackColor = Color.Red;
            }

            if (textBox9.Text == bt.Dapantungcau[8])
            {
                textBox9.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox9.BackColor = Color.Red;
            }

            if (textBox10.Text == bt.Dapantungcau[9])
            {
                textBox10.BackColor = Color.Green;
                diem++;
            }
            else
            {
                textBox10.BackColor = Color.Red;
            }

            MessageBox.Show("Điểm của bạn là: " + diem);
        }

        private void button_dapan_Click(object sender, EventArgs e)
        {
            richTextBox_debai.Text = bt.Dapan;
        }

        private void button_lamlai_Click(object sender, EventArgs e)
        {
            richTextBox_debai.Text = bt.Debai;

            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.Text = "";
            textBox2.BackColor = Color.White;
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.BackColor = Color.White;
            textBox5.Text = "";
            textBox5.BackColor = Color.White;
            textBox6.Text = "";
            textBox6.BackColor = Color.White;
            textBox7.Text = "";
            textBox7.BackColor = Color.White;
            textBox8.Text = "";
            textBox8.BackColor = Color.White;
            textBox9.Text = "";
            textBox9.BackColor = Color.White;
            textBox10.Text = "";
            textBox10.BackColor = Color.White;
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
