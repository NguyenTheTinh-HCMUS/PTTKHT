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
    public partial class fr_NhanVien_TraHang : Form
    {
        public NhanVien NhanVien { get; set; }
        public List<ChiTietDonTraHangNCC> ListCTTH { get; set; }
        public fr_NhanVien_TraHang()
        {
            InitializeComponent();
            this.ListCTTH = new List<ChiTietDonTraHangNCC>();
        }
        public fr_NhanVien_TraHang(NhanVien nv)
        {
            InitializeComponent();
            this.NhanVien = nv;
            this.ListCTTH = new List<ChiTietDonTraHangNCC>();
        }

        private void fr_NhanVien_TraHang_Load(object sender, EventArgs e)
        {
            comb_NCC.DataSource = NhaCungCap_BUL.getList();
            comb_NCC.SelectedIndex = 0;
            comb_NCC.DisplayMember = "TenNCC";
            getDonHang();
            CheckListDS();
        }
        private void getDonHang()
        {
            List<HangHoa> list = HangHoa_BUL.DanhSachHangTra(((NhaCungCap)comb_NCC.Items[comb_NCC.SelectedIndex]).ID);
            if (list != null)
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Tên Hàng", typeof(string));
                table.Columns.Add("Số lượng trả", typeof(int));
                table.Columns.Add("Số lượng tồn", typeof(int));
                foreach(HangHoa hh in list)
                {
                    table.Rows.Add(hh.ID, hh.TenHH, hh.SoLuongTra, hh.SoLuongTon);
                }
                dtgv1.DataSource = table;
            }
        }
       
        private void comb_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDonHang();
            this.ListCTTH.Clear();
            CheckListDS();
            Displayct();
        }

        private void dtgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_IDHang.Text = dtgv1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txt_tenhang.Text = dtgv1.Rows[e.RowIndex].Cells["Tên Hàng"].Value.ToString();
                txt_sltra.Text = dtgv1.Rows[e.RowIndex].Cells["Số lượng trả"].Value.ToString();
            }
            catch (Exception ex)
            {
                
            }
        }
        private void CheckListDS()
        {
           
            
            if (this.ListCTTH.Count > 0)
            {
                btn_Lapphieutra.Enabled = true;
            }
            else
            {
                btn_Lapphieutra.Enabled = false;
            }

        }

        private void btn_Lapphieutra_Click(object sender, EventArgs e)
        {
            DonTraHangCC a = new DonTraHangCC() {
                NgayLap = DateTime.Now,
                Nguoilap = this.NhanVien.ID,
                NhaCC = ((NhaCungCap)comb_NCC.SelectedItem).ID,
                LyDo=txt_lyDo.Text
            };
             DonTraHangCC rs= DonTraHangCC_BUL.Them(a);
            if (rs != null)
            {
                if(ChiTietDonTraHang_BUL.ThemList(rs.ID, this.ListCTTH)){
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
            if (txt_IDHang.Text != "" && txt_tenhang.Text != "")
            {
                ChiTietDonTraHangNCC ct = new ChiTietDonTraHangNCC()
                {
                    IDHangHoa = Convert.ToInt32(txt_IDHang.Text),
                    SoLuong = Convert.ToInt32(txt_sltra.Text)
                };
                int pos = this.ListCTTH.FindIndex(p => p.IDHangHoa == ct.IDHangHoa);
                if (pos > -1)
                {
                    this.ListCTTH.RemoveAt(pos);
                }
                this.ListCTTH.Add(ct);
                Displayct();
            }
        }
        private void Displayct()
        {
            if (this.ListCTTH.Count <= 0)
            {
                dtgv_2.Hide();
                btn_xoact.Hide();
                btn_Lapphieutra.Enabled = false;

            }
            else
            {
                dtgv_2.Show();
                btn_xoact.Show();
                btn_Lapphieutra.Enabled = true;
                DataTable table = new DataTable();
                table.Columns.Add("ID Hàng", typeof(int));
                table.Columns.Add("Số Lượng", typeof(int));
                foreach(ChiTietDonTraHangNCC ct in this.ListCTTH)
                {
                    table.Rows.Add(ct.IDHangHoa, ct.SoLuong);
                }
                dtgv_2.DataSource = table;
            }


        }

        private void btn_xoact_Click(object sender, EventArgs e)
        {
            try
            {
                this.ListCTTH.RemoveAt(dtgv_2.CurrentRow.Index);
                Displayct();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
