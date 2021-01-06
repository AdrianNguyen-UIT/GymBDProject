CREATE PROCEDURE [dbo].[spGetAllNhanVien]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM [dbo].[NhanVien];
	END
