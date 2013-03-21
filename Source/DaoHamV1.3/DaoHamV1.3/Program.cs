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
            //double x = 2;
            //BieuThuc bt = new DaThucThuong(
            //                    new DonThuc(x, 5, 4),
            //                    new DonThuc(x, 2, 3));
            //System.Console.WriteLine(bt.ToString());
            //System.Console.WriteLine(bt.TinhDaoHam().ToString());
            //System.Console.WriteLine(bt.TinhGiaTri());
            //System.Console.ReadLine();   

            //Program bt = new Program();
            //bt.NhapXuat();
            NhapXuatConsole console = new NhapXuatConsole() ;
            
        }
        public void NhapXuat()
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
                StreamReader Re = File.OpenText("../../Note.txt");
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
                        temp = new DonThuc(Array[Array.Count - 1], Array[index + 1], Array[index + 2]);
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
                for (int i = 0; i < Array.Count; i++)
                    if (Array[i] == -100)
                        Array.RemoveAt(i);
                double chan = list.Count % 2;
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
                                if(Array[i+1]==1 &&Array[i+2]==2)
                                {
                                    if (Array[i] == 4)
                                    {
                                        temp = new DaThucThuong(list[IndexOfList * 2], list[IndexOfList * 2 + 1]);
                                        list[IndexOfList] = temp;
                                        Array.RemoveAt(i+1);
                                        Array.RemoveAt(i+2);
                                        Array[i] =1;
                                    }
                                    if (Array[i] == 3)
                                    {
                                        temp = new DaThucTich(list[IndexOfList * 2], list[IndexOfList * 2 + 1]);
                                        list[IndexOfList] = temp;
                                        Array[i] = 1;
                                        Array.RemoveAt(i+1);
                                        Array.RemoveAt(i+2);
                                    }
                                    if (Array[i] == 2)
                                    {
                                        temp = new DaThucTong(list[IndexOfList * 2], list[IndexOfList * 2 + 1], true);
                                        list[IndexOfList] = temp;
                                        Array[i] = 1;
                                        Array.RemoveAt(i+1);
                                        Array.RemoveAt(i+2);
                                    }
                                }
                            }
                                //IndexOfList = IndexOfList + 1;

                            
                        }
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
                StreamWriter ghiFile = new StreamWriter("KetQua.txt");
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
