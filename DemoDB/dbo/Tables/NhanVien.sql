CREATE TABLE [dbo].[NhanVien]
(
	[Ma] INT NOT NULL PRIMARY KEY IDENTITY, 
    [HoTen] NVARCHAR(50) NOT NULL, 
    [GioiTinh] NVARCHAR(20) NULL, 
    [NgaySinh] DATETIME NULL DEFAULT GetDate(), 
    [DiaChi] NVARCHAR(128) NULL, 
    [SDT] VARCHAR(15) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [CMND] VARCHAR(15) NULL, 
    [NgayVaoLam] DATETIME NULL DEFAULT GetDate(), 
    [Luong] MONEY NOT NULL, 
    [TrangThai] NVARCHAR(50) NULL, 
    [MaLNV] INT NOT NULL, 
    CONSTRAINT [FK_NhanVien_LoaiNV_MaLNV] FOREIGN KEY ([MaLNV]) REFERENCES [LoaiNV]([MaLNV]), 
    CONSTRAINT [CK_NhanVien_NgayVaoLam] CHECK ([NgayVaoLam] > [NgaySinh])
)

GO
