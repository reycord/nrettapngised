using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class DaThucTich : DaThuc
    {
        // CONSTRUCTORS
        public DaThucTich(BieuThuc _u, BieuThuc _v)
        {
            u = _u;
            v = _v;
        }

        // TÍNH GIÁ TRỊ + ĐẠO HÀM
        public override double TinhGiaTri()
        {
            return (u.TinhGiaTri() * v.TinhGiaTri());
        }

        public override BieuThuc TinhDaoHam()
        {
            // (u.v)' = u'v + uv'
            // u'v , uv' là 2 DaThucTich
            // (u'v + uv') là 1 DaThucTong
            return new DaThucTong(new DaThucTich(u.TinhDaoHam(), v), 
                                  new DaThucTich(v.TinhDaoHam(), u),
                                  true);
        }

        // BIỂU DIỄN BIỂU THỨC
        public override string ToString()
        {
            return ("(" + u.ToString() + " * " + v.ToString() + ")");
        }
    }
}
