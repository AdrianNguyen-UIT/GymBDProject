﻿CREATE PROCEDURE [dbo].[spDeleteDangKyGT]
    @MaDKGT INT
AS
	BEGIN
		SET NOCOUNT ON;
		DELETE FROM [dbo].[DangKyGT]
		WHERE [MaDKGT] = @MaDKGT
	END
RETURN 0
