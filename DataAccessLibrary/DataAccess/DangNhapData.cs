using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class DangNhapData
    {
        public List<DangNhapModel> GetAllDangNhap()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllDangNhap]";

            var data = sqlDataAccess.LoadData<DangNhapModel, dynamic>(sql, new { });

            NhanVienData db = new NhanVienData();
            foreach (var d in data)
            {
                d.NhanVien = db.GetNhanVienByID(d.MaNV)[0];
            }
            return data;
        }

        public List<DangNhapModel> GetDangNhapByUsername(String username)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetDangNhapByUsername] @TaiKhoan";
            var p = new { TaiKhoan = username };
            var data = sqlDataAccess.LoadData<DangNhapModel, dynamic>(sql, p);

            NhanVienData db = new NhanVienData();
            data[0].NhanVien = db.GetNhanVienByID(data[0].MaNV)[0];
            return data;
        }

        public void InsertDangNhap(DangNhapModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertDangNhap] @TaiKhoan, @MatKhau, @MaNV";
            sqlDataAccess.SaveData(sql, new { sp.TaiKhoan, sp.MatKhau, sp.MaNV});
        }

        public void DeleteDangNhap(DangNhapModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteDangNhap] @TaiKhoan";

            sqlDataAccess.SaveData(sql, new { TaiKhoan = sp.TaiKhoan });
        }

        public void UpdateDangNhap(DangNhapModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateDangNhap] @TaiKhoan, @MatKhau";
            sqlDataAccess.SaveData(sql, new { sp.TaiKhoan, sp.MatKhau });
        }
    }
}
