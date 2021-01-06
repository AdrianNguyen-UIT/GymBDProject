CREATE TABLE [dbo].[DangNhap]
(
	[TaiKhoan] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [MatKhau] VARCHAR(50) NOT NULL, 
    [MaNV] INT NOT NULL, 
    CONSTRAINT [FK_DangNhap_NhanVien_MaNV] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien]([Ma])
)