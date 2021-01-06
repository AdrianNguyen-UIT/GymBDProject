using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class DangKyHDModel
    {
        public int MaDK { get; set; }

        public int MaNV { get; set; }

        public int MaHV { get; set; }

        public DateTime NgayHD { get; set; }

        public DateTime NgayBD { get; set; }

        public DateTime NgayKT { get; set; }

        public long ThanhTien { get; set; }

        public String GhiChu { get; set; }
    }
}
