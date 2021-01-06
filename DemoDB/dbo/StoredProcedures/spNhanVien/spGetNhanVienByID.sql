CREATE PROCEDURE [dbo].[spGetNhanVienByID]
	@MaNV INT
AS
	SELECT *
	FROM [dbo].[NhanVien]
	WHERE [Ma] = @MaNV;
RETURN 0
