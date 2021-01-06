using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class HuanLuyenVienModel : NguoiModel
    {
        public String CMND { get; set; }

        public DateTime NgayVaoLam { get; set; }

        public long Luong { get; set; }

        public long LuongKR { get; set; }

        public String TrangThai { get; set; }

    }
}
