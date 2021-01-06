CREATE FUNCTION [dbo].[fnGetSoLuongSP]
(@MaSP INT)
RETURNS INT
AS
	BEGIN
		DECLARE @Result INT;
		SET @Result = (SELECT [SoLuong]
					   FROM [dbo].[SanPham]
					   WHERE [MaSP] = @MaSP)
		RETURN @Result;
	END