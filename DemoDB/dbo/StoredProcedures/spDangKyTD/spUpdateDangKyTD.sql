CREATE PROCEDURE [dbo].[spUpdateDangKyTD]
    @MaDKTD INT, 
    @MaHV INT, 
    @MaNV INT, 
    @NgayMuon DATETIME, 
    @GhiChu NVARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[DangKyTD]
		SET [MaNV] = @MaNV
		WHERE [MaDKTD] = @MaDKTD

		UPDATE [dbo].[DangKyTD]
		SET [MaHV] = @MaHV
		WHERE [MaDKTD] = @MaDKTD

		UPDATE [dbo].[DangKyTD]
		SET [NgayMuon] = @NgayMuon
		WHERE [MaDKTD] = @MaDKTD

		UPDATE [dbo].[DangKyTD]
		SET [GhiChu] = @GhiChu
		WHERE [MaDKTD] = @MaDKTD
	END
RETURN 0
