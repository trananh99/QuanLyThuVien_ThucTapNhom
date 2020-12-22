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
        public DataTable TimKiemSachID(string _MaSach)
        {
            conn.Open();
            var dt = new DataTable();
            var cmd = new SqlCommand("TimTaiLieuTheoID",conn );
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaTL", _MaSach));
            SqlDataReader daReader = cmd.ExecuteReader();
            dt.Load(daReader);
            conn.Close();
            return dt;
        }
        public DataTable TimKiemMaSachHopLe(string _MaTL)
        {
            DataTable dt = new DataTable();
            string str = string.Format("Select MaSach from Sach where (MaTL = @MaTL)");
            SqlParameter[] arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@MaSach", SqlDbType.NVarChar, 10);
            arrPara[0].Value = _MaTL;

            dt = dbcon.executeSelectQuery(str, arrPara);
            return dt;
        }
        public DataTable TimKiemMaSachTheoMaDauSach(string _MaDauSach)
        {
            DataTable dt = new DataTable();
            string str = string.Format(@"SELECT     dbo.Sach.MaSach
                                            FROM         dbo.Sach INNER JOIN
                                                                  dbo.DauSach ON dbo.Sach.MaDauSach = dbo.DauSach.MaDauSach
                                            WHERE     (dbo.DauSach.MaDauSach = @MaDauSach)");
            SqlParameter[] arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@MaDauSach", SqlDbType.NVarChar, 10);
            arrPara[0].Value = _MaDauSach;

            dt = dbcon.executeSelectQuery(str, arrPara);
            return dt;
        }
        public DataTable TimKiemSoLuongDauSachID(string _MaSach)
        {
            DataTable dt = new DataTable();
            string str = string.Format(@"SELECT     dbo.DauSach.SoLuong
                                        FROM         dbo.Sach INNER JOIN
                                                              dbo.DauSach ON dbo.Sach.MaDauSach = dbo.DauSach.MaDauSach
                                        WHERE     (dbo.Sach.MaSach = @MaSach)");
            SqlParameter[] arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@MaSach", SqlDbType.NVarChar, 10);
            arrPara[0].Value = _MaSach;

            dt = dbcon.executeSelectQuery(str, arrPara);
            return dt;
        }
        public bool UodateSoLuongDauSachID(string _MaDauSach)
        {
            bool b = true;
            string str = string.Format("UpdateSLTL");
            SqlConnection con = new SqlConnection(AppConfig.connectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@MaTL", _MaDauSach);
            cmd.Parameters.AddWithValue("@SoLuong", -1);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.ExecuteNonQuery() > 0)
                b = true;
            con.Close();
            return b;
        }
        public bool UodateSoLuongTLID_TraSach(string _MaTL)
        {
            bool b = true;
            string str = string.Format("UpdateSLTL");
            SqlConnection con = new SqlConnection(AppConfig.connectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@MaTL", _MaTL);
            cmd.Parameters.AddWithValue("@SoLuong", 1);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.ExecuteNonQuery() > 0)
                b = true;
            con.Close();
            return b;
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

        public void SuaTaiLieu(string MaTL, string TacGia, string NhanDe, int SoLuong, int DoMat, string NgonNgu, string MaTheLoai, string MaNXB)
        {
            string sql = "SuaTaiLieu";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTL", MaTL);
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@NhanDe", NhanDe);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
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

        public DataTable TimKiemTaiLieu( string _maTL)
        {
            var dt = new DataTable();
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            var cmd = new SqlCommand("LayTaiLieu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maTL", _maTL);
            cmd.ExecuteNonQuery();
            var dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }
        public void Export_TaiLieu(DataTable dt, string sheetName, string title)
        {

            //tao cac doi tuong Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //tao moi mot Excel WorkBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            //tao phan dau 
            Excel.Range head = oSheet.get_Range("A1", "H1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Size = "18";
            head.Font.Name = "Times New Roman";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            //tao tieu de cot
            Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã tài liệu";
            cl1.ColumnWidth = 30.0;

            Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "tác giả";
            cl2.ColumnWidth = 40.0;

            Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Nhan đề";
            cl3.ColumnWidth = 60.0;

            Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "số lượng";
            cl4.ColumnWidth = 20.0;

            Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Độ mật";
            cl5.ColumnWidth = 10.0;

            Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Ngôn ngữ";
            cl6.ColumnWidth = 40.0;

            Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Mã thể loại";
            cl7.ColumnWidth = 40.0;

            Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Mã NXB";
            cl8.ColumnWidth = 40.0;

            Excel.Range rowHead = oSheet.get_Range("A3", "H3");
            rowHead.Font.Bold = true;

            //ke vien

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //thiet lap mau nen
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            //tao mang doi tuong de luu tru toan bo du lieu trong datatable

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //chuyen du lieu tu datatable vao mang doi tuong

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }

            //thiet lap vung dien du lieu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;

            //o bat dau dien du lieu
            Excel.Range c1 = (Excel.Range)oSheet.Cells[rowStart, columnStart];
            //o ket thuc vung du lieu
            Excel.Range c2 = (Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            //lay ve vung dien du lieu
            //lay ve vung dien du lieu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);


            //dien du lieu vao vung da thiet lap
            range.Value2 = arr;
            //ke vien 
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //can giu cot thu tu
            Excel.Range c3 = (Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        }

        public void ExportToExcel()
        {
            Export_TaiLieu(HienThiTaiLieu(), "danh sách tài liệu", "DANH SÁCH TÀI LIỆU");
        }
    }
}
