namespace LTTQ_TH2_BTTT_B1
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
            this.groupBox_thongtindiem = new System.Windows.Forms.GroupBox();
            this.button_themvaods = new System.Windows.Forms.Button();
            this.textBox_diem = new System.Windows.Forms.TextBox();
            this.label_diem = new System.Windows.Forms.Label();
            this.label_sotinchi = new System.Windows.Forms.Label();
            this.textBox_sotinchi = new System.Windows.Forms.TextBox();
            this.comboBox_tenmonhoc = new System.Windows.Forms.ComboBox();
            this.label_tenmonhoc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_dsmonhoc = new System.Windows.Forms.GroupBox();
            this.listBox_dsmonhoc = new System.Windows.Forms.ListBox();
            this.label_tongsotinchi = new System.Windows.Forms.Label();
            this.textBox_tongsotinchi = new System.Windows.Forms.TextBox();
            this.label_tongsodiem = new System.Windows.Forms.Label();
            this.textBox_tongsodiem = new System.Windows.Forms.TextBox();
            this.label_diemtrungbinh = new System.Windows.Forms.Label();
            this.textBox_diemtrungbinh = new System.Windows.Forms.TextBox();
            this.button_tinh = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.groupBox_thongtindiem.SuspendLayout();
            this.groupBox_dsmonhoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_thongtindiem
            // 
            this.groupBox_thongtindiem.Controls.Add(this.button_themvaods);
            this.groupBox_thongtindiem.Controls.Add(this.textBox_diem);
            this.groupBox_thongtindiem.Controls.Add(this.label_diem);
            this.groupBox_thongtindiem.Controls.Add(this.label_sotinchi);
            this.groupBox_thongtindiem.Controls.Add(this.textBox_sotinchi);
            this.groupBox_thongtindiem.Controls.Add(this.comboBox_tenmonhoc);
            this.groupBox_thongtindiem.Controls.Add(this.label_tenmonhoc);
            this.groupBox_thongtindiem.Controls.Add(this.groupBox1);
            this.groupBox_thongtindiem.Location = new System.Drawing.Point(12, 24);
            this.groupBox_thongtindiem.Name = "groupBox_thongtindiem";
            this.groupBox_thongtindiem.Size = new System.Drawing.Size(278, 414);
            this.groupBox_thongtindiem.TabIndex = 0;
            this.groupBox_thongtindiem.TabStop = false;
            this.groupBox_thongtindiem.Text = "Thông tin điểm sinh viên";
            // 
            // button_themvaods
            // 
            this.button_themvaods.Location = new System.Drawing.Point(60, 216);
            this.button_themvaods.Name = "button_themvaods";
            this.button_themvaods.Size = new System.Drawing.Size(146, 54);
            this.button_themvaods.TabIndex = 9;
            this.button_themvaods.Text = "Thêm vào DS";
            this.button_themvaods.UseVisualStyleBackColor = true;
            this.button_themvaods.Click += new System.EventHandler(this.button_themvaods_Click);
            // 
            // textBox_diem
            // 
            this.textBox_diem.Location = new System.Drawing.Point(90, 139);
            this.textBox_diem.Name = "textBox_diem";
            this.textBox_diem.Size = new System.Drawing.Size(116, 20);
            this.textBox_diem.TabIndex = 8;
            // 
            // label_diem
            // 
            this.label_diem.AutoSize = true;
            this.label_diem.Location = new System.Drawing.Point(21, 139);
            this.label_diem.Name = "label_diem";
            this.label_diem.Size = new System.Drawing.Size(31, 13);
            this.label_diem.TabIndex = 7;
            this.label_diem.Text = "Điểm";
            // 
            // label_sotinchi
            // 
            this.label_sotinchi.AutoSize = true;
            this.label_sotinchi.Location = new System.Drawing.Point(21, 105);
            this.label_sotinchi.Name = "label_sotinchi";
            this.label_sotinchi.Size = new System.Drawing.Size(53, 13);
            this.label_sotinchi.TabIndex = 6;
            this.label_sotinchi.Text = "Số tín chỉ";
            // 
            // textBox_sotinchi
            // 
            this.textBox_sotinchi.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_sotinchi.Location = new System.Drawing.Point(90, 102);
            this.textBox_sotinchi.Name = "textBox_sotinchi";
            this.textBox_sotinchi.ReadOnly = true;
            this.textBox_sotinchi.Size = new System.Drawing.Size(160, 20);
            this.textBox_sotinchi.TabIndex = 5;
            // 
            // comboBox_tenmonhoc
            // 
            this.comboBox_tenmonhoc.FormattingEnabled = true;
            this.comboBox_tenmonhoc.Items.AddRange(new object[] {
            "Tin hoc dai cuong",
            "Giai tich F1",
            "Tieng Anh A0",
            "Triet hoc Mac_Lenin",
            "Vat ly F1"});
            this.comboBox_tenmonhoc.Location = new System.Drawing.Point(24, 61);
            this.comboBox_tenmonhoc.Name = "comboBox_tenmonhoc";
            this.comboBox_tenmonhoc.Size = new System.Drawing.Size(226, 21);
            this.comboBox_tenmonhoc.TabIndex = 4;
            this.comboBox_tenmonhoc.SelectedIndexChanged += new System.EventHandler(this.comboBox_tenmonhoc_SelectedIndexChanged);
            // 
            // label_tenmonhoc
            // 
            this.label_tenmonhoc.AutoSize = true;
            this.label_tenmonhoc.Location = new System.Drawing.Point(21, 45);
            this.label_tenmonhoc.Name = "label_tenmonhoc";
            this.label_tenmonhoc.Size = new System.Drawing.Size(70, 13);
            this.label_tenmonhoc.TabIndex = 2;
            this.label_tenmonhoc.Text = "Tên môn học";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(273, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // groupBox_dsmonhoc
            // 
            this.groupBox_dsmonhoc.Controls.Add(this.listBox_dsmonhoc);
            this.groupBox_dsmonhoc.Location = new System.Drawing.Point(285, 24);
            this.groupBox_dsmonhoc.Name = "groupBox_dsmonhoc";
            this.groupBox_dsmonhoc.Size = new System.Drawing.Size(503, 213);
            this.groupBox_dsmonhoc.TabIndex = 1;
            this.groupBox_dsmonhoc.TabStop = false;
            this.groupBox_dsmonhoc.Text = "Danh sách các môn học";
            // 
            // listBox_dsmonhoc
            // 
            this.listBox_dsmonhoc.FormattingEnabled = true;
            this.listBox_dsmonhoc.Location = new System.Drawing.Point(11, 31);
            this.listBox_dsmonhoc.Name = "listBox_dsmonhoc";
            this.listBox_dsmonhoc.Size = new System.Drawing.Size(473, 160);
            this.listBox_dsmonhoc.TabIndex = 0;
            // 
            // label_tongsotinchi
            // 
            this.label_tongsotinchi.AutoSize = true;
            this.label_tongsotinchi.Location = new System.Drawing.Point(309, 261);
            this.label_tongsotinchi.Name = "label_tongsotinchi";
            this.label_tongsotinchi.Size = new System.Drawing.Size(79, 13);
            this.label_tongsotinchi.TabIndex = 10;
            this.label_tongsotinchi.Text = "Tổng số tín chỉ";
            // 
            // textBox_tongsotinchi
            // 
            this.textBox_tongsotinchi.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_tongsotinchi.Location = new System.Drawing.Point(397, 258);
            this.textBox_tongsotinchi.Name = "textBox_tongsotinchi";
            this.textBox_tongsotinchi.ReadOnly = true;
            this.textBox_tongsotinchi.Size = new System.Drawing.Size(127, 20);
            this.textBox_tongsotinchi.TabIndex = 10;
            // 
            // label_tongsodiem
            // 
            this.label_tongsodiem.AutoSize = true;
            this.label_tongsodiem.Location = new System.Drawing.Point(542, 261);
            this.label_tongsodiem.Name = "label_tongsodiem";
            this.label_tongsodiem.Size = new System.Drawing.Size(72, 13);
            this.label_tongsodiem.TabIndex = 11;
            this.label_tongsodiem.Text = "Tổng số điểm";
            // 
            // textBox_tongsodiem
            // 
            this.textBox_tongsodiem.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_tongsodiem.Location = new System.Drawing.Point(630, 258);
            this.textBox_tongsodiem.Name = "textBox_tongsodiem";
            this.textBox_tongsodiem.ReadOnly = true;
            this.textBox_tongsodiem.Size = new System.Drawing.Size(127, 20);
            this.textBox_tongsodiem.TabIndex = 12;
            // 
            // label_diemtrungbinh
            // 
            this.label_diemtrungbinh.AutoSize = true;
            this.label_diemtrungbinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diemtrungbinh.Location = new System.Drawing.Point(309, 311);
            this.label_diemtrungbinh.Name = "label_diemtrungbinh";
            this.label_diemtrungbinh.Size = new System.Drawing.Size(123, 17);
            this.label_diemtrungbinh.TabIndex = 13;
            this.label_diemtrungbinh.Text = "Điểm trung bình";
            // 
            // textBox_diemtrungbinh
            // 
            this.textBox_diemtrungbinh.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_diemtrungbinh.Location = new System.Drawing.Point(438, 310);
            this.textBox_diemtrungbinh.Name = "textBox_diemtrungbinh";
            this.textBox_diemtrungbinh.ReadOnly = true;
            this.textBox_diemtrungbinh.Size = new System.Drawing.Size(176, 20);
            this.textBox_diemtrungbinh.TabIndex = 14;
            // 
            // button_tinh
            // 
            this.button_tinh.Location = new System.Drawing.Point(333, 355);
            this.button_tinh.Name = "button_tinh";
            this.button_tinh.Size = new System.Drawing.Size(146, 54);
            this.button_tinh.TabIndex = 10;
            this.button_tinh.Text = "Tính";
            this.button_tinh.UseVisualStyleBackColor = true;
            this.button_tinh.Click += new System.EventHandler(this.button_tinh_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(590, 355);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(146, 54);
            this.button_thoat.TabIndex = 15;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.Thoat);
            this.button_thoat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_thoat_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_tinh);
            this.Controls.Add(this.textBox_diemtrungbinh);
            this.Controls.Add(this.label_diemtrungbinh);
            this.Controls.Add(this.textBox_tongsodiem);
            this.Controls.Add(this.label_tongsodiem);
            this.Controls.Add(this.textBox_tongsotinchi);
            this.Controls.Add(this.label_tongsotinchi);
            this.Controls.Add(this.groupBox_dsmonhoc);
            this.Controls.Add(this.groupBox_thongtindiem);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_thongtindiem.ResumeLayout(false);
            this.groupBox_thongtindiem.PerformLayout();
            this.groupBox_dsmonhoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_thongtindiem;
        private System.Windows.Forms.Label label_diem;
        private System.Windows.Forms.Label label_sotinchi;
        private System.Windows.Forms.TextBox textBox_sotinchi;
        private System.Windows.Forms.ComboBox comboBox_tenmonhoc;
        private System.Windows.Forms.Label label_tenmonhoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_dsmonhoc;
        private System.Windows.Forms.Button button_themvaods;
        private System.Windows.Forms.TextBox textBox_diem;
        private System.Windows.Forms.ListBox listBox_dsmonhoc;
        private System.Windows.Forms.Label label_tongsotinchi;
        private System.Windows.Forms.TextBox textBox_tongsotinchi;
        private System.Windows.Forms.Label label_tongsodiem;
        private System.Windows.Forms.TextBox textBox_tongsodiem;
        private System.Windows.Forms.Label label_diemtrungbinh;
        private System.Windows.Forms.TextBox textBox_diemtrungbinh;
        private System.Windows.Forms.Button button_tinh;
        private System.Windows.Forms.Button button_thoat;
    }
}

