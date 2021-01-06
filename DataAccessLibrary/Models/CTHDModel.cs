using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class CTHDModel
    {
        public int MaHD { get; set; }

        public int MaSP { get; set; }

        public int SoLuong { get; set; }

        public SanPhamModel SanPham { get; set; }

    }
}
