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
    public partial class fr_NhanVien_main : Form
    {
        public NhanVien NhanVien { get; set; }
        public fr_NhanVien_main()
        {
            InitializeComponent();
        }
        public fr_NhanVien_main(NhanVien nv)
        {
            InitializeComponent();
            this.NhanVien = nv;
        }

        private void fr_NhanVien_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void fr_NhanVien_main_Load(object sender, EventArgs e)
        {
            initQuanLiSanFam();
        }
        private void initQuanLiSanFam()
        {
            comb_filter.SelectedIndex = 0;
            IntoDgv();
        }
        private void IntoDgv()
        {
            if (comb_filter.SelectedIndex == 0)
            {
                dtgv.DataSource = HangHoa_BUL.getDataTableDachSachMaQuanLi(this.NhanVien.ID.ToString());

            }
            else if(comb_filter.SelectedIndex == 1)
            {
                dtgv.DataSource = HangHoa_BUL.getDataTableDachSachMaQuanLi(this.NhanVien.ID.ToString(),true);

            }
        }

        private void comb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntoDgv();
        }

        private void btn_yeucauNH_Click(object sender, EventArgs e)
        {
            fr_NhanVien_NhapHang fr = new fr_NhanVien_NhapHang(this.NhanVien);
            this.Hide();
            fr.Show();
            fr.FormClosing += Frm2_Closing;
        }
        private void Frm2_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btn_trahang_Click(object sender, EventArgs e)
        {
            fr_NhanVien_TraHang fr = new fr_NhanVien_TraHang(this.NhanVien);
            this.Hide();
            fr.Show();
            fr.FormClosing += Frm2_Closing;
        }
    }
}
