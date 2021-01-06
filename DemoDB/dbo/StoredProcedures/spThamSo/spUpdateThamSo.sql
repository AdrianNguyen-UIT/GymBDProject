CREATE PROCEDURE [dbo].[spUpdateThamSo]
	@MaTS INT, 
    @TenTS NVARCHAR(50), 
    @GiaTriTS INT
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[ThamSo]
		SET [TenTS] = @TenTS
		WHERE [MaTS] = @MaTS

		UPDATE [dbo].[ThamSo]
		SET [GiaTriTS] = @GiaTriTS
		WHERE [MaTS] = @MaTS
	END
RETURN 0
