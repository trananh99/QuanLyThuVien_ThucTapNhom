using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mượnTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonSach frm = new frmMuonSach();
            frm.Show();
        }

        private void trảTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraSach frm = new frmTraSach();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Question", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void tàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachTaiLieu frm = new frmDanhSachTaiLieu();
            frm.Show();
        }

        private void bạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachDocGia frm = new frmDanhSachDocGia();
            frm.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.Show();
        }

        private void saoLưuDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
