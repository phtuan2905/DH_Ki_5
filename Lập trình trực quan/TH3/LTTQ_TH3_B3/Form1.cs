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

            comboBox_odia.Items.Clear();
            foreach (DriveInfo drive in drives)
            {
                comboBox_odia.Items.Add(drive.Name);
            }
        }

        private void OnChangeDrive(object sender, EventArgs e)
        {
            DirectoryInfo driveDirectory = new DirectoryInfo(comboBox_odia.SelectedItem.ToString());

            DirectoryInfo[] directories = driveDirectory.GetDirectories("*.*");

            comboBox_thumuc.Items.Clear();
            foreach (DirectoryInfo d in directories)
            {
                comboBox_thumuc.Items.Add(d.FullName);
            }

            FileInfo[] files = driveDirectory.GetFiles();
            
            listBox_taptin.Items.Clear();
            foreach (FileInfo file in files)
            {
                listBox_taptin.Items.Add((string)file.FullName);
            }

        }

        private void OnChangeFolder(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(comboBox_thumuc.SelectedItem.ToString());

            FileInfo[] files = directory.GetFiles();

            listBox_taptin.Items.Clear();
            foreach (FileInfo file in files)
            {
                listBox_taptin.Items.Add((string)file.FullName);
            }
        }

        private void OnSelectFile(object sender, EventArgs e)
        {
            string folder = Path.GetDirectoryName(listBox_taptin.SelectedItem.ToString());
            string fileNameNoExt = Path.GetFileNameWithoutExtension(listBox_taptin.SelectedItem.ToString());
            string filePath = Path.Combine(folder, fileNameNoExt);

            FileStream fileStream = new FileStream(filePath + ".txt", FileMode.Open);
            StreamReader fileReader = new StreamReader(fileStream, Encoding.UTF8);
            richTextBox_loibaihat.Text = fileReader.ReadToEnd();

            axWindowsMediaPlayer1.URL = filePath + ".mp3";

        }
    }
}
