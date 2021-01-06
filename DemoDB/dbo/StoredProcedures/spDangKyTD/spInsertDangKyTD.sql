CREATE PROCEDURE [dbo].[spInsertDangKyTD]
	@MaHV INT, 
    @MaNV INT, 
    @NgayMuon DATETIME, 
    @GhiChu NVARCHAR(50)
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[DangKyTD] ([MaNV], [MaHV], [NgayMuon], [GhiChu])
        VALUES (@MaNV, @MaHV, @NgayMuon, @GhiChu)
    END
RETURN 0
