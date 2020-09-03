using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BangThuVien;
using KetNoiDB;


namespace QuanLyThuVien
{
    public partial class frmDanhSachDocGia : Form
    {
        BUS_BanDoc bd = new BUS_BanDoc();
        int chon;
        TimKiem tk = new TimKiem();
      
        public frmDanhSachDocGia()
        {
            InitializeComponent();
        }

        public void KhoaDK()
        {
            txtCMND.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = txtEmail.Enabled = txtHoTen.Enabled = txtMaLop.Enabled = cbGT.Enabled = dtpNgaySinh.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

    }
}
