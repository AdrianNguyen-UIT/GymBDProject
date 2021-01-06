CREATE PROCEDURE [dbo].[spGetAllHoiVien]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM [dbo].[HoiVien];
	END
