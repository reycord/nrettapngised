using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DaoHamV1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mô Tả
            Console.WriteLine("=============v1.3=============");
            Console.WriteLine("Chuong Trinh Tinh Dao Ham");
            Console.WriteLine("Vui Long Chon Thong Tin :");
            Console.WriteLine("   A. Console");
            Console.WriteLine("   B. File");
            Console.Write("Ban Chon : ");
            #endregion
            int key = Console.Read();
            DHManager dhManager = null;
            switch (key)
            {
                case 'a':
                case 'A':
                    //Xu ly Nhap Console
                    dhManager = new DHConsoleManager();
                    break;
                case 'b':
                case 'B':
                    //Xu Ly Nhap File      
                    dhManager = new DHFileManager();
                    break;
                default: Console.Write("Error : Khong Dung Ki Tu");
                    break;
            }
            if (dhManager != null)
            {
                dhManager.XuLy();
            }
            
        }
    }
}
