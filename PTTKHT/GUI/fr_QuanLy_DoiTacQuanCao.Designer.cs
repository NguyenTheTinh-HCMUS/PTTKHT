namespace PTTKHT.GUI
{
    partial class fr_QuanLy_DoiTacQuanCao
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tendoitac = new System.Windows.Forms.TextBox();
            this.btn_handle = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(370, 89);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(172, 26);
            this.txt_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đối Tác Quảng Cáo";
            // 
            // txt_tendoitac
            // 
            this.txt_tendoitac.Location = new System.Drawing.Point(370, 200);
            this.txt_tendoitac.Name = "txt_tendoitac";
            this.txt_tendoitac.Size = new System.Drawing.Size(172, 26);
            this.txt_tendoitac.TabIndex = 1;
            // 
            // btn_handle
            // 
            this.btn_handle.Location = new System.Drawing.Point(329, 306);
            this.btn_handle.Name = "btn_handle";
            this.btn_handle.Size = new System.Drawing.Size(244, 51);
            this.btn_handle.TabIndex = 2;
            this.btn_handle.Text = "Thêm";
            this.btn_handle.UseVisualStyleBackColor = true;
            this.btn_handle.Click += new System.EventHandler(this.btn_handle_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(630, 387);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(143, 51);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // fr_QuanLy_DoiTacQuanCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_handle);
            this.Controls.Add(this.txt_tendoitac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Name = "fr_QuanLy_DoiTacQuanCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đối Tác Quảng Cáo";
            this.Load += new System.EventHandler(this.fr_QuanLy_DoiTacQuanCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tendoitac;
        private System.Windows.Forms.Button btn_handle;
        private System.Windows.Forms.Button btn_thoat;
    }
}