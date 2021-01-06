using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class DangNhapModel
    {
        public String TaiKhoan { get; set; }

        public String MatKhau { get; set; }

        public int MaNV { get; set; }

        public NhanVienModel NhanVien { get; set; }
    }
}
