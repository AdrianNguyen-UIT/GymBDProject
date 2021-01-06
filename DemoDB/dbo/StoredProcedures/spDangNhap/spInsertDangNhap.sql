CREATE PROCEDURE [dbo].[spInsertDangNhap]
    @TaiKhoan VARCHAR(50), 
    @MatKhau VARCHAR(50),
    @MaNV INT
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [MaNV])
        VALUES (@TaiKhoan, @MatKhau, @MaNV)
    END
RETURN 0
