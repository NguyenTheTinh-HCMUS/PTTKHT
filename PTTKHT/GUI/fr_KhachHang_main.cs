using PTTKHT.BUL;
using PTTKHT.DAL;
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
    public partial class fr_KhachHang_main : Form
    {
        public KhachHang KhachHang { get; set; }
        public fr_KhachHang_main()
        {
            InitializeComponent();
        }
        public fr_KhachHang_main(KhachHang kh)
        {
            this.KhachHang = kh;

            InitializeComponent();
        }

        private void fr_KhachHang_main_Load(object sender, EventArgs e)
        {
            init_comment();
        }
        private void init_comment()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID",typeof(int));
            table.Columns.Add("Tên Hàng Hóa", typeof(string));
            //table.Columns.Add("Loại", typeof(string));
            table.Columns.Add("Gia", typeof(double));


            foreach (HangHoa hh in HangHoa_BUL.getList())
            {
                table.Rows.Add(hh.ID, hh.TenHH, hh.DonGia);
            }
            dtgv_t1.DataSource = table;
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

        private void fr_KhachHang_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void dtgv_t1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtgv_t1.CurrentCell.Selected = true;
                txt_IDtag1.Text = dtgv_t1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txt_tenhang_t1.Text = dtgv_t1.Rows[e.RowIndex].Cells["Tên Hàng Hóa"].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void dtgv_t1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_guibinhluan_Click(object sender, EventArgs e)
        {
            if(txt_comment.Text!="" && txt_IDtag1.Text!="" && txt_tenhang_t1.Text != "")
            {
                Comment cm = new Comment() { 
                    IDHangHoa=Convert.ToInt32(txt_IDtag1.Text),
                    IDKhachHang=this.KhachHang.ID,
                    Ngay=DateTime.Now,
                    NoiDung=txt_comment.Text
                };
                if (Comment_BUL.Them(cm) != null)
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
                MesageFaild();
            }
        }
    }
}
