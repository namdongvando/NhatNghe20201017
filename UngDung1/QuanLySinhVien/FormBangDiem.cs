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
    public partial class FormBangDiem : Form
    {

        private int IsThem = 1;
        // 1 them 
        // 0 sua

        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BangDiem bd = GetInputForm();
                // them
                if (IsThem == 1)
                {
                    // reset data
                }
                else
                {
                    // sua

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private BangDiem GetInputForm()
        {
            if(txtToan.Text == "")
            {
                txtToan.SelectAll();
                txtToan.Focus();
                throw new Exception("Bạn Chưa Nhập Điêm Toán");
            }
            if (txtHoa.Text == "")
            {
                txtHoa.SelectAll();
                txtHoa.Focus();
                throw new Exception("Bạn Chưa Nhập Điêm Hóa");
            }
            if (txtLy.Text == "")
            {
                txtLy.SelectAll();
                txtLy.Focus();
                throw new Exception("Bạn Chưa Nhập Điêm Lý");
            }
            // toan ly hoa
            double toan, ly, hoa;
            #region Kiem tra diem toan
            if (double.TryParse(txtToan.Text, out toan) == true)
            {
                if (toan > 10 || toan < 0)
                {
                    txtToan.SelectAll();
                    txtToan.Focus();
                    throw new Exception("Điểm Toán Không Hợp Lệ");
                }
            }
            else
            {
                txtToan.SelectAll();
                txtToan.Focus();
                throw new Exception("Điểm Toán Không Hợp Lệ");
            }
            #endregion
            #region Diem Ly
            if (double.TryParse(txtLy.Text, out ly) == true)
            {
                if (ly > 10 || ly < 0)
                {
                    txtLy.SelectAll();
                    txtLy.Focus();
                    throw new Exception("Điểm Toán Không Hợp Lệ");
                }
            }
            else
            {
                txtLy.SelectAll();
                txtLy.Focus();
                throw new Exception("Điểm Toán Không Hợp Lệ");
            }
            #endregion
            #region Hoa
            if (double.TryParse(txtHoa.Text, out hoa) == true)
            {
                if (hoa > 10 || hoa < 0)
                {
                    txtHoa.SelectAll();
                    txtHoa.Focus();
                    throw new Exception("Điểm Toán Không Hợp Lệ");
                }
            }
            else
            {
                txtHoa.SelectAll();
                txtHoa.Focus();
                throw new Exception("Điểm Toán Không Hợp Lệ");
            }
            #endregion
            SinhVien itemSV = (SinhVien) cbbSinhVien.SelectedItem;
            LopHoc itemLH = (LopHoc)cbbLopHoc.SelectedItem;
            return new BangDiem(itemSV.MaSV, itemLH.MaLop, toan, ly, hoa);

        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {
            cbbLopHoc.DataSource 
                = LopHoc.GetDanhSachLopHoc().ToList();
            cbbLopHoc.DisplayMember = "TenLop";
            cbbLopHoc.ValueMember = "MaLop";
            cbbSinhVien.DataSource = SinhVien.GetDanhSachSinhVien().ToList();
            cbbSinhVien.DisplayMember = "TenSV";
            cbbSinhVien.ValueMember = "MaSV";
        }
    }
}
