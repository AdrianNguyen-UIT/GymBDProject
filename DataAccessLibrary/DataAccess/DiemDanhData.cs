using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class DiemDanhData
    {
        public List<DiemDanhModel> GetAllDiemDanh()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllDiemDanh]";

            var data = sqlDataAccess.LoadData<DiemDanhModel, dynamic>(sql, new { });

            NhanVienData db = new NhanVienData();
            HoiVienData db2 = new HoiVienData();

            foreach (var d in data)
            {
                d.NhanVien = db.GetNhanVienByID(d.MaNV)[0];
                d.HoiVien = db2.GetHoiVienByID(d.MaHV)[0];
            }
            return data;
        }

        public List<DiemDanhModel> spGetDiemDanhByHVid(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetDiemDanhByHVid] @MaHV";
            var p = new { MaHV = id };
            var data = sqlDataAccess.LoadData<DiemDanhModel, dynamic>(sql, p);

            NhanVienData db = new NhanVienData();
            HoiVienData db2 = new HoiVienData();

            foreach (var d in data)
            {
                d.NhanVien = db.GetNhanVienByID(d.MaNV)[0];
                d.HoiVien = db2.GetHoiVienByID(d.MaHV)[0];
            }
            return data;
        }

        public void InsertDiemDanh(DiemDanhModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertDiemDanh] @MaHV, @ThoiDiem, @MaNV";
            sqlDataAccess.SaveData(sql, new { sp.MaHV, sp.ThoiDiem, sp.MaNV});
        }

        public void DeleteDiemDanh(DiemDanhModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteDiemDanh] @MaHV, @ThoiDiem";

            sqlDataAccess.SaveData(sql, new { MaHV = sp.MaHV, ThoiDiem = sp.ThoiDiem });
        }

        public void UpdateDiemDanh(DiemDanhModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateDiemDanh] @MaHV, @ThoiDiem, @MaNV";
            sqlDataAccess.SaveData(sql, new { sp.MaHV, sp.ThoiDiem, sp.MaNV });
        }
    }
}
