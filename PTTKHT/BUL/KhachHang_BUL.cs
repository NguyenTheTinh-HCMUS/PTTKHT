using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class KhachHang_BUL
    {
        static public KhachHang CheckKhachHang(string user, string pass)
        {
            KhachHang result = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var query = context.KhachHangs.Where(nv => nv.Email == user && nv.Password == pass)
                                    .FirstOrDefault<KhachHang>();
                result = (KhachHang)query;

            }
            return result;

        }
        public static DataTable getDataTable(string search)
        {
            DataTable dt = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                if (search != "")
                {
                    List<KhachHang> LoaiHangs = context.KhachHangs.ToList();
                    string query = String.Format("select * from KhachHang where HoTen like '%{0}%'", search);
                    dt = context.DataTable(query);
                }
                else
                {
                    dt = context.DataTable((
                  from lh in context.KhachHangs
                  select lh
                  ).ToString());
                }
            }
            return dt;
        }
        public static bool Them(string Email, string HoTen, string SoDT, string DiaChi, string PassWord)
        {

            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                KhachHang a = new KhachHang()
                {
                   Email=Email,
                   HoTen=HoTen,
                   SoDT=SoDT,
                   DiaChi=DiaChi,
                   Password=PassWord
                };
                context.KhachHangs.Add(a);
                var created = context.SaveChanges();
                if (created > 0)
                {
                    rs = true;
                }

            }
            return rs;
        }
        public static KhachHang TimKhachHang(int ID)
        {
            KhachHang lh = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.KhachHangs.SingleOrDefault(b => b.ID == ID);
                if (v is KhachHang)
                {
                    lh = (KhachHang)v;
                }

            }
            return lh;
        }
        public static bool ChinhSua(int ID, string Email, string HoTen, string SoDT, string DiaChi, string PassWord)
        {
            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.KhachHangs.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    v.Email = Email;
                    v.HoTen = HoTen;
                    v.SoDT = SoDT;
                    v.DiaChi =DiaChi;
                    v.Password = PassWord;
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
                var v = context.KhachHangs.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    context.KhachHangs.Remove(v);
                    int rm = context.SaveChanges();
                    rs = rm > 0;
                }
            }
            return rs;
        }
        public static List<KhachHang> getList()
        {
            List<KhachHang> list = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                list = context.KhachHangs.ToList();
            }
            return list;
        }


    }
}
