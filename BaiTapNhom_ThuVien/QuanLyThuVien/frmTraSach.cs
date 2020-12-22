using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using KetNoiDB;
using BangThuVien;

namespace QuanLyThuVien
{
    public partial class frmTraSach : Form
    {

        BUS_BanDoc bd = new BUS_BanDoc();
        BUS_TaiLieu tl = new BUS_TaiLieu();
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        BUS_PhieuMuon pm = new BUS_PhieuMuon();
        BUS_ChiTietPM ctpm = new BUS_ChiTietPM();
        List<BUS_TaiLieu> listTLMuon = new List<BUS_TaiLieu>();

        public frmTraSach()
        {
            InitializeComponent();
        }

        private void txtMaBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KhoiTaoTxt();
            if (e.KeyChar == (char)Keys.Enter)
            {
                var dt = bd.TimKiemBD(txtMaBD.Text);
                if (dt.Rows.Count > 0)
                {
                    txtMaBD.Text = dt.Rows[0]["MaBD"].ToString();
                    txtHoTen.Text = dt.Rows[0]["Hoten"].ToString();
                    txtGT.Text = dt.Rows[0]["GioiTinh"].ToString();
                    txtNS.Text = dt.Rows[0]["NgaySinh"].ToString();
                    txtCMND.Text = dt.Rows[0]["CMND"].ToString();
                    txtMaLop.Text = dt.Rows[0]["MaLop"].ToString();
                    txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtSoDT.Text = dt.Rows[0]["DienThoai"].ToString();
                    dgvSachDaMuon.DataSource = bd.ThongKeSachDaMuonTheoID(txtMaBD.Text);
                }
                else
                {
                    MessageBox.Show("Không tìmm thấy bạn đọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
           
        }
  