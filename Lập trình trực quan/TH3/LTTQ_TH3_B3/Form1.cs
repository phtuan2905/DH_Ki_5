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

namespace LTTQ_TH3_B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                comboBox_odia.Items.Add(drive.Name);
            }
        }

        private void ChangeDrive(object sender, EventArgs e)
        {
            DirectoryInfo driveDirectory = new DirectoryInfo("E:\\");

            DirectoryInfo[] directories = driveDirectory.GetDirectories("*.*");
            FileInfo[] files = driveDirectory.GetFiles();

            foreach (DirectoryInfo d in directories)
            {
                comboBox_thumuc.Items.Add(d.Name);
            }
        }
    }
}
