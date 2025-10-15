namespace LTTQ_TH4_B2
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_taikhoan = new System.Windows.Forms.Label();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.textBox_taikhoan = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.button_huybo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngHóaToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // label_taikhoan
            // 
            this.label_taikhoan.AutoSize = true;
            this.label_taikhoan.Location = new System.Drawing.Point(85, 58);
            this.label_taikhoan.Name = "label_taikhoan";
            this.label_taikhoan.Size = new System.Drawing.Size(58, 13);
            this.label_taikhoan.TabIndex = 1;
            this.label_taikhoan.Text = "Tài khoản:";
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Location = new System.Drawing.Point(85, 102);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(55, 13);
            this.label_matkhau.TabIndex = 2;
            this.label_matkhau.Text = "Mật khẩu:";
            // 
            // textBox_taikhoan
            // 
            this.textBox_taikhoan.Location = new System.Drawing.Point(158, 58);
            this.textBox_taikhoan.Name = "textBox_taikhoan";
            this.textBox_taikhoan.Size = new System.Drawing.Size(227, 20);
            this.textBox_taikhoan.TabIndex = 3;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Location = new System.Drawing.Point(158, 99);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(227, 20);
            this.textBox_matkhau.TabIndex = 4;
            this.textBox_matkhau.UseSystemPasswordChar = true;
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Location = new System.Drawing.Point(113, 167);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(83, 38);
            this.button_dangnhap.TabIndex = 5;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // button_huybo
            // 
            this.button_huybo.Location = new System.Drawing.Point(264, 167);
            this.button_huybo.Name = "button_huybo";
            this.button_huybo.Size = new System.Drawing.Size(83, 38);
            this.button_huybo.TabIndex = 6;
            this.button_huybo.Text = "Hủy bỏ";
            this.button_huybo.UseVisualStyleBackColor = true;
            this.button_huybo.Click += new System.EventHandler(this.button_huybo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(210, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sai thông tin";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(465, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_huybo);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.textBox_taikhoan);
            this.Controls.Add(this.label_matkhau);
            this.Controls.Add(this.label_taikhoan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.Label label_taikhoan;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.TextBox textBox_taikhoan;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.Button button_huybo;
        private System.Windows.Forms.Label label1;
    }
}

