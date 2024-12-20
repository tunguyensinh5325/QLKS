using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;

namespace QLKSDAO
{
    public class BaoCaoDAO
    {
        public static List<BaoCao> LayDSBaoCao()
        {
            List<BaoCao> dsBaoCao = new List<BaoCao>();

            try
            {
                DataTable dtBaoCao = DataProvider.TruyVan_LayDuLieu("SELECT * FROM BaoCao");

                foreach (DataRow row in dtBaoCao.Rows)
                {
                    BaoCao bc = new BaoCao
                    {
                        MaHD = row["MaHD"].ToString(),
                        MaPhong = row["MaPhong"].ToString(),
                        LoaiPhong = row["LoaiPhong"].ToString(),
                        SoNgay = Convert.ToInt16(row["SoNgay"]),
                        DoanhThu = Convert.ToInt32(row["DoanhThu"])
                    };
                    dsBaoCao.Add(bc);
                }
            }
            catch
            {
                dsBaoCao = new List<BaoCao>();
            }

            return dsBaoCao;
        }

        public static void ThemBaoCao(BaoCao bc)
        {
            string sql = @"INSERT INTO BaoCao(MaHD, MaPhong, LoaiPhong, SoNgay, DoanhThu) 
                          VALUES(@MaHD, @MaPhong, @LoaiPhong, @SoNgay, @DoanhThu)";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MaHD", bc.MaHD);
            parameters[1] = new SqlParameter("@MaPhong", bc.MaPhong);
            parameters[2] = new SqlParameter("@LoaiPhong", bc.LoaiPhong);
            parameters[3] = new SqlParameter("@SoNgay", bc.SoNgay);
            parameters[4] = new SqlParameter("@DoanhThu", bc.DoanhThu);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static void XoaBaoCao(string maHD, string maPhong)
        {
            string sql = "DELETE FROM BaoCao WHERE MaHD = @MaHD AND MaPhong = @MaPhong";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaHD", maHD);
            parameters[1] = new SqlParameter("@MaPhong", maPhong);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static void CapNhatBaoCao(BaoCao bc)
        {
            string sql = @"UPDATE BaoCao 
                          SET LoaiPhong = @LoaiPhong, 
                              SoNgay = @SoNgay, 
                              DoanhThu = @DoanhThu 
                          WHERE MaHD = @MaHD AND MaPhong = @MaPhong";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MaHD", bc.MaHD);
            parameters[1] = new SqlParameter("@MaPhong", bc.MaPhong);
            parameters[2] = new SqlParameter("@LoaiPhong", bc.LoaiPhong);
            parameters[3] = new SqlParameter("@SoNgay", bc.SoNgay);
            parameters[4] = new SqlParameter("@DoanhThu", bc.DoanhThu);

            DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static List<BaoCao> LayBaoCaoTheoMaHD(string maHD)
        {
            List<BaoCao> dsBaoCao = new List<BaoCao>();

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaHD", maHD);

            DataTable dtBaoCao = DataProvider.SelectData(
                "SELECT * FROM BaoCao WHERE MaHD = @MaHD",
                CommandType.Text,
                parameters
            );

            foreach (DataRow row in dtBaoCao.Rows)
            {
                BaoCao bc = new BaoCao
                {
                    MaHD = row["MaHD"].ToString(),
                    MaPhong = row["MaPhong"].ToString(),
                    LoaiPhong = row["LoaiPhong"].ToString(),
                    SoNgay = Convert.ToInt16(row["SoNgay"]),
                    DoanhThu = Convert.ToInt32(row["DoanhThu"])
                };
                dsBaoCao.Add(bc);
            }

            return dsBaoCao;
        }
    }
}