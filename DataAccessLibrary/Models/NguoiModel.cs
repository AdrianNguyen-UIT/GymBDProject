using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace DataAccessLibrary.Models
{
    public class NguoiModel
    {
        public int Ma { get; set; }

        public String HoTen { get; set; }

        public String GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public String DiaChi { get; set; }

        public String SDT { get; set; }

        public String Email { get; set; }
    }
}
