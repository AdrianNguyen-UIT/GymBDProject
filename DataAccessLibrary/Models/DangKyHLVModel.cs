using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class DangKyHLVModel : DangKyHDModel
    {
        public int MaHLV { get; set; }

        public int ThoiHan { get; set; }
        
        public NhanVienModel NhanVien { get; set; }
        public HoiVienModel HoiVien { get; set; }
        public HuanLuyenVienModel HuanLuyenVien { get; set; }
    }
}
