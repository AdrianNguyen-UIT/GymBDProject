using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class DangKyTDModel
    {
        public int MaDK { get; set; }

        public int MaHV { get; set; }

        public int MaNV { get; set; }

        public DateTime NgayMuon { get; set; }

        public String GhiChu { get; set; }

        public HoiVienModel HoiVien { get; set; }

        public NhanVienModel NhanVien { get; set; }

        public List<CTDKTDModel> CTDKTDs { get; set; }

        public int SoMuonToiDa { get; set; }

    }
}
