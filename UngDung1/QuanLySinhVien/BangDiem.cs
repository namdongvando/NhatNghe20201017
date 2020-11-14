using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class BangDiem 
    {
        public string MaSV { get; set; }
        public string MaLop { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public static List<BangDiem> DanhSachBangDiem { get; set; }

        public BangDiem(string maSV, string maLop, double toan, double ly, double hoa)
        {
            MaSV = maSV;
            MaLop = maLop;
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
        }

        public BangDiem()
        {
        }

        public static void Xoa(string maLop , string maSinhVien)
        {
            DanhSachBangDiem
                .RemoveAll(
                item => item.MaSV == maSinhVien 
                && item.MaLop == maLop);
        }
        public static void Them(BangDiem bd) {
            if (DanhSachBangDiem == null)
                DanhSachBangDiem = new List<BangDiem>();
            DanhSachBangDiem.Add(bd);
        }
        public static void Sua(BangDiem bd)
        {
            Xoa(bd.MaLop, bd.MaSV);
            Them(bd);
        }


        /// <summary>
        /// lấy danh sách bảng diem
        /// </summary>
        /// <returns></returns>
        public static List<BangDiem> GetDanhSachBangDiem() {
            if (DanhSachBangDiem == null)
                return new List<BangDiem>();
            return DanhSachBangDiem;
        }

        public static BangDiem BangDiemByMaSVMaLop(string maSV, string maLop)
        {
            foreach (var item in DanhSachBangDiem)
            {
                if (item.MaLop == maLop && item.MaSV == maSV)
                    return item;
            }
            return new BangDiem();
        }
    }
}
