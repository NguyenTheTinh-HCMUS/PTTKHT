using PTTKHT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKHT.BUL
{
    class DonNhapHang_BUL
    {
        static public DonNhapHang Them(DonNhapHang dnh)
        {
            DonNhapHang rs = null;
            using(PTTKHTEntities context=new PTTKHTEntities())
            {
                context.DonNhapHangs.Add(dnh);
                context.SaveChanges();
                rs= dnh;
            }
            return rs;
        }
        public static List<DonNhapHang> getAllList()
        {
            List<DonNhapHang> list = null;
            using (PTTKHTEntities contex = new PTTKHTEntities())
            {
                list = contex.DonNhapHangs.Where(p=>p.NguoiXacNhan.Equals(null)).ToList();
            }
            return list;
        }
        public static bool XacNhanDonNhap(int IDDonTra, int IDNguoiXacNhan)
        {
            bool rs = false;
            using (PTTKHTEntities context = new PTTKHTEntities())
            {
                DonNhapHang abc = context.DonNhapHangs.SingleOrDefault(b => b.ID == IDDonTra);
                abc.NguoiXacNhan = IDNguoiXacNhan;
                abc.NgayXacNhan = DateTime.Now;
                foreach (ChiTietDonNhapHang ct in abc.ChiTietDonNhapHangs)
                {
                    ct.HangHoa.SoLuongTra += ct.SoLuong;
                }
                int index = context.SaveChanges();
                rs = true;

            }
            return rs;
        }

    }
}
