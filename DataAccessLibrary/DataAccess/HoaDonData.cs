using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class HoaDonData
    {
        public List<HoaDonModel> GetAllHoaDon()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllHoaDon]";

            var data = sqlDataAccess.LoadData<HoaDonModel, dynamic>(sql, new { });

            NhanVienData db = new NhanVienData();
            CTHDData db2 = new CTHDData();
            foreach (var d in data)
            {
                d.NhanVien = db.GetNhanVienByID(d.MaNV)[0];
                d.CTHDs = db2.GetCTHDByHDid(d.MaHD);
            }
            return data;
        }

        public void InsertHoaDon(HoaDonModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertHoaDon] @MaNV, @NgayHD";
            sqlDataAccess.SaveData(sql, new { sp.MaNV, sp.NgayHD});
        }

        public void DeleteHoaDon(HoaDonModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteHoaDon] @MaHD";

            sqlDataAccess.SaveData(sql, new { MaHD = sp.MaHD });
        }

        public void UpdateHoaDon(HoaDonModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateHoaDon] @MaHD, @MaNV, @NgayHD";
            sqlDataAccess.SaveData(sql, new { sp.MaHD, sp.MaNV, sp.NgayHD });
        }
    }
}
