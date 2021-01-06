CREATE PROCEDURE [dbo].[spInsertDiemDanh]
	@MaHV INT, 
	@ThoiDiem DATETIME, 
    @MaNV INT
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[DiemDanh] ([MaHV], [ThoiDiem], [MaNV])
        VALUES (@MaHV, @ThoiDiem, @MaNV)
    END
RETURN 0
