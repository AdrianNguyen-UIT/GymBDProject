CREATE PROCEDURE [dbo].[spUpdateDangKyGT]
    @MaDKGT INT, 
    @MaNV INT, 
    @MaHV INT, 
    @MaGT INT, 
    @NgayHD DATETIME, 
    @NgayBD DATETIME, 
    @GhiChu NVARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[DangKyGT]
		SET [MaNV] = @MaNV
		WHERE [MaDKGT] = @MaDKGT

		UPDATE [dbo].[DangKyGT]
		SET [MaHV] = @MaHV
		WHERE [MaDKGT] = @MaDKGT

		UPDATE [dbo].[DangKyGT]
		SET [MaGT] = @MaGT
		WHERE [MaDKGT] = @MaDKGT

		UPDATE [dbo].[DangKyGT]
		SET [NgayHD] = @NgayHD
		WHERE [MaDKGT] = @MaDKGT

		UPDATE [dbo].[DangKyGT]
		SET [NgayBD] = @NgayBD
		WHERE [MaDKGT] = @MaDKGT

		UPDATE [dbo].[DangKyGT]
		SET [GhiChu] = @GhiChu
		WHERE [MaDKGT] = @MaDKGT
	END
RETURN 0
