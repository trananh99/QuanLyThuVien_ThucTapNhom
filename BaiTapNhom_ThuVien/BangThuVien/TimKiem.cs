using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;
namespace BangThuVien
{
    public class TimKiem
    {
        KetNoi cn = new KetNoi();


        // Tìm kiếm Tài liệu theo mã
        public DataTable TKTL_MaTL(string MaTL)
        {
            string sql = "SELECT * FROM TaiLieu WHERE MaTL LIKE N'%' + @MaDauSach + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaDauSach", MaTL);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        // Tìm kiếm tài liệu theo nhan đề
        public DataTable TKTL_NhanDe(string NhanDe)
        {
            string sql = "SELECT * FROM TaiLieu WHERE NhanDe LIKE N'%' + @NhanDe + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@NhanDe", NhanDe);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm tài liệu theo tác giả
        public DataTable TKTL_TacGia(string TacGia)
        {
            string sql = "SELECT * FROM TaiLieu WHERE TacGia LIKE N'%' + @TacGia + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm độc giả theo mã đọc giả
        public DataTable TKDG_MaDG(string MaBD)
        {
            string sql = "SELECT * FROM BanDoc WHERE MaBD LIKE N'%' + @MaBD + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaBD", MaBD);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // TK độc giả theo họ tên
        public DataTable TKDG_TenDG(string HoTen)
        {
            string sql = "SELECT * FROM BanDoc WHERE HoTen LIKE N'%' + @HoTen + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        //TK độc giả theo CMND
        public DataTable TKDG_CMND(string CMND)
        {
            string sql = "SELECT * FROM BanDoc WHERE CMND LIKE N'%' + @CMND + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@CMND", CMND);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        // TK độc giả theo mã lớp
        public DataTable TKDG_MaLop(string MaLop)
        {
            string sql = "SELECT * FROM BanDoc WHERE MaLop LIKE N'%' + @MaLop + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm Ban doc theo ten
        public DataTable TKBD_HoTen(string HoTen)
        {
            string sql = "SELECT * FROM BanDoc WHERE HoTen LIKE N'%' + @HoTen + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        //tìm kiếm tài liệu
        public DataTable TimKiemTaiLieu( string _MaTL, string _NhanDe, string _TacGia, string _MaTheLoai, string _MaNXB, string _NgonNgu)
        {
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand("TimKiemTaiLieu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maTL", _MaTL);
            cmd.Parameters.AddWithValue("@NhanDe", _NhanDe);
            cmd.Parameters.AddWithValue("@TacGia", _TacGia);
            cmd.Parameters.AddWithValue("@maTheLoai", _MaTheLoai);
            cmd.Parameters.AddWithValue("@maNXB", _MaNXB);
            cmd.Parameters.AddWithValue("@NgonNgu", _NgonNgu);
            SqlDataAdapter da = new SqlDataAdapter();
            var table = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(table);
            conn.Close();
            return table;
           
        }

        //tim kiem doc gia
        public DataTable TimKiemDocGia( string _MaBD, string _HoTen, string _GioiTinh, DateTime _NgaySinh, string _DiaChi, string _MaLop)
        {
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            DataTable table = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("TimKiemDocGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBD", _MaBD);
            cmd.Parameters.AddWithValue("@HoTen", _HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", _GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", _NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", _DiaChi);
            cmd.Parameters.AddWithValue("@MaLop", _MaLop);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(table);
            conn.Close();
            return table;
        }

    }
}
