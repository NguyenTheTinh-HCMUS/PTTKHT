using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class HangHoa_BUL
    {
        public static DataTable getDataTable(string search)
        {
            DataTable dt = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                if (search != "")
                {
                    List<HangHoa> LoaiHangs = context.HangHoas.ToList();
                    string query = String.Format("select * from HangHoa where TenHH like '%{0}%'", search);
                    dt = context.DataTable(query);
                }
                else
                {
                    dt = context.DataTable((
                  from lh in context.HangHoas
                  select lh
                  ).ToString());
                }
            }
            return dt;
        }
        public static bool Them(string TenHH,int NhapMax, int SLmin, int NCC,int QuanLy,int LoaiHang,double DonGia)
        {

            bool rs = false;
            int SoLuongTra = 0;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                HangHoa a = new HangHoa()
                {
                    TenHH=TenHH,
                    NhapMax=NhapMax,
                    SLmin=SLmin,
                    SoLuongTra=SoLuongTra,
                    NCC=NCC,
                    QuanLy=QuanLy,
                    LoaiHang=LoaiHang,
                    DonGia=DonGia,
                    SoLuongTon=0
                };
                context.HangHoas.Add(a);
                var created = context.SaveChanges();
                if (created > 0)
                {
                    rs = true;
                }

            }
            return rs;
        }
        public static HangHoa TimLoaiHang(int ID)
        {
            HangHoa lh = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.HangHoas.SingleOrDefault(b => b.ID == ID);
                if (v is HangHoa)
                {
                    lh = (HangHoa)v;
                }

            }
            return lh;
        }
        public static bool ChinhSua(int ID, string TenHH, int NhapMax, int SLmin, int NCC, int QuanLy, int LoaiHang, double DonGia)
        {
            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.HangHoas.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    v.TenHH = TenHH;
                    v.NhapMax = NhapMax;
                    v.SLmin = SLmin;
                    v.NCC = NCC;
                    v.QuanLy = QuanLy;
                    v.LoaiHang = LoaiHang;
                    v.DonGia = DonGia;
                    int updated = context.SaveChanges();
                    rs = updated > 0;
                }

            }
            return rs;
        }
        public static bool Xoa(int ID)
        {
            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.HangHoas.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    context.HangHoas.Remove(v);
                    int rm = context.SaveChanges();
                    rs = rm > 0;
                }
            }
            return rs;
        }
        public static List<HangHoa> getList()
        {
            List<HangHoa> list = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                list = context.HangHoas.ToList();
            }
            return list;
        }
        public static DataTable getDataTableDachSachMaQuanLi(string ID,bool NhapHang=false)
        {
            DataTable dt = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {

                if (NhapHang)
                {
                    string query = String.Format("select * from HangHoa where QuanLy={0} and SoLuongTon<SLmin", ID);
                    dt = context.DataTable(query);
                }
                else
                {
                    string query = String.Format("select * from HangHoa where QuanLy={0}", ID);
                    dt = context.DataTable(query);
                }
               
               
            }
            return dt;
        }
        public static List<HangHoa> getHangHoaFilter1(int QuanLy,int IDNCC)
        {
            List<HangHoa> list = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                list = context.HangHoas
                        .Where(p => p.QuanLy == QuanLy && p.NCC == IDNCC)
                        .Select(p => p).ToList();
            }
            return list;
        }
        public static List<HangHoa> DanhSachHangTra(int NCC)
        {
            List<HangHoa> list = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                list = context.HangHoas
                .Where(hh => hh.NCC == NCC && hh.SoLuongTra > 0).ToList();
            }
            return list;
        }
    }
}
