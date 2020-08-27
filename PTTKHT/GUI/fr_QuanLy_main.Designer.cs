namespace PTTKHT.GUI
{
    partial class fr_QuanLy_main
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
            this.control_tab = new System.Windows.Forms.TabControl();
            this.tab_quanly = new System.Windows.Forms.TabPage();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.comb_danhmuc = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cob2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgv_ds1 = new System.Windows.Forms.DataGridView();
            this.dtgvct2 = new System.Windows.Forms.DataGridView();
            this.control_tab.SuspendLayout();
            this.tab_quanly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvct2)).BeginInit();
            this.SuspendLayout();
            // 
            // control_tab
            // 
            this.control_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.control_tab.Controls.Add(this.tab_quanly);
            this.control_tab.Controls.Add(this.tabPage2);
            this.control_tab.Location = new System.Drawing.Point(-3, 38);
            this.control_tab.Name = "control_tab";
            this.control_tab.SelectedIndex = 0;
            this.control_tab.Size = new System.Drawing.Size(983, 715);
            this.control_tab.TabIndex = 0;
            // 
            // tab_quanly
            // 
            this.tab_quanly.Controls.Add(this.btn_timkiem);
            this.tab_quanly.Controls.Add(this.txt_search);
            this.tab_quanly.Controls.Add(this.btn_sua);
            this.tab_quanly.Controls.Add(this.btn_xoa);
            this.tab_quanly.Controls.Add(this.btn_them);
            this.tab_quanly.Controls.Add(this.label1);
            this.tab_quanly.Controls.Add(this.dtgv);
            this.tab_quanly.Controls.Add(this.comb_danhmuc);
            this.tab_quanly.Location = new System.Drawing.Point(4, 29);
            this.tab_quanly.Name = "tab_quanly";
            this.tab_quanly.Padding = new System.Windows.Forms.Padding(3);
            this.tab_quanly.Size = new System.Drawing.Size(975, 682);
            this.tab_quanly.TabIndex = 0;
            this.tab_quanly.Text = "Quản Lý";
            this.tab_quanly.UseVisualStyleBackColor = true;
            this.tab_quanly.Click += new System.EventHandler(this.tab_quanly_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(827, 54);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(138, 32);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(624, 57);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(187, 26);
            this.txt_search.TabIndex = 4;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(678, 560);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(218, 50);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(347, 560);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(218, 50);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(58, 560);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(218, 50);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Mục Quản Lý";
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(0, 107);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 62;
            this.dtgv.RowTemplate.Height = 28;
            this.dtgv.Size = new System.Drawing.Size(1465, 371);
            this.dtgv.TabIndex = 1;
            // 
            // comb_danhmuc
            // 
            this.comb_danhmuc.FormattingEnabled = true;
            this.comb_danhmuc.Items.AddRange(new object[] {
            "Loại Hàng Hóa",
            "Hàng Hóa",
            "Khách Hàng",
            "Nhà Cung Cấp",
            "Nhân Viên",
            "Đối Tác Quảng Cáo"});
            this.comb_danhmuc.Location = new System.Drawing.Point(37, 55);
            this.comb_danhmuc.Name = "comb_danhmuc";
            this.comb_danhmuc.Size = new System.Drawing.Size(179, 28);
            this.comb_danhmuc.TabIndex = 0;
            this.comb_danhmuc.SelectedIndexChanged += new System.EventHandler(this.comb_danhmuc_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_xacnhan);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.cob2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xác Nhận Đơn Nhập Trả Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cob2
            // 
            this.cob2.FormattingEnabled = true;
            this.cob2.Items.AddRange(new object[] {
            "Nhập Hàng",
            "Trả Hàng"});
            this.cob2.Location = new System.Drawing.Point(11, 28);
            this.cob2.Name = "cob2";
            this.cob2.Size = new System.Drawing.Size(271, 28);
            this.cob2.TabIndex = 0;
            this.cob2.SelectedIndexChanged += new System.EventHandler(this.cob2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv_ds1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 570);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvct2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(506, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 570);
            this.panel2.TabIndex = 2;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(795, 28);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(170, 51);
            this.btn_xacnhan.TabIndex = 3;
            this.btn_xacnhan.Text = "Xác Nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chi Tiết";
            // 
            // dtgv_ds1
            // 
            this.dtgv_ds1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ds1.Location = new System.Drawing.Point(8, 100);
            this.dtgv_ds1.Name = "dtgv_ds1";
            this.dtgv_ds1.RowHeadersWidth = 62;
            this.dtgv_ds1.RowTemplate.Height = 28;
            this.dtgv_ds1.Size = new System.Drawing.Size(476, 349);
            this.dtgv_ds1.TabIndex = 1;
            this.dtgv_ds1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ds1_CellClick);
            // 
            // dtgvct2
            // 
            this.dtgvct2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvct2.Location = new System.Drawing.Point(13, 100);
            this.dtgvct2.Name = "dtgvct2";
            this.dtgvct2.RowHeadersWidth = 62;
            this.dtgvct2.RowTemplate.Height = 28;
            this.dtgvct2.Size = new System.Drawing.Size(456, 349);
            this.dtgvct2.TabIndex = 1;
            this.dtgvct2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvct2_CellClick);
            // 
            // fr_QuanLy_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.control_tab);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "fr_QuanLy_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_QuanLy_main_FormClosing);
            this.Load += new System.EventHandler(this.fr_QuanLy_main_Load);
            this.control_tab.ResumeLayout(false);
            this.tab_quanly.ResumeLayout(false);
            this.tab_quanly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvct2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl control_tab;
        private System.Windows.Forms.TabPage tab_quanly;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.ComboBox comb_danhmuc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvct2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv_ds1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cob2;
    }
}