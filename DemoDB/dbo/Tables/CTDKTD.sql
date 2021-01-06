CREATE TABLE [dbo].[CTDKTD]
(
	[MaDKTD] INT NOT NULL, 
    [MaTD] INT NOT NULL
	PRIMARY KEY([MaDKTD], [MaTD]), 
    CONSTRAINT [FK_CTDKTD_TuDo_MaTD] FOREIGN KEY ([MaTD]) REFERENCES [TuDo]([MaTD]), 
    CONSTRAINT [FK_CTDKTD_DangKyTD_MaDKTD] FOREIGN KEY ([MaDKTD]) REFERENCES [DangKyTD]([MaDKTD])
)

GO

CREATE TRIGGER [dbo].[Trigger_CTDKTD_ins]
    ON [dbo].[CTDKTD]
    FOR INSERT
    AS
    BEGIN
        SET NoCount ON
        DECLARE @MaxNumberOfTK INT;
        SET @MaxNumberOfTK = (SELECT [GiaTriTS]
                              FROM [ThamSo]
                              WHERE [ThamSo].[MaTS] = 1)
        DECLARE @CurrentTDCount INT;
        SET @CurrentTDCount = (SELECT COUNT(*)
                               FROM [dbo].[CTDKTD] JOIN [inserted] ON [dbo].[CTDKTD].[MaDKTD] = [inserted].[MaDKTD])

        IF (@CurrentTDCount > @MaxNumberOfTK)
            BEGIN
                PRINT 'Khong the dang ky so Tu Do nhieu hon 2'
                ROLLBACK TRANSACTION
            END
    END