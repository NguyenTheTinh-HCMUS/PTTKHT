namespace PTTKHT.GUI
{
    partial class fr_KhachHang_main
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgv_t1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IDtag1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenhang_t1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.btn_guibinhluan = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_t1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 686);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_guibinhluan);
            this.tabPage1.Controls.Add(this.txt_comment);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_tenhang_t1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_IDtag1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtgv_t1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mua Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgv_t1
            // 
            this.dtgv_t1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_t1.Location = new System.Drawing.Point(0, 186);
            this.dtgv_t1.Name = "dtgv_t1";
            this.dtgv_t1.RowHeadersWidth = 62;
            this.dtgv_t1.RowTemplate.Height = 28;
            this.dtgv_t1.Size = new System.Drawing.Size(965, 467);
            this.dtgv_t1.TabIndex = 0;
            this.dtgv_t1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_t1_CellClick);
            this.dtgv_t1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_t1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txt_IDtag1
            // 
            this.txt_IDtag1.Enabled = false;
            this.txt_IDtag1.Location = new System.Drawing.Point(119, 26);
            this.txt_IDtag1.Name = "txt_IDtag1";
            this.txt_IDtag1.Size = new System.Drawing.Size(199, 26);
            this.txt_IDtag1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Hàng";
            // 
            // txt_tenhang_t1
            // 
            this.txt_tenhang_t1.Enabled = false;
            this.txt_tenhang_t1.Location = new System.Drawing.Point(511, 26);
            this.txt_tenhang_t1.Name = "txt_tenhang_t1";
            this.txt_tenhang_t1.Size = new System.Drawing.Size(199, 26);
            this.txt_tenhang_t1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Comment";
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(119, 74);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(591, 26);
            this.txt_comment.TabIndex = 2;
            // 
            // btn_guibinhluan
            // 
            this.btn_guibinhluan.Location = new System.Drawing.Point(756, 38);
            this.btn_guibinhluan.Name = "btn_guibinhluan";
            this.btn_guibinhluan.Size = new System.Drawing.Size(161, 47);
            this.btn_guibinhluan.TabIndex = 3;
            this.btn_guibinhluan.Text = "Gửi Bình Luận";
            this.btn_guibinhluan.UseVisualStyleBackColor = true;
            this.btn_guibinhluan.Click += new System.EventHandler(this.btn_guibinhluan_Click);
            // 
            // fr_KhachHang_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "fr_KhachHang_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khach Hang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_KhachHang_main_FormClosing);
            this.Load += new System.EventHandler(this.fr_KhachHang_main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_t1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_guibinhluan;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tenhang_t1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDtag1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_t1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}