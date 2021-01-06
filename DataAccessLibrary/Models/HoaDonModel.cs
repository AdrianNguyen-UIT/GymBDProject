using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class HoaDonModel
    {
        public int MaHD { get; set; }

        public int MaNV { get; set; }

        public DateTime NgayHD { get; set; }

        public long TongTien { get; set; }

        public NhanVienModel NhanVien { get; set; }

        public List<CTHDModel> CTHDs { get; set; }
    }
}
