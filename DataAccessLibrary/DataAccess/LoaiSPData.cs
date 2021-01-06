using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class LoaiSPData
    {
        public List<LoaiSPModel> GetAllLoaiSP()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllLoaiSP]";

            return sqlDataAccess.LoadData<LoaiSPModel, dynamic>(sql, new { });
        }

        public List<LoaiSPModel> GetLSPByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetLSPByID] @MaLSP";
            var p = new { MaLSP = id };
            return sqlDataAccess.LoadData<LoaiSPModel, dynamic>(sql, p);
        }

        public void InsertLoaiSP(LoaiSPModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertLoaiSP]  @TenLSP, @MoTa";

            sqlDataAccess.SaveData(sql, new { sp.TenLSP, sp.MoTa});
        }

        public void DeleteLoaiSP(LoaiSPModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteHoiVien] @MaLSP";

            sqlDataAccess.SaveData(sql, new { sp.MaLSP });
        }

        public void UpdateLoaiSP(LoaiSPModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateLoaiSP] @MaLSP, @TenLSP, @MoTa";

            sqlDataAccess.SaveData(sql, new { sp.MaLSP, sp.TenLSP, sp.MoTa });
        }
    }
}
