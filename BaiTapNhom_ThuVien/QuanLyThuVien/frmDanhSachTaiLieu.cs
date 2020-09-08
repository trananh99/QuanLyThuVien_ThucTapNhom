using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KetNoiDB;
using BangThuVien;


namespace QuanLyThuVien
{
    public partial class frmDanhSachTaiLieu : Form
    {
        BUS_TaiLieu _tailieu = new BUS_TaiLieu();
        int chon = 0;
        TimKiem tk = new TimKiem();
        public frmDanhSachTaiLieu()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            dgvKhachHang.DataSource = kh.HienThiKhachHang();
            for (int i = 0; i < dgvKhachHang.RowCount; i++)
                dgvKhachHang.Rows[i].Cells[0].Value = (i + 1).ToString();

            dgvSanPham.DataSource = sp.HienThiSP_LH();
        }
        public void KhoiTaotxtsKH()
        {
            txttenKH.Text = txtDC.Text = txtGhichu.Text = txtSoDT.Text = txtMaKH.Text = "";
            cmbLoaiKH.Text = "";
            cmbGioiTinh.Text = "";
            MaKHNew = ""; MaHDB = "";
            txtTongTienHDB.Text = txtMaKHHDB.Text = txtNgayBanHDB.Text = "";
            dong = DongCTHD = 0;
        }
        void KhoaDieuKhien()
        {
            txtTG.Enabled = txtNhanDe.Enabled = txtSoLuong.Enabled = txtNgonNgu.Enabled = cbMaTheLoai.Enabled = cbMaNXB.Enabled = txtDoMat.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }

        void MoDieuKhien()
        {
            txtTG.Enabled = txtNhanDe.Enabled = txtSoLuong.Enabled = txtNgonNgu.Enabled = cbMaTheLoai.Enabled = cbMaNXB.Enabled = txtDoMat.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        void SetNull()
        {
            txtDoMat.Text = cbMaNXB.Text = txtMaTL.Text = cbMaTheLoai.Text = txtNgonNgu.Text = txtNhanDe.Text = txtSoLuong.Text = txtTG.Text = "";
            txtMa.Text = txtND.Text = txtTacGia.Text = txtNN.Text = cbxTL.Text = cbxNXB.Text= "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            chon = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            chon = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa Tài liệu này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                _tailieu.XoaTaiLieu(txtMaTL.Text);
                MessageBox.Show("Xóa thành công!");
                frmDanhSachTaiLieu_Load(sender, e);
                SetNull();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtNhanDe.Text == "" || txtTG.Text == "" || txtSoLuong.Text == "" || cbMaTheLoai.Text == "" || cbMaNXB.Text == "" || txtDoMat.Text == "" || txtNgonNgu.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm tài liệu này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    _tailieu.ThemTaiLieu(txtTG.Text, txtNhanDe.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDoMat.Text), txtNgonNgu.Text, cbMaTheLoai.Text, cbMaNXB.Text);
                    MessageBox.Show("Thêm thành công!");
                    SetNull();
                    frmDanhSachTaiLieu_Load(sender, e);
                }
            }
            else if (chon == 2)
            {
                if (txtNhanDe.Text == "" || txtTG.Text == "" || txtSoLuong.Text == "" || cbMaTheLoai.Text == "" || cbMaNXB.Text == "" || txtDoMat.Text == "" || txtNgonNgu.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn tài liệu này không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    _tailieu.SuaTaiLieu(txtMaTL.Text, txtTG.Text, txtNhanDe.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDoMat.Text), txtNgonNgu.Text, cbMaTheLoai.Text, cbMaNXB.Text);
                    MessageBox.Show("Sửa thành công!");
                    SetNull();
                    frmDanhSachTaiLieu_Load(sender, e);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            chon = 0;
            SetNull();
            frmDanhSachTaiLieu_Load(sender, e);
        }

        private void frmDanhSachTaiLieu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = _tailieu.HienThiTaiLieu();
            dgvTaiLieu.DataSource = dt;
            KhoaDieuKhien();
        }

        private void dgvTaiLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaTL.Text = dgvTaiLieu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTG.Text = dgvTaiLieu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNhanDe.Text = dgvTaiLieu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvTaiLieu.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDoMat.Text = dgvTaiLieu.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNgonNgu.Text = dgvTaiLieu.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbMaTheLoai.Text = dgvTaiLieu.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbMaNXB.Text = dgvTaiLieu.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch { }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            dgvTaiLieu.DataSource = tk.TimKiemTaiLieu(txtMa.Text, txtND.Text, txtTacGia.Text, cbxTL.Text, cbxNXB.Text, txtNN.Text);
            if (dgvTaiLieu.Rows.Count<=0)
            {
                MessageBox.Show("Không tìm thấy tài liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtND_TextChanged(object sender, EventArgs e)
        {
            dgvTaiLieu.DataSource = tk.TimKiemTaiLieu(txtMa.Text, txtND.Text, txtTacGia.Text, cbxTL.Text, cbxNXB.Text, txtNN.Text);
            if (dgvTaiLieu.Rows.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy tài liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {
            dgvTaiLieu.DataSource = tk.TimKiemTaiLieu(txtMa.Text, txtND.Text, txtTacGia.Text, cbxTL.Text, cbxNXB.Text, txtNN.Text);
            if (dgvTaiLieu.Rows.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy tài liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNN_TextChanged(object sender, EventArgs e)
        {
            dgvTaiLieu.DataSource = tk.TimKiemTaiLieu(txtMa.Text, txtND.Text, txtTacGia.Text, cbxTL.Text, cbxNXB.Text, txtNN.Text);
            if (dgvTaiLieu.Rows.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy tài liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTaiLieu.DataSource = tk.TimKiemTaiLieu(txtMa.Text, txtND.Text, txtTacGia.Text, cbxTL.Text, cbxNXB.Text, txtNN.Text);
            if (dgvTaiLieu.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tài liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbxNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTaiLieu.DataSource = tk.TimKiemTaiLieu(txtMa.Text, txtND.Text, txtTacGia.Text, cbxTL.Text, cbxNXB.Text, txtNN.Text);
            if (dgvTaiLieu.Rows.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy tài liệu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            _tailieu.ExportToExcel();
        }
    }
}
