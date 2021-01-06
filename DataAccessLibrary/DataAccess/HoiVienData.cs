using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess
{
    public class HoiVienData
    {
        public List<HoiVienModel> GetAllHoiViens()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllHoiVien]";

            return sqlDataAccess.LoadData<HoiVienModel, dynamic>(sql, new { });
        }

        public List<HoiVienModel> GetHoiVienByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetHoiVienByID]";
            var p = new { MaHV = id };
            return sqlDataAccess.LoadData<HoiVienModel, dynamic>(sql, p);
        }

        public void InsertHoiVien(HoiVienModel hoiVien)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertHoiVien] @HoTen, @GioiTinh,@NgaySinh, @DiaChi, @SDT, @Email, @GhiChu";

            sqlDataAccess.SaveData(sql, new { hoiVien.HoTen, hoiVien.GioiTinh, hoiVien.NgaySinh, hoiVien.DiaChi, hoiVien.SDT, hoiVien.Email, hoiVien.GhiChu });
        }

        public void DeleteHoiVien(HoiVienModel hoiVien)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteHoiVien] @MaHV";

            sqlDataAccess.SaveData(sql, new { MaHV = hoiVien.Ma });
        }

        public void UpdateHoiVien(HoiVienModel hoiVien)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateHoiVien] @MaHV, @HoTen, @GioiTinh,@NgaySinh, @DiaChi, @SDT, @Email, @GhiChu";

            sqlDataAccess.SaveData(sql, new { hoiVien.Ma, hoiVien.HoTen, hoiVien.GioiTinh, hoiVien.NgaySinh, hoiVien.DiaChi, hoiVien.SDT, hoiVien.Email, hoiVien.GhiChu });
        }
    }
}
