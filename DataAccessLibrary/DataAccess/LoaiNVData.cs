using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    class LoaiNVData
    {
        public List<LoaiNVModel> GetAllLoaiNV()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllLoaiNhanVien]";

            var data = sqlDataAccess.LoadData<LoaiNVModel, dynamic>(sql, new { });
            return data;
        }

        public List<LoaiNVModel> GetLoaiNVByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetLNVByID] @MaLNV";
            var p = new { MaLNV = id };
            return sqlDataAccess.LoadData<LoaiNVModel, dynamic>(sql, p);
        }

        public void InsertLoaiNV(LoaiNVModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertLoaiNhanVien] @TenLNV, @MoTa";
            sqlDataAccess.SaveData(sql, new { sp.TenLNV, sp.MoTa});
        }

        public void DeleteLoaiNV(LoaiNVModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteLoaiNhanVien] @MaLNV";

            sqlDataAccess.SaveData(sql, new { MaLNV = sp.MaLNV });
        }

        public void UpdateLoaiNV(LoaiNVModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateLoaiNhanVien] @MaLNV, @TenLNV, @MoTa";
            sqlDataAccess.SaveData(sql, new { sp.MaLNV, sp.TenLNV, sp.MoTa });
        }
    }
}
