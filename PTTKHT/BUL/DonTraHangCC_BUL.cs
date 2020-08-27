using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class DonTraHangCC_BUL
    {
        public static DonTraHangCC Them(DonTraHangCC param)
        {
            DonTraHangCC dth = null;
            using (PTTKHTEntities context=new PTTKHTEntities())
            {
                context.DonTraHangCCs.Add(param);
                context.SaveChanges();
                dth = param;
            }
            return dth;
        }
        public static List<DonTraHangCC> getAllList()
        {
            List<DonTraHangCC> list = null;
            using(PTTKHTEntities contex=new PTTKHTEntities())
            {
                list = contex.DonTraHangCCs.Where(p=>p.NguoiXacNhap.Equals(null)).ToList();
            }
            return list;
        }
        public static bool XacNhanDonTraHang(int IDDonTra,int IDNguoiXacNhan)
        {
            bool rs = false;
            using(PTTKHTEntities context=new PTTKHTEntities())
            {
                DonTraHangCC abc= context.DonTraHangCCs.SingleOrDefault(b => b.ID ==IDDonTra);
                abc.NguoiXacNhap = IDNguoiXacNhan;
                abc.NgayXacNhan = DateTime.Now;
                foreach (ChiTietDonTraHangNCC ct in abc.ChiTietDonTraHangNCCs)
                {
                    ct.HangHoa.SoLuongTra -= ct.SoLuong;
                }
                int index=context.SaveChanges();
                rs = true;

            }
            return rs;
        }
    }
}
