CREATE PROCEDURE [dbo].[spDeleteHoiVien]
	@MaHV int
AS
	BEGIN
		SET NOCOUNT ON;
		DELETE FROM [dbo].[DiemDanh]
		WHERE [MaHV] = @MaHV

		DELETE FROM [dbo].[DangKyTD]
		WHERE [MaHV] = @MaHV

		DELETE FROM [dbo].[DangKyGT]
		WHERE [MaHV] = @MaHV

		DELETE FROM [dbo].[DangKyHLV]
		WHERE [MaHV] = @MaHV

		DELETE FROM [dbo].[HoiVien]
		WHERE [Ma] = @MaHV
 	END
RETURN 0
