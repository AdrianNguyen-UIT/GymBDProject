using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class DangKyGTData
    {
        public List<DangKyGTModel> GetAllDangKyGT()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllDangKyGT]";

            var data = sqlDataAccess.LoadData<DangKyGTModel, dynamic>(sql, new { });

            NhanVienData db = new NhanVienData();
            HoiVienData db2 = new HoiVienData();
            GoiTapData db3 = new GoiTapData();

            foreach (var d in data)
            {
                d.NhanVien = db.GetNhanVienByID(d.MaNV)[0];
                d.HoiVien = db2.GetHoiVienByID(d.MaHV)[0];
                d.GoiTap = db3.GetGoiTapByID(d.MaGT)[0];
            }
            return data;
        }

        public void InsertDangKyGT(DangKyGTModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertDangKyGT] @MaNV, @MaHV, @MaGT, @NgayHD, @NgayBD, @GhiChu";
            sqlDataAccess.SaveData(sql, new { sp.MaNV, sp.MaHV, sp.MaGT, sp.NgayHD, sp.NgayBD, sp.GhiChu});
        }

        public void DeleteDangKyGT(DangKyGTModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteDangKyGT] @MaDKGT";

            sqlDataAccess.SaveData(sql, new { MaDKGT = sp.MaDK });
        }

        public void UpdateDangKyGT(DangKyGTModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateDangKyGT] @MaDKGT, @MaNV, @MaHV, @MaGT, @NgayHD, @NgayBD, @GhiChu";
            sqlDataAccess.SaveData(sql, new { sp.MaDK, sp.MaNV, sp.MaHV, sp.MaGT, sp.NgayHD, sp.NgayBD, sp.GhiChu });
        }
    }
}
