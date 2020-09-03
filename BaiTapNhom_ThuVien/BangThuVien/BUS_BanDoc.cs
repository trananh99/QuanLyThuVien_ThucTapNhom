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
    public class BUS_BanDoc
    {
        KetNoi cn = new KetNoi();
        dbConnection dbcon = new dbConnection();

        public DataTable TimKiemBDID(string _MaBD)
        {
            DataTable dt = new DataTable();
            string str = string.Format("Select * from BanDoc where (MaBD = @MaBD)");
            SqlParameter[] arrPara = new SqlParameter[1];
            arrPara[0] = new SqlParameter("@MaBD", SqlDbType.NVarChar, 10);
            arrPara[0].Value = _MaBD;

            dt = dbcon.executeSelectQuery(str, arrPara);
            return dt;
        }
        public DataTable HienThiBanDoc()
        {
            string sql = "SELECT * FROM BanDoc";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoi.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public DataTable TimKiemBD(string _MaBD)
        {
            SqlConnection conn = new SqlConnection(KetNoi.connect());
            conn.Open();
            SqlCommand cmd = new SqlCommand("LayBanDoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBD", _MaBD);
            SqlDataReader dap = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dap);
            conn.Close();
            return dt;
        }

        public void ThemBanDoc(string HoTen, string GioiTinh, DateTime NgaySinh, string CMND, string MaLop, string DiaChi, string Email, string DienThoai)
        {
            string sql = "ADDBanDoc";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@CMND", CMND);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaBanDoc(string MaBD, string HoTen, string GioiTinh, DateTime NgaySinh, string CMND, string MaLop, string DiaChi, string Email, string DienThoai)
        {
            string sql = "SuaBanDoc";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBD", MaBD);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@CMND", CMND);
            cmd.Parameters.AddWithValue("@MaLop", MaLop);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DienThoai", DienThoai);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaBanDoc(string MaBD)
        {
            string sql = "Xoa_BD";
            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBD", MaBD);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable ThongKeSachDaMuonTheoID(string _MaBD)
        {
            string str = string.Format("ThongKeSachDaMuon");
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(KetNoi.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBD", _MaBD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public void Export_BanDoc(DataTable dt, string sheetName, string title)
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
            Excel.Range head = oSheet.get_Range("A1", "I1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Size = "18";
            head.Font.Name = "Times New Roman";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            //tao tieu de cot
            Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã bạn đọc";
            cl1.ColumnWidth = 30.0;

            Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ và tên";
            cl2.ColumnWidth = 40.0;

            Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Giới tính";
            cl3.ColumnWidth = 20.0;

            Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày sinh";
            cl4.ColumnWidth = 30.0;

            Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "CMND";
            cl5.ColumnWidth = 30.0;

            Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Mã lớp";
            cl6.ColumnWidth = 30.0;

            Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Địa chỉ";
            cl7.ColumnWidth = 70.0;

            Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Email";
            cl8.ColumnWidth = 50.0;

            Excel.Range cl9 = oSheet.get_Range("K3", "I3");
            cl9.Value2 = "Điện thoại";
            cl9.ColumnWidth = 30.0;

            Excel.Range rowHead = oSheet.get_Range("A3", "I3");
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

        public void  ExportToExcel()
        {
            Export_BanDoc(HienThiBanDoc(), "danh sách bạn đọc", "DANH SÁCH BẠN ĐỌC MƯỢN SÁCH");
        }
    }
}
