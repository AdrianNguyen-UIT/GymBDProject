CREATE PROCEDURE [dbo].[spUpdateDangNhap]
    @TaiKhoan VARCHAR(50), 
    @MatKhau VARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[DangNhap]
		SET [MatKhau] = @MatKhau
		WHERE [TaiKhoan] = @TaiKhoan
	END
RETURN 0
