using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH1_BTVN_B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {
            double x1 = 0f;
            double y1 = 0f;
            double x2 = 0f;
            double y2 = 0f;
            if (double.TryParse(txt_x1.Text, out x1) && double.TryParse(txt_y1.Text, out y1) && double.TryParse(txt_x2.Text, out x2) && double.TryParse(txt_y2.Text, out y2))
            {
                txt_hsg.Text = TinhHeSoGoc(x1, y1, x2, y2).ToString();
                txt_kc.Text = TinhKhoangCach(x1, y1, x2, y2).ToString();
            }
            else
            {
                txt_hsg.Text = "Khong the tinh";
                txt_kc.Text = "Khong the tinh";
                return;
            }
        }

        private double TinhHeSoGoc(double x1, double y1, double x2, double y2)
        {
            return (y2 - y1) / (x2 - x1);
        }

        private double TinhKhoangCach(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) +  Math.Pow(y2 - y1, 2));
        }

        private void txt_x1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
