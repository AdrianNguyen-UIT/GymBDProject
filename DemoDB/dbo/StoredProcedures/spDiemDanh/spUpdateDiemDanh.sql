CREATE PROCEDURE [dbo].[spUpdateDiemDanh]
    @MaHV INT, 
    @ThoiDiem DATETIME, 
    @MaNV INT
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[DiemDanh]
		SET [MaNV] = @MaNV
		WHERE [MaHV] = @MaHV AND [ThoiDiem] = @ThoiDiem
 
		UPDATE [dbo].[DiemDanh]
		SET [ThoiDiem] = @ThoiDiem
		WHERE [MaHV] = @MaHV AND [ThoiDiem] = @ThoiDiem
	END
RETURN 0
