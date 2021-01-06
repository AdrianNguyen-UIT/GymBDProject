CREATE TABLE [dbo].[DangKyGT]
(
	[MaDKGT] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MaNV] INT NOT NULL, 
    [MaHV] INT NOT NULL, 
    [NgayHD] DATETIME NOT NULL DEFAULT GetDate(), 
    [NgayBD] DATETIME NOT NULL DEFAULT GetDate(), 
    [NgayKT] DATETIME NULL DEFAULT GetDate(), 
    [ThanhTien] MONEY NULL, 
    [GhiChu] NVARCHAR(50) NULL, 
    [MaGT] INT NOT NULL, 
    CONSTRAINT [FK_DangKyGT_NhanVien_MaNV] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien]([Ma]), 
    CONSTRAINT [FK_DangKyGT_HoiVien_MaHV] FOREIGN KEY ([MaHV]) REFERENCES [HoiVien]([Ma]), 
    CONSTRAINT [FK_DangKyGT_GoiTap_MaGT] FOREIGN KEY ([MaGT]) REFERENCES [GoiTap]([MaGT]), 
    CONSTRAINT [CK_DangKyGT_NgayBD] CHECK ([NgayBD] >= [NgayHD])
)
GO

CREATE TRIGGER [dbo].[Trigger_DangKyGT]
    ON [dbo].[DangKyGT]
    FOR INSERT, UPDATE
    AS
    BEGIN
        SET NoCount ON

        UPDATE [dbo].[DangKyGT]
        SET [ThanhTien] = (SELECT [GT].[DonGia]
                           FROM [dbo].[GoiTap] GT JOIN [inserted] I ON [GT].[MaGT] = [I].[MaGT])
        FROM [dbo].[DangKyGT] DKGT JOIN [inserted] I ON [DKGT].[MaDKGT] = [I].[MaDKGT]

        UPDATE [dbo].[DangKyGT]
        SET [NgayKT] = DATEADD(MONTH, (SELECT [GT].[ThoiHan]
                                       FROM [dbo].[GoiTap] GT JOIN [inserted] I ON [GT].[MaGT] = [I].[MaGT]), [I].[NgayBD])
        FROM [dbo].[DangKyGT] DKGT JOIN [inserted] I ON [DKGT].[MaDKGT] = [I].[MaDKGT]
    END