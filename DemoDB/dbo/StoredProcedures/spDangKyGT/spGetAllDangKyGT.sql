﻿CREATE PROCEDURE [dbo].[spGetAllDangKyGT]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM [dbo].[DangKyGT];
	END
RETURN 0