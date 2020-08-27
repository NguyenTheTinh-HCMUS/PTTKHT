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
    public partial class fr_NhanVien_NhapHang : Form
    {
        public NhanVien NhanVien { get; set; }
        public List<ChiTietDonNhapHang> ListChiTietDNH { get; set; }
        public fr_NhanVien_NhapHang()
        {
            InitializeComponent();
        }
        public fr_NhanVien_NhapHang(NhanVien nv)
        {
            InitializeComponent();
            this.NhanVien = nv;
            this.ListChiTietDNH = new List<ChiTietDonNhapHang>();
        }

        private void fr_NhanVien_NhapHang_Load(object sender, EventArgs e)
        {
            comb_ncc.DataSource = NhaCungCap_BUL.getList();
            comb_ncc.SelectedIndex = 0;
            comb_ncc.DisplayMember = "TenNCC";
            txt_HangHoa.Enabled = false;
            checkList();
            chinhsuaChiTiet();
        }
        private void chinhsuaChiTiet()
        {
            if (ListChiTietDNH==null || ListChiTietDNH.Count == 0)
            {
                btn_xoact.Hide();
                dtv_ct.Hide();
            }
            else
            {
                btn_xoact.Show();
                dtv_ct.Show();
            }
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Số Lượng", typeof(string));


            foreach (ChiTietDonNhapHang hh in this.ListChiTietDNH)
            {
                table.Rows.Add(hh.IDHangHoa, hh.SoLuong);
            }
            dtv_ct.DataSource = table;
        }
        private void checkList()
        {
            if (ListChiTietDNH!=null && ListChiTietDNH.Count > 0)
            {
                btn_yeucaunhaphang.Enabled = true;

            }
            else
            {
                btn_yeucaunhaphang.Enabled = false;
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Load_HangHoa(int IDNCC)
        {
            DataTable table = new DataTable();
            List<HangHoa> list = HangHoa_BUL.getHangHoaFilter1(this.NhanVien.ID, IDNCC);
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Tên Hàng", typeof(string));
            table.Columns.Add("Số Lượng Còn", typeof(int));
            table.Columns.Add("Số lượng nhập max", typeof(int));
            table.Columns.Add("Số lượng hàng min", typeof(int));

            foreach (HangHoa hh in list)
            {
                table.Rows.Add(hh.ID, hh.TenHH, hh.SoLuongTon, hh.NhapMax, hh.SLmin);
            }
            dtgv.DataSource = table;
        }

        private void comb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListChiTietDNH.Clear();
            checkList();
            Load_HangHoa(((NhaCungCap)comb_ncc.SelectedItem).ID);
            chinhsuaChiTiet();
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
        private void btn_themct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_HangHoa.Text != "" && txt_soluong.Text != "" && Convert.ToInt32(txt_nhapmax.Text) >= Convert.ToInt32(txt_soluong.Text))

                {
                    int pos = this.ListChiTietDNH.FindIndex(p => p.IDHangHoa.ToString() == txt_HangHoa.Text);
                    if (pos > -1)
                    {
                        this.ListChiTietDNH.RemoveAt(pos);
                    }

                    ChiTietDonNhapHang ct = new ChiTietDonNhapHang()
                    {
                        IDHangHoa = Convert.ToInt32(txt_HangHoa.Text),
                        SoLuong = Convert.ToInt32(txt_soluong.Text)
                    };
                    ListChiTietDNH.Add(ct);

                    checkList();
                    chinhsuaChiTiet();

                }
                else
                {
                    MesageFaild();
                }
            }
            catch(Exception ex)
            {
                MesageFaild();
            }

        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                dtgv.CurrentCell.Selected = true;
                txt_HangHoa.Text = dtgv.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txt_nhapmax.Text = dtgv.Rows[e.RowIndex].Cells["Số lượng nhập max"].FormattedValue.ToString();



            }
            catch (Exception ex)
            {
                
            }
        }




        private void btn_xoact_Click(object sender, EventArgs e)
        {
            try
            {
                this.ListChiTietDNH.RemoveAt(dtv_ct.CurrentRow.Index);
                chinhsuaChiTiet();
                checkList();
            }
            catch(Exception ex)
            {

            }
        }

        private void btn_yeucaunhaphang_Click(object sender, EventArgs e)
        {
            DonNhapHang dnh = new DonNhapHang() {
                LyDo = txt_lydo.Text,
                NguoiLap = this.NhanVien.ID,
                NCC = ((NhaCungCap)comb_ncc.SelectedItem).ID,
                NgayLap=DateTime.Now
            };
            DonNhapHang kq = DonNhapHang_BUL.Them(dnh);
            if ( kq!= null)
            {
                bool rs1= ChiTietDonNhapHang_BUL.themList(kq.ID, this.ListChiTietDNH);
                if (rs1)
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
