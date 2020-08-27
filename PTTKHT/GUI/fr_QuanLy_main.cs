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
    public partial class fr_QuanLy_main : Form
    {
        public NhanVien NhanVien { get; set; }
        public fr_QuanLy_main()
        {
            InitializeComponent();
        }
        public fr_QuanLy_main(NhanVien nv)
        {
            InitializeComponent();
            this.NhanVien = nv;
        }
        public int Temp { get; set; }
        private void fr_QuanLy_main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }

        private void fr_QuanLy_main_Load(object sender, EventArgs e)
        {
            comb_danhmuc.SelectedIndex = 0;
            IntoDataTodtgv();
            inittag2();
        }
        private void inittag2()
        {
            cob2.SelectedIndex = 0;
            diplay_dtgvc_ds();
        }
        private void diplay_dtgvc_ds()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("LyDo", typeof(string));
            table.Columns.Add("Nguoi Lap", typeof(int));
            if (cob2.SelectedIndex == 0)
            {
               
                List<DonNhapHang> list = DonNhapHang_BUL.getAllList();
                foreach (DonNhapHang dnh in list)
                {
                    table.Rows.Add(dnh.ID, dnh.LyDo, dnh.NguoiLap);
                }
            }
            else if(cob2.SelectedIndex == 1)
            {
                List<DonTraHangCC> list = DonTraHangCC_BUL.getAllList();
                foreach (DonTraHangCC dnh in list)
                {
                    table.Rows.Add(dnh.ID, dnh.LyDo, dnh.Nguoilap);
                }
            }
            dtgv_ds1.DataSource = table;


        }

        private void IntoDataTodtgv()
        {
            
            if (comb_danhmuc.SelectedIndex == 0)
            {
                dtgv.DataSource = LoaiHang_BUL.getDataTable(txt_search.Text);
            }
            else if(comb_danhmuc.SelectedIndex == 1)
            {
                dtgv.DataSource = HangHoa_BUL.getDataTable(txt_search.Text);
            }
            else if (comb_danhmuc.SelectedIndex == 2)
            {
                dtgv.DataSource = KhachHang_BUL.getDataTable(txt_search.Text);
            }
            else if (comb_danhmuc.SelectedIndex == 3)
            {
                dtgv.DataSource = NhaCungCap_BUL.getDataTable(txt_search.Text);
            }
            else if (comb_danhmuc.SelectedIndex == 4)
            {
                dtgv.DataSource = NhanVien_BUL.getDataTable(txt_search.Text);
            }
            else if (comb_danhmuc.SelectedIndex == 5)
            {
                dtgv.DataSource = DoiTacQuangCao_BUL.getDataTable(txt_search.Text);
            }
        }
       
        private void btn_them_Click(object sender, EventArgs e)
        {
            Form fr_lh = null;
            if (comb_danhmuc.SelectedIndex==0)
            {
                fr_lh=new fr_QuanLy_LoaiHang();
            }
            if (comb_danhmuc.SelectedIndex == 1)
            {
                fr_lh = new fr_QuanLy_HangHoa();
            }
            if (comb_danhmuc.SelectedIndex == 2)
            {
                fr_lh = new fr_QuanLy_KhachHang();
            }
            if (comb_danhmuc.SelectedIndex == 3)
            {
                fr_lh = new fr_QuanLy_NhaCungCap();
            }
            if (comb_danhmuc.SelectedIndex == 4)
            {
                fr_lh = new fr_QuanLy_NhanVien();
            }
            if (comb_danhmuc.SelectedIndex == 5)
            {
                fr_lh = new fr_QuanLy_DoiTacQuanCao();
            }


            if (fr_lh != null)
            {
                fr_lh.FormClosing += Frm2_Closing;
                fr_lh.ShowDialog();
                resetAfterHandle();
            }
        }
        private void Frm2_Closing(object sender, FormClosingEventArgs e)
        {
            IntoDataTodtgv();
        }

        private void resetAfterHandle()
        {
            txt_search.Text = "";
            

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            IntoDataTodtgv();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Form fr_lh = null;
            if (comb_danhmuc.SelectedIndex == 0)
            {
                int pos = dtgv.CurrentRow.Index;
                int ID = Convert.ToInt32(dtgv.Rows[pos].Cells[0].Value);
                LoaiHoang lh = LoaiHang_BUL.TimLoaiHang(ID);
                fr_lh = new fr_QuanLy_LoaiHang(lh);
            }
            else if (comb_danhmuc.SelectedIndex == 1){
                int pos = dtgv.CurrentRow.Index;
                int ID = Convert.ToInt32(dtgv.Rows[pos].Cells[0].Value);
                HangHoa hh = HangHoa_BUL.TimLoaiHang(ID);
                fr_lh = new fr_QuanLy_HangHoa(hh);
            }
            else if (comb_danhmuc.SelectedIndex == 2)
            {
                int pos = dtgv.CurrentRow.Index;
                int ID = Convert.ToInt32(dtgv.Rows[pos].Cells[0].Value);
                KhachHang hh = KhachHang_BUL.TimKhachHang(ID);
                fr_lh = new fr_QuanLy_KhachHang(hh);
            }
            else if (comb_danhmuc.SelectedIndex == 3)
            {
                int pos = dtgv.CurrentRow.Index;
                int ID = Convert.ToInt32(dtgv.Rows[pos].Cells[0].Value);
                NhaCungCap hh = NhaCungCap_BUL.TimNCC(ID);
                fr_lh = new fr_QuanLy_NhaCungCap(hh);
            }
            else if (comb_danhmuc.SelectedIndex == 4)
            {
                int pos = dtgv.CurrentRow.Index;
                int ID = Convert.ToInt32(dtgv.Rows[pos].Cells[0].Value);
                NhanVien hh = NhanVien_BUL.TimNhanVien(ID);
                fr_lh = new fr_QuanLy_NhanVien(hh);
            }
            else if (comb_danhmuc.SelectedIndex == 5)
            {
                int pos = dtgv.CurrentRow.Index;
                int ID = Convert.ToInt32(dtgv.Rows[pos].Cells[0].Value);
                DoiTacQuangCao hh = DoiTacQuangCao_BUL.TimLoaiHang(ID);
                fr_lh = new fr_QuanLy_DoiTacQuanCao(hh);
            }
            if (fr_lh != null)
            {
                fr_lh.FormClosing += Frm2_Closing;
                fr_lh.ShowDialog();
                resetAfterHandle();
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int pos = dtgv.CurrentRow.Index;
            int ID = Convert.ToInt32(dtgv.Rows[pos].Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (comb_danhmuc.SelectedIndex==0)
                {
                    if (LoaiHang_BUL.Xoa(ID))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        IntoDataTodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comb_danhmuc.SelectedIndex == 1)
                {
                    if (HangHoa_BUL.Xoa(ID))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        IntoDataTodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (comb_danhmuc.SelectedIndex == 2)
                {
                    if (KhachHang_BUL.Xoa(ID))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        IntoDataTodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (comb_danhmuc.SelectedIndex == 3)
                {
                    if (NhaCungCap_BUL.Xoa(ID))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        IntoDataTodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (comb_danhmuc.SelectedIndex == 4)
                {
                    if (NhanVien_BUL.Xoa(ID))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        IntoDataTodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (comb_danhmuc.SelectedIndex == 5)
                {
                    if (DoiTacQuangCao_BUL.Xoa(ID))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        IntoDataTodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            
          
        }

        private void tab_quanly_Click(object sender, EventArgs e)
        {

        }

        private void comb_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntoDataTodtgv();
        }

        private void cob2_SelectedIndexChanged(object sender, EventArgs e)
        {
            diplay_dtgvc_ds();
            dtgvct2.DataSource = null;
        }
        private void display_ct2(int ID)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID Hàng");
            table.Columns.Add("Số Lượng");

            if (cob2.SelectedIndex == 0)
            {
                List<ChiTietDonNhapHang> list = ChiTietDonNhapHang_BUL.getAllList_IDDN(ID);
                foreach (ChiTietDonNhapHang tr in list)
                {
                    table.Rows.Add(tr.IDHangHoa, tr.SoLuong);
                }
            }
            else if(cob2.SelectedIndex == 1)
            {

                List<ChiTietDonTraHangNCC> list = ChiTietDonTraHang_BUL.getAllList_IDDT(ID);
                foreach(ChiTietDonTraHangNCC tr in list)
                {
                    table.Rows.Add(tr.IDHangHoa, tr.SoLuong);
                }
            }
            dtgvct2.DataSource = table;
        }

        private void dtgv_ds1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int ID =Convert.ToInt32(dtgv_ds1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
                display_ct2(ID);
                this.Temp = ID;
            }
            catch (Exception ex)
            {
                dtgvct2.DataSource = null;
                this.Temp = 0;

            }

        }

        private void dtgvct2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (this.Temp != 0)
            {
                if (cob2.SelectedIndex == 0)
                {
                    if (DonNhapHang_BUL.XacNhanDonNhap(this.Temp, this.NhanVien.ID))
                    {
                        diplay_dtgvc_ds();
                        dtgvct2.DataSource = null;
                        MessageSucess();

                    }
                    else
                    {
                        MesageFaild();
                    }
                }
                else if (cob2.SelectedIndex == 1)
                {
                    if (DonTraHangCC_BUL.XacNhanDonTraHang(this.Temp, this.NhanVien.ID))
                    {
                        diplay_dtgvc_ds();
                        dtgvct2.DataSource = null;
                        MessageSucess();

                    }
                    else
                    {
                        MesageFaild();
                    }
                }
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
     

    }
}
