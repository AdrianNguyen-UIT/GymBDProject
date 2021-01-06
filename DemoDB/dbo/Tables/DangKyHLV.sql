CREATE TABLE [dbo].[DangKyHLV]
(
	[MaDKHLV] INT NOT NULL PRIMARY KEY IDENTITY,
    [MaNV] INT NOT NULL, 
    [MaHV] INT NOT NULL, 
    [NgayHD] DATETIME NOT NULL DEFAULT GetDate(),
    [NgayBD] DATETIME NOT NULL DEFAULT GetDate(), 
    [NgayKT] DATETIME NULL DEFAULT GetDate(), 
    [TongTien] MONEY NULL, 
    [GhiChu] NVARCHAR(50) NULL,
    [MaHLV] INT NOT NULL, 
    [ThoiHan] INT NOT NULL,
    CONSTRAINT [FK_DangKyHLV_NhanVien_MaNV] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien]([Ma]), 
    CONSTRAINT [FK_DangKyHLV_HoiVien_MaHV] FOREIGN KEY ([MaHV]) REFERENCES [HoiVien]([Ma]), 
    CONSTRAINT [FK_DangKyHLV_HuanLuyenVien] FOREIGN KEY ([MaHLV]) REFERENCES [HuanLuyenVien]([Ma]), 
    CONSTRAINT [CK_DangKyHLV_NgayBD] CHECK ([NgayBD] >= [NgayHD]),
)

GO

CREATE TRIGGER [dbo].[Trigger_DangKyHLV]
    ON [dbo].[DangKyHLV]
    FOR INSERT, UPDATE
    AS
    BEGIN
        SET NoCount ON
        UPDATE  [dbo].[DangKyHLV]
        SET [TongTien] = (SELECT [LuongKR]
                          FROM [dbo].[HuanLuyenVien] HLV JOIN [inserted] I on [HLV].[Ma] = [I].[MaHLV]) * [I].[ThoiHan]
        FROM [dbo].[DangKyHLV] DKHLV JOIN [inserted] I ON [DKHLV].[MaHLV] = [I].[MaHLV]

        UPDATE [dbo].[DangKyHLV]
        SET [NgayKT] = DATEADD(MONTH, [I].[ThoiHan], [I].[NgayBD])
        FROM [dbo].[DangKyHLV] DKHLV JOIN [inserted] I ON [DKHLV].[MaHLV] = [I].[MaHLV]
    END