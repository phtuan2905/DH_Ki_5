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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LTTQ_TrenLop_Chuong4_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private string openFilePath = "";

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn file cần mở";
            openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialog.FileName;
                richTextBox.LoadFile(openFilePath, RichTextBoxStreamType.RichText);
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (openFilePath == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Lưu file";
                saveFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf";
                saveFileDialog.DefaultExt = "rtf";
                saveFileDialog.FileName = "NewFile.rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                StreamWriter newStream = new StreamWriter(openFilePath);

                newStream.Write(richTextBox.Text);
            }
        }

        private void NewFile(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            openFilePath = "";
        }

        private void EditFont(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowColor = true;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
                richTextBox.SelectionColor = fontDialog.Color;
            }
        }
    }
}
