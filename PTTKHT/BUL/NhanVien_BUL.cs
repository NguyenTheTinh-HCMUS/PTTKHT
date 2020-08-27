using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class NhanVien_BUL
    {
        static public NhanVien CheckNhanVien(string user,string pass)
        {
            NhanVien result = null;
            using (PTTKHTEntities context=new PTTKHTEntities())
            {
                var query = context.NhanViens.Where(nv => nv.Email == user && nv.Password == pass)
                                    .FirstOrDefault<NhanVien>();
                result = (NhanVien)query;

            }
            return result;

        }
        public static List<NhanVien> getListNhanVien()
        {
            List<NhanVien> list = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                list = context.NhanViens.Where(s => s.ChucVu == "NhanVien").ToList();
            }
            return list;
        }
        public static DataTable getDataTable(string search)
        {
            DataTable dt = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                if (search != "")
                {
                    List<NhanVien> LoaiHangs = context.NhanViens.ToList();
                    string query = String.Format("select * from NhanVien where HoTen like '%{0}%'", search);
                    dt = context.DataTable(query);
                }
                else
                {
                    dt = context.DataTable((
                  from lh in context.NhanViens
                  select lh
                  ).ToString());
                }
            }
            return dt;
        }
        public static bool Them(string Email, string HoTen, string SoDT, string DiaChi, string PassWord,String ChucVu)
        {

            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                NhanVien a = new NhanVien()
                {
                    Email = Email,
                    HoTen = HoTen,
                    SoDT = SoDT,
                    DiaChi = DiaChi,
                    Password = PassWord,
                    ChucVu=ChucVu
                };
                context.NhanViens.Add(a);
                var created = context.SaveChanges();
                if (created > 0)
                {
                    rs = true;
                }

            }
            return rs;
        }
        public static NhanVien TimNhanVien(int ID)
        {
            NhanVien lh = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.NhanViens.SingleOrDefault(b => b.ID == ID);
                if (v is NhanVien)
                {
                    lh = (NhanVien)v;
                }

            }
            return lh;
        }
        public static bool ChinhSua(int ID, string Email, string HoTen, string SoDT, string DiaChi, string PassWord, String ChucVu)
        {
            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.NhanViens.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    v.Email = Email;
                    v.HoTen = HoTen;
                    v.SoDT = SoDT;
                    v.DiaChi = DiaChi;
                    v.Password = PassWord;
                    v.ChucVu = ChucVu;
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
                var v = context.NhanViens.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    context.NhanViens.Remove(v);
                    int rm = context.SaveChanges();
                    rs = rm > 0;
                }
            }
            return rs;
        }
      

    }
}
