﻿using System;
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
    public class BUS_PhieuMuon
    {
        dbConnection dbcon = new dbConnection();

        public DataTable ThemPhieuMuon(string _MaBD)
        {
            DataTable dt = new DataTable();
            string str = string.Format("ThemPhieuMuon");
            SqlParameter[] arrpara = new SqlParameter[1];
            arrpara[0] = new SqlParameter("@MaBD", SqlDbType.NVarChar, 10);
            arrpara[0].Value = _MaBD;

            SqlConnection con = new SqlConnection(AppConfig.connectionString());
            con.Open();
            
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddRange(arrpara);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            //dt = dbcon.executeSelectProcedureQuery(str, arrpara);
            return dt;
        }
        public void UpdateTTPM_TraSach(string _MaPM)
        {
            string str = string.Format("Update PhieuMuon set TrangThai = -1 where MaPM = '" + _MaPM + "'");
            SqlConnection con = new SqlConnection(AppConfig.connectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateTrangThaiPM_TraSach(string _MaSach)
        {
            DataTable dt = new DataTable();
            string str = string.Format("LayMaPM_MaSach");
            SqlConnection con = new SqlConnection(AppConfig.connectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@MaSach", _MaSach);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UpdateTTPM_TraSach(dt.Rows[i]["MaPM"].ToString());
            }
        }
    }
}
