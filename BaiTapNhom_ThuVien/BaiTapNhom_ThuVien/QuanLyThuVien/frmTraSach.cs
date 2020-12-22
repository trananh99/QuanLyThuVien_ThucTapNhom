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
        public void KhoiTaoTxt()
        {
            txtMaBD.Text = txtHoTen.Text = txtCMND.Text = txtDiaChi.Text = txtEmail.Text = txtGT.Text = txtMaLop.Text = txtNS.Text = txtSoDT.Text = "";
        }
       

       
        private void btnTra_Click(object sender, EventArgs e)
        {
            //pm.UpdateTrangThaiPM_TraSach(txtMaTL.Text);
            int b = ctpm.TraTaiLieu(txtMaBD.Text, txtMaTL.Text);
            if ( b>0)
            {
                tl.UodateSoLuongTLID_TraSach(txtMaTL.Text);
                dgvSachDaMuon.DataSource = bd.ThongKeSachDaMuonTheoID(txtMaBD.Text);
                if (MessageBox.Show("Trả Sách Hoàn Tất. Bạn có muốn tiếp tục?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
                    this.Close();
                txtMaTL.Text = txtNhanDe.Text = txtNXB.Text = txtTheLoai.Text = txttacGia.Text = "";
            }
            else
                MessageBox.Show("Trả Sách Thất Bại.");

        }

     

        private void dgvSachDaMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvSachDaMuon.Rows[e.RowIndex];
            string maTL = row.Cells[0].Value.ToString();
            DataTable dt = tl.TimKiemTaiLieu(maTL);
            if (dt.Rows.Count > 0)
            {
                txtMaTL.Text = maTL;
                txtNhanDe.Text = dt.Rows[0]["NhanDe"].ToString();
                txttacGia.Text = dt.Rows[0]["TacGia"].ToString();
                txtNXB.Text = dt.Rows[0]["TenNXB"].ToString();
                txtTheLoai.Text = dt.Rows[0]["TenTheLoai"].ToString();
            }
            else
            {
                MessageBox.Show("Không có tài liệu nay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
