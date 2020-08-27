namespace PTTKHT.GUI
{
    partial class fr_QuanLy_HangHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_slmax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_slmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sltra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comb_ncc = new System.Windows.Forms.ComboBox();
            this.comb_quanly = new System.Windows.Forms.ComboBox();
            this.comb_loaihang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_handle = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Hàng Hóa";
            // 
            // txt_tenHH
            // 
            this.txt_tenHH.Location = new System.Drawing.Point(251, 64);
            this.txt_tenHH.Name = "txt_tenHH";
            this.txt_tenHH.Size = new System.Drawing.Size(165, 26);
            this.txt_tenHH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng nhập max";
            // 
            // txt_slmax
            // 
            this.txt_slmax.Location = new System.Drawing.Point(251, 146);
            this.txt_slmax.Name = "txt_slmax";
            this.txt_slmax.Size = new System.Drawing.Size(165, 26);
            this.txt_slmax.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lương  hàng min";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_slmin
            // 
            this.txt_slmin.Location = new System.Drawing.Point(251, 229);
            this.txt_slmin.Name = "txt_slmin";
            this.txt_slmin.Size = new System.Drawing.Size(165, 26);
            this.txt_slmin.TabIndex = 7;
            this.txt_slmin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng trả";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_sltra
            // 
            this.txt_sltra.Location = new System.Drawing.Point(251, 328);
            this.txt_sltra.Name = "txt_sltra";
            this.txt_sltra.Size = new System.Drawing.Size(165, 26);
            this.txt_sltra.TabIndex = 9;
            this.txt_sltra.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đơn Giá";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(608, 64);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(165, 26);
            this.txt_dongia.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quản Lý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Loại Hàng";
            // 
            // comb_ncc
            // 
            this.comb_ncc.FormattingEnabled = true;
            this.comb_ncc.Location = new System.Drawing.Point(608, 152);
            this.comb_ncc.Name = "comb_ncc";
            this.comb_ncc.Size = new System.Drawing.Size(165, 28);
            this.comb_ncc.TabIndex = 13;
            // 
            // comb_quanly
            // 
            this.comb_quanly.FormattingEnabled = true;
            this.comb_quanly.Location = new System.Drawing.Point(608, 229);
            this.comb_quanly.Name = "comb_quanly";
            this.comb_quanly.Size = new System.Drawing.Size(165, 28);
            this.comb_quanly.TabIndex = 15;
            // 
            // comb_loaihang
            // 
            this.comb_loaihang.FormattingEnabled = true;
            this.comb_loaihang.Location = new System.Drawing.Point(608, 320);
            this.comb_loaihang.Name = "comb_loaihang";
            this.comb_loaihang.Size = new System.Drawing.Size(165, 28);
            this.comb_loaihang.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(209, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(278, 26);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btn_handle
            // 
            this.btn_handle.Location = new System.Drawing.Point(34, 396);
            this.btn_handle.Name = "btn_handle";
            this.btn_handle.Size = new System.Drawing.Size(245, 42);
            this.btn_handle.TabIndex = 18;
            this.btn_handle.Text = "Thêm";
            this.btn_handle.UseVisualStyleBackColor = true;
            this.btn_handle.Click += new System.EventHandler(this.btn_handle_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(528, 396);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(245, 42);
            this.btn_thoat.TabIndex = 19;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // fr_QuanLy_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_handle);
            this.Controls.Add(this.comb_loaihang);
            this.Controls.Add(this.comb_quanly);
            this.Controls.Add(this.comb_ncc);
            this.Controls.Add(this.txt_sltra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_slmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_slmax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tenHH);
            this.Controls.Add(this.label1);
            this.Name = "fr_QuanLy_HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.fr_QuanLy_HangHoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_slmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_slmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sltra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comb_ncc;
        private System.Windows.Forms.ComboBox comb_quanly;
        private System.Windows.Forms.ComboBox comb_loaihang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_handle;
        private System.Windows.Forms.Button btn_thoat;
    }
}