using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 2;
            BieuThuc bt = new DaThucThuong(
                                new DonThuc(x, 5, 4),
                                new DonThuc(x, 2, 3));
            System.Console.WriteLine(bt.ToString());
            System.Console.WriteLine(bt.TinhDaoHam().ToString());
            System.Console.WriteLine(bt.TinhGiaTri());
            System.Console.ReadLine();
        }
    }
}
