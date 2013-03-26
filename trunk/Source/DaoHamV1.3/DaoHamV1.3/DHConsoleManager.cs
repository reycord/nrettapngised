using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaoHamV1._3
{
    public class DHConsoleManager : DHManager
    {
        double x;
        public override void KhoiTaoDaoHam()
        {
            //xử lý nhập xuất từ console ở đây nhé
            Console.ReadLine();
            Console.WriteLine("Chuong trinh nhap vao 1 bieu thuc va tinh gia tri + dao ham");
            Console.WriteLine("0: HangSo\t1: DonThuc\t2: DaThucTong");
            Console.WriteLine("3: DaThucHieu \t4: DaThucTich\t5: DaThucThuong");

            Console.Write("Nhap Gia tri cua bien X: ");
            x = double.Parse(Console.ReadLine());

            List<BieuThuc> bt = new List<BieuThuc>();
            Console.WriteLine("Loai bieu thuc: ");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 0:
                    bieuThuc = NhapHangSo();
                    break;
                case 1:
                    bieuThuc = NhapDonThuc(x);
                    break;
                case 2:
                    bieuThuc = NhapDaThucTong(true);
                    break;
                case 3:
                    bieuThuc = NhapDaThucTong(false);
                    break;
                case 4:
                    bieuThuc = NhapDaThucTich();
                    break;
                case 5:
                    bieuThuc = NhapDaThucThuong();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }

        #region Các hàm phụ trợ việc tạo biểu thức nhập từ Console
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
                Console.WriteLine("Nhap he so: ");
                heSo = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so mu: ");
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
        #endregion

        public override void XuatKetQua()
        {
            Console.WriteLine("Ket Qua Dao Ham : {0}", TinhDaoHam());
            Console.WriteLine("Ket Qua Bieu Thuc : {0}", TinhGiaTriBieuThuc());
        }
    }
}
