using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class DangKyTDData
    {
        public List<DangKyTDModel> GetAllDangKyTD()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllDangKyTD]";

            var data = sqlDataAccess.LoadData<DangKyTDModel, dynamic>(sql, new { });

            NhanVienData db = new NhanVienData();
            HoiVienData db2 = new HoiVienData();
            CTDKTDData db3 = new CTDKTDData();
            foreach (var d in data)
            {
                d.NhanVien = db.GetNhanVienByID(d.MaNV)[0];
                d.HoiVien = db2.GetHoiVienByID(d.MaHV)[0];
                d.CTDKTDs = db3.GetCTDKTDByDKTDid(d.MaDK);
            }
            return data;
        }

        public void InsertDangKyTD(DangKyTDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertDangKyTD] @MaHV, @MaNV, @NgayMuon, @GhiChu";
            sqlDataAccess.SaveData(sql, new { sp.MaHV, sp.MaNV, sp.NgayMuon, sp.GhiChu});
        }

        public void DeleteDangKyTD(DangKyTDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteDangKyTD] @MaDKTD";

            sqlDataAccess.SaveData(sql, new { MaDKTD = sp.MaDK });
        }

        public void UpdateDangKyTD(DangKyTDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateDangKyTD] @MaDKTD, @MaHV, @MaNV, @NgayMuon, @GhiChu";
            sqlDataAccess.SaveData(sql, new { sp.MaDK, sp.MaHV, sp.MaNV, sp.NgayMuon, sp.GhiChu });
        }
    }
}
