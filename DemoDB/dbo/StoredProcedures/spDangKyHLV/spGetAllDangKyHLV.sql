﻿CREATE PROCEDURE [dbo].[spGetAllDangKyHLV]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM [dbo].[DangKyHLV];
	END
RETURN 0