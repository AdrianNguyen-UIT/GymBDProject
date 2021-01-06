CREATE PROCEDURE [dbo].[spGetSanPhamByID]
	@MaSP INT
AS
	SELECT *
	FROM [dbo].[SanPham]
	WHERE [MaSP] = @MaSP;
RETURN 0
