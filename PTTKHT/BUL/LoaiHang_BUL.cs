using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class LoaiHang_BUL
    {
        public static DataTable getDataTable(string search)
        {
            DataTable dt = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                if (search != "")
                {
                    List<LoaiHoang> LoaiHangs = context.LoaiHoangs.ToList();
                    string query = String.Format("select * from LoaiHoang where TenLoai like '%{0}%'", search);
                    dt = context.DataTable(query);
                }
                else
                {
                    dt = context.DataTable((
                  from lh in context.LoaiHoangs
                  select lh
                  ).ToString());
                }
            }
            return dt;
        } 
        public static bool Them(string TenLoai)
        {

            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                LoaiHoang a = new LoaiHoang() {
                TenLoai=TenLoai
                };
                context.LoaiHoangs.Add(a);
                var created= context.SaveChanges();
                if (created > 0)
                {
                    rs = true;
                }
               
            }
            return rs;
        }
        public static LoaiHoang TimLoaiHang(int ID)
        {
            LoaiHoang lh = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v= context.LoaiHoangs.SingleOrDefault(b => b.ID==ID);
                if(v is LoaiHoang)
                {
                    lh = (LoaiHoang)v;
                }

            }
            return lh;
        }
        public static bool ChinhSua(int ID,string tenLoaiHang)
        {
            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.LoaiHoangs.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    v.TenLoai = tenLoaiHang;
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
                var v = context.LoaiHoangs.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    context.LoaiHoangs.Remove(v);
                    int rm= context.SaveChanges();
                    rs = rm > 0;
                }
            }
            return rs;
        }
        public static List<LoaiHoang> getList()
        {
            List<LoaiHoang> list = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                list = context.LoaiHoangs.ToList();
            }
            return list;
        }
    }
}
