using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class DangKyGTModel : DangKyHDModel
    {
        public int MaGT { get; set; }

        public NhanVienModel NhanVien { get; set; }
        public HoiVienModel HoiVien { get; set; }
        public GoiTapModel GoiTap { get; set; }
    }
}
