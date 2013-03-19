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
            return (heSo * Math.Pow(x, soMu));
        }

        public override BieuThuc TinhDaoHam()
        {
            return new DonThuc(x, this.heSo * this.soMu, this.soMu - 1);
        }

        // BIỂU DIỄN BIỂU THỨC
        public override string ToString()
        {
            return (heSo + "X ^ " + soMu);
        }
    }
}
