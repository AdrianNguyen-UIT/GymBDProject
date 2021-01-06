CREATE PROCEDURE [dbo].[spDeleteDangNhap]
    @TaiKhoan VARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		DELETE FROM [dbo].[DangNhap]
		WHERE [TaiKhoan] = @TaiKhoan
 	END
RETURN 0
