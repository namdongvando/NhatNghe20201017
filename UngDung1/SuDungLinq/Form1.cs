﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinq
{
    public partial class Form1 : Form
    {
        static Estore20DataContext _Estore20Db = new Estore20DataContext();
         public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = _Estore20Db.HangHoas.ToList();

            List<Loai> lLoai = _Estore20Db.Loais.ToList();

            Loai chonLoai = new Loai()
            {
                MaLoai = 0,
                TenLoai = "Chon Loại Hàng Hóa"
            };
            lLoai.Insert(0, chonLoai);
            cbbLoai.DataSource = lLoai;
                
            cbbLoai.DisplayMember = "TenLoai";
            cbbLoai.ValueMember = "MaLoai";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                int maLoai =
                    int.Parse(cbbLoai.SelectedValue.ToString());
                if (maLoai == 0)
                    throw new Exception("Bạn Chưa Chọn Loai Hang Hóa");
                dgvHangHoa.DataSource = _Estore20Db.HangHoas
                    .Where(
                    hh => (hh.TenHH.Contains(tuKhoa)
                    && hh.MaLoai == maLoai)
                    ).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
            


        }
    }
}
