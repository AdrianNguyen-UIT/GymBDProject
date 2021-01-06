CREATE PROCEDURE [dbo].[spInsertHuanLuyenVien]
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
		INSERT INTO [dbo].[HuanLuyenVien] ([HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [CMND], [NgayVaoLam], [Luong], [LuongKR], [TrangThai])
		VALUES (@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email, @CMND, @NgayVaoLam, @Luong, @LuongKR, @TrangThai)
	END
RETURN 0
