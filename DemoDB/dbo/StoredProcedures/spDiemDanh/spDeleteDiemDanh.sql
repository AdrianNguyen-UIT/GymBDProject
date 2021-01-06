CREATE PROCEDURE [dbo].[spDeleteDiemDanh]
    @MaHV INT, 
	@ThoiDiem DATETIME 
AS
	BEGIN
		SET NOCOUNT ON;
		DELETE FROM [dbo].[DiemDanh]
		WHERE [MaHV] = @MaHV AND [ThoiDiem] = @ThoiDiem
 	END
RETURN 0
