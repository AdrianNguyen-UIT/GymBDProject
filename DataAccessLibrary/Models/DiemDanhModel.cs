using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class DiemDanhModel
    {
        public int MaHV { get; set; }

        public DateTime ThoiDiem { get; set; }

        public int MaNV { get; set; }

        public HoiVienModel HoiVien { get; set; }

        public NhanVienModel NhanVien { get; set; }
    }
}
