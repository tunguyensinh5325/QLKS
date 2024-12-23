using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;

namespace QLKSDAO
{
    public class PhongDAO
    {
        public static List<Phong> LayDSPhong()
        {
            List<Phong> dsPhong = new List<Phong>();

            try
            {
                DataTable dtPhong = DataProvider.TruyVan_LayDuLieu("SELECT * FROM Phong");

                foreach (DataRow row in dtPhong.Rows)
                {
                    Phong p = new Phong
                    {
                        MaPhong = row["MaPhong"].ToString(),
                        LoaiPhong = row["LoaiPhong"].ToString(),
                        TinhTrang = row["TinhTrang"].ToString(),
                        Gia = Convert.ToInt32(row["Gia"]),
                        GhiChu = row["GhiChu"].ToString()
                    };
                    dsPhong.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách phòng: " + ex.Message);
            }

            return dsPhong;
        }
        
        public static void CapNhatTinhTrangPhong(string maPhong, string tinhTrang)
        {
            string sql = @"UPDATE Phong SET TinhTrang = @TinhTrang WHERE MaPhong = @MaPhong";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaPhong", maPhong);
            parameters[1] = new SqlParameter("@TinhTrang", tinhTrang);
            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }
        public static void ThemPhong(Phong p)
        {
            string sql = @"INSERT INTO Phong(MaPhong, LoaiPhong, TinhTrang, Gia, GhiChu) 
                          VALUES(@MaPhong, @LoaiPhong, @TinhTrang, @Gia, @GhiChu)";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MaPhong", p.MaPhong);
            parameters[1] = new SqlParameter("@LoaiPhong", p.LoaiPhong);
            parameters[2] = new SqlParameter("@TinhTrang", p.TinhTrang);
            parameters[3] = new SqlParameter("@Gia", p.Gia);
            parameters[4] = new SqlParameter("@GhiChu", p.GhiChu);

            try
            {
                DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm phòng: " + ex.Message);
            }
        }

        public static void XoaPhong(string maPhong)
        {
            string sql = "DELETE FROM Phong WHERE MaPhong = @MaPhong";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhong", maPhong);

            try
            {
                DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa phòng: " + ex.Message);
            }
        }

        public static void CapNhatPhong(Phong p)
        {
            string sql = @"UPDATE Phong 
                          SET LoaiPhong = @LoaiPhong, 
                              TinhTrang = @TinhTrang, 
                              Gia = @Gia, 
                              GhiChu = @GhiChu 
                          WHERE MaPhong = @MaPhong";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MaPhong", p.MaPhong);
            parameters[1] = new SqlParameter("@LoaiPhong", p.LoaiPhong);
            parameters[2] = new SqlParameter("@TinhTrang", p.TinhTrang);
            parameters[3] = new SqlParameter("@Gia", p.Gia);
            parameters[4] = new SqlParameter("@GhiChu", p.GhiChu);

            try
            {
                DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật phòng: " + ex.Message);
            }
        }

        public static Phong LayPhongTheoMa(string maPhong)
        {
            Phong p = null;

            string sql = "SELECT * FROM Phong WHERE MaPhong = @MaPhong";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhong", maPhong);

            try
            {
                DataTable dtPhong = DataProvider.SelectData(sql, CommandType.Text, parameters);

                if (dtPhong.Rows.Count > 0)
                {
                    DataRow row = dtPhong.Rows[0];
                    p = new Phong
                    {
                        MaPhong = row["MaPhong"].ToString(),
                        LoaiPhong = row["LoaiPhong"].ToString(),
                        TinhTrang = row["TinhTrang"].ToString(),
                        Gia = Convert.ToInt32(row["Gia"]),
                        GhiChu = row["GhiChu"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy thông tin phòng: " + ex.Message);
            }

            return p;
        }
    }
}
