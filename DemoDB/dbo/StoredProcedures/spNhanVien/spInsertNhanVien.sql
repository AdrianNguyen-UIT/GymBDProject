CREATE PROCEDURE [dbo].[spInsertNhanVien]
	@HoTen NVARCHAR(50),
	@GioiTinh NVARCHAR(50),
	@NgaySinh DATETIME,
	@DiaChi NVARCHAR(128),
	@SDT VARCHAR(15),
	@Email NVARCHAR(50),
	@CMND VARCHAR(15),
	@NgayVaoLam DATETIME,
	@Luong MONEY,
	@TrangThai NVARCHAR(50),
	@MaLNV INT
AS
	BEGIN
		SET NOCOUNT ON;
		INSERT INTO [dbo].[NhanVien] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [CMND], [NgayVaoLam], [Luong], [TrangThai], [MaLNV])
		VALUES (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email, @CMND, @NgayVaoLam, @Luong, @TrangThai, @MaLNV)
	END
RETURN 0
