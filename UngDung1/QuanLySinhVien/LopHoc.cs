using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string DiaChi { get; set; }
        public static List<LopHoc> DanhSachLopHoc;
        private static LopHoc ThongTinSuaLopHoc;
        public LopHoc()
        {
        }

        public LopHoc(string maLop, string tenLop, string diaChi)
        {
            MaLop = maLop;
            TenLop = tenLop;
            DiaChi = diaChi;
        }

        public string LopHoc2String()
        {
            return string.Format("{0},{1},{2}",
                MaLop,
                TenLop,
                DiaChi);
        }
        /// <summary>
        /// Thêm thông tin của đoi tượng hiện tai vào danh sách
        /// là this
        /// </summary>
        public void ThemLopHoc()
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<LopHoc>();
            DanhSachLopHoc.Add(this);
        }

        public static List<LopHoc> GetDanhSachLopHoc()
        {
            if (DanhSachLopHoc == null)
                return new List<LopHoc>();
            return DanhSachLopHoc;
        }





        /// <summary>
        /// Xóa lop hoc trong danh sách
        /// </summary>
        /// <param name="maLopHoc"></param>
        public static void Xoa(string maLopHoc)
        {
            DanhSachLopHoc.RemoveAll(lh => lh.MaLop == maLopHoc);
        }
        public static void Sua(LopHoc lh)
        {
            Xoa(lh.MaLop);
            ThemLopHoc(lh);
        }

        public static LopHoc LopHocById(string maLopHoc)
        {
            if (DanhSachLopHoc != null)
                foreach (var lopHoc in DanhSachLopHoc)
                {
                    if (lopHoc.MaLop == maLopHoc)
                        return lopHoc;
                }
            return new LopHoc();
        }

        public static void SetThongTinSuaLopHoc(LopHoc lhSua)
        {
            ThongTinSuaLopHoc = lhSua;
        }
        public static LopHoc GetThongTinSuaLopHoc()
        {
            if (ThongTinSuaLopHoc != null)
                return ThongTinSuaLopHoc;
            return new LopHoc();
        }
        private static void ThemLopHoc(LopHoc lh)
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<LopHoc>();
            DanhSachLopHoc.Add(lh);
        }
    }
}
