using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public static List<SinhVien> DanhSachSinhVien;
        private static SinhVien ThongTinSinhVienSua;
        /// <summary>
        /// Tìm sinh vien theo ma
        /// </summary>
        /// <param name="maSV"></param>
        /// <returns></returns>
        public static SinhVien SinhVienById(string maSV)
        {
            
            foreach (var sv in DanhSachSinhVien)
            {
                if (sv.MaSV == maSV)
                    return sv;
            }
            return new SinhVien();
        }
        // gán thong tin sinh vien can sua
        public static void SetSinhVienSua(SinhVien svSua)
        {
            ThongTinSinhVienSua = svSua;
        }

        public static SinhVien GetSinhVienSua()
        {
            
            if (ThongTinSinhVienSua == null)
                return new SinhVien();
            return ThongTinSinhVienSua;
        }
        /// <summary>
        ///  khoi tao Sinh Vien
        /// </summary>
        /// <param name="maSV"></param>
        /// <param name="tenSV"></param>
        /// <param name="sDT"></param>
        /// <param name="diaChi"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="NgaySinh"></param>
        public SinhVien(string maSV, string tenSV, string sDT, string diaChi, bool gioiTinh, DateTime ngaySinh)
        {
            MaSV = maSV;
            TenSV = tenSV;
            SDT = sDT;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }

        public static List<SinhVien> GetDanhSachSinhVien()
        {
            if (DanhSachSinhVien == null)
                return new List<SinhVien>();
            return DanhSachSinhVien;
        }

        public SinhVien() {

        }
        /// <summary>
        /// tuôi cua sinh vien hien tai
        /// </summary>
        /// <returns></returns>
        public int Tuoi() {
            // lấy nam hiện tai
            int namHienTai = DateTime.Now.Year;
            // nam sinh cua sinh vien
            int namSinh = this.NgaySinh.Year;
            return namHienTai - namSinh;
        }

        public string SinhVien2String()
        {
            return string.Format(
                @"{0},{1},{2},{3},{4},{5}",
             MaSV,TenSV,SDT,DiaChi,GioiTinh,NgaySinh);
        }
        /// <summary>
        /// them sinh vien hien tai vao danh sach
        /// </summary>
        public void Them() {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<SinhVien>();
            DanhSachSinhVien.Add(this);
        }
        public static void Them(SinhVien sv)
        {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<SinhVien>();
            DanhSachSinhVien.Add(sv);
        }

        public static void Xoa(string maSV) {
            DanhSachSinhVien
                .RemoveAll(sv => sv.MaSV == maSV);
        }
        /// <summary>
        /// sua thong tin sinh vien
        /// </summary>
        /// <param name="sinhVien"></param>
        public static void Sua(SinhVien sinhVien)
        {
            Xoa(sinhVien.MaSV);
            Them(sinhVien);
        }

    }
}
