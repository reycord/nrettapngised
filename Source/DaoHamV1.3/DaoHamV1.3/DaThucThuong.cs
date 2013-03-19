using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class DaThucThuong : DaThuc
    {
        // CONSTRUCTORS
        public DaThucThuong(BieuThuc _u, BieuThuc _v)
        {
            u = _u;
            v = _v;
        }

        // TÍNH GIÁ TRỊ + ĐẠO HÀM         
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
            return ("(" + u.ToString() + " / " + v.ToString() + ")");
        }
    }
}
