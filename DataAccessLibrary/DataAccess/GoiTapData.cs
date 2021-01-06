using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class GoiTapData
    {
        public List<GoiTapModel> GetAllGoiTap()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllGoiTap]";

            var data = sqlDataAccess.LoadData<GoiTapModel, dynamic>(sql, new { });
            return data;
        }

        public List<GoiTapModel> GetGoiTapByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetGoiTapByID]";
            var p = new { MaGT = id };
            return sqlDataAccess.LoadData<GoiTapModel, dynamic>(sql, p);
        }

        public void InsertGoiTap(GoiTapModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertGoiTap] @TenGT, @ThoiHan, @DonGia, @MoTa, @TrangThai";
            sqlDataAccess.SaveData(sql, new { sp.TenGT, sp.ThoiHan, sp.DonGia, sp.MoTa, sp.TrangThai });
        }

        public void DeleteGoiTap(GoiTapModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteGoiTap] @MaGT";

            sqlDataAccess.SaveData(sql, new { MaGT = sp.MaGT });
        }

        public void UpdateGoiTap(GoiTapModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateGoiTap] @MaGT, @TenGT, @ThoiHan, @DonGia, @MoTa, @TrangThai";
            sqlDataAccess.SaveData(sql, new { sp.MaGT, sp.TenGT, sp.ThoiHan, sp.DonGia, sp.MoTa, sp.TrangThai });
        }
    }
}
