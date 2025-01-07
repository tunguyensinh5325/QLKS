using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;

namespace QLKSDAO
{
    public class HoaDonDAO
    {
        public static List<HoaDon> LayDSHoaDon()
        {
            List<HoaDon> dshoaDon = new List<HoaDon>();
            try
            {
                DataTable dtHoaDon = DataProvider.TruyVan_LayDuLieu("SELECT * FROM HoaDon");

                foreach (DataRow row in dtHoaDon.Rows)
                {
                    HoaDon hd = new HoaDon
                    {
                        MaHD = row["MaHD"].ToString(),
                        ThanhTien = Convert.ToInt32(row["ThanhTien"]),
                        NgayDat = DateTime.Parse(row["NgayDat"].ToString()),
                        NgayTra = DateTime.Parse(row["NgayTra"].ToString()),
                        CMND = row["CMND"].ToString(),
                        MaPhong = row["MaPhong"].ToString()
                    };
                    dshoaDon.Add(hd);
                }
            }
            catch
            {
                dshoaDon = new List<HoaDon>();
            }

            return dshoaDon;
        }
        public static List<HoaDon> LayDSHoaDonTheoThangNam(string t, string n)
        {
            List<HoaDon> kq=new List<HoaDon>();
            string sql;
            SqlParameter[] parameters ;
            if (t == "")
            {
                sql = "select * from HoaDon where year(NgayDat)=@Nam";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Nam", n);
            }
            else
            {
                sql = "select * from HoaDon where month(NgayDat)=@Thang and year(NgayDat)=@Nam";
                parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@Thang",t);
                parameters[1] = new SqlParameter("@Nam",n);
            }
            DataTable dtHoaDon = DataProvider.SelectData(sql,CommandType.Text,parameters);
            foreach (DataRow row in dtHoaDon.Rows)
            {
                HoaDon hd = new HoaDon
                {

                    MaHD = row["MaHD"].ToString(),
                    ThanhTien = Convert.ToInt32(row["ThanhTien"]),
                    NgayDat = DateTime.Parse(row["NgayDat"].ToString()),
                    NgayTra = DateTime.Parse(row["NgayTra"].ToString()),
                    CMND = row["CMND"].ToString(),
                    MaPhong = row["MaPhong"].ToString(),
                };
                kq.Add(hd);
            }


            return kq;
        }
        public static void ThemHoaDon(HoaDon hoaDon)
        {
            string sql = @"INSERT INTO HoaDon (MaHD, ThanhTien, NgayDat, NgayTra, CMND, MaPhong) VALUES (@MaHD, @ThanhTien, @NgayDat, @NgayTra, @CMND, @MaPhong)";
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@MaHD", hoaDon.MaHD);
            parameters[1] = new SqlParameter("@ThanhTien", hoaDon.ThanhTien);
            parameters[2] = new SqlParameter("@NgayDat", hoaDon.NgayDat);
            parameters[3] = new SqlParameter("@NgayTra", hoaDon.NgayTra);
            parameters[4] = new SqlParameter("@CMND", hoaDon.CMND);
            parameters[5] = new SqlParameter("@MaPhong", hoaDon.MaPhong);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }
        public static void XoaHoaDon(string maHD)
        {
            string sql = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaHD", maHD);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }
        public static void CapNhatHoaDon(HoaDon hoaDon)
        {
            string sql = "UPDATE HoaDon SET ThanhTien = @ThanhTien, NgayDat = @NgayDat, NgayTra = @NgayTra, CMND = @CMND, MaPhong = @MaPhong WHERE MaHD = @MaHD";
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@MaHD", hoaDon.MaHD);
            parameters[1] = new SqlParameter("@ThanhTien", hoaDon.ThanhTien);
            parameters[2] = new SqlParameter("@NgayDat", hoaDon.NgayDat);
            parameters[3] = new SqlParameter("@NgayTra", hoaDon.NgayTra);
            parameters[4] = new SqlParameter("@CMND", hoaDon.CMND);
            parameters[5] = new SqlParameter("@MaPhong", hoaDon.MaPhong);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }
        
    }
}



