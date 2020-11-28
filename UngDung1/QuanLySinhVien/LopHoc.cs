using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConnectDB;

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
            //insert into tblLopHoc (MaLop, TenLop, DiaChi) values('001', 'toan', 'p001')
            string sql = @"insert into tblLopHoc (MaLop, TenLop, DiaChi) values('{0}', '{1}', '{2}')";
            ConnectDB cdb = new ConnectDB();
            cdb.InsertQuery(
                string.Format(sql, this.MaLop, this.TenLop, this.DiaChi));
        }

        public static List<LopHoc> GetDanhSachLopHoc()
        {
            ConnectDB cdb = new ConnectDB();
            string sql = "select * from tblLopHoc";
            SqlDataReader res = cdb.SelectQuery(sql);
            List<LopHoc> lLopHoc = new List<LopHoc>();
            while (res.Read()) {
                string maLop = res.GetValue(0).ToString();
                string tenLop = res.GetValue(1).ToString();
                string diaChi = res.GetValue(2).ToString();
                LopHoc lh = new LopHoc(maLop, tenLop, diaChi);
                lLopHoc.Add(lh);
            }
            return lLopHoc;
        }





        /// <summary>
        /// Xóa lop hoc trong danh sách
        /// </summary>
        /// <param name="maLopHoc"></param>
        public static void Xoa(string maLopHoc)
        {
            string sql = @"delete from tblLopHoc where MaLop = '{0}'";
            ConnectDB cdb = new ConnectDB();
            cdb.InsertQuery(String.Format(sql, maLopHoc));

        }
        public static void Sua(LopHoc lh)
        {
            string sql = @"update tblLopHoc
set TenLop = '{0}',DiaChi = '{1}'
where MaLop= '{2}'";
            ConnectDB cdb = new ConnectDB();
            cdb.InsertQuery(String.Format(sql, lh.TenLop, lh.DiaChi, lh.MaLop));
        }

        public static LopHoc LopHocById(string maLopHoc)
        {
            string sql = @"select * from tblLopHoc where MaLop= '{0}'";
            ConnectDB cdb = new ConnectDB();
            var res = cdb.SelectQuery(string.Format(sql, maLopHoc));
            res.Read();
            string maLop = res.GetValue(0).ToString().Trim();
            string tenLop = res.GetValue(1).ToString().Trim();
            string diaChi = res.GetValue(2).ToString().Trim();

            return new LopHoc(
                maLop, tenLop, diaChi);
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
            string sql = @"insert into tblLopHoc (MaLop, TenLop, DiaChi) values('{0}', '{1}', '{2}')";
            ConnectDB cdb = new ConnectDB();
            cdb.InsertQuery(
                string.Format(sql, lh.MaLop, lh.TenLop, lh.DiaChi));
        }
    }
}
