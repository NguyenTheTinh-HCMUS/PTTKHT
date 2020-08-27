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
    public partial class fr_QuanLy_DoiTacQuanCao : Form
    {
        public DoiTacQuangCao DoiTacQuangCao;
        public fr_QuanLy_DoiTacQuanCao()
        {
            InitializeComponent();
        }
        public fr_QuanLy_DoiTacQuanCao(DoiTacQuangCao dtqc)
        {
            InitializeComponent();
            this.DoiTacQuangCao = dtqc;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_handle_Click(object sender, EventArgs e)
        {
            if (txt_tendoitac.Text != "")
            {
                bool rs = this.DoiTacQuangCao == null ? DoiTacQuangCao_BUL.Them(txt_tendoitac.Text) : DoiTacQuangCao_BUL.ChinhSua(this.DoiTacQuangCao.ID,txt_tendoitac.Text);

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
                MessageValidate(new string[] { "Tên đối tác quảng cáo" });
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
            MessageBox.Show(String.Format("Vui long kiem tra lai các trường: {0}", String.Join(", ", list)), "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fr_QuanLy_DoiTacQuanCao_Load(object sender, EventArgs e)
        {
            if (this.DoiTacQuangCao != null)
            {
                txt_ID.Text = this.DoiTacQuangCao.ID.ToString();
                txt_tendoitac.Text = this.DoiTacQuangCao.TenDoiTac;
                btn_handle.Text = "Cập Nhật";
            }
        }
    }
}
