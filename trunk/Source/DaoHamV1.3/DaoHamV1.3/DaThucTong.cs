using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class DaThucTong : DaThuc
    {
        // Cái này dành cho biểu diễn luôn Đa Thức Hiệu trong lớp này
        // Nếu true:    a + b
        // Nếu false:   a - b
        // set giá trị isDaThucTong này trong hàm constructor
        private bool isDaThucTong = true;   // Mặc định true (Đa thức tổng)

        // CONSTRUCTORS
        public DaThucTong(BieuThuc _u, BieuThuc _v, bool _isDaThucTong)
        {
            u = _u;
            v = _v;
            isDaThucTong = _isDaThucTong;
        }

        // TÍNH GIÁ TRỊ + ĐẠO HÀM

        public override double TinhGiaTri()
        {
            if (isDaThucTong)
                return u.TinhGiaTri() + v.TinhGiaTri();
            return u.TinhGiaTri() - v.TinhGiaTri();
        }

        public override BieuThuc TinhDaoHam()
        {
            return new DaThucTong(u.TinhDaoHam(), v.TinhDaoHam(), isDaThucTong);
        }

        // BIỂU DIỄN BIỂU THỨC
        public override string ToString()
        {
            if (isDaThucTong)   //Tổng
                return ("(" + u.ToString() + " + " + v.ToString() + ")");
            return ("(" + u.ToString() + " - " + v.ToString() + ")");   //Hiệu
        }
    }
}
