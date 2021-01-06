using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class CTHDData
    {
        public List<CTHDModel> GetAllCTHD()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllCTHD]";

            var data = sqlDataAccess.LoadData<CTHDModel, dynamic>(sql, new { });

            SanPhamData db = new SanPhamData();
            foreach (var d in data)
            {
                d.SanPham = db.GetSanPhamByID(d.MaSP)[0];
            }
            return data;
        }

        public List<CTHDModel> GetCTHDByHDid(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetCTHDByHDid]";
            var p = new { MaHD = id };
            var data = sqlDataAccess.LoadData<CTHDModel, dynamic>(sql, p);

            SanPhamData db = new SanPhamData();
            foreach (var d in data)
            {
                d.SanPham = db.GetSanPhamByID(d.MaSP)[0];
            }
            return data;
        }

        public void InsertCTHD(CTHDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertCTHD] @MaHD, @MaSP, @SoLuong";
            sqlDataAccess.SaveData(sql, new { sp.MaHD, sp.MaSP, sp.SoLuong});
        }

        public void DeleteCTHD(CTHDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteCTHD] @MaHD, @MaSP";

            sqlDataAccess.SaveData(sql, new { MaHD = sp.MaHD, MaSP = sp.MaSP });
        }

        public void UpdateCTDKTD(CTHDModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateCTHD] @MaHD, @MaSP, @SoLuong";

            sqlDataAccess.SaveData(sql, new { sp.MaHD, sp.MaSP, sp.SoLuong });
        }
    }
}
