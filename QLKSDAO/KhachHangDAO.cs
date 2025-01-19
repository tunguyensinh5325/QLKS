using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using QLKSDTO;

namespace QLKSDAO
{
    public class KhachHangDAO
    {
        public static List<KhachHang> LayDSKhachHang()
        {
            List<KhachHang> dsKhachHang = new List<KhachHang>();

            try
            {
                DataTable dtKhachHang = DataProvider.TruyVan_LayDuLieu("SELECT * FROM KhachHang");

                foreach (DataRow row in dtKhachHang.Rows)
                {
                    KhachHang kh = new KhachHang
                    {
                        CMND = row["CMND"].ToString(),
                        TenKH = row["TenKH"].ToString(),
                        LoaiKH = row["LoaiKH"].ToString(),
                        DiaChi = row["DiaChi"].ToString()
                    };
                    dsKhachHang.Add(kh);
                }
            }
            catch
            {
                dsKhachHang = new List<KhachHang>();
            }

            return dsKhachHang;
        }
        public static List<KhachHang> LayDSKhachHangDangThueCuaPhong(string maphong)
        {
            List<KhachHang> dskh=new List<KhachHang>();
            string sql = "SELECT kh.CMND, kh.TenKH, kh.LoaiKH, kh.DiaChi\r\n" +
                "FROM KhachHang kh\r\n" +
                "JOIN Thue t ON kh.CMND = t.CMND\r\n" +
                "WHERE t.MaPhong = @MaPhong AND NOT EXISTS (\r\n " +
                "SELECT 1\r\n" +
                "FROM HoaDon hd WHERE hd.MaPhong = t.MaPhong AND hd.NgayDat = t.NgayDat)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhong", maphong);
            DataTable dtKhachHang = DataProvider.SelectData(
                sql,
                CommandType.Text,
                parameters
            );
            foreach (DataRow row in dtKhachHang.Rows)
            {
                KhachHang kh = new KhachHang
                {
                    CMND = row["CMND"].ToString(),
                    TenKH = row["TenKH"].ToString(),
                    LoaiKH = row["LoaiKH"].ToString(),
                    DiaChi = row["DiaChi"].ToString()
                };
                dskh.Add(kh);
            }
            return dskh;
        }

        public static void ThemKhachHang(KhachHang kh)
        {
            string sql = @"INSERT INTO KhachHang(CMND, TenKH, LoaiKH, DiaChi) 
                          VALUES(@CMND, @TenKH, @LoaiKH, @DiaChi)";

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@CMND", kh.CMND);
            parameters[1] = new SqlParameter("@TenKH", kh.TenKH);
            parameters[2] = new SqlParameter("@LoaiKH", kh.LoaiKH);
            parameters[3] = new SqlParameter("@DiaChi", kh.DiaChi);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static void XoaKhachHang(string cmnd)
        {
            string sql = "DELETE FROM KhachHang WHERE CMND = @CMND";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@CMND", cmnd);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static void CapNhatKhachHang(KhachHang kh)
        {
            string sql = @"UPDATE KhachHang 
                          SET TenKH = @TenKH, 
                              LoaiKH = @LoaiKH, 
                              DiaChi = @DiaChi 
                          WHERE CMND = @CMND";

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@CMND", kh.CMND);
            parameters[1] = new SqlParameter("@TenKH", kh.TenKH);
            parameters[2] = new SqlParameter("@LoaiKH", kh.LoaiKH);
            parameters[3] = new SqlParameter("@DiaChi", kh.DiaChi);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static KhachHang LayKhachHangTheoCMND(string cmnd)
        {
            KhachHang kh = null;

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@CMND", cmnd);

            DataTable dtKhachHang = DataProvider.SelectData(
                "SELECT * FROM KhachHang WHERE CMND = @CMND",
                CommandType.Text,
                parameters
            );

            if (dtKhachHang.Rows.Count > 0)
            {
                DataRow row = dtKhachHang.Rows[0];
                kh = new KhachHang
                {
                    CMND = row["CMND"].ToString(),
                    TenKH = row["TenKH"].ToString(),
                    LoaiKH = row["LoaiKH"].ToString(),
                    DiaChi = row["DiaChi"].ToString()
                };
            }
            if (kh!=null) kh.CMND= kh.CMND.Replace(" ", "");
            return kh;
        }
    }
}
