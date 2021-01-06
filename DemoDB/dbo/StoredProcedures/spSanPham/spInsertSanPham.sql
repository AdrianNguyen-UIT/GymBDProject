CREATE PROCEDURE [dbo].[spInsertSanPham]
	@TenSP NVARCHAR(50), 
    @MaLSP INT, 
    @DonGia MONEY, 
    @SoLuong INT
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[SanPham] ([TenSP], [MaLSP], [DonGia], [SoLuong])
        VALUES (@TenSP, @MaLSP, @DonGia, @SoLuong);
    END
RETURN 0