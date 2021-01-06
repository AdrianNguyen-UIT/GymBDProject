using DataAccessLibrary.Internal.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class SanPhamData
    {
        public List<SanPhamModel> GetAllSanPham()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetAllSanPham]";

            var data = sqlDataAccess.LoadData<SanPhamModel, dynamic>(sql, new { });

            LoaiSPData maLSPDB = new LoaiSPData();
            foreach (var d in data)
            {
                d.LoaiSP = maLSPDB.GetLSPByID(d.MaLSP)[0];
            }
            return data;
        }

        public List<SanPhamModel> GetSanPhamByID(int id)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

            string sql = "[dbo].[spGetSanPhamByID]";
            var p = new { MaSP = id };
            var data =  sqlDataAccess.LoadData<SanPhamModel, dynamic>(sql, p);

            LoaiSPData db = new LoaiSPData();
            data[0].LoaiSP = db.GetLSPByID(data[0].MaLSP)[0];
            return data;
        }

        public void InsertSanPham(SanPhamModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spInsertSanPham] @TenSP, @MaLSP, @DonGia, @SoLuong";
            sqlDataAccess.SaveData(sql, new { sp.TenSP, sp.MaLSP, sp.DonGia, sp.SoLuong });
        }

        public void DeleteSanPham(SanPhamModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spDeleteSanPham] @MaSP";

            sqlDataAccess.SaveData(sql, new { MaSP = sp.MaSP});
        }

        public void UpdateSanPham(SanPhamModel sp)
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();
            string sql = "[dbo].[spUpdateSanPham] @MaSP, @TenSP, @MaLSP, @DonGia, @SoLuong";
            sqlDataAccess.SaveData(sql, new { sp.MaSP, sp.TenSP, sp.MaLSP, sp.DonGia, sp.SoLuong });
        }
    }
}
