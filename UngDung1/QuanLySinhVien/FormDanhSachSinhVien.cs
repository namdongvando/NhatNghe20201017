using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormDanhSachSinhVien : Form
    {
        private object sv;

        public FormDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void dgvDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSV = dgvDanhSachSinhVien
                .Rows[e.RowIndex].Cells[0]
                .Value.ToString();
            SinhVien svSua = 
                SinhVien.SinhVienById(maSV);

            // luu thông tin sinh vien can sua
            SinhVien.SetSinhVienSua(svSua);
            Form fSuaSV = new formSuaSinhVien();
            
          var isOk =  fSuaSV.ShowDialog();
            if (isOk == DialogResult.OK)
                ResetDanhSachSinhVien();

        }

        private void FormDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            ResetDanhSachSinhVien();
        }
        /// <summary>
        /// tai lai danh sách sinh vien
        /// </summary>
        private void ResetDanhSachSinhVien()
        {
                dgvDanhSachSinhVien.DataSource = SinhVien.GetDanhSachSinhVien().ToList();

        }
        /// <summary>
        /// Mở form thêm sinh vien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            Form formThemSinhVien = new FormThemSinhVien();
            // mở form thêm sinh vien
            var isOk = formThemSinhVien.ShowDialog();
            // nếu mà có thêm
            if (isOk == DialogResult.OK) {
                // cap nhat danh sach sinh vien
                ResetDanhSachSinhVien();
            }

        }
    }
}
