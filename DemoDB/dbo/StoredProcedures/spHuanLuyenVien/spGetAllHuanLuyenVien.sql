CREATE PROCEDURE [dbo].[spGetAllHuanLuyenVien]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM [dbo].[HuanLuyenVien];
	END
RETURN 0
