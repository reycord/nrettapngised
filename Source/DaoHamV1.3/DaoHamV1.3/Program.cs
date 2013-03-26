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

        public static void NhapXuat()
        {
            try
            {
                // 0: Hang So
                // 1: Don Thuc
                // 2: BT Tong
                // 3: BT Tich
                // 4: BT Thuong
                string input;
                List<Double> Array = new List<Double>();
                List<BieuThuc> list = new List<BieuThuc>();
                StreamReader Re = File.OpenText("../../input.txt");
                while ((input = Re.ReadLine()) != null)
                {
                    if(input!="")
                        Array.Add(Convert.ToDouble(input));
                }
                Re.Close();
                int index = 0;
                BieuThuc temp;
                while (index < Array.Count)
                {
                    if (Array[index] == 1)
                    {
                        temp = DonThuc.Create(Array[Array.Count - 1], Array[index + 1], Array[index + 2]);
                        //Array[index] = -100;
                        Array[index + 1] = -100;
                        Array[index + 2] = -100;
                        index = index + 2;
                        list.Add(temp);
                    }
                    if (Array[index] == 0)
                    {
                        temp = new HangSo(Array[index + 1]);
                        Array[index] = 1;
                        Array[index + 1] = -100;
                        index = index + 1;
                        list.Add(temp);
                    }
                    index = index + 1;
                }
                
                for(int i=0;i<Array.Count;i++)
                {
                    if (Array[i] == -100)
                    {
                        Array.RemoveAt(i);
                        i = 0;
                    }
                }
               // double chan = list.Count % 2;
                int IndexOfList=0;
                if (true)
                {
                    while (list.Count != 1)
                    {
                        //IndexOfList = 0;
                        for (int i = 0; i < Array.Count - 1; i++)
                        {
                            if (Array[i] != 0 && Array[i]!=1 )
                            {
                                if(Array[i+1]==1 &&Array[i+2]==1)
                                {
                                    if (Array[i] == 4)
                                    {
                                        temp = new DaThucThuong(list[IndexOfList], list[IndexOfList + 1]);
                                        list[IndexOfList] = temp;
                                        list[IndexOfList + 1]=null;
                                        Array.RemoveAt(i+1);
                                        Array.RemoveAt(i+1);
                                        Array[i] =1;
                                        IndexOfList = IndexOfList + 2;
                                    }
                                    if (Array[i] == 3)
                                    {
                                        temp = new DaThucTich(list[IndexOfList], list[IndexOfList + 1]);
                                        list[IndexOfList] = temp;
                                        list[IndexOfList + 1] = null;
                                        Array[i] = 1;
                                        Array.RemoveAt(i+1);
                                        Array.RemoveAt(i+1);
                                        IndexOfList = IndexOfList + 2;
                                    }
                                    if (Array[i] == 2)
                                    {
                                        temp = new DaThucTong(list[IndexOfList], list[IndexOfList + 1], true);
                                        list[IndexOfList] = temp;
                                        list[IndexOfList + 1] = null;
                                        Array[i] = 1;
                                        Array.RemoveAt(i+1);
                                        Array.RemoveAt(i+1);
                                        IndexOfList = IndexOfList + 2;
                                    }
                                }
                                if (Array[i + 1] == 1)
                                {
                                    IndexOfList += 1;
                                }
                            }
                                //IndexOfList = IndexOfList + 1;
                            
                            
                        }
                        for (int i = 0; i < list.Count; i++)
                            if (list[i] == null)
                                list.RemoveAt(i);
                        IndexOfList = 0;
                        //chan = list.Count % 2;
                        //if (chan != 0)
                        //{
                        //    list[IndexOfList] = list[list.Count - 1];
                        //    for (int j = list.Count - 1; j > IndexOfList; j--)
                        //        list.RemoveAt(j);
                        //}
                        //if (chan == 0)
                        //{
                        //    int number = list.Count / 2;
                        //    for (int i = list.Count - 1; i >= number; i--)
                        //        list.RemoveAt(i);
                        
                    }
                }
                if (Array[Array.Count - 1] == -100)
                {
                    Console.WriteLine("\n\nInvalid Input");
                    Console.ReadKey();
                    return;
                }
                //Console.WriteLine(list[0].ToString());
                //Console.WriteLine(list[0].TinhDaoHam().ToString());
                //Console.WriteLine(list[0].TinhGiaTri().ToString());
                StreamWriter ghiFile = new StreamWriter("../../output.txt");
                string giatri = list[0].TinhGiaTri().ToString();
                string daoham = list[0].TinhDaoHam().ToString();
                ghiFile.WriteLine(giatri);
                ghiFile.WriteLine(daoham);
                ghiFile.Close();
                ghiFile.Dispose();
                //Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nInvalid Input");
                Console.ReadKey();
            }
        }
    }
}
