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
        public static List<KhachHang> DSKHDangThuePhong(string mp)
        {
            return KhachHangDAO.LayDSKhachHangDangThueCuaPhong(mp);
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

        public static KhachHang LayKhachHangTheoCMND(string cmnd)
        {
            if(string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(cmnd) ) {return null;}
            try
            {
               return KhachHangDAO.LayKhachHangTheoCMND(cmnd);
         
            }
            catch
            {
                return null;
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

        
    }
}
