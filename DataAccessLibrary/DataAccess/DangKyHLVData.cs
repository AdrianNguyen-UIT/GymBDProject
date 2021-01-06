using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class DangKyHLVData
    {
        public List<DangKyHLVModel> GetAllDangKyHLV()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllDangKyHLV]";

            var data = sqlDataAccess.LoadData<DangKyHLVModel, dynamic>(sql, new { });

            NhanVienData db = new NhanVienData();
            HoiVienData db2 = new HoiVienData();
            HuanLuyenVienData db3 = new HuanLuyenVienData();

            foreach (var d in data)
            {
                d.NhanVien = db.GetNhanVienByID(d.MaNV)[0];
                d.HoiVien = db2.GetHoiVienByID(d.MaHV)[0];
                d.HuanLuyenVien = db3.GetHuanLuyenVienByID(d.MaHLV)[0];
            }
            return data;
        }

        public void InsertDangKyHLV(DangKyHLVModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertDangKyHLV] @MaNV, @MaHV, @MaHLV, @NgayHD, @ThoiHan, @NgayBD, @GhiChu";
            sqlDataAccess.SaveData(sql, new { sp.MaNV, sp.MaHV, sp.MaHLV, sp.NgayHD, sp.ThoiHan, sp.NgayBD, sp.GhiChu });
        }

        public void DeleteDangKyHLV(DangKyHLVModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteDangKyHLV] @MaDKHLV";

            sqlDataAccess.SaveData(sql, new { MaDKHLV = sp.MaDK });
        }

        public void UpdateDangKyHLV(DangKyHLVModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateDangKyHLV] @MaNV, @MaHV, @MaHLV, @NgayHD, @ThoiHan, @NgayBD, @GhiChu";
            sqlDataAccess.SaveData(sql, new { sp.MaNV, sp.MaHV, sp.MaHLV, sp.NgayHD, sp.ThoiHan, sp.NgayBD, sp.GhiChu });
        }
    }
}
