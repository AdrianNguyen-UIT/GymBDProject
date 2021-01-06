using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class SanPhamModel
    {
        public int MaSP { get; set; }

        public String TenSP { get; set; }

        public int MaLSP { get; set; }

        public long DonGia { get; set; }

        public int SoLuong { get; set; }

        public LoaiSPModel LoaiSP { get; set; }
    }
}
