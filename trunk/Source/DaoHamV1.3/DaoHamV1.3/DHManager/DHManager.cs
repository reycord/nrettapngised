using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public abstract class DHManager
    {
        protected BieuThuc bieuThuc;
        public abstract void KhoiTaoDaoHam();   // Primitive Operation
        public double TinhGiaTriBieuThuc()
        {
            return bieuThuc.TinhGiaTri();
        }

        public BieuThuc TinhDaoHam()
        {
            BieuThuc kq = bieuThuc.TinhDaoHam();
            kq.AddtoList();
            kq.OSupport = new OPSuffix();
            return bieuThuc.TinhDaoHam();
        }

        public abstract void XuatKetQua();
        
        public void XuLy()  // Skeleton methods
        {
            KhoiTaoDaoHam();
            XuatKetQua();
            Console.WriteLine("=================== END ======================");
            Console.WriteLine("                  Nhom 20 ");
        }
    }
}
