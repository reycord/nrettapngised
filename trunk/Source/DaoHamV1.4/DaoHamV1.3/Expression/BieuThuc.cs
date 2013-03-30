using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public abstract class BieuThuc
    {
        protected static List<String> ExprToString = new List<string>();
        public static OutputSupport _oSupport;

        public OutputSupport OSupport
        {
            get { 
                //if (_oSupport == null)
                //    return new OPInfix();
                return _oSupport; 
            }
            set { _oSupport = value; }
        }

        // Tính giá trị và đạo hàm
        public abstract double TinhGiaTri();
        public abstract BieuThuc TinhDaoHam();
        public abstract override string ToString();
        public abstract void AddtoList();
    }
}
