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
        protected BieuThuc daoHam = null;

        public override string ToString()
        {
            return (u.ToString() + v.ToString());
        }
        public override void AddtoList()
        {
            Console.WriteLine("oc oc");
        }
    }
}
