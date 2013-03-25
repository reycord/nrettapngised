using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public abstract class DHManager
    {
        public BieuThuc bieuThuc;
        public abstract void KhoiTaoDaoHam();
        public double TinhGiaTriBieuThuc()
        {
            return bieuThuc.TinhGiaTri();
        }
        public BieuThuc TinhDaoHam()
        {
            return bieuThuc.TinhDaoHam();
        }
        public void XuLy()
        {
            KhoiTaoDaoHam();
            Console.Write("Ket Qua Dao Ham : {0}", TinhGiaTriBieuThuc());
            Console.Write("Ket Qua Bieu Thuc : {0}",TinhDaoHam());
            Console.Write("=================== END ======================");
            Console.Write("                  Nhom 20 ");
        }
    }
}
