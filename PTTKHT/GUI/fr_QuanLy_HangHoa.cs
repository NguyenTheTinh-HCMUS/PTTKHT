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
    public partial class fr_QuanLy_HangHoa : Form
    {
        public HangHoa HangHoa { get; set; }
        public fr_QuanLy_HangHoa()
        {
            InitializeComponent();
        }
        public fr_QuanLy_HangHoa(HangHoa HangHoa)
        {
            InitializeComponent();
            this.HangHoa = HangHoa;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void fr_QuanLy_HangHoa_Load(object sender, EventArgs e)
        {
            init();
            if (this.HangHoa != null)
            {
                updateToFilde();

            }
        }
        private void init()
        {
            List<LoaiHoang> listLoaihang= LoaiHang_BUL.getList();
            comb_loaihang.DataSource = listLoaihang;
            comb_loaihang.DisplayMember = "TenLoai";
            List<NhanVien> listQuanLy = NhanVien_BUL.getListNhanVien();
            comb_quanly.DataSource = listQuanLy;
            comb_quanly.DisplayMember = "HoTen";
            List<NhaCungCap> listNCC = NhaCungCap_BUL.getList();
            comb_ncc.DataSource = listNCC;
            comb_ncc.DisplayMember = "TenNCC";
            txt_sltra.Enabled = false;
            txt_sltra.Text = "0";
        }
        private void updateToFilde()
        {
            txt_ID.Text = this.HangHoa.ID.ToString();
            txt_dongia.Text = this.HangHoa.DonGia.ToString();
            txt_slmax.Text = this.HangHoa.NhapMax.ToString();
            txt_sltra.Text = this.HangHoa.SoLuongTra.ToString();
            txt_slmin.Text = this.HangHoa.SLmin.ToString();
            txt_tenHH.Text = this.HangHoa.TenHH;
            btn_handle.Text = "Chỉnh Sửa";
            comb_loaihang.SelectedIndex = findIndexLoaiHangHoa();
            comb_ncc.SelectedIndex = findIndexNCC();
            comb_quanly.SelectedIndex = findIndexQuanLy();
        }
        private int findIndexQuanLy()
        {
            for(int i = 0; i < comb_quanly.Items.Count; i++)
            {
                NhanVien a = (NhanVien)comb_quanly.Items[i];

                if (a.ID == this.HangHoa.QuanLy)
                {
                    return i;
                }
            }
            return -1;
        }
        private int findIndexNCC()
        {
            for (int i = 0; i < comb_ncc.Items.Count; i++)
            {
                NhaCungCap a =(NhaCungCap)comb_ncc.Items[i];

                if (a.ID == this.HangHoa.NCC)
                {
                    return i;
                }
            }
            return -1;
        }
        private int findIndexLoaiHangHoa()
        {
            for (int i = 0; i < comb_loaihang.Items.Count; i++)
            {
                LoaiHoang a =(LoaiHoang)comb_loaihang.Items[i];
                if (a.ID == this.HangHoa.LoaiHang)
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
            List<String> listError = new List<String>() ;
            if(txt_dongia.Text=="" ||  txt_slmax.Text=="" || txt_slmin.Text=="" || txt_sltra.Text=="" || txt_tenHH.Text=="")
            {
                listError.Add("Trường không được rỗng");
            }
            if (listError.Count==0)
            {
                NhaCungCap ncc = (NhaCungCap)comb_ncc.SelectedItem;
                NhanVien ql = (NhanVien)comb_quanly.SelectedItem;
                LoaiHoang lh = (LoaiHoang)comb_loaihang.SelectedItem;
                bool rs = this.HangHoa == null ? HangHoa_BUL.Them(txt_tenHH.Text, Convert.ToInt32(txt_slmax.Text), Convert.ToInt32(txt_slmin.Text), ncc.ID, ql.ID, lh.ID, Convert.ToDouble(txt_dongia.Text)) : HangHoa_BUL.ChinhSua(this.HangHoa.ID,txt_tenHH.Text, Convert.ToInt32(txt_slmax.Text), Convert.ToInt32(txt_slmin.Text), ncc.ID, ql.ID, lh.ID, Convert.ToDouble(txt_dongia.Text));

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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
