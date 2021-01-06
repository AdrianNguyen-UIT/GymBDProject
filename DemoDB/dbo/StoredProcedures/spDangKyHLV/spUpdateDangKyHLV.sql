CREATE PROCEDURE [dbo].[spUpdateDangKyHLV]
    @MaDKHLV INT,
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
		UPDATE [dbo].[DangKyHLV]
		SET [MaNV] = @MaNV
		WHERE [MaDKHLV] = @MaDKHLV

		UPDATE [dbo].[DangKyHLV]
		SET [MaHV] = @MaHV
		WHERE [MaDKHLV] = @MaDKHLV

		UPDATE [dbo].[DangKyHLV]
		SET [MaHLV] = @MaHLV
		WHERE [MaDKHLV] = @MaDKHLV

		UPDATE [dbo].[DangKyHLV]
		SET [NgayHD] = @NgayHD
		WHERE [MaDKHLV] = @MaDKHLV

		UPDATE [dbo].[DangKyHLV]
		SET [NgayBD] = @NgayBD
		WHERE [MaDKHLV] = @MaDKHLV

		UPDATE [dbo].[DangKyHLV]
		SET [GhiChu] = @GhiChu
		WHERE [MaDKHLV] = @MaDKHLV

		UPDATE [dbo].[DangKyHLV]
		SET [ThoiHan] = @ThoiHan
		WHERE [MaDKHLV] = @MaDKHLV
	END
RETURN 0
