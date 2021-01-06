CREATE PROCEDURE [dbo].[spGetHoiVienByID]
	@MaHV INT
AS
	SELECT *
	FROM [dbo].[HoiVien]
	WHERE [Ma] = @MaHV;
RETURN 0
