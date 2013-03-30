using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    class NhapXuatConsole
    {
        double x;
        public NhapXuatConsole()
        {
            Console.WriteLine("Chuong trinh nhap vao 1 bieu thuc va tinh gia tri + dao ham");
            Console.WriteLine("0: HangSo\t1: DonThuc\t2: DaThucTong");
            Console.WriteLine("3: DaThucHieu \t4: DaThucTich\t5: DaThucThuong");

            Console.Write("Nhap Gia tri cua bien X: ");
            x = double.Parse(Console.ReadLine());

            List<BieuThuc> bt = new List<BieuThuc>();
            Console.Write("Loai bieu thuc: ");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 0:
                    BieuThuc hangSo = NhapHangSo();
                    Console.WriteLine("Gia tri: " + hangSo.TinhGiaTri());
                    Console.WriteLine("Dao Ham: " + hangSo.TinhDaoHam());
                    break;
                case 1:
                    BieuThuc donthuc = NhapDonThuc(x);
                    Console.WriteLine("Gia tri: " + donthuc.TinhGiaTri());
                    Console.WriteLine("Dao Ham: " + donthuc.TinhDaoHam());
                    break;
                case 2:
                    BieuThuc daThucTong = NhapDaThucTong(true);
                    Console.WriteLine("Gia tri: " + daThucTong.TinhGiaTri());
                    Console.WriteLine("Dao Ham: " + daThucTong.TinhDaoHam());
                    break;
                case 3:
                    BieuThuc daThucHieu = NhapDaThucTong(false);
                    Console.WriteLine("Gia tri: " + daThucHieu.TinhGiaTri());
                    Console.WriteLine("Dao Ham: " + daThucHieu.TinhDaoHam());
                    break;
                case 4:
                    BieuThuc daThucTich = NhapDaThucTich();
                    Console.WriteLine("Gia tri: " + daThucTich.TinhGiaTri());
                    Console.WriteLine("Dao Ham: " + daThucTich.TinhDaoHam());
                    break;
                case 5:
                    BieuThuc daThucThuong = NhapDaThucThuong();
                    Console.WriteLine("Gia tri: " + daThucThuong.TinhGiaTri());
                    Console.WriteLine("Dao Ham: " + daThucThuong.TinhDaoHam());
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }

        private DaThucTich NhapDaThucTich()
        {
            try
            {
                BieuThuc u, v;
                Console.Write("Loai bieu thuc cua u:");
                NhapBieuThuc(x, out u);

                Console.Write("Loai bieu thuc cua v:");
                NhapBieuThuc(x, out v);
                return new DaThucTich(u, v);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input!");
                return null;
            }
        }

        private DaThucThuong NhapDaThucThuong()
        {
            try
            {
                BieuThuc u, v;
                Console.Write("Loai bieu thuc cua u:");
                NhapBieuThuc(x, out u);

                Console.Write("Loai bieu thuc cua v:");
                NhapBieuThuc(x, out v);
                return new DaThucThuong(u, v);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input!");
                return null;
            }
        }

        private DaThucTong NhapDaThucTong(bool isTong)
        {
            try
            {
                BieuThuc u, v;
                Console.Write("Loai bieu thuc cua u:");
                NhapBieuThuc(x, out u);

                Console.Write("Loai bieu thuc cua v:");
                NhapBieuThuc(x, out v);
                return new DaThucTong(u, v, isTong);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input!");
                return null;
            }
        }

        private void NhapBieuThuc(double x, out BieuThuc u)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    u = NhapHangSo();
                    break;
                case 1:
                    u = NhapDonThuc(x);
                    break;
                case 2:
                    u = NhapDaThucTong(true);
                    break;
                case 3:
                    u = NhapDaThucTong(false);
                    break;
                case 4:
                    u = NhapDaThucTich();
                    break;
                case 5:
                    u = NhapDaThucThuong();
                    break;
                default:
                    u = null;
                    break;
            }
        }

        private BieuThuc NhapDonThuc(double x)
        {
            try
            {
                double heSo, soMu;
                Console.Write("Nhap he so: ");
                heSo = double.Parse(Console.ReadLine());
                Console.Write("Nhap so mu: ");
                soMu = double.Parse(Console.ReadLine());
                return DonThuc.Create(x, heSo, soMu);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Exception!");
                return null;
            }
        }

        private HangSo NhapHangSo()
        {
            try
            {
                Console.Write("Nhap gia tri hang so: ");
                return new HangSo(double.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input!");
                return null;
            }
        }
    }
}

