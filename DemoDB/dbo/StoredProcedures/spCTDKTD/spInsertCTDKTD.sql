CREATE PROCEDURE [dbo].[spInsertCTDKTD]
	@MaDKTD INT, 
    @MaTD INT
AS
	BEGIN
        SET NOCOUNT ON;
        INSERT INTO [dbo].[CTDKTD] ([MaDKTD], [MaTD])
        VALUES (@MaDKTD, @MaTD)
    END
RETURN 0
