using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class ChiTietDonNhapHang_BUL
    {
        public static bool themList(int ID_DNH,List<ChiTietDonNhapHang> list)
        {
            bool rs = false;
            using(PTTKHTEntities context=new PTTKHTEntities())
            {
                foreach(ChiTietDonNhapHang ct in list)
                {
                    ct.IDDonNhap = ID_DNH;
                    context.ChiTietDonNhapHangs.Add(ct);
                }
                if(context.SaveChanges() == list.Count)
                {
                    rs = true;
                }
            }
            return rs;
        }
        public static List<ChiTietDonNhapHang> getAllList_IDDN(int IDDN)
        {
            List<ChiTietDonNhapHang> list = null;
            using (PTTKHTEntities contex = new PTTKHTEntities())
            {
                list = contex.ChiTietDonNhapHangs.Where(p => p.IDDonNhap == IDDN).ToList();
            }
            return list;
        }
    }
}
