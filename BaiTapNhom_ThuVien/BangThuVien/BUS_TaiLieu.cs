using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;
using Excel = Microsoft.Office.Interop.Excel;
namespace BangThuVien
{
    public class BUS_TaiLieu
    {
        KetNoi cn = new KetNoi();
        dbConnection dbcon = new dbConnection();
        SqlConnection conn = new SqlConnection(KetNoi.connect());
        private string matl;

        public string Matl
        {
            get { return matl; }
            set { matl = value; }
        }
        private string tacgia;
        private string nhande;
        private int soluong;
        private int domat;
        private string ngonngu;
        private string maTheLoai;
        private string maNXB;

        public string MaNXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }

        public string MaTheLoai
        {
            get { return maTheLoai; }
            set { maTheLoai = value; }
        }

        public string Ngonngu
        {
            get { return ngonngu; }
            set { ngonngu = value; }
        }

        public int Domat
        {
            get { return domat; }
            set { domat = value; }
        }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public string Nhande
        {
            get { return nhande; }
            set { nhande = value; }
        }
        public string Tacgia
        {
            get { return tacgia; }
            set { tacgia = value; }
        }
      

        public DataTable HienThiTaiLieu()
        {
            string sql = "SELECT * FROM TaiLieu";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void ThemTaiLieu(string TacGia, string NhanDe, int SoLuong,int DoMat, string NgonNgu, string MaTheLoai, string MaNXB)
        {
            string sql = "ADDTaiLieu";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@NhanDe", NhanDe);
            cmd.Parameters.AddWithValue("@SoLuong",SoLuong);
            cmd.Parameters.AddWithValue("@DoMat", DoMat);
            cmd.Parameters.AddWithValue("@NgonNgu", NgonNgu);
            cmd.Parameters.AddWithValue("@MaTheLoai", MaTheLoai);
            cmd.Parameters.AddWithValue("@MaNXB", MaNXB);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

       

        public void XoaTaiLieu(string MaTL)
        {
            string sql = string.Format("Delete from DauSach where MaDauSach = '" + MaTL + "'");
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

       
    }
}
