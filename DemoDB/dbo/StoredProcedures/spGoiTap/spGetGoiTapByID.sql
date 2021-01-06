CREATE PROCEDURE [dbo].[spGetGoiTapByID]
	@MaGT INT
AS
	SELECT *
	FROM [dbo].[GoiTap]
	WHERE [MaGT] = @MaGT;
RETURN 0
