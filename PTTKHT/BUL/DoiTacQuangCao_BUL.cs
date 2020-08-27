using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class DoiTacQuangCao_BUL
    {
        public static DataTable getDataTable(string search)
        {
            DataTable dt = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                if (search != "")
                {
                    List<DoiTacQuangCao> LoaiHangs = context.DoiTacQuangCaos.ToList();
                    string query = String.Format("select * from DoiTacQuangCao where TenDoiTac like '%{0}%'", search);
                    dt = context.DataTable(query);
                }
                else
                {
                    dt = context.DataTable((
                  from lh in context.DoiTacQuangCaos
                  select lh
                  ).ToString());
                }
            }
            return dt;
        }
        public static bool Them(string TenDoiTac)
        {

            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                DoiTacQuangCao a = new DoiTacQuangCao()
                {
                   TenDoiTac=TenDoiTac
                };
                context.DoiTacQuangCaos.Add(a);
                var created = context.SaveChanges();
                if (created > 0)
                {
                    rs = true;
                }

            }
            return rs;
        }
        public static DoiTacQuangCao TimLoaiHang(int ID)
        {
            DoiTacQuangCao lh = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.DoiTacQuangCaos.SingleOrDefault(b => b.ID == ID);
                if (v is DoiTacQuangCao)
                {
                    lh = (DoiTacQuangCao)v;
                }

            }
            return lh;
        }
        public static bool ChinhSua(int ID, string TenDoiTac)
        {
            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                var v = context.DoiTacQuangCaos.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    v.TenDoiTac = TenDoiTac;
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
                var v = context.DoiTacQuangCaos.SingleOrDefault(b => b.ID == ID);
                if (v != null)
                {
                    context.DoiTacQuangCaos.Remove(v);
                    int rm = context.SaveChanges();
                    rs = rm > 0;
                }
            }
            return rs;
        }
        public static List<DoiTacQuangCao> getList()
        {
            List<DoiTacQuangCao> list = null;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                list = context.DoiTacQuangCaos.ToList();
            }
            return list;
        }
    }
}
