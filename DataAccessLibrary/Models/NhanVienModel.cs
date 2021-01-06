using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class NhanVienModel : NguoiModel
    {
        public String CMND { get; set; }

        public DateTime NgayVaoLam { get; set; }

        public long Luong { get; set; }

        public String  TrangThai { get; set; }

        public int MaLNV { get; set; }

        public LoaiNVModel LoaiNV { get; set; }

    }
}
