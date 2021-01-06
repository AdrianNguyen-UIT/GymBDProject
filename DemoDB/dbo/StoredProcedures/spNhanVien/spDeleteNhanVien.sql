CREATE PROCEDURE [dbo].[spDeleteNhanVien]
	@MaNV int
AS
	BEGIN
		SET NOCOUNT ON;

		DELETE FROM [dbo].[DangKyGT]
		WHERE [MaNV] = @MaNV
		
		DELETE FROM [dbo].[DangKyHLV]
		WHERE [MaNV] = @MaNV

		DELETE FROM [dbo].[DangKyTD]
		WHERE [MaNV] = @MaNV

		DELETE FROM [dbo].[DiemDanh]
		WHERE [MaNV] = @MaNV

		DELETE FROM [dbo].[HoaDon]
		WHERE [MaNV] = @MaNV

		DELETE FROM [dbo].[DangNhap]
		WHERE [MaNV] = @MaNV

		DELETE FROM [dbo].[NhanVien]
		WHERE [Ma] = @MaNV
 	END
RETURN 0
