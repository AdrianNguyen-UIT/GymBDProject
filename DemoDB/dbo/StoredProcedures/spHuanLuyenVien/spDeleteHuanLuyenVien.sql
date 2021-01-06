CREATE PROCEDURE [dbo].[spDeleteHuanLuyenVien]
	@MaHLV INT
AS
	BEGIN
		SET NOCOUNT ON;

		DELETE FROM [dbo].[DangKyHLV]
		WHERE [MaHLV] = @MaHLV

		DELETE FROM [dbo].[HuanLuyenVien]
		WHERE [Ma] = @MaHLV
 	END
RETURN 0
