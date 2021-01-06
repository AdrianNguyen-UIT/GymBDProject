using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class CTDKTDData
    {
        public List<CTDKTDModel> GetAllCTDKTD()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllCTDKTD]";

            var data = sqlDataAccess.LoadData<CTDKTDModel, dynamic>(sql, new { });

            TuDoData db = new TuDoData();
            foreach (var d in data)
            {
                d.TuDo = db.GetTuDoByID(d.MaTD)[0];
            }
            return data;
        }

        public List<CTDKTDModel> GetCTDKTDByDKTDid(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetCTDKTDByDKTDid]";
            var p = new { MaDKTD = id };
            var data = sqlDataAccess.LoadData<CTDKTDModel, dynamic>(sql, p);

            TuDoData db = new TuDoData();
            foreach (var d in data)
            {
                d.TuDo = db.GetTuDoByID(d.MaTD)[0];
            }
            return data;
        }

        public void InsertCTDKTD(CTDKTDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertCTDKTD] @MaDKTD, @MaTD";
            sqlDataAccess.SaveData(sql, new { sp.MaDKTD, sp.MaTD});
        }

        public void DeleteCTDKTD(CTDKTDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteCTDKTD] @MaDKTD, @MaTD";

            sqlDataAccess.SaveData(sql, new { MaDKTD = sp.MaDKTD, MaTD = sp.MaTD });
        }

        public void UpdateCTDKTD(CTDKTDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateCTDKTD] @MaDKTD, @MaTD";

            sqlDataAccess.SaveData(sql, new { MaDKTD = sp.MaDKTD, MaTD = sp.MaTD });
        }
    }
}
