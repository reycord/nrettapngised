using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class HangSo : BieuThuc
    {
        private double c;

        // CONSTRUCTORS
        public HangSo()
        {
            c = 0;
        }

        public HangSo(int _value)
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
            return new HangSo(0);
        }

        // BIỂU DIỄN BIỂU THỨC
        public override string ToString()
        {
            return c + " ";   
        }
    }
}
