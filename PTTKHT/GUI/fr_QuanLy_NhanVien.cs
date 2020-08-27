using PTTKHT.BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHT.GUI
{
    public partial class fr_QuanLy_NhanVien : Form
    {
        public NhanVien NhanVien { get; set; }
        public fr_QuanLy_NhanVien()
        {
            InitializeComponent();
        }
        public fr_QuanLy_NhanVien(NhanVien nv)
        {
            InitializeComponent();
            this.NhanVien = nv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fr_QuanLy_NhanVien_Load(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            if (this.NhanVien!=null)
            {
                btn_handle.Text = "Cập Nhật";
                txt_diachi.Text = this.NhanVien.DiaChi;
                txt_email.Text = this.NhanVien.Email;
                txt_hoten.Text = this.NhanVien.HoTen;
                txt_pass.Text = this.NhanVien.Password;
                txt_sodt.Text = this.NhanVien.SoDT;
                comb_chucvu.SelectedIndex = findIndexChucVu();

            }
        }
        private int findIndexChucVu()
        {
            for(int i = 0; i < comb_chucvu.Items.Count; i++)
            {
                if (this.NhanVien.ChucVu == comb_chucvu.Items[i].ToString())
                {
                    return i;
                }
            }
            return -1;
        }
        private void MesageFaild()
        {
            MessageBox.Show("Không thành công vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MessageSucess()
        {
            MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MessageValidate(List<String> list)
        {
            MessageBox.Show(String.Format("Vui long kiem tra lai các trường: {0}", String.Join(", ", list)), "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btn_handle_Click(object sender, EventArgs e)
        {
            List<String> listError = new List<String>();
            if (txt_diachi.Text == "" || txt_email.Text == "" || txt_hoten.Text == "" || txt_pass.Text == "" || txt_sodt.Text == "")
            {
                listError.Add("Trường không được rỗng");
            }
            if (listError.Count == 0)
            {

                bool rs = this.NhanVien == null ? NhanVien_BUL.Them(txt_email.Text, txt_hoten.Text, txt_sodt.Text, txt_diachi.Text, txt_pass.Text,comb_chucvu.SelectedItem.ToString()) : NhanVien_BUL.ChinhSua(this.NhanVien.ID, txt_email.Text, txt_hoten.Text, txt_sodt.Text, txt_diachi.Text, txt_pass.Text,comb_chucvu.SelectedItem.ToString());

                if (rs == true)
                {
                    MessageSucess();
                }
                else
                {
                    MesageFaild();
                }
            }
            else
            {
                MessageValidate(listError);
            }
        }
    }
}
