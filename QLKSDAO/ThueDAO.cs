using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using QLKSDTO;

namespace QLKSDAO
{
    public class ThueDAO
    {
        public static List<Thue> LayDSThue()
        {
            List<Thue> dsThue = new List<Thue>();

            try
            {
                DataTable dtThue = DataProvider.TruyVan_LayDuLieu("SELECT * FROM Thue");

                foreach (DataRow row in dtThue.Rows)
                {
                    Thue thue = new Thue
                    {
                        MaPhong = row["MaPhong"].ToString(),
                        CMND = row["CMND"].ToString(),
                        NgayDat = Convert.ToDateTime(row["NgayDat"]),
                        NgayTra = Convert.ToDateTime(row["NgayTra"])
                    };
                    dsThue.Add(thue);
                }
            }
            catch
            {
                dsThue = new List<Thue>();
            }

            return dsThue;
        }
        public static List<Thue> LayThueKhachChuaThanhToan(string CMND)
        {
            List<Thue> dsThue = new List<Thue>();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@CMND", CMND);

            DataTable dtThue = DataProvider.SelectData(
                "SELECT t.*\r\nFROM Thue t\r\nLEFT JOIN HoaDon h ON t.MaPhong = h.MaPhong AND t.NgayDat = h.NgayDat\r\nWHERE h.MaHD IS NULL and t.CMND=@CMND;",
                CommandType.Text,
                parameters
            );

            foreach (DataRow row in dtThue.Rows)
            {
                Thue thue = new Thue
                {
                    MaPhong = row["MaPhong"].ToString(),
                    CMND = row["CMND"].ToString(),
                    NgayDat = Convert.ToDateTime(row["NgayDat"]),
                    NgayTra = Convert.ToDateTime(row["NgayTra"])
                };
                dsThue.Add(thue);
            }

            return dsThue;
        }

        public static void ThemThue(Thue thue)
        {
            string sql = @"INSERT INTO Thue(MaPhong, CMND, NgayDat, NgayTra) 
                          VALUES(@MaPhong, @CMND, @NgayDat, @NgayTra)";

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaPhong", thue.MaPhong);
            parameters[1] = new SqlParameter("@CMND", thue.CMND);
            parameters[2] = new SqlParameter("@NgayDat", thue.NgayDat);
            parameters[3] = new SqlParameter("@NgayTra", thue.NgayTra);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static void XoaThue(string maPhong, string cmnd)
        {
            string sql = "DELETE FROM Thue WHERE MaPhong = @MaPhong AND CMND = @CMND";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaPhong", maPhong);
            parameters[1] = new SqlParameter("@CMND", cmnd);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static void CapNhatThue(Thue thue)
        {
            string sql = @"UPDATE Thue 
                          SET NgayDat = @NgayDat, 
                              NgayTra = @NgayTra 
                          WHERE MaPhong = @MaPhong AND CMND = @CMND";

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaPhong", thue.MaPhong);
            parameters[1] = new SqlParameter("@CMND", thue.CMND);
            parameters[2] = new SqlParameter("@NgayDat", thue.NgayDat);
            parameters[3] = new SqlParameter("@NgayTra", thue.NgayTra);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        
    }
}
