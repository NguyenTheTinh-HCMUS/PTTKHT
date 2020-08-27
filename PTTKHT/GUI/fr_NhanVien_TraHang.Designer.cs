namespace PTTKHT.GUI
{
    partial class fr_NhanVien_TraHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Lapphieutra = new System.Windows.Forms.Button();
            this.comb_NCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xoact = new System.Windows.Forms.Button();
            this.dtgv_2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IDHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.btn_themct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sltra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_lyDo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_lyDo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_Lapphieutra);
            this.panel1.Controls.Add(this.comb_NCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 170);
            this.panel1.TabIndex = 0;
            // 
            // btn_Lapphieutra
            // 
            this.btn_Lapphieutra.Location = new System.Drawing.Point(619, 29);
            this.btn_Lapphieutra.Name = "btn_Lapphieutra";
            this.btn_Lapphieutra.Size = new System.Drawing.Size(321, 58);
            this.btn_Lapphieutra.TabIndex = 4;
            this.btn_Lapphieutra.Text = "Lập Phiếu Trả Hàng";
            this.btn_Lapphieutra.UseVisualStyleBackColor = true;
            this.btn_Lapphieutra.Click += new System.EventHandler(this.btn_Lapphieutra_Click);
            // 
            // comb_NCC
            // 
            this.comb_NCC.FormattingEnabled = true;
            this.comb_NCC.Location = new System.Drawing.Point(29, 50);
            this.comb_NCC.Name = "comb_NCC";
            this.comb_NCC.Size = new System.Drawing.Size(244, 28);
            this.comb_NCC.TabIndex = 0;
            this.comb_NCC.SelectedIndexChanged += new System.EventHandler(this.comb_NCC_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà Cung Cấp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xoact);
            this.panel2.Controls.Add(this.dtgv_2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(529, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 564);
            this.panel2.TabIndex = 1;
            // 
            // btn_xoact
            // 
            this.btn_xoact.Location = new System.Drawing.Point(300, 445);
            this.btn_xoact.Name = "btn_xoact";
            this.btn_xoact.Size = new System.Drawing.Size(146, 47);
            this.btn_xoact.TabIndex = 1;
            this.btn_xoact.Text = "Xóa";
            this.btn_xoact.UseVisualStyleBackColor = true;
            this.btn_xoact.Click += new System.EventHandler(this.btn_xoact_Click);
            // 
            // dtgv_2
            // 
            this.dtgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_2.Location = new System.Drawing.Point(7, 92);
            this.dtgv_2.Name = "dtgv_2";
            this.dtgv_2.RowHeadersWidth = 62;
            this.dtgv_2.RowTemplate.Height = 28;
            this.dtgv_2.Size = new System.Drawing.Size(442, 347);
            this.dtgv_2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh Sách Chi Tiết";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Location = new System.Drawing.Point(0, 226);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.RowHeadersWidth = 62;
            this.dtgv1.RowTemplate.Height = 28;
            this.dtgv1.Size = new System.Drawing.Size(523, 351);
            this.dtgv1.TabIndex = 2;
            this.dtgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Hàng";
            // 
            // txt_IDHang
            // 
            this.txt_IDHang.Enabled = false;
            this.txt_IDHang.Location = new System.Drawing.Point(141, 590);
            this.txt_IDHang.Name = "txt_IDHang";
            this.txt_IDHang.Size = new System.Drawing.Size(212, 26);
            this.txt_IDHang.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Hàng";
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Enabled = false;
            this.txt_tenhang.Location = new System.Drawing.Point(141, 629);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(212, 26);
            this.txt_tenhang.TabIndex = 4;
            // 
            // btn_themct
            // 
            this.btn_themct.Location = new System.Drawing.Point(379, 625);
            this.btn_themct.Name = "btn_themct";
            this.btn_themct.Size = new System.Drawing.Size(122, 30);
            this.btn_themct.TabIndex = 5;
            this.btn_themct.Text = "Thêm";
            this.btn_themct.UseVisualStyleBackColor = true;
            this.btn_themct.Click += new System.EventHandler(this.btn_themct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Danh Sách Hàng Hóa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 673);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số Lượng Trả";
            // 
            // txt_sltra
            // 
            this.txt_sltra.Enabled = false;
            this.txt_sltra.Location = new System.Drawing.Point(141, 673);
            this.txt_sltra.Name = "txt_sltra";
            this.txt_sltra.Size = new System.Drawing.Size(212, 26);
            this.txt_sltra.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lý Do";
            // 
            // txt_lyDo
            // 
            this.txt_lyDo.Location = new System.Drawing.Point(306, 50);
            this.txt_lyDo.Name = "txt_lyDo";
            this.txt_lyDo.Size = new System.Drawing.Size(289, 26);
            this.txt_lyDo.TabIndex = 7;
            // 
            // fr_NhanVien_TraHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.btn_themct);
            this.Controls.Add(this.txt_sltra);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IDHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "fr_NhanVien_TraHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trả Hàng Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.fr_NhanVien_TraHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Lapphieutra;
        private System.Windows.Forms.ComboBox comb_NCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_xoact;
        private System.Windows.Forms.DataGridView dtgv_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IDHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Button btn_themct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sltra;
        private System.Windows.Forms.TextBox txt_lyDo;
        private System.Windows.Forms.Label label7;
    }
}