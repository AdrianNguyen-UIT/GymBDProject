CREATE PROCEDURE [dbo].[spGetDangNhapByUsername]
	@TaiKhoan VARCHAR(50) 
AS
	BEGIN
		SELECT *
		FROM [dbo].[DangNhap]
		WHERE [TaiKhoan] = @TaiKhoan
	END
RETURN 0
