﻿CREATE PROCEDURE [dbo].[spGetTuDoByID]
	@MaTD INT
AS
	SELECT *
	FROM [dbo].[TuDo]
	WHERE [MaTD] = @MaTD;
RETURN 0
