using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DaoHamV1._3
{
    public class DHFileManager : DHManager
    {
        public override void KhoiTaoDaoHam()
        {
            //Xử lý nhập xuất file ở đây nhé
            List<string> buffer = new List<string>();
            // 0: Hang So // 1: Don Thuc // 2: BT Tong // 3: BT Tich // 4: BT Thuong
            // Object đọc file
            StreamReader reader = File.OpenText("../../input.txt");
            string input;
            while ((input = reader.ReadLine()) != null) // Tiến hành vừa đọc vừa xét các giá trị
            {
                if (input != "")
                    buffer.Add(input);
                else
                {
                    break;
                }
            }
            reader.Close();

            double x = double.Parse(buffer[buffer.Count - 1]);    // Giá trị biến x
            int ptrIndex = 0;

            // Xác định biểu thức từ chuỗi
            bieuThuc = DocBieuThuc(buffer, ref ptrIndex);
        }

        #region Các hàm phụ trợ việc tạo BieuThuc obj từ file
        private BieuThuc DocBieuThuc(List<string> buffer, ref int ptrIndex)
        {
            BieuThuc bt;
            switch (int.Parse(buffer[ptrIndex]))
            {
                case 0:     // Hằng số
                    bt = DocHangSo(buffer, ref ptrIndex);
                    break;
                case 1:     // Đơn thức
                    bt = DocDonThuc(buffer, ref ptrIndex);
                    break;
                case 2:     // Đa thức tổng / hiệu
                    bt = DocDaThucTong(buffer, ref ptrIndex);
                    break;
                case 3:     // Đa thức tích
                    bt = DocDaThucTich(buffer, ref ptrIndex);
                    break;
                case 4:     // Đa thức thương
                    bt = DocDaThucThuong(buffer, ref ptrIndex);
                    break;
                default:
                    bt = null;
                    break;
            }
            return bt;
        }

        private BieuThuc DocHangSo(List<string> buffer, ref int ptrIndex)
        {
            ptrIndex++;     // Di chuyển đến vị trí của giá trị hằng số
            //HangSo hangSo = new HangSo(double.Parse(buffer[ptrIndex]));
            HangSo hangSo = HangSo.CreateHangSo(double.Parse(buffer[ptrIndex]));

            ptrIndex++;
            return hangSo;
        }

        private BieuThuc DocDonThuc(List<string> buffer, ref int ptrIndex)
        {
            double x = double.Parse(buffer[buffer.Count - 1]);  // Biến số

            ptrIndex++;
            double heSo = double.Parse(buffer[ptrIndex]);     // hệ số

            ptrIndex++;
            double soMu = double.Parse(buffer[ptrIndex]);     // số mũ
            DonThuc donThuc = (DonThuc)DonThuc.Create(x, heSo, soMu);

            ptrIndex++;     // Di chuyển đến giá trị biểu diễn loại biểu thức tiếp theo (0 - 4)

            return donThuc;
        }

        private BieuThuc DocDaThucTong(List<string> buffer, ref int ptrIndex)
        {
            ptrIndex++;
            BieuThuc u, v;
            u = DocBieuThuc(buffer, ref ptrIndex);
            v = DocBieuThuc(buffer, ref ptrIndex);
            return new DaThucTong(u, v, true);
        }

        private BieuThuc DocDaThucTich(List<string> buffer, ref int ptrIndex)
        {
            ptrIndex++;
            BieuThuc u, v;
            u = DocBieuThuc(buffer, ref ptrIndex);
            v = DocBieuThuc(buffer, ref ptrIndex);
            return new DaThucTich(u, v);
        }

        private BieuThuc DocDaThucThuong(List<string> buffer, ref int ptrIndex)
        {
            ptrIndex++;
            BieuThuc u, v;
            u = DocBieuThuc(buffer, ref ptrIndex);
            v = DocBieuThuc(buffer, ref ptrIndex);
            return new DaThucThuong(u, v);
        }
        #endregion

        public override void XuatKetQua()
        {
            Console.WriteLine("Nhap file : input.txt, Ket qua: output.txt");
            try
            {
                BieuThuc kq = bieuThuc.TinhDaoHam();
                kq.AddtoList();
                StreamWriter ghiFile = new StreamWriter("../../output.txt");
                ghiFile.WriteLine(TinhGiaTriBieuThuc());
                ghiFile.WriteLine(kq);
                ghiFile.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
