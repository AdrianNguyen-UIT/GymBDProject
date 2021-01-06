CREATE PROCEDURE [dbo].[spUpdateNhanVien]
	@MaNV INT,
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
		UPDATE [dbo].[NhanVien]
		SET [HoTen] = @HoTen
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [GioiTinh] = @GioiTinh
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [NgaySinh] = @NgaySinh
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [DiaChi] = @DiaChi
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [SDT] = @SDT
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [Email] = @Email
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [CMND] = @CMND
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [NgayVaoLam] = @NgayVaoLam
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [Luong] = @Luong
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [TrangThai] = @TrangThai
		WHERE [Ma] = @MaNV

		UPDATE [dbo].[NhanVien]
		SET [MaLNV] = @MaLNV
		WHERE [Ma] = @MaNV
	END
RETURN 0
