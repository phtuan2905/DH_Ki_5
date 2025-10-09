namespace LTTQ_C6_BT6._5.DanhMuc
{
    partial class FormKhachHang
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
            this.label_tieude = new System.Windows.Forms.Label();
            this.label_makhachhang = new System.Windows.Forms.Label();
            this.dataGridView_khachhang = new System.Windows.Forms.DataGridView();
            this.textBox_makhachhang = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label_tenkhachhang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_boqua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_themmoi = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.groupBox_formchatlieu = new System.Windows.Forms.GroupBox();
            this.textBox_dienthoai = new System.Windows.Forms.TextBox();
            this.label_dienthoai = new System.Windows.Forms.Label();
            this.label_diachi = new System.Windows.Forms.Label();
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_formchatlieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_tieude
            // 
            this.label_tieude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tieude.AutoSize = true;
            this.label_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tieude.Location = new System.Drawing.Point(229, 20);
            this.label_tieude.Name = "label_tieude";
            this.label_tieude.Size = new System.Drawing.Size(364, 31);
            this.label_tieude.TabIndex = 0;
            this.label_tieude.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // label_makhachhang
            // 
            this.label_makhachhang.AutoSize = true;
            this.label_makhachhang.Location = new System.Drawing.Point(32, 28);
            this.label_makhachhang.Name = "label_makhachhang";
            this.label_makhachhang.Size = new System.Drawing.Size(98, 16);
            this.label_makhachhang.TabIndex = 1;
            this.label_makhachhang.Text = "Mã khách hàng";
            // 
            // dataGridView_khachhang
            // 
            this.dataGridView_khachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khachhang.Location = new System.Drawing.Point(9, 197);
            this.dataGridView_khachhang.Name = "dataGridView_khachhang";
            this.dataGridView_khachhang.RowHeadersWidth = 51;
            this.dataGridView_khachhang.RowTemplate.Height = 24;
            this.dataGridView_khachhang.Size = new System.Drawing.Size(779, 330);
            this.dataGridView_khachhang.TabIndex = 9;
            this.dataGridView_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_khachhang_CellClick);
            // 
            // textBox_makhachhang
            // 
            this.textBox_makhachhang.Location = new System.Drawing.Point(148, 25);
            this.textBox_makhachhang.Name = "textBox_makhachhang";
            this.textBox_makhachhang.Size = new System.Drawing.Size(247, 22);
            this.textBox_makhachhang.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_tieude);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 10;
            // 
            // textBox_tenkhachhang
            // 
            this.textBox_tenkhachhang.Location = new System.Drawing.Point(148, 75);
            this.textBox_tenkhachhang.Name = "textBox_tenkhachhang";
            this.textBox_tenkhachhang.Size = new System.Drawing.Size(247, 22);
            this.textBox_tenkhachhang.TabIndex = 6;
            // 
            // label_tenkhachhang
            // 
            this.label_tenkhachhang.AutoSize = true;
            this.label_tenkhachhang.Location = new System.Drawing.Point(32, 78);
            this.label_tenkhachhang.Name = "label_tenkhachhang";
            this.label_tenkhachhang.Size = new System.Drawing.Size(103, 16);
            this.label_tenkhachhang.TabIndex = 5;
            this.label_tenkhachhang.Text = "Tên khách hàng";
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
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 71);
            this.panel2.TabIndex = 14;
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
            // groupBox_formchatlieu
            // 
            this.groupBox_formchatlieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_formchatlieu.Controls.Add(this.textBox_dienthoai);
            this.groupBox_formchatlieu.Controls.Add(this.label_dienthoai);
            this.groupBox_formchatlieu.Controls.Add(this.label_diachi);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_diachi);
            this.groupBox_formchatlieu.Controls.Add(this.label_makhachhang);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_tenkhachhang);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_makhachhang);
            this.groupBox_formchatlieu.Controls.Add(this.label_tenkhachhang);
            this.groupBox_formchatlieu.Location = new System.Drawing.Point(12, 68);
            this.groupBox_formchatlieu.Name = "groupBox_formchatlieu";
            this.groupBox_formchatlieu.Size = new System.Drawing.Size(776, 123);
            this.groupBox_formchatlieu.TabIndex = 11;
            this.groupBox_formchatlieu.TabStop = false;
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
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Location = new System.Drawing.Point(414, 28);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(47, 16);
            this.label_diachi.TabIndex = 7;
            this.label_diachi.Text = "Địa chỉ";
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Location = new System.Drawing.Point(508, 25);
            this.textBox_diachi.Multiline = true;
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(247, 43);
            this.textBox_diachi.TabIndex = 8;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.dataGridView_khachhang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox_formchatlieu);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox_formchatlieu.ResumeLayout(false);
            this.groupBox_formchatlieu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_tieude;
        private System.Windows.Forms.Label label_makhachhang;
        private System.Windows.Forms.DataGridView dataGridView_khachhang;
        private System.Windows.Forms.TextBox textBox_makhachhang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_tenkhachhang;
        private System.Windows.Forms.Label label_tenkhachhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_boqua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_themmoi;
        private System.Windows.Forms.GroupBox groupBox_formchatlieu;
        private System.Windows.Forms.TextBox textBox_dienthoai;
        private System.Windows.Forms.Label label_dienthoai;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.TextBox textBox_diachi;
    }
}