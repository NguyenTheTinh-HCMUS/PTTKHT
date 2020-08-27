namespace PTTKHT.GUI
{
    partial class fr_NhanVien_NhapHang
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
            this.comb_ncc = new System.Windows.Forms.ComboBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lydo = new System.Windows.Forms.TextBox();
            this.btn_yeucaunhaphang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_xoact = new System.Windows.Forms.Button();
            this.dtv_ct = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HangHoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.btn_themct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nhapmax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_ct)).BeginInit();
            this.SuspendLayout();
            // 
            // comb_ncc
            // 
            this.comb_ncc.FormattingEnabled = true;
            this.comb_ncc.Location = new System.Drawing.Point(12, 46);
            this.comb_ncc.Name = "comb_ncc";
            this.comb_ncc.Size = new System.Drawing.Size(217, 28);
            this.comb_ncc.TabIndex = 0;
            this.comb_ncc.SelectedIndexChanged += new System.EventHandler(this.comb_ncc_SelectedIndexChanged);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(1, 101);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 62;
            this.dtgv.RowTemplate.Height = 28;
            this.dtgv.Size = new System.Drawing.Size(557, 316);
            this.dtgv.TabIndex = 1;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lý Do";
            // 
            // txt_lydo
            // 
            this.txt_lydo.Location = new System.Drawing.Point(353, 47);
            this.txt_lydo.Name = "txt_lydo";
            this.txt_lydo.Size = new System.Drawing.Size(285, 26);
            this.txt_lydo.TabIndex = 3;
            // 
            // btn_yeucaunhaphang
            // 
            this.btn_yeucaunhaphang.Location = new System.Drawing.Point(693, 37);
            this.btn_yeucaunhaphang.Name = "btn_yeucaunhaphang";
            this.btn_yeucaunhaphang.Size = new System.Drawing.Size(192, 44);
            this.btn_yeucaunhaphang.TabIndex = 4;
            this.btn_yeucaunhaphang.Text = "Yêu Cầu Nhập Hàng";
            this.btn_yeucaunhaphang.UseVisualStyleBackColor = true;
            this.btn_yeucaunhaphang.Click += new System.EventHandler(this.btn_yeucaunhaphang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_xoact);
            this.panel1.Controls.Add(this.dtv_ct);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(564, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 641);
            this.panel1.TabIndex = 5;
            // 
            // btn_xoact
            // 
            this.btn_xoact.Location = new System.Drawing.Point(249, 438);
            this.btn_xoact.Name = "btn_xoact";
            this.btn_xoact.Size = new System.Drawing.Size(148, 43);
            this.btn_xoact.TabIndex = 2;
            this.btn_xoact.Text = "Xóa Chi Tiết";
            this.btn_xoact.UseVisualStyleBackColor = true;
            this.btn_xoact.Click += new System.EventHandler(this.btn_xoact_Click);
            // 
            // dtv_ct
            // 
            this.dtv_ct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_ct.Location = new System.Drawing.Point(3, 119);
            this.dtv_ct.Name = "dtv_ct";
            this.dtv_ct.RowHeadersWidth = 62;
            this.dtv_ct.RowTemplate.Height = 28;
            this.dtv_ct.Size = new System.Drawing.Size(406, 270);
            this.dtv_ct.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông Tin Chi Tiết";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hàng Hóa";
            // 
            // txt_HangHoa
            // 
            this.txt_HangHoa.Location = new System.Drawing.Point(148, 492);
            this.txt_HangHoa.Name = "txt_HangHoa";
            this.txt_HangHoa.Size = new System.Drawing.Size(156, 26);
            this.txt_HangHoa.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(148, 556);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(156, 26);
            this.txt_soluong.TabIndex = 7;
            // 
            // btn_themct
            // 
            this.btn_themct.Location = new System.Drawing.Point(353, 556);
            this.btn_themct.Name = "btn_themct";
            this.btn_themct.Size = new System.Drawing.Size(178, 35);
            this.btn_themct.TabIndex = 8;
            this.btn_themct.Text = "Thêm Chi Tiết";
            this.btn_themct.UseVisualStyleBackColor = true;
            this.btn_themct.Click += new System.EventHandler(this.btn_themct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập Max";
            // 
            // txt_nhapmax
            // 
            this.txt_nhapmax.Enabled = false;
            this.txt_nhapmax.Location = new System.Drawing.Point(148, 622);
            this.txt_nhapmax.Name = "txt_nhapmax";
            this.txt_nhapmax.Size = new System.Drawing.Size(156, 26);
            this.txt_nhapmax.TabIndex = 7;
            // 
            // fr_NhanVien_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.btn_themct);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nhapmax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_HangHoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_yeucaunhaphang);
            this.Controls.Add(this.txt_lydo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.comb_ncc);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "fr_NhanVien_NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.fr_NhanVien_NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_ct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comb_ncc;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lydo;
        private System.Windows.Forms.Button btn_yeucaunhaphang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HangHoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Button btn_themct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nhapmax;
        private System.Windows.Forms.Button btn_xoact;
        private System.Windows.Forms.DataGridView dtv_ct;
    }
}