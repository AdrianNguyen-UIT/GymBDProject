CREATE PROCEDURE [dbo].[spInsertDangKyGT]
    @MaNV INT, 
    @MaHV INT, 
    @MaGT INT, 
    @NgayHD DATETIME, 
    @NgayBD DATETIME, 
    @GhiChu NVARCHAR(50)
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[DangKyGT] ([MaNV], [MaHV], [MaGT], [NgayHD], [NgayBD], [GhiChu])
        VALUES (@MaNV, @MaHV, @MaGT, @NgayHD, @NgayBD, @GhiChu)
    END
RETURN 0
