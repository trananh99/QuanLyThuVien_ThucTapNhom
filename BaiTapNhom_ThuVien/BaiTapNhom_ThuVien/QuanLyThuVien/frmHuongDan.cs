using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyThuVien
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }
        private void GetFileAll(string tenfile)
        {
            StreamReader doc = File.OpenText(tenfile);
            string s = doc.ReadToEnd();
            txtGioiThieu.Text = s;
        }

        private void trViewGioiThieu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "gtPhanMem")
            {
                GetFileAll(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\GioiThieuChung.txt");
                Image img = Image.FromFile(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\lb.jpg");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDangNhap")
            {
                GetFileAll(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\PhanDangNhap.txt");
                Image img = Image.FromFile(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\DangNhap.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtManHinhChinh")
            {
                GetFileAll(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\PhanMain.txt");
                Image img = Image.FromFile(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\main.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtDocGia")
            {
                GetFileAll(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\PhanDocGia.txt");
                Image img = Image.FromFile(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\DocGia.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtMuonSach")
            {
                GetFileAll(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\PhanMuonSach.txt");
                Image img = Image.FromFile(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\MuonSach.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtTaiLieu")
            {
                GetFileAll(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\PhanTaiLieu.txt");
                Image img = Image.FromFile(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\TaiLieu.png");
                pictureBox1.BackgroundImage = img;
            }
            else if (e.Node.Name == "gtTraSach")
            {
                GetFileAll(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\PhanTraSach.txt");
                Image img = Image.FromFile(@"D:\Github\BaiTapNhom_ThuVien\QuanLyThuVien\GioiThieu\TraSach.png");
                pictureBox1.BackgroundImage = img;
            }
        }

        private void frmHuongDan_Load(object sender, EventArgs e)
        {

        }
    }
}
