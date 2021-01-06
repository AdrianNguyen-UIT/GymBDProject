using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class ThamSoData
    {
        public List<ThamSoModel> GetAllThamSos()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllThamSo]";

            return sqlDataAccess.LoadData<ThamSoModel, dynamic>(sql, new { });
        }

        public List<ThamSoModel> GetThamSoByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetThamSoByID]";
            var p = new { MaTS = id };
            return sqlDataAccess.LoadData<ThamSoModel, dynamic>(sql, p);
        }

        public void InsertThamSo(ThamSoModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertThamSo] @TenTS, @GiaTriTS";

            sqlDataAccess.SaveData(sql, new { sp.TenTS, sp.GiaTriTS });
        }

        public void DeleteThamSo(ThamSoModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteThamSo] @MaTS";

            sqlDataAccess.SaveData(sql, new { MaTS = sp.MaTS });
        }

        public void UpdateThamSo(ThamSoModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateThamSo] @MaTS, @TenTS, @GiaTriTS";

            sqlDataAccess.SaveData(sql, new { sp.MaTS, sp.TenTS, sp.GiaTriTS });
        }
    }
}
