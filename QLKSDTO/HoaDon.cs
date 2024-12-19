using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSDTO
{
    public class HoaDon
    {
        public string MaHD { get; set; } // (MaPhong-ngày đặt)
        public int ThanhTien { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayTra { get; set; }
        public string CMND { get; set; } // Chủ phòng (người thanh toán)
        public string MaPhong { get; set; }
    }
}
