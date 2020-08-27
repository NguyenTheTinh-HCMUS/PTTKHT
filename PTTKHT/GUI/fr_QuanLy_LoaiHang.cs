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
    public partial class fr_QuanLy_LoaiHang : Form
    {
        public LoaiHoang LoaiHoang { get; set; }
        public fr_QuanLy_LoaiHang()
        {
            InitializeComponent();
        }
        public fr_QuanLy_LoaiHang(LoaiHoang LoaiHoang)
        {
            InitializeComponent();
            this.LoaiHoang = LoaiHoang;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                bool rs = this.LoaiHoang==null ?LoaiHang_BUL.Them(txtTen.Text) : LoaiHang_BUL.ChinhSua(this.LoaiHoang.ID,txtTen.Text);

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
                MessageValidate(new string[]{ "Tên loại hàng"});
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
        private void MessageValidate(string[] list)
        {
            MessageBox.Show(String.Format("Vui long kiem tra lai các trường: {0}",String.Join(", ",list)), "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fr_QuanLy_LoaiHang_Load(object sender, EventArgs e)
        {
            init();

        }
        private void init()
        {
            if (this.LoaiHoang != null)
            {
                btn_them.Text = "Cập Nhật";
                txtTen.Text = this.LoaiHoang.TenLoai;
            }
            else
            {
            }
        }
    }

}
