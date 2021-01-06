CREATE PROCEDURE [dbo].[spUpdateGoiTap]
	@MaGT INT,
	@TenGT NVARCHAR(50),
	@ThoiHan INT,
	@DonGia MONEY,
	@MoTa NVARCHAR(MAX),
	@TrangThai NVARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[GoiTap]
		SET [TenGT] = @TenGT
		WHERE [MaGT] = @MaGT

		UPDATE [dbo].[GoiTap]
		SET [ThoiHan] = @ThoiHan
		WHERE [MaGT] = @MaGT

		UPDATE [dbo].[GoiTap]
		SET [DonGia] = @DonGia
		WHERE [MaGT] = @MaGT

		UPDATE [dbo].[GoiTap]
		SET [MoTa] = @MoTa
		WHERE [MaGT] = @MaGT

		UPDATE [dbo].[GoiTap]
		SET [TrangThai] = @TrangThai
		WHERE [MaGT] = @MaGT
	END
RETURN 0
