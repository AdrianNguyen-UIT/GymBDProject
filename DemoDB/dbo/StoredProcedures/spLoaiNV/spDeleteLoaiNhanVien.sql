CREATE PROCEDURE [dbo].[spDeleteLoaiNhanVien]
	@MaLNV INT
AS
	BEGIN
		SET NOCOUNT ON;
		DELETE FROM [dbo].[NhanVien]
		WHERE [Ma] = @MaLNV

		DELETE FROM [dbo].[LoaiNV]
		WHERE [MaLNV] = @MaLNV
	END
RETURN 0
