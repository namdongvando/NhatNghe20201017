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
    public partial class formSuaSinhVien : Form
    {

        public formSuaSinhVien()
        {
            // khoi tao các doi tuong form
            InitializeComponent();
            
            List<GioiTinh> lgt = GioiTinh.Get();
            cbbGioiTinh.DataSource = lgt;
            cbbGioiTinh.DisplayMember = "Name";
            cbbGioiTinh.ValueMember = "Id";


            SetInputForm(SinhVien.GetSinhVienSua());
        }

        private void SetInputForm(SinhVien sv)
        {
            txtMaSinhVien.Text = sv.MaSV;
            txtTenSinhVien.Text = sv.TenSV;
            txtDiaChi.Text = sv.DiaChi;
            txtSDT.Text = sv.SDT;
            dtpNgaySinh.Value = sv.NgaySinh;
            cbbGioiTinh.SelectedValue = sv.GioiTinh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien svSua = GetInputForm();
                SinhVien.Sua(svSua);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
            


        }

        private SinhVien GetInputForm()
        {
            
            if (txtTenSinhVien.Text == "")
            {
                txtMaSinhVien.Focus();
                throw new Exception("Nhập Tên Sinh Viên");
            }

            if (txtDiaChi.Text == "")
            {
                txtMaSinhVien.Focus();
                throw new Exception("Nhập Địa Chỉ");
            }
            GioiTinh gt = (GioiTinh)cbbGioiTinh.SelectedItem;

            return new SinhVien(
                txtMaSinhVien.Text
                , txtTenSinhVien.Text
                , txtSDT.Text
                , txtDiaChi.Text
                , gt.Id
                , dtpNgaySinh.Value
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var isXoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isXoa != DialogResult.OK)
                return;
            SinhVien.Xoa(SinhVien.GetSinhVienSua().MaSV);
            DialogResult = DialogResult.OK;
        }
    }
}
