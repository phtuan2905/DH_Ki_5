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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bàiĐiềnTừ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu();
            bt.Debai = "Last summer I decided to take a short (1)__ to the coast.\r\nI packed a small (2)__ with clothes and a camera, then booked a (3)__ for two nights.\r\nThe weather was perfect: sunny in the (4)__ and cool in the evenings.\r\nOn the first day I walked along the (5)__ and collected small shells.\r\nAt lunchtime I found a tiny café where the owner served fresh fish and a salad (6)__ with lemon.\r\nIn the afternoon I rented a (7)__ and explored a quiet bay.\r\nThat evening, people gathered on the beach to watch the (8)__ — it was beautiful.\r\nI felt completely (9)__ from work.\r\nBefore leaving, I bought a small (10)__ for my friend as a reminder of the trip.";

            bt.Dapan = "Last summer I decided to take a short (1) trip to the coast.\r\nI packed a small (2) bag with clothes and a camera, then booked a (3) room for two nights.\r\nThe weather was perfect: sunny in the (4) morning and cool in the evenings.\r\nOn the first day I walked along the (5) shore and collected small shells.\r\nAt lunchtime I found a tiny café where the owner served fresh fish and a salad (6) dressed with lemon.\r\nIn the afternoon I rented a (7) kayak and explored a quiet bay.\r\nThat evening, people gathered on the beach to watch the (8) sunset — it was beautiful.\r\nI felt completely (9) relaxed from work.\r\nBefore leaving, I bought a small (10) souvenir for my friend as a reminder of the trip.";

            bt.Dapantungcau = new List<string>
            {
                "trip",
                "bag",
                "room",
                "morning",
                "shore",
                "dressed",
                "kayak",
                "sunset",
                "relaxed",
                "souvenir"
            };

            BTDienTu btdt = new BTDienTu(bt);
            btdt.Show();
        }
    }
}
