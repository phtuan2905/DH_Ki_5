using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_TH2_BTTT_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Thoat(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void button_thoat_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        Dictionary<string, int> bangtinchi = new Dictionary<string, int>()
        {
            { "Tin hoc dai cuong", 2 },
            { "Giai tich F1", 3 },
            { "Tieng Anh A0", 3 },
            { "Triet hoc Mac_Lenin", 2 },
            { "Vat ly F1", 3 },
        };

        class MonHoc
        {
            public string tenMH;
            public int soTinChi;
            public double diemso;
            public MonHoc(string tenMH, int soTinChi, double diemso)
            {
                this.tenMH = tenMH;
                this.soTinChi = soTinChi;
                this.diemso = diemso;
            }
        }

        List<MonHoc> dsMonHoc = new List<MonHoc>();

        private void comboBox_tenmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_sotinchi.Text = bangtinchi[comboBox_tenmonhoc.SelectedItem.ToString()].ToString();
        }

        private void button_themvaods_Click(object sender, EventArgs e)
        {
            if (textBox_sotinchi.Text == null || textBox_sotinchi.Text == "")
            {
                MessageBox.Show("Chọn 1 môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string diemTxt = textBox_diem.Text;
            double diem = 0;
            bool diemHopLe = true;

            if (int.TryParse(diemTxt, out int diemInt))
            {
                diem = diemInt;
            }
            else if (double.TryParse(diemTxt, out double diemDouble))
            {
                diem = diemDouble;
            }
            else 
            {
                diemHopLe = false;
            }

            if (diem < 0 || diem > 10)
            {
                diemHopLe = false;
            } 

            if (!diemHopLe)
            {
                MessageBox.Show("Điểm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dsMonHoc.Add(new MonHoc(comboBox_tenmonhoc.SelectedItem.ToString(), int.Parse(textBox_sotinchi.Text), diem * int.Parse(textBox_sotinchi.Text)));
                string monhocTxt = comboBox_tenmonhoc.SelectedItem.ToString() + "-" + textBox_sotinchi.Text + "-" + diemTxt;
                listBox_dsmonhoc.Items.Add(monhocTxt);
            }
        }

        private void button_tinh_Click(object sender, EventArgs e)
        {
            if (dsMonHoc.Count == 0)
            {
                MessageBox.Show("Thêm môn học vào danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double tongsotinchi = 0;
                double tongsodiem = 0;
                foreach (MonHoc mh in dsMonHoc)
                {
                    tongsotinchi += mh.soTinChi;
                    tongsodiem += mh.diemso;
                }

                textBox_tongsotinchi.Text = tongsotinchi.ToString();
                textBox_tongsodiem.Text = tongsodiem.ToString();
                textBox_diemtrungbinh.Text = (tongsodiem / tongsotinchi).ToString();
            }
        }
    }
}
