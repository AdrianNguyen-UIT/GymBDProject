CREATE PROCEDURE [dbo].[spGetAllSanPham]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT [SP].*, [LSP].*
		FROM [dbo].[SanPham] SP JOIN [dbo].[LoaiSP] LSP ON [SP].[MaLSP] = [LSP].[MaLSP];
	END
RETURN 0
