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
        static HangSo soKhong = null;

        // CONSTRUCTORS
        public HangSo()
        {
            c = 0;
        }

        private HangSo(double _value)
        {
            c = _value;
        }
        //Câu 3.B
        public static HangSo CreateHangSo(double _value)
        {
            if (_value == 0)
            {
                if (soKhong == null)
                {
                    soKhong = new HangSo(0);
                }
                return soKhong;
            }
            return new HangSo(_value);
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
            if (OSupport != null)
            {
                return OSupport.XuLy(ExprToString);
            }
            return null;
        }
        public override void AddtoList()
        {
            ExprToString.Add(c.ToString());
        }
    }
}
