using System;
using System.Collections.Generic;
using QLKSDTO;
using QLKSDAO;

namespace QLKSBUS
{
    public class BaoCaoBUS
    {
        public static List<BaoCao> LayDSBaoCao()
        {
            return BaoCaoDAO.LayDSBaoCao();
        }

        public static bool ThemBaoCao(BaoCao bc)
        {
            if (string.IsNullOrEmpty(bc.MaHD) || string.IsNullOrEmpty(bc.MaPhong))
                return false;

            if (bc.SoNgay <= 0)
                return false;

            if (bc.DoanhThu < 0)
                return false;

            try
            {
                BaoCaoDAO.ThemBaoCao(bc);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaBaoCao(string maHD, string maPhong)
        {
            if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(maPhong))
                return false;

            try
            {
                BaoCaoDAO.XoaBaoCao(maHD, maPhong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatBaoCao(BaoCao bc)
        {
            if (string.IsNullOrEmpty(bc.MaHD) || string.IsNullOrEmpty(bc.MaPhong))
                return false;

            if (bc.SoNgay <= 0)
                return false;

            if (bc.DoanhThu < 0)
                return false;

            try
            {
                BaoCaoDAO.CapNhatBaoCao(bc);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<BaoCao> LayBaoCaoTheoMaHD(string maHD)
        {
            if (string.IsNullOrEmpty(maHD))
                return new List<BaoCao>();

            return BaoCaoDAO.LayBaoCaoTheoMaHD(maHD);
        }
    }
}