﻿CREATE PROCEDURE [dbo].[spGetAllCTHD]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM [dbo].[CTHD];
	END
RETURN 0