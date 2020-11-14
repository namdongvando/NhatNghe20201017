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
        const int Sua = 0;
        const int Them = 1;
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
                    BangDiem.Them(bd);
                    ResetData();
                    // reset data
                }
                else
                {
                    // sua
                    BangDiem.Sua(bd);
                    IsThem = Them;
                   ResetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ResetData()
        {
            dgvBangDiem.DataSource =
                BangDiem.GetDanhSachBangDiem()
                .ToList();
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
                    throw new Exception("Điểm Lý Không Hợp Lệ");
                }
            }
            else
            {
                txtLy.SelectAll();
                txtLy.Focus();
                throw new Exception("Điểm Lý Không Hợp Lệ");
            }
            #endregion
            #region Hoa
            if (double.TryParse(txtHoa.Text, out hoa) == true)
            {
                if (hoa > 10 || hoa < 0)
                {
                    txtHoa.SelectAll();
                    txtHoa.Focus();
                    throw new Exception("Điểm Hóa Không Hợp Lệ");
                }
            }
            else
            {
                txtHoa.SelectAll();
                txtHoa.Focus();
                throw new Exception("Điểm Hóa Không Hợp Lệ");
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

        private void dgvBangDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IsThem = Sua;
            string maSV = dgvBangDiem
                .Rows[e.RowIndex]
                .Cells[0]
                .Value.ToString();
            string maLop = dgvBangDiem
                .Rows[e.RowIndex]
                .Cells[1]
                .Value.ToString();
            // láy thông tin dong cần sửa
            BangDiem bdSua = 
                BangDiem.BangDiemByMaSVMaLop(maSV, maLop);
            // gán thông tin dong can sua vào form
            SetInputForm(bdSua);
        }

        private void SetInputForm(BangDiem bdSua)
        {
            txtToan.Text = bdSua.Toan.ToString();
            txtLy.Text = bdSua.Ly.ToString();
            txtHoa.Text = bdSua.Hoa.ToString();
            cbbLopHoc.SelectedValue = bdSua.MaLop;
            cbbSinhVien.SelectedValue = bdSua.MaSV;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var isOk = MessageBox.Show("Bạn Có Muốn Xóa Không?");
            if (isOk != DialogResult.OK)
                return;
            BangDiem bdSua = GetInputForm();
            BangDiem.Xoa(bdSua.MaLop,bdSua.MaSV);

        }
    }
}
