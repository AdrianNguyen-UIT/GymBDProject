using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class HuanLuyenVienData
    {
        public List<HuanLuyenVienModel> GetAllHuanLuyenVien()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllHuanLuyenVien]";

            var data = sqlDataAccess.LoadData<HuanLuyenVienModel, dynamic>(sql, new { });
            return data;
        }

        public List<HuanLuyenVienModel> GetHuanLuyenVienByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetHLVByID]";
            var p = new { MaHLV = id };
            var data = sqlDataAccess.LoadData<HuanLuyenVienModel, dynamic>(sql, p);
            return data;
        }

        public void InsertHuanLuyenVien(HuanLuyenVienModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertHuanLuyenVien] @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email, @CMND, @NgayVaoLam, @Luong, @LuongKR, @TrangThai";
            sqlDataAccess.SaveData(sql, new { sp.HoTen, sp.GioiTinh, sp.NgaySinh, sp.DiaChi, sp.SDT, sp.Email, sp.CMND, sp.NgayVaoLam, sp.Luong, sp.LuongKR, sp.TrangThai });
        }

        public void DeleteHuanLuyenVien(HuanLuyenVienModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteHuanLuyenVien] @MaHLV";

            sqlDataAccess.SaveData(sql, new { MaHLV = sp.Ma });
        }

        public void UpdateHuanLuyenVien(HuanLuyenVienModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateHuanLuyenVien] @MaHLV, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email, @CMND, @NgayVaoLam, @Luong, @LuongKR, @TrangThai";
            sqlDataAccess.SaveData(sql, new { sp.Ma, sp.HoTen, sp.GioiTinh, sp.NgaySinh, sp.DiaChi, sp.SDT, sp.Email, sp.CMND, sp.NgayVaoLam, sp.Luong, sp.LuongKR, sp.TrangThai });
        }
    }
}
