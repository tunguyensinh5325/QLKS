﻿using System;
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
        public static List<Phong> LayDSPhongTrong()
        {
            return PhongDAO.LayDSPhongTrong();
        }
        public static List<Phong> TimPhongTheoLoai(string lp)
        {
            return PhongDAO.TimPhongTheoLoai(lp);
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
        public static Phong LayPhongTheoMa(string mp)
        {
            return PhongDAO.LayPhongTheoMa(mp);
        }
        public static Phong LayTTPhong(string ttPhong)
        {
            return PhongDAO.LayThongTinPhong(ttPhong);
        }
        public static void CapNhatTinhTrangPhong(string maPhong, string tinhTrang)
        {
          if (!string.IsNullOrEmpty(maPhong) && string.IsNullOrEmpty(tinhTrang))
            return;
          try
          {
              PhongDAO.CapNhatTinhTrangPhong(maPhong, tinhTrang);

          }
          catch
          {
              return;
          }
      }
    }
}
