using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public abstract class BieuThuc
    {
        public abstract double TinhGiaTri();

        public abstract BieuThuc TinhDaoHam();

        public abstract override string ToString();
    }
}
