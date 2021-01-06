CREATE PROCEDURE [dbo].[spUpdateSanPham]
	@MaSP INT,
    @TenSP NVARCHAR(50), 
    @MaLSP INT, 
    @DonGia MONEY, 
    @SoLuong INT
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[SanPham]
		SET [TenSP] = @TenSP
		WHERE [MaSP] = @MaSP

		UPDATE [dbo].[SanPham]
		SET [MaLSP] = @MaLSP
		WHERE [MaSP] = @MaSP

		UPDATE [dbo].[SanPham]
		SET [DonGia] = @DonGia
		WHERE [MaSP] = @MaSP

		UPDATE [dbo].[SanPham]
		SET [DonGia] = @DonGia
		WHERE [MaSP] = @MaSP

		UPDATE [dbo].[SanPham]
		SET [SoLuong] = @SoLuong
		WHERE [MaSP] = @MaSP
	END
RETURN 0
