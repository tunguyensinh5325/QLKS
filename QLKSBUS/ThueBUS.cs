﻿using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;
using QLKSDAO;

namespace QLKSBUS
{
    public class ThueBUS
    {
        public static List<Thue> LayDSThue()
        {
            return ThueDAO.LayDSThue();
        }

        public static bool ThemThue(Thue t)
        {
            if (string.IsNullOrEmpty(t.MaPhong) || string.IsNullOrEmpty(t.CMND))
                return false;

            if (t.NgayDat >= t.NgayTra)
                return false;

            try
            {
                ThueDAO.ThemThue(t);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaThue(string maPhong, string cmnd)
        {
            if (string.IsNullOrEmpty(maPhong) || string.IsNullOrEmpty(cmnd))
                return false;

            try
            {
                ThueDAO.XoaThue(maPhong, cmnd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatThue(Thue t)
        {
            if (string.IsNullOrEmpty(t.MaPhong) || string.IsNullOrEmpty(t.CMND))
                return false;

            if (t.NgayDat >= t.NgayTra)
                return false;

            try
            {
                ThueDAO.CapNhatThue(t);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemKhachThue(Thue thue)
        {
            if (string.IsNullOrEmpty(thue.MaPhong) || string.IsNullOrEmpty(thue.CMND))
                return false;

            try
            {
                ThueDAO.ThemPhieuThue(thue);

                PhongDAO.CapNhatTinhTrangPhong(thue.MaPhong, "Đã thuê");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
