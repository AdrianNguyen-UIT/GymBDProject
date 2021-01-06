CREATE PROCEDURE [dbo].[spInsertLoaiNhanVien]
	@TenLNV NVARCHAR(50),
	@MoTa NVARCHAR(MAX)
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[LoaiNV] ([TenLNV], [MoTa])
        VALUES (@TenLNV, @MoTa)
    END
RETURN 0
