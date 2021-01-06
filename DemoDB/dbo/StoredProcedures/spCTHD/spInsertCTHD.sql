CREATE PROCEDURE [dbo].[spInsertCTHD]
	@MaHD INT, 
    @MaSP INT,
	@SoLuong INT
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong])
        VALUES (@MaHD, @MaSP, @SoLuong)
    END
RETURN 0
