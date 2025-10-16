namespace LTTQ_C6_BT6_5.DanhMuc
{
    partial class FormNhanVien
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
            this.textBox_dienthoai = new System.Windows.Forms.TextBox();
            this.label_dienthoai = new System.Windows.Forms.Label();
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            this.groupBox_formchatlieu = new System.Windows.Forms.GroupBox();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.radioButton_nam = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label_gioitinh = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.label_diachi = new System.Windows.Forms.Label();
            this.label_manhanvien = new System.Windows.Forms.Label();
            this.textBox_tennhanvien = new System.Windows.Forms.TextBox();
            this.textBox_manhanvien = new System.Windows.Forms.TextBox();
            this.label_tennhanvien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_boqua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_themmoi = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_tieude = new System.Windows.Forms.Label();
            this.dataGridView_nhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox_formchatlieu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_dienthoai
            // 
            this.textBox_dienthoai.Location = new System.Drawing.Point(508, 78);
            this.textBox_dienthoai.Name = "textBox_dienthoai";
            this.textBox_dienthoai.Size = new System.Drawing.Size(247, 22);
            this.textBox_dienthoai.TabIndex = 10;
            // 
            // label_dienthoai
            // 
            this.label_dienthoai.AutoSize = true;
            this.label_dienthoai.Location = new System.Drawing.Point(414, 81);
            this.label_dienthoai.Name = "label_dienthoai";
            this.label_dienthoai.Size = new System.Drawing.Size(66, 16);
            this.label_dienthoai.TabIndex = 9;
            this.label_dienthoai.Text = "Điện thoại";
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Location = new System.Drawing.Point(508, 25);
            this.textBox_diachi.Multiline = true;
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(247, 43);
            this.textBox_diachi.TabIndex = 8;
            // 
            // groupBox_formchatlieu
            // 
            this.groupBox_formchatlieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_formchatlieu.Controls.Add(this.radioButton_nu);
            this.groupBox_formchatlieu.Controls.Add(this.radioButton_nam);
            this.groupBox_formchatlieu.Controls.Add(this.dateTimePicker_ngaysinh);
            this.groupBox_formchatlieu.Controls.Add(this.label_gioitinh);
            this.groupBox_formchatlieu.Controls.Add(this.label_ngaysinh);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_dienthoai);
            this.groupBox_formchatlieu.Controls.Add(this.label_dienthoai);
            this.groupBox_formchatlieu.Controls.Add(this.label_diachi);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_diachi);
            this.groupBox_formchatlieu.Controls.Add(this.label_manhanvien);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_tennhanvien);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_manhanvien);
            this.groupBox_formchatlieu.Controls.Add(this.label_tennhanvien);
            this.groupBox_formchatlieu.Location = new System.Drawing.Point(9, 68);
            this.groupBox_formchatlieu.Name = "groupBox_formchatlieu";
            this.groupBox_formchatlieu.Size = new System.Drawing.Size(776, 206);
            this.groupBox_formchatlieu.TabIndex = 17;
            this.groupBox_formchatlieu.TabStop = false;
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.Location = new System.Drawing.Point(619, 133);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(45, 20);
            this.radioButton_nu.TabIndex = 15;
            this.radioButton_nu.Text = "Nữ";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_nam
            // 
            this.radioButton_nam.AutoSize = true;
            this.radioButton_nam.Checked = true;
            this.radioButton_nam.Location = new System.Drawing.Point(508, 133);
            this.radioButton_nam.Name = "radioButton_nam";
            this.radioButton_nam.Size = new System.Drawing.Size(57, 20);
            this.radioButton_nam.TabIndex = 14;
            this.radioButton_nam.TabStop = true;
            this.radioButton_nam.Text = "Nam";
            this.radioButton_nam.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(148, 133);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker_ngaysinh.TabIndex = 13;
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.Location = new System.Drawing.Point(413, 138);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(54, 16);
            this.label_gioitinh.TabIndex = 12;
            this.label_gioitinh.Text = "Giới tính";
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.Location = new System.Drawing.Point(32, 138);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(67, 16);
            this.label_ngaysinh.TabIndex = 11;
            this.label_ngaysinh.Text = "Ngày sinh";
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(414, 28);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(47, 16);
            this.label_diachi.TabIndex = 7;
            this.label_diachi.Text = "Địa chỉ";
            // 
            // label_manhanvien
            // 
            this.label_manhanvien.AutoSize = true;
            this.label_manhanvien.Location = new System.Drawing.Point(32, 28);
            this.label_manhanvien.Name = "label_manhanvien";
            this.label_manhanvien.Size = new System.Drawing.Size(86, 16);
            this.label_manhanvien.TabIndex = 1;
            this.label_manhanvien.Text = "Mã nhân viên";
            // 
            // textBox_tennhanvien
            // 
            this.textBox_tennhanvien.Location = new System.Drawing.Point(148, 75);
            this.textBox_tennhanvien.Name = "textBox_tennhanvien";
            this.textBox_tennhanvien.Size = new System.Drawing.Size(247, 22);
            this.textBox_tennhanvien.TabIndex = 6;
            // 
            // textBox_manhanvien
            // 
            this.textBox_manhanvien.Location = new System.Drawing.Point(148, 25);
            this.textBox_manhanvien.Name = "textBox_manhanvien";
            this.textBox_manhanvien.Size = new System.Drawing.Size(247, 22);
            this.textBox_manhanvien.TabIndex = 3;
            // 
            // label_tennhanvien
            // 
            this.label_tennhanvien.AutoSize = true;
            this.label_tennhanvien.Location = new System.Drawing.Point(32, 78);
            this.label_tennhanvien.Name = "label_tennhanvien";
            this.label_tennhanvien.Size = new System.Drawing.Size(91, 16);
            this.label_tennhanvien.TabIndex = 5;
            this.label_tennhanvien.Text = "Tên nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_thoat);
            this.panel2.Controls.Add(this.button_boqua);
            this.panel2.Controls.Add(this.button_xoa);
            this.panel2.Controls.Add(this.button_sua);
            this.panel2.Controls.Add(this.button_themmoi);
            this.panel2.Controls.Add(this.button_luu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 71);
            this.panel2.TabIndex = 18;
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(673, 16);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(127, 37);
            this.button_thoat.TabIndex = 5;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_boqua
            // 
            this.button_boqua.Location = new System.Drawing.Point(546, 16);
            this.button_boqua.Name = "button_boqua";
            this.button_boqua.Size = new System.Drawing.Size(127, 37);
            this.button_boqua.TabIndex = 4;
            this.button_boqua.Text = "Bỏ qua";
            this.button_boqua.UseVisualStyleBackColor = true;
            this.button_boqua.Click += new System.EventHandler(this.button_boqua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(413, 16);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(127, 37);
            this.button_xoa.TabIndex = 3;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(280, 16);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(127, 37);
            this.button_sua.TabIndex = 2;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_themmoi
            // 
            this.button_themmoi.Location = new System.Drawing.Point(14, 16);
            this.button_themmoi.Name = "button_themmoi";
            this.button_themmoi.Size = new System.Drawing.Size(127, 37);
            this.button_themmoi.TabIndex = 0;
            this.button_themmoi.Text = "Thêm";
            this.button_themmoi.UseVisualStyleBackColor = true;
            this.button_themmoi.Click += new System.EventHandler(this.button_themmoi_Click);
            // 
            // button_luu
            // 
            this.button_luu.Location = new System.Drawing.Point(147, 16);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(127, 37);
            this.button_luu.TabIndex = 1;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = true;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_tieude);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 16;
            // 
            // label_tieude
            // 
            this.label_tieude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tieude.AutoSize = true;
            this.label_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tieude.Location = new System.Drawing.Point(229, 20);
            this.label_tieude.Name = "label_tieude";
            this.label_tieude.Size = new System.Drawing.Size(331, 31);
            this.label_tieude.TabIndex = 0;
            this.label_tieude.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dataGridView_nhanvien
            // 
            this.dataGridView_nhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhanvien.Location = new System.Drawing.Point(9, 280);
            this.dataGridView_nhanvien.Name = "dataGridView_nhanvien";
            this.dataGridView_nhanvien.RowHeadersWidth = 51;
            this.dataGridView_nhanvien.RowTemplate.Height = 24;
            this.dataGridView_nhanvien.Size = new System.Drawing.Size(779, 385);
            this.dataGridView_nhanvien.TabIndex = 15;
            this.dataGridView_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_nhanvien_CellClick);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.groupBox_formchatlieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_nhanvien);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.groupBox_formchatlieu.ResumeLayout(false);
            this.groupBox_formchatlieu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dienthoai;
        private System.Windows.Forms.Label label_dienthoai;
        private System.Windows.Forms.TextBox textBox_diachi;
        private System.Windows.Forms.GroupBox groupBox_formchatlieu;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.Label label_manhanvien;
        private System.Windows.Forms.TextBox textBox_tennhanvien;
        private System.Windows.Forms.TextBox textBox_manhanvien;
        private System.Windows.Forms.Label label_tennhanvien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_boqua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_themmoi;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_tieude;
        private System.Windows.Forms.DataGridView dataGridView_nhanvien;
        private System.Windows.Forms.Label label_gioitinh;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.RadioButton radioButton_nam;
    }
}