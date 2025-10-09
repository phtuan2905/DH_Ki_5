namespace LTTQ_C6_BT6._5.DanhMuc
{
    partial class FormChatLieu
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
            this.label_machatlieu = new System.Windows.Forms.Label();
            this.dataGridView_chatlieu = new System.Windows.Forms.DataGridView();
            this.textBox_machatlieu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_tenchatlieu = new System.Windows.Forms.TextBox();
            this.label_tenchatlieu = new System.Windows.Forms.Label();
            this.groupBox_formchatlieu = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_boqua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_themmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chatlieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_formchatlieu.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.label_tieude.Size = new System.Drawing.Size(325, 31);
            this.label_tieude.TabIndex = 0;
            this.label_tieude.Text = "DANH SÁCH CHẤT LIỆU";
            // 
            // label_machatlieu
            // 
            this.label_machatlieu.AutoSize = true;
            this.label_machatlieu.Location = new System.Drawing.Point(32, 28);
            this.label_machatlieu.Name = "label_machatlieu";
            this.label_machatlieu.Size = new System.Drawing.Size(78, 16);
            this.label_machatlieu.TabIndex = 1;
            this.label_machatlieu.Text = "Mã chất liệu";
            // 
            // dataGridView_chatlieu
            // 
            this.dataGridView_chatlieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_chatlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chatlieu.Location = new System.Drawing.Point(9, 197);
            this.dataGridView_chatlieu.Name = "dataGridView_chatlieu";
            this.dataGridView_chatlieu.RowHeadersWidth = 51;
            this.dataGridView_chatlieu.RowTemplate.Height = 24;
            this.dataGridView_chatlieu.Size = new System.Drawing.Size(631, 241);
            this.dataGridView_chatlieu.TabIndex = 2;
            this.dataGridView_chatlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_chatlieu_CellClick);
            // 
            // textBox_machatlieu
            // 
            this.textBox_machatlieu.Location = new System.Drawing.Point(126, 25);
            this.textBox_machatlieu.Name = "textBox_machatlieu";
            this.textBox_machatlieu.Size = new System.Drawing.Size(496, 22);
            this.textBox_machatlieu.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_tieude);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 4;
            // 
            // textBox_tenchatlieu
            // 
            this.textBox_tenchatlieu.Location = new System.Drawing.Point(126, 75);
            this.textBox_tenchatlieu.Name = "textBox_tenchatlieu";
            this.textBox_tenchatlieu.Size = new System.Drawing.Size(496, 22);
            this.textBox_tenchatlieu.TabIndex = 6;
            // 
            // label_tenchatlieu
            // 
            this.label_tenchatlieu.AutoSize = true;
            this.label_tenchatlieu.Location = new System.Drawing.Point(32, 78);
            this.label_tenchatlieu.Name = "label_tenchatlieu";
            this.label_tenchatlieu.Size = new System.Drawing.Size(83, 16);
            this.label_tenchatlieu.TabIndex = 5;
            this.label_tenchatlieu.Text = "Tên chất liệu";
            // 
            // groupBox_formchatlieu
            // 
            this.groupBox_formchatlieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_formchatlieu.Controls.Add(this.label_machatlieu);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_tenchatlieu);
            this.groupBox_formchatlieu.Controls.Add(this.textBox_machatlieu);
            this.groupBox_formchatlieu.Controls.Add(this.label_tenchatlieu);
            this.groupBox_formchatlieu.Location = new System.Drawing.Point(12, 85);
            this.groupBox_formchatlieu.Name = "groupBox_formchatlieu";
            this.groupBox_formchatlieu.Size = new System.Drawing.Size(628, 106);
            this.groupBox_formchatlieu.TabIndex = 7;
            this.groupBox_formchatlieu.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_thoat);
            this.panel2.Controls.Add(this.button_boqua);
            this.panel2.Controls.Add(this.button_xoa);
            this.panel2.Controls.Add(this.button_sua);
            this.panel2.Controls.Add(this.button_luu);
            this.panel2.Controls.Add(this.button_themmoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(647, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 388);
            this.panel2.TabIndex = 8;
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(14, 238);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(127, 37);
            this.button_thoat.TabIndex = 5;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_boqua
            // 
            this.button_boqua.Location = new System.Drawing.Point(14, 195);
            this.button_boqua.Name = "button_boqua";
            this.button_boqua.Size = new System.Drawing.Size(127, 37);
            this.button_boqua.TabIndex = 4;
            this.button_boqua.Text = "Bỏ qua";
            this.button_boqua.UseVisualStyleBackColor = true;
            this.button_boqua.Click += new System.EventHandler(this.button_boqua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(14, 152);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(127, 37);
            this.button_xoa.TabIndex = 3;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(14, 109);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(127, 37);
            this.button_sua.TabIndex = 2;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_luu
            // 
            this.button_luu.Location = new System.Drawing.Point(14, 66);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(127, 37);
            this.button_luu.TabIndex = 1;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = true;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_themmoi
            // 
            this.button_themmoi.Location = new System.Drawing.Point(14, 23);
            this.button_themmoi.Name = "button_themmoi";
            this.button_themmoi.Size = new System.Drawing.Size(127, 37);
            this.button_themmoi.TabIndex = 0;
            this.button_themmoi.Text = "Thêm";
            this.button_themmoi.UseVisualStyleBackColor = true;
            this.button_themmoi.Click += new System.EventHandler(this.button_themmoi_Click);
            // 
            // FormChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox_formchatlieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_chatlieu);
            this.Name = "FormChatLieu";
            this.Text = "FormChatLieu";
            this.Load += new System.EventHandler(this.FormChatlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chatlieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_formchatlieu.ResumeLayout(false);
            this.groupBox_formchatlieu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_tieude;
        private System.Windows.Forms.Label label_machatlieu;
        private System.Windows.Forms.DataGridView dataGridView_chatlieu;
        private System.Windows.Forms.TextBox textBox_machatlieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_tenchatlieu;
        private System.Windows.Forms.Label label_tenchatlieu;
        private System.Windows.Forms.GroupBox groupBox_formchatlieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_themmoi;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_boqua;
        private System.Windows.Forms.Button button_xoa;
    }
}