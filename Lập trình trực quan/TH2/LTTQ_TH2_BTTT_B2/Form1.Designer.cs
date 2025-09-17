namespace LTTQ_TH2_BTTT_B2_1
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
            this.button_thoat = new System.Windows.Forms.Button();
            this.groupBox_dskh = new System.Windows.Forms.GroupBox();
            this.listBox_dskh = new System.Windows.Forms.ListBox();
            this.button_themmoi = new System.Windows.Forms.Button();
            this.button_themvaods = new System.Windows.Forms.Button();
            this.label_dolarsign1 = new System.Windows.Forms.Label();
            this.comboBox_soluong = new System.Windows.Forms.ComboBox();
            this.comboBox_douong = new System.Windows.Forms.ComboBox();
            this.label_soluong = new System.Windows.Forms.Label();
            this.label_tien = new System.Windows.Forms.Label();
            this.label_dolarsign = new System.Windows.Forms.Label();
            this.textBox_giaduthuyen = new System.Windows.Forms.TextBox();
            this.label_giaduthuyen = new System.Windows.Forms.Label();
            this.radioButton_nuangay = new System.Windows.Forms.RadioButton();
            this.radioButton_cangay = new System.Windows.Forms.RadioButton();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.label_hoten = new System.Windows.Forms.Label();
            this.groupBox_nhapttkh = new System.Windows.Forms.GroupBox();
            this.textBox_tien = new System.Windows.Forms.TextBox();
            this.label_chondouong = new System.Windows.Forms.Label();
            this.groupBox_dskh.SuspendLayout();
            this.groupBox_nhapttkh.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(664, 387);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(124, 23);
            this.button_thoat.TabIndex = 19;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.Thoat);
            // 
            // groupBox_dskh
            // 
            this.groupBox_dskh.Controls.Add(this.listBox_dskh);
            this.groupBox_dskh.Location = new System.Drawing.Point(413, 64);
            this.groupBox_dskh.Name = "groupBox_dskh";
            this.groupBox_dskh.Size = new System.Drawing.Size(375, 304);
            this.groupBox_dskh.TabIndex = 18;
            this.groupBox_dskh.TabStop = false;
            this.groupBox_dskh.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // listBox_dskh
            // 
            this.listBox_dskh.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_dskh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_dskh.FormattingEnabled = true;
            this.listBox_dskh.Location = new System.Drawing.Point(7, 18);
            this.listBox_dskh.Name = "listBox_dskh";
            this.listBox_dskh.Size = new System.Drawing.Size(362, 275);
            this.listBox_dskh.TabIndex = 0;
            // 
            // button_themmoi
            // 
            this.button_themmoi.Location = new System.Drawing.Point(219, 251);
            this.button_themmoi.Name = "button_themmoi";
            this.button_themmoi.Size = new System.Drawing.Size(124, 23);
            this.button_themmoi.TabIndex = 15;
            this.button_themmoi.Text = "Thêm Mới";
            this.button_themmoi.UseVisualStyleBackColor = true;
            this.button_themmoi.Click += new System.EventHandler(this.button_themmoi_Click);
            // 
            // button_themvaods
            // 
            this.button_themvaods.Location = new System.Drawing.Point(26, 251);
            this.button_themvaods.Name = "button_themvaods";
            this.button_themvaods.Size = new System.Drawing.Size(124, 23);
            this.button_themvaods.TabIndex = 14;
            this.button_themvaods.Text = "Thêm Vào DS";
            this.button_themvaods.UseVisualStyleBackColor = true;
            this.button_themvaods.Click += new System.EventHandler(this.button_themvaods_Click);
            // 
            // label_dolarsign1
            // 
            this.label_dolarsign1.AutoSize = true;
            this.label_dolarsign1.Location = new System.Drawing.Point(349, 195);
            this.label_dolarsign1.Name = "label_dolarsign1";
            this.label_dolarsign1.Size = new System.Drawing.Size(13, 13);
            this.label_dolarsign1.TabIndex = 13;
            this.label_dolarsign1.Text = "$";
            // 
            // comboBox_soluong
            // 
            this.comboBox_soluong.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_soluong.FormattingEnabled = true;
            this.comboBox_soluong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_soluong.Location = new System.Drawing.Point(135, 193);
            this.comboBox_soluong.Name = "comboBox_soluong";
            this.comboBox_soluong.Size = new System.Drawing.Size(108, 21);
            this.comboBox_soluong.TabIndex = 12;
            this.comboBox_soluong.SelectedIndexChanged += new System.EventHandler(this.comboBox_soluong_SelectedIndexChanged);
            // 
            // comboBox_douong
            // 
            this.comboBox_douong.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_douong.FormattingEnabled = true;
            this.comboBox_douong.Items.AddRange(new object[] {
            "Coca cola",
            "Pepsi",
            "Seven up"});
            this.comboBox_douong.Location = new System.Drawing.Point(6, 192);
            this.comboBox_douong.Name = "comboBox_douong";
            this.comboBox_douong.Size = new System.Drawing.Size(108, 21);
            this.comboBox_douong.TabIndex = 11;
            this.comboBox_douong.SelectedIndexChanged += new System.EventHandler(this.comboBox_douong_SelectedIndexChanged);
            // 
            // label_soluong
            // 
            this.label_soluong.AutoSize = true;
            this.label_soluong.Location = new System.Drawing.Point(165, 177);
            this.label_soluong.Name = "label_soluong";
            this.label_soluong.Size = new System.Drawing.Size(53, 13);
            this.label_soluong.TabIndex = 9;
            this.label_soluong.Text = "Số Lượng";
            // 
            // label_tien
            // 
            this.label_tien.AutoSize = true;
            this.label_tien.Location = new System.Drawing.Point(287, 177);
            this.label_tien.Name = "label_tien";
            this.label_tien.Size = new System.Drawing.Size(28, 13);
            this.label_tien.TabIndex = 8;
            this.label_tien.Text = "Tiền";
            // 
            // label_dolarsign
            // 
            this.label_dolarsign.AutoSize = true;
            this.label_dolarsign.Location = new System.Drawing.Point(249, 123);
            this.label_dolarsign.Name = "label_dolarsign";
            this.label_dolarsign.Size = new System.Drawing.Size(13, 13);
            this.label_dolarsign.TabIndex = 6;
            this.label_dolarsign.Text = "$";
            // 
            // textBox_giaduthuyen
            // 
            this.textBox_giaduthuyen.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_giaduthuyen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_giaduthuyen.Location = new System.Drawing.Point(108, 120);
            this.textBox_giaduthuyen.Name = "textBox_giaduthuyen";
            this.textBox_giaduthuyen.ReadOnly = true;
            this.textBox_giaduthuyen.Size = new System.Drawing.Size(135, 20);
            this.textBox_giaduthuyen.TabIndex = 5;
            // 
            // label_giaduthuyen
            // 
            this.label_giaduthuyen.AutoSize = true;
            this.label_giaduthuyen.Location = new System.Drawing.Point(23, 123);
            this.label_giaduthuyen.Name = "label_giaduthuyen";
            this.label_giaduthuyen.Size = new System.Drawing.Size(79, 13);
            this.label_giaduthuyen.TabIndex = 4;
            this.label_giaduthuyen.Text = "Giá Du Thuyền";
            // 
            // radioButton_nuangay
            // 
            this.radioButton_nuangay.AutoSize = true;
            this.radioButton_nuangay.Location = new System.Drawing.Point(136, 81);
            this.radioButton_nuangay.Name = "radioButton_nuangay";
            this.radioButton_nuangay.Size = new System.Drawing.Size(73, 17);
            this.radioButton_nuangay.TabIndex = 3;
            this.radioButton_nuangay.Text = "Nửa Ngày";
            this.radioButton_nuangay.UseVisualStyleBackColor = true;
            this.radioButton_nuangay.Click += new System.EventHandler(this.radioButton_nuangay_Click);
            // 
            // radioButton_cangay
            // 
            this.radioButton_cangay.AutoSize = true;
            this.radioButton_cangay.Location = new System.Drawing.Point(26, 81);
            this.radioButton_cangay.Name = "radioButton_cangay";
            this.radioButton_cangay.Size = new System.Drawing.Size(64, 17);
            this.radioButton_cangay.TabIndex = 2;
            this.radioButton_cangay.Text = "Cả ngày";
            this.radioButton_cangay.UseVisualStyleBackColor = true;
            this.radioButton_cangay.Click += new System.EventHandler(this.radioButton_cangay_Click);
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_hoten.Location = new System.Drawing.Point(74, 38);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(135, 20);
            this.textBox_hoten.TabIndex = 1;
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Location = new System.Drawing.Point(23, 41);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(43, 13);
            this.label_hoten.TabIndex = 0;
            this.label_hoten.Text = "Họ Tên";
            // 
            // groupBox_nhapttkh
            // 
            this.groupBox_nhapttkh.Controls.Add(this.button_themmoi);
            this.groupBox_nhapttkh.Controls.Add(this.button_themvaods);
            this.groupBox_nhapttkh.Controls.Add(this.label_dolarsign1);
            this.groupBox_nhapttkh.Controls.Add(this.comboBox_soluong);
            this.groupBox_nhapttkh.Controls.Add(this.comboBox_douong);
            this.groupBox_nhapttkh.Controls.Add(this.textBox_tien);
            this.groupBox_nhapttkh.Controls.Add(this.label_soluong);
            this.groupBox_nhapttkh.Controls.Add(this.label_tien);
            this.groupBox_nhapttkh.Controls.Add(this.label_chondouong);
            this.groupBox_nhapttkh.Controls.Add(this.label_dolarsign);
            this.groupBox_nhapttkh.Controls.Add(this.textBox_giaduthuyen);
            this.groupBox_nhapttkh.Controls.Add(this.label_giaduthuyen);
            this.groupBox_nhapttkh.Controls.Add(this.radioButton_nuangay);
            this.groupBox_nhapttkh.Controls.Add(this.radioButton_cangay);
            this.groupBox_nhapttkh.Controls.Add(this.textBox_hoten);
            this.groupBox_nhapttkh.Controls.Add(this.label_hoten);
            this.groupBox_nhapttkh.Location = new System.Drawing.Point(12, 40);
            this.groupBox_nhapttkh.Name = "groupBox_nhapttkh";
            this.groupBox_nhapttkh.Size = new System.Drawing.Size(375, 328);
            this.groupBox_nhapttkh.TabIndex = 17;
            this.groupBox_nhapttkh.TabStop = false;
            this.groupBox_nhapttkh.Text = "Nhập Thông Tin Khách Hàng Đặt Tour";
            // 
            // textBox_tien
            // 
            this.textBox_tien.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_tien.Location = new System.Drawing.Point(261, 193);
            this.textBox_tien.Name = "textBox_tien";
            this.textBox_tien.ReadOnly = true;
            this.textBox_tien.Size = new System.Drawing.Size(82, 20);
            this.textBox_tien.TabIndex = 10;
            // 
            // label_chondouong
            // 
            this.label_chondouong.AutoSize = true;
            this.label_chondouong.Location = new System.Drawing.Point(23, 177);
            this.label_chondouong.Name = "label_chondouong";
            this.label_chondouong.Size = new System.Drawing.Size(78, 13);
            this.label_chondouong.TabIndex = 7;
            this.label_chondouong.Text = "Chọn Đồ Uống";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.groupBox_dskh);
            this.Controls.Add(this.groupBox_nhapttkh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_dskh.ResumeLayout(false);
            this.groupBox_nhapttkh.ResumeLayout(false);
            this.groupBox_nhapttkh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.GroupBox groupBox_dskh;
        private System.Windows.Forms.ListBox listBox_dskh;
        private System.Windows.Forms.Button button_themmoi;
        private System.Windows.Forms.Button button_themvaods;
        private System.Windows.Forms.Label label_dolarsign1;
        private System.Windows.Forms.ComboBox comboBox_soluong;
        private System.Windows.Forms.ComboBox comboBox_douong;
        private System.Windows.Forms.Label label_soluong;
        private System.Windows.Forms.Label label_tien;
        private System.Windows.Forms.Label label_dolarsign;
        private System.Windows.Forms.TextBox textBox_giaduthuyen;
        private System.Windows.Forms.Label label_giaduthuyen;
        private System.Windows.Forms.RadioButton radioButton_nuangay;
        private System.Windows.Forms.RadioButton radioButton_cangay;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.GroupBox groupBox_nhapttkh;
        private System.Windows.Forms.TextBox textBox_tien;
        private System.Windows.Forms.Label label_chondouong;
    }
}

