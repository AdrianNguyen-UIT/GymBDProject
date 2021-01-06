CREATE PROCEDURE [dbo].[spUpdateLoaiSP]
	@MaLSP INT, 
    @TenLSP NVARCHAR(50), 
    @MoTa NVARCHAR(50)
AS
	BEGIN
		SET NOCOUNT ON;
		UPDATE [dbo].[LoaiSP]
		SET [TenLSP] = @TenLSP
		WHERE [MaLSP] = @MaLSP
 
		UPDATE [dbo].[LoaiSP]
		SET [MoTa] = @MoTa
		WHERE [MaLSP] = @MaLSP
	END
RETURN 0
