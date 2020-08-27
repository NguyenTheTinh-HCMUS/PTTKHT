using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class NhaCungCap_BUL
    {
        public static DataTable getDataTable(string search)
        {
            DataTable dt = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                if (search != "")
                {
                    List<NhaCungCap> LoaiHangs = context.NhaCungCaps.ToList();
                    string query = String.Format("select * from NhaCungCap where TenNCC like '%{0}%'", search);
                    dt = context.DataTable(query);
                }
                else
                {
                    dt = context.DataTable((
                  from lh in context.NhaCungCaps
                  select lh
                  ).ToString());
                }
            }
            return dt;
        }
        public static bool Them(string TenNCC)
        {

            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                NhaCungCap a = new NhaCungCap()
                {
                    TenNCC=TenNCC
                };
                context.NhaCungCaps.Add(a);
                var created = context.SaveChanges();
                if (created > 0)
                {
                    rs = true;
                }

            }
            return rs;
        }
        public static NhaCungCap TimNCC(int ID)
        {
            NhaCungCap lh = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.NhaCungCaps.SingleOrDefault(b => b.ID == ID);
                if (v is NhaCungCap)
                {
                    lh = (NhaCungCap)v;
                }

            }
            return lh;
        }
        public static bool ChinhSua(int ID, string TenNCC) { 
            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.NhaCungCaps.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    v.TenNCC = TenNCC;
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
                var v = context.NhaCungCaps.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    context.NhaCungCaps.Remove(v);
                    int rm = context.SaveChanges();
                    rs = rm > 0;
                }
            }
            return rs;
        }
        public static List<NhaCungCap> getList()
        {
            List<NhaCungCap> list = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                list = context.NhaCungCaps.ToList();
            }
            return list;
        }
    }
}
