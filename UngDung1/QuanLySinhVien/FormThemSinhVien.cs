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
    public partial class FormThemSinhVien : Form
    {
        public FormThemSinhVien()
        {
            InitializeComponent();
        }

        private void FormThemSinhVien_Load(object sender, EventArgs e)
        {
            List<GioiTinh> lgt = GioiTinh.Get();
            cbbGioiTinh.DataSource = lgt;
            cbbGioiTinh.DisplayMember = "Name";
            cbbGioiTinh.ValueMember = "Id";
            // gan gia tri mac dinh
            cbbGioiTinh.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = GetInputForm();
                SinhVien.Them(sv);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
            
        }

        private SinhVien GetInputForm()
        {
            if (txtMaSinhVien.Text == "") {
                txtMaSinhVien.Focus();
                throw new Exception("Nhập Mã Sinh Viên");
            }
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
            GioiTinh gt = (GioiTinh) cbbGioiTinh.SelectedItem;

            return new SinhVien(
                txtMaSinhVien.Text
                , txtTenSinhVien.Text
                , txtSDT.Text
                , txtDiaChi.Text
                , gt.Id
                , dtpNgaySinh.Value
                ) ;
        }
    }
}
