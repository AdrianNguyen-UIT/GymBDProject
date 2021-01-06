CREATE PROCEDURE [dbo].[spUpdateLoaiNhanVien]
	@MaLNV INT,
	@TenLNV NVARCHAR(50),
	@MoTa NVARCHAR(MAX)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[LoaiNV]
		SET [TenLNV] = @TenLNV
		WHERE [MaLNV] = @MaLNV

		UPDATE [dbo].[LoaiNV]
		SET [MoTa] = @MoTa
		WHERE [MaLNV] = @MaLNV
	END
RETURN 0
