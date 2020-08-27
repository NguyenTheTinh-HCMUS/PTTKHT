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
    public partial class fr_QuanLy_KhachHang : Form
    {
        public KhachHang KhachHang { get; set; }
        public fr_QuanLy_KhachHang()
        {
            InitializeComponent();
        }
        public fr_QuanLy_KhachHang(KhachHang kh)
        {
            InitializeComponent();
            this.KhachHang = kh;
        }

        private void btn_handle_Click(object sender, EventArgs e)
        {
            List<String> listError = new List<String>();
            if (txt_diachi.Text == "" || txt_email.Text == "" || txt_hoten.Text == "" || txt_pass.Text == "" || txt_sdt.Text == "")
            {
                listError.Add("Trường không được rỗng");
            }
            if (listError.Count == 0)
            {

                bool rs = this.KhachHang == null ? KhachHang_BUL.Them(txt_email.Text,txt_hoten.Text,txt_sdt.Text,txt_diachi.Text,txt_pass.Text) : KhachHang_BUL.ChinhSua(this.KhachHang.ID,txt_email.Text,txt_hoten.Text,txt_sdt.Text,txt_diachi.Text,txt_pass.Text);

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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fr_QuanLy_KhachHang_Load(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            if (this.KhachHang != null)
            {
                txt_diachi.Text = this.KhachHang.DiaChi;
                txt_email.Text = this.KhachHang.Email;
                txt_hoten.Text = this.KhachHang.HoTen;
                txt_pass.Text = this.KhachHang.Password;
                txt_sdt.Text = this.KhachHang.SoDT;
                btn_handle.Text = "Chỉnh Sửa";
            }
            
        }
    }
}
