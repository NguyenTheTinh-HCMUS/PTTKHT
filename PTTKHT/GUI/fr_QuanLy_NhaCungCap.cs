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
    public partial class fr_QuanLy_NhaCungCap : Form
    {
        public NhaCungCap NhaCungCap { get; set; }
        public fr_QuanLy_NhaCungCap()
        {
            InitializeComponent();
        }
        public fr_QuanLy_NhaCungCap(NhaCungCap ncc)
        {
            InitializeComponent();
            this.NhaCungCap = ncc;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            List<String> listError = new List<String>();
            if (txt_tenNCC.Text == "") { 
                listError.Add("Tên nhà cung cấp không được rỗng");
            }
            if (listError.Count == 0)
            {

                bool rs = this.NhaCungCap == null ? NhaCungCap_BUL.Them(txt_tenNCC.Text) : NhaCungCap_BUL.ChinhSua(this.NhaCungCap.ID,txt_tenNCC.Text);

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
        private void MessageValidate(List<string> list)
        {
            MessageBox.Show(String.Format("Vui long kiem tra lai các trường: {0}", String.Join(", ", list)), "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fr_QuanLy_NhaCungCap_Load(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            txt_ID.Enabled = false;

            if (this.NhaCungCap != null)
            {
                txt_ID.Text = this.NhaCungCap.ID.ToString();
                txt_tenNCC.Text = this.NhaCungCap.TenNCC;
                btn_them.Text="Cập nhật";
            }
        }
    }
}
