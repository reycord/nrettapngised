using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class DonThuc : BieuThuc
    {
        private double x;
        private double heSo;
        private int soMu;

        // CONSTRUCTORS
        public DonThuc()
        {
            x = 1;
            heSo = 1;
            soMu = 1;
        }

        public DonThuc(double _x, double _heSo, int _soMu)
        {
            x = _x;
            heSo = _heSo;
            soMu = _soMu;
        }

        // TÍNH ĐẠO HÀM + GIÁ TRỊ
        public override double TinhGiaTri()
        {
            throw new NotImplementedException();
        }

        public override BieuThuc TinhDaoHam()
        {
            throw new NotImplementedException();
        }

        // BIỂU DIỄN BIỂU THỨC
        public override string ToString()
        {
            return (heSo + "X ^ " + soMu);
        }
    }
}
