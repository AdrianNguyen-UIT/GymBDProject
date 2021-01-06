CREATE PROCEDURE [dbo].[spInsertLoaiSP]
    @TenLSP NVARCHAR(50), 
    @MoTa NVARCHAR(50)
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[LoaiSP] ([TenLSP], [MoTa])
        VALUES (@TenLSP, @MoTa)
    END
RETURN 0
