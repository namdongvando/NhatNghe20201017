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
    public partial class FormSuaLopHoc : Form
    {
        public FormSuaLopHoc()
        {
            InitializeComponent();
            SetInputForm(LopHoc.GetThongTinSuaLopHoc());


        }

        private void SetInputForm(LopHoc lopHoc)
        {
            txtMaLop.Text = lopHoc.MaLop;
            txtTenLop.Text = lopHoc.TenLop;
            txtDiaChi.Text = lopHoc.DiaChi;
        }

        private void FormSuaLopHoc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isOk = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo");
            if (isOk != DialogResult.OK)
                return;
            // neu ma ok 
            LopHoc.Xoa(txtMaLop.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LopHoc lHocSua = GetInputForm();
                LopHoc.Sua(lHocSua);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }


        }

        private LopHoc GetInputForm()
        {
            if (txtTenLop.Text == "")
            {
                throw new Exception("Bạn Chua Nhập Tên Lớp Học");
            }
            if (txtDiaChi.Text == "")
            {
                throw new Exception("Bạn Chua Nhập Địa Chỉ");
            }
            return new LopHoc(
                txtMaLop.Text,
                txtTenLop.Text,
                txtDiaChi.Text);
        }
    }
}
