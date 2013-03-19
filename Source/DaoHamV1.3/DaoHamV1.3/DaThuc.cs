using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public abstract class DaThuc : BieuThuc
    {
        protected BieuThuc u;
        protected BieuThuc v;

        public override string ToString()
        {
            return (u.ToString() + v.ToString());
        }
    }
}
