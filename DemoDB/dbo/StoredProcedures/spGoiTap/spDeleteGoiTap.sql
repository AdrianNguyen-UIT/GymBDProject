﻿CREATE PROCEDURE [dbo].[spDeleteGoiTap]
	@MaGT INT
AS
	BEGIN
		SET NOCOUNT ON;
		DELETE FROM [dbo].[DangKyGT]
		WHERE [MaGT] = @MaGT

		DELETE FROM [dbo].[GoiTap]
		WHERE [MaGT] = @MaGT
 	END
RETURN 0
