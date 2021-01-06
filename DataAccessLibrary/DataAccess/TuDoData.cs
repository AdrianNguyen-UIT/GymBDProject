using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class TuDoData
    {
        public List<TuDoModel> GetAllSanPham()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllTuDo]";

            var data = sqlDataAccess.LoadData<TuDoModel, dynamic>(sql, new { });
            return data;
        }

        public List<TuDoModel> GetTuDoByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetTuDoByID] @MaTD";
            var p = new { MaTD = id };
            return sqlDataAccess.LoadData<TuDoModel, dynamic>(sql, p);
        }

        public void InsertTuDo(TuDoModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertTuDo] @TenTD, @MoTa, @TrangThai";
            sqlDataAccess.SaveData(sql, new { sp.TenTD, sp.MoTa, sp.TrangThai });
        }

        public void DeleteTuDo(TuDoModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteTuDo] @MaTD";

            sqlDataAccess.SaveData(sql, new { MaTD = sp.MaTD});
        }

        public void UpdateTuDo(TuDoModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateTuDo] @MaTD, @TenTD, @MoTa, @TrangThai";
            sqlDataAccess.SaveData(sql, new { sp.MaTD, sp.TenTD, sp.MoTa, sp.TrangThai });
        }
    }
}
