CREATE PROCEDURE [dbo].[spUpdateHoiVien]
	@MaHV INT,
	@HoTen NVARCHAR(50),
	@GioiTinh NVARCHAR(50),
	@NgaySinh DATETIME,
	@DiaChi NVARCHAR(128),
	@SDT VARCHAR(15),
	@Email NVARCHAR(50),
	@GhiChu NVARCHAR(MAX)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[HoiVien]
		SET [HoTen] = @HoTen
		WHERE [Ma] = @MaHV

		UPDATE [dbo].[HoiVien]
		SET [GioiTinh] = @GioiTinh
		WHERE [Ma] = @MaHV

		UPDATE [dbo].[HoiVien]
		SET [NgaySinh] = @NgaySinh
		WHERE [Ma] = @MaHV

		UPDATE [dbo].[HoiVien]
		SET [DiaChi] = @DiaChi
		WHERE [Ma] = @MaHV

		UPDATE [dbo].[HoiVien]
		SET [SDT] = @SDT
		WHERE [Ma] = @MaHV

		UPDATE [dbo].[HoiVien]
		SET [Email] = @Email
		WHERE [Ma] = @MaHV

		UPDATE [dbo].[HoiVien]
		SET [GhiChu] = @GhiChu
		WHERE [Ma] = @MaHV
	END
RETURN 0
