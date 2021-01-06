CREATE TABLE [dbo].[DiemDanh]
(
	[MaHV] INT NOT NULL, 
    [ThoiDiem] DATETIME NOT NULL DEFAULT GetDate(), 
    [MaNV] INT NOT NULL,
    PRIMARY KEY ([MaHV], [ThoiDiem]), 
    CONSTRAINT [FK_DiemDanh_HoiVien_MaHV] FOREIGN KEY ([MaHV]) REFERENCES [HoiVien]([Ma]), 
    CONSTRAINT [FK_DiemDanh_NhanVien_MaNV] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien]([Ma])
)
