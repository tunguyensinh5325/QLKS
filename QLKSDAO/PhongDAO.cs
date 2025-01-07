using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata.Ecma335;

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

        public static List<Phong> LayDSPhongTrong()
        {
            string query = "SELECT * FROM Phong where TinhTrang=N'Trống'";
            List<Phong> dsPhong = new List<Phong>();
            DataTable dtPhong = DataProvider.SelectData(query,CommandType.Text,null);
            foreach (DataRow row in dtPhong.Rows)
            {
                Phong phong = new Phong
                {

                    MaPhong = row["MaPhong"].ToString(),
                    LoaiPhong = row["LoaiPhong"].ToString(),
                    TinhTrang = row["TinhTrang"].ToString(),
                    Gia = Convert.ToInt32(row["Gia"]),
                    GhiChu = row["GhiChu"].ToString()
                };
                dsPhong.Add(phong);
            }
            return dsPhong;
        }
        public static List<Phong> TimPhongTheoLoai(string loaiPhong)
        {
            string query = @"SELECT * FROM Phong where LoaiPhong=@LP";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@LP", loaiPhong);
            List <Phong> dsPhong = new List<Phong>();
            DataTable dtPhong = DataProvider.SelectData(query, CommandType.Text, parameters);
            foreach (DataRow row in dtPhong.Rows)
            {
                Phong phong = new Phong
                {

                    MaPhong = row["MaPhong"].ToString(),
                    LoaiPhong = row["LoaiPhong"].ToString(),
                    TinhTrang = row["TinhTrang"].ToString(),
                    Gia = Convert.ToInt32(row["Gia"]),
                    GhiChu = row["GhiChu"].ToString()
                };
                dsPhong.Add(phong);
            }
            return dsPhong;
        }
        public static List<string> LayDSLoaiPhong()
        {
            List<Phong> dsp=LayDSPhong();
            List<string> lp=new List<string>();
            foreach(Phong p in dsp)
            {
                if (!lp.Contains(p.LoaiPhong))
                {
                    lp.Add(p.LoaiPhong);
                }
            }
            return lp;
        }
        public static List<int> LayDSmd(string t, string n)
        {
            List<HoaDon> dshd = HoaDonDAO.LayDSHoaDonTheoThangNam(t, n);
            List<Phong> dsp = LayDSPhong();
            List<int> md = Enumerable.Repeat(0, dsp.Count).ToList();

            foreach (HoaDon hd in dshd)
            {
                int index = dsp.FindIndex(p => p.MaPhong == hd.MaPhong);
                md[index] += (hd.NgayTra - hd.NgayDat).Days;
            }

            return md;

        }
        public static List<int> LayDSdt(string t, string n)
        {
            List<HoaDon> dshd = HoaDonDAO.LayDSHoaDonTheoThangNam(t, n);
            List<string> dslp = LayDSLoaiPhong();
            List<int> dt = Enumerable.Repeat(0, dslp.Count).ToList();
            foreach (HoaDon hd in dshd)
            {
                Phong p = LayThongTinPhong(hd.MaPhong);
                int index = dslp.IndexOf(p.LoaiPhong);
                dt[index] += hd.ThanhTien;
            }
            return dt;
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

        public static Phong LayThongTinPhong(string maPhong)
        {
            Phong phong = null;
            string query = "SELECT * FROM Phong WHERE MaPhong = @MaPhong";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPhong", maPhong);

            DataTable dt = DataProvider.SelectData(query, CommandType.Text, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                phong = new Phong
                {
                    MaPhong = row["MaPhong"].ToString(),
                    LoaiPhong = row["LoaiPhong"].ToString(),
                    TinhTrang = row["TinhTrang"].ToString(),
                    Gia = Convert.ToInt32(row["Gia"]),
                    GhiChu = row["GhiChu"].ToString()
                };
            }
            return phong;
        }

    }
}
