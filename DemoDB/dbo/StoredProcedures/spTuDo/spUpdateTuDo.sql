CREATE PROCEDURE [dbo].[spUpdateTuDo]
    @MaTD INT, 
    @TenTD NVARCHAR(50), 
    @MoTa NVARCHAR(MAX), 
    @TrangThai NCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[TuDo]
		SET [TenTD] = @TenTD
		WHERE [MaTD] = @MaTD

		UPDATE [dbo].[TuDo]
		SET [MoTa] = @MoTa
		WHERE [MaTD] = @MaTD

		UPDATE [dbo].[TuDo]
		SET [TrangThai] = @TrangThai
		WHERE [MaTD] = @MaTD
	END
RETURN 0
