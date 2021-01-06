CREATE PROCEDURE [dbo].[spUpdateHoaDon]
	@MaHD INT, 
    @MaNV INT, 
    @NgayHD DATETIME
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[HoaDon]
		SET [MaNV] = @MaNV
		WHERE [MaHD] = @MaHD
 
		UPDATE [dbo].[HoaDon]
		SET [NgayHD] = @NgayHD
		WHERE [MaHD] = @MaHD
	END
RETURN 0
