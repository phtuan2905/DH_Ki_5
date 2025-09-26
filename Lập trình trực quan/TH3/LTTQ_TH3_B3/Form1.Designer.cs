namespace LTTQ_TH3_B3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox_loibaihat = new System.Windows.Forms.RichTextBox();
            this.label_odia = new System.Windows.Forms.Label();
            this.label_thumuc = new System.Windows.Forms.Label();
            this.label_taptin = new System.Windows.Forms.Label();
            this.comboBox_odia = new System.Windows.Forms.ComboBox();
            this.comboBox_thumuc = new System.Windows.Forms.ComboBox();
            this.listBox_taptin = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_loibaihat
            // 
            this.richTextBox_loibaihat.Location = new System.Drawing.Point(339, 12);
            this.richTextBox_loibaihat.Name = "richTextBox_loibaihat";
            this.richTextBox_loibaihat.Size = new System.Drawing.Size(342, 552);
            this.richTextBox_loibaihat.TabIndex = 0;
            this.richTextBox_loibaihat.Text = "";
            // 
            // label_odia
            // 
            this.label_odia.AutoSize = true;
            this.label_odia.Location = new System.Drawing.Point(23, 26);
            this.label_odia.Name = "label_odia";
            this.label_odia.Size = new System.Drawing.Size(41, 16);
            this.label_odia.TabIndex = 1;
            this.label_odia.Text = "Ổ đĩa";
            // 
            // label_thumuc
            // 
            this.label_thumuc.AutoSize = true;
            this.label_thumuc.Location = new System.Drawing.Point(23, 64);
            this.label_thumuc.Name = "label_thumuc";
            this.label_thumuc.Size = new System.Drawing.Size(58, 16);
            this.label_thumuc.TabIndex = 2;
            this.label_thumuc.Text = "Thư mục";
            // 
            // label_taptin
            // 
            this.label_taptin.AutoSize = true;
            this.label_taptin.Location = new System.Drawing.Point(23, 110);
            this.label_taptin.Name = "label_taptin";
            this.label_taptin.Size = new System.Drawing.Size(48, 16);
            this.label_taptin.TabIndex = 3;
            this.label_taptin.Text = "Tập tin";
            // 
            // comboBox_odia
            // 
            this.comboBox_odia.FormattingEnabled = true;
            this.comboBox_odia.Location = new System.Drawing.Point(114, 23);
            this.comboBox_odia.Name = "comboBox_odia";
            this.comboBox_odia.Size = new System.Drawing.Size(202, 24);
            this.comboBox_odia.TabIndex = 4;
            this.comboBox_odia.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox_odia.SelectedIndexChanged += new System.EventHandler(this.ChangeDrive);
            // 
            // comboBox_thumuc
            // 
            this.comboBox_thumuc.FormattingEnabled = true;
            this.comboBox_thumuc.Location = new System.Drawing.Point(114, 61);
            this.comboBox_thumuc.Name = "comboBox_thumuc";
            this.comboBox_thumuc.Size = new System.Drawing.Size(202, 24);
            this.comboBox_thumuc.TabIndex = 5;
            // 
            // listBox_taptin
            // 
            this.listBox_taptin.FormattingEnabled = true;
            this.listBox_taptin.ItemHeight = 16;
            this.listBox_taptin.Location = new System.Drawing.Point(26, 141);
            this.listBox_taptin.Name = "listBox_taptin";
            this.listBox_taptin.Size = new System.Drawing.Size(290, 164);
            this.listBox_taptin.TabIndex = 6;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(26, 311);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(290, 253);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 576);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listBox_taptin);
            this.Controls.Add(this.comboBox_thumuc);
            this.Controls.Add(this.comboBox_odia);
            this.Controls.Add(this.label_taptin);
            this.Controls.Add(this.label_thumuc);
            this.Controls.Add(this.label_odia);
            this.Controls.Add(this.richTextBox_loibaihat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_loibaihat;
        private System.Windows.Forms.Label label_odia;
        private System.Windows.Forms.Label label_thumuc;
        private System.Windows.Forms.Label label_taptin;
        private System.Windows.Forms.ComboBox comboBox_odia;
        private System.Windows.Forms.ComboBox comboBox_thumuc;
        private System.Windows.Forms.ListBox listBox_taptin;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

