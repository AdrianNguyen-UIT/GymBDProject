CREATE PROCEDURE [dbo].[spGetHLVByID]
	@MaHLV INT
AS
	SELECT *
	FROM [dbo].[HuanLuyenVien]
	WHERE [Ma] = @MaHLV;
RETURN 0
