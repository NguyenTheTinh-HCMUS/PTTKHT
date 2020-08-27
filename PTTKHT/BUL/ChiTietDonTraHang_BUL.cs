using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class ChiTietDonTraHang_BUL
    {
        public static bool ThemList(int IDDONTRA,List<ChiTietDonTraHangNCC> list)
        {
            bool rs = false;
            using(PTTKHTEntities context=new PTTKHTEntities())
            {
                foreach(ChiTietDonTraHangNCC ct in list)
                {
                    ct.IDDonTra = IDDONTRA;
                    context.ChiTietDonTraHangNCCs.Add(ct);
                }
                if (context.SaveChanges() == list.Count)
                {
                    rs = true;
                }
            }
            return rs;
        }
        public static List<ChiTietDonTraHangNCC> getAllList_IDDT(int IDDT)
        {
            List<ChiTietDonTraHangNCC> list = null;
            using (PTTKHTEntities contex = new PTTKHTEntities())
            {
                list = contex.ChiTietDonTraHangNCCs.Where(p => p.IDDonTra == IDDT).ToList();
            }
            return list;
        }

    }
}
