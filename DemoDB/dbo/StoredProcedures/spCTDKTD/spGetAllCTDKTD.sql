﻿CREATE PROCEDURE [dbo].[spGetAllCTDKTD]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM [dbo].[CTDKTD];
	END
RETURN 0
