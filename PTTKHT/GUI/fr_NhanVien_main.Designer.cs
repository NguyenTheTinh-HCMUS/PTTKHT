namespace PTTKHT.GUI
{
    partial class fr_NhanVien_main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_yeucauNH = new System.Windows.Forms.Button();
            this.comb_filter = new System.Windows.Forms.ComboBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_trahang = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 686);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_trahang);
            this.tabPage1.Controls.Add(this.btn_yeucauNH);
            this.tabPage1.Controls.Add(this.comb_filter);
            this.tabPage1.Controls.Add(this.dtgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Sản Phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_yeucauNH
            // 
            this.btn_yeucauNH.Location = new System.Drawing.Point(461, 25);
            this.btn_yeucauNH.Name = "btn_yeucauNH";
            this.btn_yeucauNH.Size = new System.Drawing.Size(261, 47);
            this.btn_yeucauNH.TabIndex = 2;
            this.btn_yeucauNH.Text = "Yêu Cầu Nhập Hàng";
            this.btn_yeucauNH.UseVisualStyleBackColor = true;
            this.btn_yeucauNH.Click += new System.EventHandler(this.btn_yeucauNH_Click);
            // 
            // comb_filter
            // 
            this.comb_filter.FormattingEnabled = true;
            this.comb_filter.Items.AddRange(new object[] {
            "Tất cả sản phẩm quản lý",
            "Những sản phẩm cần nhập"});
            this.comb_filter.Location = new System.Drawing.Point(18, 35);
            this.comb_filter.Name = "comb_filter";
            this.comb_filter.Size = new System.Drawing.Size(374, 28);
            this.comb_filter.TabIndex = 1;
            this.comb_filter.SelectedIndexChanged += new System.EventHandler(this.comb_filter_SelectedIndexChanged);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(0, 99);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 62;
            this.dtgv.RowTemplate.Height = 28;
            this.dtgv.Size = new System.Drawing.Size(967, 332);
            this.dtgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_trahang
            // 
            this.btn_trahang.Location = new System.Drawing.Point(764, 25);
            this.btn_trahang.Name = "btn_trahang";
            this.btn_trahang.Size = new System.Drawing.Size(184, 47);
            this.btn_trahang.TabIndex = 3;
            this.btn_trahang.Text = "Lập Phiếu Trả Hàng";
            this.btn_trahang.UseVisualStyleBackColor = true;
            this.btn_trahang.Click += new System.EventHandler(this.btn_trahang_Click);
            // 
            // fr_NhanVien_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "fr_NhanVien_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhan Vien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_NhanVien_main_FormClosing);
            this.Load += new System.EventHandler(this.fr_NhanVien_main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.ComboBox comb_filter;
        private System.Windows.Forms.Button btn_yeucauNH;
        private System.Windows.Forms.Button btn_trahang;
    }
}