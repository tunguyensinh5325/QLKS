using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;
using QLKSDAO;

namespace QLKSBUS
{
  public class PhongBUS
    {
        public static List<Phong> LayDSPhong()
        {
            return PhongDAO.LayDSPhong();
        }

        public static bool ThemPhong(Phong p)
        {
            if (string.IsNullOrEmpty(p.MaPhong) || string.IsNullOrEmpty(p.LoaiPhong))
                return false;

            if (p.Gia < 0)
                return false;

            try
            {
                PhongDAO.ThemPhong(p);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaPhong(string maPhong)
        {
            if (string.IsNullOrEmpty(maPhong))
                return false;

            try
            {
                PhongDAO.XoaPhong(maPhong);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatPhong(Phong p)
        {
            if (string.IsNullOrEmpty(p.MaPhong) || string.IsNullOrEmpty(p.LoaiPhong))
                return false;

            if (p.Gia < 0)
                return false;

            try
            {
                PhongDAO.CapNhatPhong(p);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
