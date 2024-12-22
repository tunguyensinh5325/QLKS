using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using QLKSDTO;
using QLKSDAO;

namespace QLKSBUS
{
    public class HoaDonBUS
    {

        public List<HoaDon> LayDSHoaDon()
        {
            return HoaDonDAO.LayDSHoaDon();
        }


        public bool ThemHoaDon(HoaDon hoaDon)
        {

            if (string.IsNullOrEmpty(hoaDon.MaHD) || string.IsNullOrEmpty(hoaDon.MaPhong) || string.IsNullOrEmpty(hoaDon.CMND))
            {
                return false;
            }

            try
            {
                HoaDonDAO.ThemHoaDon(hoaDon);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaHoaDon(string maHD)
        {
            if (string.IsNullOrEmpty(maHD))
            {
                return false;
            }

            try
            {
                HoaDonDAO.XoaHoaDon(maHD);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool CapNhatHoaDon(HoaDon hoaDon)
        {
            if (string.IsNullOrEmpty(hoaDon.MaHD))
            {
                return false;
            }

            try
            {
                HoaDonDAO.CapNhatHoaDon(hoaDon);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
