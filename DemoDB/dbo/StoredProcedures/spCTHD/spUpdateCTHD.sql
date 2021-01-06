CREATE PROCEDURE [dbo].[spUpdateCTHD]
	@MaHD INT, 
    @MaSP INT,
	@SoLuong INT
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[CTHD]
		SET [MaSP] = @MaSP
		WHERE [MaHD] = @MaHD AND [MaSP] = @MaSP

		UPDATE [dbo].[CTHD]
		SET [SoLuong] = @SoLuong
		WHERE [MaHD] = @MaHD AND [MaSP] = @MaSP
	END
RETURN 0
