using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using KetNoiDB;
using System.Data.SqlClient;

namespace BangThuVien
{
    public class BUS_ChiTietPM
    {
        dbConnection dbcon = new dbConnection();
        public int ThemCTPM(string MaPM, string MaSach, DateTime NgayMuon, DateTime HanTra, string Ghichu)
        {
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand("ThemChiTietPhieuMuon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maPM", MaPM);
            cmd.Parameters.AddWithValue("@maTL", MaSach);
            cmd.Parameters.AddWithValue("@ngayMuon", NgayMuon);
            cmd.Parameters.AddWithValue("@ngayTra", HanTra);
            cmd.Parameters.AddWithValue("@hanTra", HanTra);
            cmd.Parameters.AddWithValue("@ghiChu", Ghichu);
            int b =  cmd.ExecuteNonQuery();
            conn.Close();
            return b;

        }

      
    }
}
