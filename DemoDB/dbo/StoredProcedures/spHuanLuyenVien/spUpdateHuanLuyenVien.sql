CREATE PROCEDURE [dbo].[spUpdateHuanLuyenVien]
	@MaHLV INT,
	@HoTen NVARCHAR(50),
	@GioiTinh NVARCHAR(50),
	@NgaySinh DATETIME,
	@DiaChi NVARCHAR(128),
	@SDT VARCHAR(15),
	@Email NVARCHAR(50),
	@CMND VARCHAR(15),
	@NgayVaoLam DATETIME,
	@Luong MONEY,
	@LuongKR MONEY,
	@TrangThai NVARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[HuanLuyenVien]
		SET [HoTen] = @HoTen
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [GioiTinh] = @GioiTinh
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [NgaySinh] = @NgaySinh
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [DiaChi] = @DiaChi
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [SDT] = @SDT
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [Email] = @Email
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [CMND] = @CMND
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [NgayVaoLam] = @NgayVaoLam
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [Luong] = @Luong
		WHERE [Ma] = @MaHLV
		
		UPDATE [dbo].[HuanLuyenVien]
		SET [LuongKR] = @LuongKR
		WHERE [Ma] = @MaHLV

		UPDATE [dbo].[HuanLuyenVien]
		SET [TrangThai] = @TrangThai
		WHERE [Ma] = @MaHLV

	END
RETURN 0
