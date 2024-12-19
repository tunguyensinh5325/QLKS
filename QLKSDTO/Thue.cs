using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSDTO
{
    public class Thue
    {
        public string MaPhong { get; set; }  // Room ID
        public string CMND { get; set; }     // Customer ID
        public DateTime NgayDat { get; set; } // Booking date
        public DateTime NgayTra { get; set; } // Return date
    }
}
