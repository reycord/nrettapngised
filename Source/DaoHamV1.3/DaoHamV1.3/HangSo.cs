using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class HangSo : BieuThuc
    {
        private double c;
        private BieuThuc daoHam = null;

        // CONSTRUCTORS
        public HangSo()
        {
            c = 0;
        }

        public HangSo(double _value)
        {
            c = _value;
        }

        // TÍNH GIÁ TRỊ + ĐẠO HÀM
        public override double TinhGiaTri()
        {
            return c;
        }

        public override BieuThuc TinhDaoHam()
        {
            if (daoHam == null)
                daoHam = new HangSo(0);

            return daoHam;
        }

        // BIỂU DIỄN BIỂU THỨC
        public override string ToString()
        {
            return c.ToString();   
        }
    }
}
