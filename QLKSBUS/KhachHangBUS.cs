using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;
using QLKSDAO;

namespace QLKSBUS
{
    public class KhachHangBUS
    {
        public static List<KhachHang> LayDSKhachHang()
        {
            return KhachHangDAO.LayDSKhachHang();
        }

        public static bool ThemKhachHang(KhachHang kh)
        {
            if (string.IsNullOrEmpty(kh.CMND) || string.IsNullOrEmpty(kh.TenKH) || string.IsNullOrEmpty(kh.LoaiKH))
                return false;

            try
            {
                KhachHangDAO.ThemKhachHang(kh);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaKhachHang(string cmnd)
        {
            if (string.IsNullOrEmpty(cmnd))
                return false;

            try
            {
                KhachHangDAO.XoaKhachHang(cmnd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CapNhatKhachHang(KhachHang kh)
        {
            if (string.IsNullOrEmpty(kh.CMND) || string.IsNullOrEmpty(kh.TenKH) || string.IsNullOrEmpty(kh.LoaiKH))
                return false;

            try
            {
                KhachHangDAO.CapNhatKhachHang(kh);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static KhachHang LayTTKH(string CMND)
        {
            return KhachHangDAO.LayKhachHangTheoCMND(CMND);
        }
    }
}
