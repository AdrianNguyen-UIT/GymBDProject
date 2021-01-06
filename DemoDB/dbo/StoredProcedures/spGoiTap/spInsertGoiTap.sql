CREATE PROCEDURE [dbo].[spInsertGoiTap]
	@TenGT NVARCHAR(50),
	@ThoiHan INT,
	@DonGia MONEY,
	@MoTa NVARCHAR(MAX),
	@TrangThai NVARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		INSERT INTO [dbo].[GoiTap] ([TenGT], [ThoiHan], [DonGia], [MoTa], [TrangThai])
		VALUES (@TenGT, @ThoiHan, @DonGia, @MoTa, @TrangThai)
	END
RETURN 0
