CREATE PROCEDURE [dbo].[spInsertTuDo]
    @TenTD NVARCHAR(50), 
    @MoTa NVARCHAR(MAX), 
    @TrangThai NCHAR(50)
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[TuDo] ([TenTD], [MoTa], [TrangThai])
        VALUES (@TenTD, @MoTa, @TrangThai)
    END
RETURN 0
