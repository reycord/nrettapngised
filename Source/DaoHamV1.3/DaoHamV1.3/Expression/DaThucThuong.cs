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
            return u.TinhGiaTri() / v.TinhGiaTri();
        }

        public override BieuThuc TinhDaoHam()
        {
            // (u/v)' = (u'v - uv') / v^2
            // u'v và uv' là 2 DaThucTich
            // (u'v - uv') là 1 DaThucTong
            // v^2 = v * v là 1 DaThucTich
            // (u'v - uv') / v^2 là 1 DaThucThuong
            if(daoHam ==null)
                daoHam = new DaThucThuong(
                        new DaThucTong(
                            new DaThucTich(u.TinhDaoHam(), v),
                            new DaThucTich(u, v.TinhDaoHam()),
                            false
                            ),
                        new DaThucTich(v, v)
                        );

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
            ExprToString.Add("(");
            u.AddtoList();
            ExprToString.Add("/");
            v.AddtoList();
            ExprToString.Add(")");
        }
    }
}
