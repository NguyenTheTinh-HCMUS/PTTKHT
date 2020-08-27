using PTTKHT.BUL;
using PTTKHT.DAL;
using PTTKHT.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHT
{
    public partial class fr_login : Form
    {

        public fr_login()
        {
            InitializeComponent();
            // 
            combDomain.SelectedIndex = 0;
            //
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fr_login_Load(object sender, EventArgs e)
        {
            


        }

        private void combDomain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (combDomain.SelectedIndex == 0)
            {
                KhachHang kh = KhachHang_BUL.CheckKhachHang(txtUser.Text, txtPass.Text);
                if (kh != null)
                {
                    fr_KhachHang_main KhachHangForm = new fr_KhachHang_main(kh);
                    this.Hide();
                    KhachHangForm.Show();
                    KhachHangForm.FormClosing += Frm2_Closing;
                }
                else
                {
                    ShowMessage();

                }



            }
            else if (combDomain.SelectedIndex == 1)
            {
                NhanVien nv= NhanVien_BUL.CheckNhanVien(txtUser.Text, txtPass.Text);
                if ( nv!= null)
                {

                    if (nv.ChucVu == "NhanVien")
                    {
                        fr_NhanVien_main NhanVien = new fr_NhanVien_main(nv);
                        this.Hide();
                        NhanVien.Show();
                        NhanVien.FormClosing += Frm2_Closing;
                    }
                    else if (nv.ChucVu == "QuanLy")
                    {
                        
                        fr_QuanLy_main QuanLy = new fr_QuanLy_main(nv);
                        this.Hide();
                        QuanLy.Show();
                        QuanLy.FormClosing += Frm2_Closing;
                    }
                    else
                    {
                        ShowMessage();

                    }
                }
                else
                {
                    ShowMessage();
                }

               

            }
        }

        private void Frm2_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            // 
            combDomain.SelectedIndex = 0;
            //
            txtUser.Text = "";
            txtPass.Text = "";
        }
        private void ShowMessage()
        {
            MessageBox.Show("Kiem tra lai email hoac mat khau", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }

    
}
