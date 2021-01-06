﻿CREATE TABLE [dbo].[HoaDon]
(
	[MaHD] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MaNV] INT NOT NULL, 
    [NgayHD] DATETIME NULL DEFAULT GetDate(), 
    [TongTien] MONEY NULL, 
    CONSTRAINT [FK_HoaDon_NhanVien_MaNV] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien]([Ma])
)