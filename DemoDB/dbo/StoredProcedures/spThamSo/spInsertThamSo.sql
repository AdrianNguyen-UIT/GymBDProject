CREATE PROCEDURE [dbo].[spInsertThamSo]
    @TenTS NVARCHAR(50), 
    @GiaTriTS INT
AS
		BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[ThamSo] ([TenTS], [GiaTriTS])
        VALUES (@TenTS, @GiaTriTS)
    END
RETURN 0
