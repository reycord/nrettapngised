using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public abstract class BieuThuc
    {
        protected static List<String> ExprToString = new List<string>();
        private static OutputSupport _opSupport;
        public OutputSupport OSupport
        {
            get {
                    if (_opSupport == null)
                    {
                        _opSupport = new OPInfix();
                    }
                    return BieuThuc._opSupport;
                }
            set { BieuThuc._opSupport = value; }
        }

        // Tính giá trị và đạo hàm
        public abstract double TinhGiaTri();

        public abstract BieuThuc TinhDaoHam();

        public abstract override string ToString();

        public abstract void AddtoList();
    }
}
