using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTTQ_C6_BT6_5.DanhMuc;

namespace LTTQ_C6_BT6_5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHangHoa formHangHoa = new FormHangHoa();
            formHangHoa.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChatLieu form = new FormChatLieu();
            form.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang form = new FormKhachHang();
            form.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien form = new FormNhanVien();
            form.Show();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon form = new FormHoaDon();
            form.Show();
        }
    }
}
