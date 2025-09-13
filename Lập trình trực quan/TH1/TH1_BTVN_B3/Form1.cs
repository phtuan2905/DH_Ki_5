using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH1_BTVN_B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_kq_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_giaipt_Click(object sender, EventArgs e)
        {
            if (txt_a.Text.Length == 0 || txt_b.Text.Length == 0 || txt_c.Text.Length == 0)
            {
                label_canhbao.Text = "Nhập thiếu thông tin";
            }
            if (double.TryParse(txt_a.Text, out double a) && double.TryParse(txt_b.Text, out double b) && double.TryParse(txt_c.Text, out double c))
            {
                txt_kq.Text = GiaiPtBac2(a, b, c);
            }
            else
            {
                label_canhbao.Text = "Thông tin phải là số";
            }
        }

        private string GiaiPtBac2(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return c == 0 ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -c / b;
                    return $"Phương trình bậc nhất, nghiệm x = {x}";
                }
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                return "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Phương trình có nghiệm kép x = {x}";
            }
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-b + sqrtDelta) / (2 * a);
                double x2 = (-b - sqrtDelta) / (2 * a);
                return $"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
            }
        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            txt_a.Text = "";
            txt_b.Text = "";
            txt_c.Text = "";
            txt_kq.Text = "";
            label_canhbao.Text = "";
            txt_a.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
