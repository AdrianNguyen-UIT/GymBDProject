CREATE TABLE [dbo].[CTHD]
(
	[MaHD] INT NOT NULL, 
    [MaSP] INT NOT NULL,
	[SoLuong] INT NOT NULL, 
    PRIMARY KEY ([MaHD], [MaSP]), 
    CONSTRAINT [FK_CTHD_HoaDon_MaHD] FOREIGN KEY ([MaHD]) REFERENCES [HoaDon]([MaHD]), 
    CONSTRAINT [FK_CTHD_SanPham_MaSP] FOREIGN KEY ([MaSP]) REFERENCES [SanPham]([MaSP]), 
    CONSTRAINT [CK_CTHD_SoLuong] CHECK ([SoLuong] <= [dbo].[fnGetSoLuongSP]([MaSP]))
)

GO

CREATE TRIGGER [dbo].[Trigger_CTHD_ins_upd]
    ON [dbo].[CTHD]
    FOR INSERT, UPDATE
    AS
    BEGIN
        SET NoCount ON

        UPDATE [dbo].[SanPham]
        SET [SoLuong] = [SP].[SoLuong] - [inserted].[SoLuong]
        FROM [dbo].[SanPham] SP JOIN [inserted] ON [SP].[MaSP] = [inserted].[MaSP]

        UPDATE [dbo].[HoaDon]
        SET [TongTien] = [HD].[TongTien] + ((SELECT [SP].[DonGia]
                                             FROM [dbo].[SanPham] SP JOIN [inserted] I ON [SP].[MaSP] = [I].[MaSP]) * [I].[SoLuong])
        FROM [dbo].[HoaDon] HD JOIN [inserted] I ON [HD].[MaHD] = [I].[MaHD]
    END
GO


CREATE TRIGGER [dbo].[Trigger_CTHD_del]
    ON [dbo].[CTHD]
    FOR DELETE
    AS
    BEGIN
        SET NoCount ON

        UPDATE [dbo].[SanPham]
        SET [SoLuong] = [SP].[SoLuong] + [deleted].[SoLuong]
        FROM [dbo].[SanPham] SP JOIN [deleted] ON [SP].[MaSP] = [deleted].[MaSP]

        UPDATE [dbo].[HoaDon]
        SET [TongTien] = [HD].[TongTien] - ((SELECT [SP].[DonGia]
                                             FROM [dbo].[SanPham] SP JOIN [deleted] D ON [SP].[MaSP] = [D].[MaSP]) * [D].[SoLuong])
        FROM [dbo].[HoaDon] HD JOIN [deleted] D ON [HD].[MaHD] = [D].[MaHD]
    END