namespace LTTQ_TrenLop_BT11_tr72
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
            this.components = new System.ComponentModel.Container();
            this.lable_hoten = new System.Windows.Forms.Label();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.label_dienthoai = new System.Windows.Forms.Label();
            this.textBox_dienthoai = new System.Windows.Forms.TextBox();
            this.label_dsmathang = new System.Windows.Forms.Label();
            this.label_hangdatmua = new System.Windows.Forms.Label();
            this.listBox_dsmathang = new System.Windows.Forms.ListBox();
            this.danhSachCacMatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox_hangdatmua = new System.Windows.Forms.ListBox();
            this.groupBox_phuongthucthanhtoan = new System.Windows.Forms.GroupBox();
            this.radioButton_thetindung = new System.Windows.Forms.RadioButton();
            this.radioButton_sec = new System.Windows.Forms.RadioButton();
            this.radioButton_tienmat = new System.Windows.Forms.RadioButton();
            this.groupBox_hinhthuclienlac = new System.Windows.Forms.GroupBox();
            this.checkBox_email = new System.Windows.Forms.CheckBox();
            this.checkBox_fax = new System.Windows.Forms.CheckBox();
            this.checkBox_dienthoai = new System.Windows.Forms.CheckBox();
            this.button_dongy = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachCacMatHangBindingSource)).BeginInit();
            this.groupBox_phuongthucthanhtoan.SuspendLayout();
            this.groupBox_hinhthuclienlac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable_hoten
            // 
            this.lable_hoten.AutoSize = true;
            this.lable_hoten.Location = new System.Drawing.Point(33, 26);
            this.lable_hoten.Name = "lable_hoten";
            this.lable_hoten.Size = new System.Drawing.Size(49, 16);
            this.lable_hoten.TabIndex = 0;
            this.lable_hoten.Text = "Họ tên:";
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(89, 26);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(237, 22);
            this.textBox_hoten.TabIndex = 1;
            // 
            // label_dienthoai
            // 
            this.label_dienthoai.AutoSize = true;
            this.label_dienthoai.Location = new System.Drawing.Point(406, 32);
            this.label_dienthoai.Name = "label_dienthoai";
            this.label_dienthoai.Size = new System.Drawing.Size(69, 16);
            this.label_dienthoai.TabIndex = 2;
            this.label_dienthoai.Text = "Điện thoại:";
            // 
            // textBox_dienthoai
            // 
            this.textBox_dienthoai.Location = new System.Drawing.Point(481, 29);
            this.textBox_dienthoai.Name = "textBox_dienthoai";
            this.textBox_dienthoai.Size = new System.Drawing.Size(218, 22);
            this.textBox_dienthoai.TabIndex = 3;
            // 
            // label_dsmathang
            // 
            this.label_dsmathang.AutoSize = true;
            this.label_dsmathang.Location = new System.Drawing.Point(33, 87);
            this.label_dsmathang.Name = "label_dsmathang";
            this.label_dsmathang.Size = new System.Drawing.Size(154, 16);
            this.label_dsmathang.TabIndex = 4;
            this.label_dsmathang.Text = "Danh sách các mặt hàng";
            // 
            // label_hangdatmua
            // 
            this.label_hangdatmua.AutoSize = true;
            this.label_hangdatmua.Location = new System.Drawing.Point(406, 87);
            this.label_hangdatmua.Name = "label_hangdatmua";
            this.label_hangdatmua.Size = new System.Drawing.Size(91, 16);
            this.label_hangdatmua.TabIndex = 5;
            this.label_hangdatmua.Text = "Hàng đặt mua";
            // 
            // listBox_dsmathang
            // 
            this.listBox_dsmathang.DisplayMember = "Kỹ thuật lập trình C#";
            this.listBox_dsmathang.FormattingEnabled = true;
            this.listBox_dsmathang.ItemHeight = 16;
            this.listBox_dsmathang.Items.AddRange(new object[] {
            "Clean Code",
            "The Pragmatic Programmer",
            "Design Patterns: Elements of Reusable Object-Oriented Software",
            "Refactoring: Improving the Design of Existing Code",
            "Code Complete",
            "You Don’t Know JS",
            "Structure and Interpretation of Computer Programs",
            "Head First Design Patterns",
            "Working Effectively with Legacy Code",
            "Introduction to Algorithms",
            "Programming Pearls",
            "Effective Java",
            "Effective C++",
            "The Art of Computer Programming",
            "Test-Driven Development: By Example",
            "Domain-Driven Design",
            "Patterns of Enterprise Application Architecture",
            "C Programming Language",
            "Programming in Haskell",
            "Eloquent JavaScript"});
            this.listBox_dsmathang.Location = new System.Drawing.Point(36, 106);
            this.listBox_dsmathang.Name = "listBox_dsmathang";
            this.listBox_dsmathang.Size = new System.Drawing.Size(290, 212);
            this.listBox_dsmathang.TabIndex = 8;
            this.listBox_dsmathang.ValueMember = "Kỹ thuật lập trình C#";
            this.listBox_dsmathang.SelectedIndexChanged += new System.EventHandler(this.listBox_dsmathang_SelectedIndexChanged);
            this.listBox_dsmathang.DoubleClick += new System.EventHandler(this.listBox_dsmathang_DoubleClick);
            // 
            // listBox_hangdatmua
            // 
            this.listBox_hangdatmua.FormattingEnabled = true;
            this.listBox_hangdatmua.ItemHeight = 16;
            this.listBox_hangdatmua.Location = new System.Drawing.Point(409, 106);
            this.listBox_hangdatmua.Name = "listBox_hangdatmua";
            this.listBox_hangdatmua.Size = new System.Drawing.Size(290, 212);
            this.listBox_hangdatmua.TabIndex = 9;
            this.listBox_hangdatmua.DoubleClick += new System.EventHandler(this.listBox_hangdatmua_DoubleClick);
            // 
            // groupBox_phuongthucthanhtoan
            // 
            this.groupBox_phuongthucthanhtoan.Controls.Add(this.radioButton_thetindung);
            this.groupBox_phuongthucthanhtoan.Controls.Add(this.radioButton_sec);
            this.groupBox_phuongthucthanhtoan.Controls.Add(this.radioButton_tienmat);
            this.groupBox_phuongthucthanhtoan.Location = new System.Drawing.Point(36, 358);
            this.groupBox_phuongthucthanhtoan.Name = "groupBox_phuongthucthanhtoan";
            this.groupBox_phuongthucthanhtoan.Size = new System.Drawing.Size(290, 154);
            this.groupBox_phuongthucthanhtoan.TabIndex = 10;
            this.groupBox_phuongthucthanhtoan.TabStop = false;
            this.groupBox_phuongthucthanhtoan.Text = "Phương thức thanh toán";
            // 
            // radioButton_thetindung
            // 
            this.radioButton_thetindung.AutoSize = true;
            this.radioButton_thetindung.Location = new System.Drawing.Point(27, 108);
            this.radioButton_thetindung.Name = "radioButton_thetindung";
            this.radioButton_thetindung.Size = new System.Drawing.Size(101, 20);
            this.radioButton_thetindung.TabIndex = 2;
            this.radioButton_thetindung.TabStop = true;
            this.radioButton_thetindung.Text = "Thẻ tín dụng";
            this.radioButton_thetindung.UseVisualStyleBackColor = true;
            // 
            // radioButton_sec
            // 
            this.radioButton_sec.AutoSize = true;
            this.radioButton_sec.Location = new System.Drawing.Point(27, 69);
            this.radioButton_sec.Name = "radioButton_sec";
            this.radioButton_sec.Size = new System.Drawing.Size(52, 20);
            this.radioButton_sec.TabIndex = 1;
            this.radioButton_sec.TabStop = true;
            this.radioButton_sec.Text = "Sec";
            this.radioButton_sec.UseVisualStyleBackColor = true;
            // 
            // radioButton_tienmat
            // 
            this.radioButton_tienmat.AutoSize = true;
            this.radioButton_tienmat.Checked = true;
            this.radioButton_tienmat.Location = new System.Drawing.Point(27, 32);
            this.radioButton_tienmat.Name = "radioButton_tienmat";
            this.radioButton_tienmat.Size = new System.Drawing.Size(80, 20);
            this.radioButton_tienmat.TabIndex = 0;
            this.radioButton_tienmat.TabStop = true;
            this.radioButton_tienmat.Text = "Tiền mặt";
            this.radioButton_tienmat.UseVisualStyleBackColor = true;
            // 
            // groupBox_hinhthuclienlac
            // 
            this.groupBox_hinhthuclienlac.Controls.Add(this.checkBox_email);
            this.groupBox_hinhthuclienlac.Controls.Add(this.checkBox_fax);
            this.groupBox_hinhthuclienlac.Controls.Add(this.checkBox_dienthoai);
            this.groupBox_hinhthuclienlac.Location = new System.Drawing.Point(409, 358);
            this.groupBox_hinhthuclienlac.Name = "groupBox_hinhthuclienlac";
            this.groupBox_hinhthuclienlac.Size = new System.Drawing.Size(290, 154);
            this.groupBox_hinhthuclienlac.TabIndex = 11;
            this.groupBox_hinhthuclienlac.TabStop = false;
            this.groupBox_hinhthuclienlac.Text = "Hình thức liên lạc";
            // 
            // checkBox_email
            // 
            this.checkBox_email.AutoSize = true;
            this.checkBox_email.Location = new System.Drawing.Point(30, 108);
            this.checkBox_email.Name = "checkBox_email";
            this.checkBox_email.Size = new System.Drawing.Size(63, 20);
            this.checkBox_email.TabIndex = 2;
            this.checkBox_email.Text = "Email";
            this.checkBox_email.UseVisualStyleBackColor = true;
            // 
            // checkBox_fax
            // 
            this.checkBox_fax.AutoSize = true;
            this.checkBox_fax.Location = new System.Drawing.Point(30, 69);
            this.checkBox_fax.Name = "checkBox_fax";
            this.checkBox_fax.Size = new System.Drawing.Size(51, 20);
            this.checkBox_fax.TabIndex = 1;
            this.checkBox_fax.Text = "Fax";
            this.checkBox_fax.UseVisualStyleBackColor = true;
            // 
            // checkBox_dienthoai
            // 
            this.checkBox_dienthoai.AutoSize = true;
            this.checkBox_dienthoai.Location = new System.Drawing.Point(30, 32);
            this.checkBox_dienthoai.Name = "checkBox_dienthoai";
            this.checkBox_dienthoai.Size = new System.Drawing.Size(88, 20);
            this.checkBox_dienthoai.TabIndex = 0;
            this.checkBox_dienthoai.Text = "Điện thoại";
            this.checkBox_dienthoai.UseVisualStyleBackColor = true;
            // 
            // button_dongy
            // 
            this.button_dongy.Location = new System.Drawing.Point(245, 567);
            this.button_dongy.Name = "button_dongy";
            this.button_dongy.Size = new System.Drawing.Size(106, 50);
            this.button_dongy.TabIndex = 12;
            this.button_dongy.Text = "Đồng ý";
            this.button_dongy.UseVisualStyleBackColor = true;
            this.button_dongy.Click += new System.EventHandler(this.button_dongy_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(369, 567);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(106, 50);
            this.button_thoat.TabIndex = 13;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(768, 662);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_dongy);
            this.Controls.Add(this.groupBox_hinhthuclienlac);
            this.Controls.Add(this.groupBox_phuongthucthanhtoan);
            this.Controls.Add(this.listBox_hangdatmua);
            this.Controls.Add(this.listBox_dsmathang);
            this.Controls.Add(this.label_hangdatmua);
            this.Controls.Add(this.label_dsmathang);
            this.Controls.Add(this.textBox_dienthoai);
            this.Controls.Add(this.label_dienthoai);
            this.Controls.Add(this.textBox_hoten);
            this.Controls.Add(this.lable_hoten);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.danhSachCacMatHangBindingSource)).EndInit();
            this.groupBox_phuongthucthanhtoan.ResumeLayout(false);
            this.groupBox_phuongthucthanhtoan.PerformLayout();
            this.groupBox_hinhthuclienlac.ResumeLayout(false);
            this.groupBox_hinhthuclienlac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_hoten;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.Label label_dienthoai;
        private System.Windows.Forms.TextBox textBox_dienthoai;
        private System.Windows.Forms.Label label_dsmathang;
        private System.Windows.Forms.Label label_hangdatmua;
        private System.Windows.Forms.ListBox listBox_dsmathang;
        private System.Windows.Forms.ListBox listBox_hangdatmua;
        private System.Windows.Forms.GroupBox groupBox_phuongthucthanhtoan;
        private System.Windows.Forms.GroupBox groupBox_hinhthuclienlac;
        private System.Windows.Forms.CheckBox checkBox_email;
        private System.Windows.Forms.CheckBox checkBox_fax;
        private System.Windows.Forms.CheckBox checkBox_dienthoai;
        private System.Windows.Forms.Button button_dongy;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.RadioButton radioButton_thetindung;
        private System.Windows.Forms.RadioButton radioButton_sec;
        private System.Windows.Forms.RadioButton radioButton_tienmat;
        private System.Windows.Forms.BindingSource danhSachCacMatHangBindingSource;
    }
}

