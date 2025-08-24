namespace TH1_BTVN_B3
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
            this.label_gptb2 = new System.Windows.Forms.Label();
            this.label_nhapa = new System.Windows.Forms.Label();
            this.label_nhapb = new System.Windows.Forms.Label();
            this.label_nhapc = new System.Windows.Forms.Label();
            this.label_ketqua = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_giaipt = new System.Windows.Forms.Button();
            this.btn_lamlai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label_canhbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_gptb2
            // 
            this.label_gptb2.AutoSize = true;
            this.label_gptb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gptb2.ForeColor = System.Drawing.Color.Red;
            this.label_gptb2.Location = new System.Drawing.Point(180, 9);
            this.label_gptb2.Name = "label_gptb2";
            this.label_gptb2.Size = new System.Drawing.Size(491, 39);
            this.label_gptb2.TabIndex = 0;
            this.label_gptb2.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // label_nhapa
            // 
            this.label_nhapa.AutoSize = true;
            this.label_nhapa.Location = new System.Drawing.Point(282, 88);
            this.label_nhapa.Name = "label_nhapa";
            this.label_nhapa.Size = new System.Drawing.Size(42, 13);
            this.label_nhapa.TabIndex = 1;
            this.label_nhapa.Text = "Nhập a";
            // 
            // label_nhapb
            // 
            this.label_nhapb.AutoSize = true;
            this.label_nhapb.Location = new System.Drawing.Point(282, 114);
            this.label_nhapb.Name = "label_nhapb";
            this.label_nhapb.Size = new System.Drawing.Size(42, 13);
            this.label_nhapb.TabIndex = 2;
            this.label_nhapb.Text = "Nhập b";
            // 
            // label_nhapc
            // 
            this.label_nhapc.AutoSize = true;
            this.label_nhapc.Location = new System.Drawing.Point(282, 140);
            this.label_nhapc.Name = "label_nhapc";
            this.label_nhapc.Size = new System.Drawing.Size(42, 13);
            this.label_nhapc.TabIndex = 3;
            this.label_nhapc.Text = "Nhập c";
            // 
            // label_ketqua
            // 
            this.label_ketqua.AutoSize = true;
            this.label_ketqua.Location = new System.Drawing.Point(282, 169);
            this.label_ketqua.Name = "label_ketqua";
            this.label_ketqua.Size = new System.Drawing.Size(44, 13);
            this.label_ketqua.TabIndex = 4;
            this.label_ketqua.Text = "Kết quả";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(330, 85);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(211, 20);
            this.txt_a.TabIndex = 5;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(330, 111);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(211, 20);
            this.txt_b.TabIndex = 6;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(330, 137);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(211, 20);
            this.txt_c.TabIndex = 7;
            // 
            // txt_kq
            // 
            this.txt_kq.BackColor = System.Drawing.SystemColors.Info;
            this.txt_kq.Location = new System.Drawing.Point(330, 166);
            this.txt_kq.Multiline = true;
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.ReadOnly = true;
            this.txt_kq.Size = new System.Drawing.Size(211, 63);
            this.txt_kq.TabIndex = 8;
            this.txt_kq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kq_KeyDown);
            // 
            // btn_giaipt
            // 
            this.btn_giaipt.Location = new System.Drawing.Point(187, 267);
            this.btn_giaipt.Name = "btn_giaipt";
            this.btn_giaipt.Size = new System.Drawing.Size(75, 23);
            this.btn_giaipt.TabIndex = 9;
            this.btn_giaipt.Text = "Giải phương trình";
            this.btn_giaipt.UseVisualStyleBackColor = true;
            this.btn_giaipt.Click += new System.EventHandler(this.btn_giaipt_Click);
            // 
            // btn_lamlai
            // 
            this.btn_lamlai.Location = new System.Drawing.Point(390, 267);
            this.btn_lamlai.Name = "btn_lamlai";
            this.btn_lamlai.Size = new System.Drawing.Size(75, 23);
            this.btn_lamlai.TabIndex = 10;
            this.btn_lamlai.Text = "Làm lại";
            this.btn_lamlai.UseVisualStyleBackColor = true;
            this.btn_lamlai.Click += new System.EventHandler(this.btn_lamlai_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(596, 267);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label_canhbao
            // 
            this.label_canhbao.AutoSize = true;
            this.label_canhbao.ForeColor = System.Drawing.Color.Red;
            this.label_canhbao.Location = new System.Drawing.Point(330, 243);
            this.label_canhbao.Name = "label_canhbao";
            this.label_canhbao.Size = new System.Drawing.Size(0, 13);
            this.label_canhbao.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_canhbao);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lamlai);
            this.Controls.Add(this.btn_giaipt);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label_ketqua);
            this.Controls.Add(this.label_nhapc);
            this.Controls.Add(this.label_nhapb);
            this.Controls.Add(this.label_nhapa);
            this.Controls.Add(this.label_gptb2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_gptb2;
        private System.Windows.Forms.Label label_nhapa;
        private System.Windows.Forms.Label label_nhapb;
        private System.Windows.Forms.Label label_nhapc;
        private System.Windows.Forms.Label label_ketqua;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_giaipt;
        private System.Windows.Forms.Button btn_lamlai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label_canhbao;
    }
}

