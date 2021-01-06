using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class NhanVienData
    {
        public List<NhanVienModel> GetAllNhanVien()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllNhanVien]";

            var data = sqlDataAccess.LoadData<NhanVienModel, dynamic>(sql, new { });

            LoaiNVData db = new LoaiNVData();
            foreach (var d in data)
            {
                d.LoaiNV = db.GetLoaiNVByID(d.MaLNV)[0];
            }
            return data;
        }

        public List<NhanVienModel> GetNhanVienByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetNhanVienByID]";
            var p = new { MaNV = id };
            var data = sqlDataAccess.LoadData<NhanVienModel, dynamic>(sql, p);

            LoaiNVData db = new LoaiNVData();
            data[0].LoaiNV = db.GetLoaiNVByID(data[0].MaLNV)[0];
            return data;
        }

        public void InsertNhanVien(NhanVienModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertNhanVien] @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email, @CMND, @NgayVaoLam, @Luong, @TrangThai, @MaLNV";
            sqlDataAccess.SaveData(sql, new { sp.HoTen, sp.GioiTinh, sp.NgaySinh, sp.DiaChi, sp.SDT, sp.Email, sp.CMND, sp.NgayVaoLam, sp.Luong, sp.TrangThai, sp.MaLNV });
        }

        public void DeleteNhanVien(NhanVienModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteNhanVien] @MaNV";

            sqlDataAccess.SaveData(sql, new { MaNV = sp.Ma });
        }

        public void UpdateNhanVien(NhanVienModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateNhanVien] @MaNV, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email, @CMND, @NgayVaoLam, @Luong, @TrangThai, @MaLNV";
            sqlDataAccess.SaveData(sql, new { sp.Ma, sp.HoTen, sp.GioiTinh, sp.NgaySinh, sp.DiaChi, sp.SDT, sp.Email, sp.CMND, sp.NgayVaoLam, sp.Luong, sp.TrangThai, sp.MaLNV });
        }
    }
}
