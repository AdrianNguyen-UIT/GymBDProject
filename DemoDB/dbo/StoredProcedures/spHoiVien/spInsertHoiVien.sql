CREATE PROCEDURE [dbo].[spInsertHoiVien]
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
		INSERT INTO [dbo].[HoiVien] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [GhiChu])
		VALUES (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email, @GhiChu)
	END
RETURN 0
