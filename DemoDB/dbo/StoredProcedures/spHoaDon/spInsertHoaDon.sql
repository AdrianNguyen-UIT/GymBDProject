CREATE PROCEDURE [dbo].[spInsertHoaDon]
    @MaNV INT, 
    @NgayHD DATETIME
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[HoaDon] ([MaNV], [NgayHD])
        VALUES (@MaNV, @NgayHD)
    END
RETURN 0
