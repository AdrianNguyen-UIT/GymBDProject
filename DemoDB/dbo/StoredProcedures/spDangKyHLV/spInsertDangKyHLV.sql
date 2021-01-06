CREATE PROCEDURE [dbo].[spInsertDangKyHLV]
	@MaNV INT, 
    @MaHV INT, 
    @MaHLV INT, 
    @NgayHD DATETIME,
    @ThoiHan INT,
    @NgayBD DATETIME, 
    @GhiChu NVARCHAR(50)
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[DangKyHLV] ([MaNV], [MaHV], [MaHLV], [NgayHD], [NgayBD], [ThoiHan], [GhiChu])
        VALUES (@MaNV, @MaHV, @MaHLV, @NgayHD, @NgayBD, @ThoiHan, @GhiChu)
    END
RETURN 0
